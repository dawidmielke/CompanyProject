using CompanyProject.Data.Models;
using CompanyProject.Data.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyProject.Tests
{
    public class TaskMockRepositoryTests
    {
        [Fact]
        public void Create_OnCreation_ShouldCreateTask()
        {
            // Arrange 
            var mockRepository = new TaskMockRepository();
            var taskToAdd = new EmployeeTask() { Id = 1, TaskName = "Test", EmployeeId = "001" };

            // Act
            mockRepository.Create(taskToAdd);

            // Assert 
            var addedTask = mockRepository.Get(1);
            Assert.NotNull(addedTask);
            Assert.Single(mockRepository.GetAll());
            Assert.Equal("Test", addedTask.TaskName);
        }

        [Fact]
        public void Update_OnUpdated_ShouldUpdateTask()
        {
            // Arrange
            var mockRepository = new TaskMockRepository();
            var taskToUpdate = new EmployeeTask() { Id = 1, TaskName = "Test", EmployeeId = "001" };
            mockRepository.Create(taskToUpdate);

            // Act 
            taskToUpdate.TaskName = "Test1";
            mockRepository.Update(taskToUpdate);

            // Assert 
            var updatedTask = mockRepository.Get(1);
            Assert.NotNull(updatedTask);
            Assert.Equal("Test1", updatedTask.TaskName);
        }

        [Fact]
        public void Delete_OnDeletion_ShouldDeleteTask()
        {
            // Arrange
            var mockRepository = new TaskMockRepository();
            var taskToDelete = new EmployeeTask() { Id = 1, TaskName = "Test", EmployeeId = "001" };
            mockRepository.Create(taskToDelete);

            // Act
            mockRepository.Delete(1);

            //Assert 
            var deletedTask = mockRepository.Get(1);
            Assert.Null(deletedTask);
        }

        [Fact]
        public void GetTaskByEmployeeId_OnGettingTask_ShouldGetTaskByEmployeeId()
        {
            // Arrange
            var mockRepository = new TaskMockRepository();
            var task1 = new EmployeeTask() { Id = 1, TaskName = "Test1", EmployeeId = "001" };
            var task2 = new EmployeeTask() { Id = 2, TaskName = "Test2", EmployeeId = "002" };
            var task3 = new EmployeeTask() { Id = 3, TaskName = "Test3", EmployeeId = "003" };
            var task4 = new EmployeeTask() { Id = 4, TaskName = "Test4", EmployeeId = "001" };
            mockRepository.Create(task1);
            mockRepository.Create(task2);
            mockRepository.Create(task3);
            mockRepository.Create(task4);

            // Act
            var employee1Tasks = mockRepository.GetTasksByEmployeeId("001");

            // Assert
            Assert.NotNull(employee1Tasks);
            Assert.Equal(2, employee1Tasks.Count);
            Assert.Contains(employee1Tasks, x => x.Id == 1 && x.EmployeeId == "001");
            Assert.Contains(employee1Tasks, x => x.Id == 4 && x.EmployeeId == "001");
        }
    }
}
