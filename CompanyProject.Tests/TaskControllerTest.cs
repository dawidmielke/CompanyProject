using CompanyProject.Controllers;
using CompanyProject.Data.Models;
using CompanyProject.Data.Repositories;
using CompanyProject.Data;
using CompanyProject.Models;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProject.Tests
{
    public class TaskControllerTests
    {
        private readonly Mock<ITaskRepository> _taskRepositoryMock;
        private readonly Mock<ApplicationDbContext> _contextMock;
        private readonly TaskController _controller;

        public TaskControllerTests()
        {
            _taskRepositoryMock = new Mock<ITaskRepository>();
            _contextMock = new Mock<ApplicationDbContext>();
            _controller = new TaskController(_taskRepositoryMock.Object, _contextMock.Object);
        }

        [Fact]
        public void Index_Returns_A_ViewResult()
        {
            // Arrange
            var tasks = new List<EmployeeTask>
            {
                new EmployeeTask { TaskName = "Task 1" }
            };
            _taskRepositoryMock.Setup(repo => repo.GetTasksByEmployeeId("1"))
                .Returns(tasks);

            // Act
            var result = _controller.Index();

            // Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void AddTask_Returns_A_ViewResult()
        {
            // Act
            var result = _controller.AddTask();

            // Assert
            Assert.IsType<ViewResult>(result);
        }

        [Fact]
        public void AddTask_With_Model_Saves_Task_To_Database()
        {
            // Arrange
            var model = new TaskViewModel
            {
                TaskName = "Task 1",
                TaskDescription = "Description",
                TaskStart = DateTime.Now,
                TaskEnd = DateTime.Now.AddDays(1)
            };

            // Act
            var result = _controller.AddTask(model);

            // Assert
            _taskRepositoryMock.Verify(repo => repo.Create(It.IsAny<EmployeeTask>()), Times.Once());
            Assert.IsType<RedirectToActionResult>(result);
            Assert.Equal("Index", (result as RedirectToActionResult).ActionName);
            Assert.Equal("Task", (result as RedirectToActionResult).ControllerName);
        }

        [Fact]
        public void Edit_Returns_A_ViewResult()
        {
            // Arrange
            var task = new EmployeeTask
            {
                TaskName = "Task 1",
                TaskDescription = "Description",
                TaskStart = DateTime.Now,
                TaskEnd = DateTime.Now.AddDays(1)
            };
            _contextMock.Setup(ctx => ctx.EmployeeTasks.Find(1))
                .Returns(task);

            // Act
            var result = _controller.Edit(1);

            // Assert
            Assert.IsType<ViewResult>(result);
        }

    }
}
