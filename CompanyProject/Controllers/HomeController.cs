﻿using CompanyProject.Data;
using CompanyProject.Data.Models;
using CompanyProject.Interfaces;
using CompanyProject.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CompanyProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly UserManager<Employee> userManager;
        private readonly ApplicationDbContext context;
        private readonly IPhotoService _photoService;

        public HomeController(ILogger<HomeController> logger, UserManager<Employee> userManager, ApplicationDbContext context, IPhotoService photoService)
        {
            _logger = logger;
            this.userManager = userManager;
            this.context = context;
            _photoService = photoService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult Employees()
        {
            return View(context.Users.ToList());
        }


        [Authorize(Roles = "Administrator")]
        public IActionResult DeleteUser(string id)
        {
            var employee = context.Users.Find(id);
            if(employee == null)
            {
                return NotFound();
            }
            userManager.DeleteAsync(employee).Wait();

            return RedirectToAction("Employees");
        }

        [Authorize(Roles = "Administrator")]
        public IActionResult AddEmployee()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "Administrator")]
        public async IActionResult AddEmployee(EmployeeViewModel model)
        {
            if (ModelState.IsValid)
            {
                Employee user = new Employee
                {
                    Email = model.Email,
                    UserName = model.Email,
                    Surname = model.Surname,
                    Name = model.Name,
                    Birth = model.Birth,
                    Image = model.Image
                };
                userManager.CreateAsync(user, model.Password).Wait();
                userManager.AddToRoleAsync(user, model.Role).Wait();
            }

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}