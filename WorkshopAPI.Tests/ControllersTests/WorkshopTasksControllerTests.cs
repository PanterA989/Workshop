using System.Collections.Generic;
using System.Linq;
using FakeItEasy;
using Microsoft.AspNetCore.Mvc;
using System.Text.Json;
using Workshop.DataAccessLayer.DatabaseConnection.Interfaces;
using Workshop.DataAccessLayer.Enums;
using Workshop.DataAccessLayer.Models;
using Workshop.DataAccessLayer.ViewModel;
using WorkshopAPI.Controllers;
using Xunit;

namespace WorkshopAPI.Tests.ControllersTests
{
    public class WorkshopTasksControllerTests
    {
        [Theory]
        [InlineData(WorkshopTasksListType.Active)]
        [InlineData(WorkshopTasksListType.Historical)]
        public async void GetWorkshopTaskList_ReturnsTasksList(WorkshopTasksListType listType)
        {
            //Arrange
            var fakeListOfTasks = A.CollectionOfDummy<TaskViewModel>(5).ToList();
            var myDbConnection = A.Fake<IMyDbConnection>();
            var controller = new WorkshopTasksController(myDbConnection);

            A.CallTo(() => myDbConnection.GetWorkshopTaskList(listType)).Returns(fakeListOfTasks);
            
            //Act
            var actionResult = await controller.GetWorkshopTaskList(listType);

            //Assert
            Assert.IsType<OkObjectResult>(actionResult.Result);

            var result = actionResult.Result as OkObjectResult;

            Assert.NotNull(result);
            Assert.IsType<List<TaskViewModel>>(result.Value);
        }

        [Theory]
        [InlineData(WorkshopTasksListType.Active)]
        [InlineData(WorkshopTasksListType.Historical)]
        public async void GetWorkshopTaskList_ReturnsEmptyList_WhenNoTasks(WorkshopTasksListType listType)
        {
            //Arrange
            var fakeListOfTasks = A.CollectionOfDummy<TaskViewModel>(0).ToList();
            var myDbConnection = A.Fake<IMyDbConnection>();
            var controller = new WorkshopTasksController(myDbConnection);

            A.CallTo(() => myDbConnection.GetWorkshopTaskList(listType)).Returns(fakeListOfTasks);
            
            //Act
            var actionResult = await controller.GetWorkshopTaskList(listType);

            //Assert
            Assert.IsType<OkObjectResult>(actionResult.Result);

            var result = actionResult.Result as OkObjectResult;

            Assert.NotNull(result);
            Assert.IsType<List<TaskViewModel>>(result.Value);

            var resultData = result.Value as List<TaskViewModel>;

            Assert.NotNull(resultData);
            Assert.True(resultData.Count == 0);
        }

        [Theory]
        [InlineData(1)]
        public void GetWorkshopTask_ReturnsTask_WhenTaskFound(int id)
        {
            //Arrange
            var fakeTask = A.Fake<WorkshopTask>();
            var myDbConnection = A.Fake<IMyDbConnection>();
            var controller = new WorkshopTasksController(myDbConnection);

            A.CallTo(() => myDbConnection.GetWorkshopTask(id)).Returns(fakeTask);
            
            //Act
            var actionResult = controller.GetWorkshopTask(id);
        
            //Assert
            Assert.IsType<OkObjectResult>(actionResult.Result);
        
            var result = actionResult.Result as OkObjectResult;
        
            Assert.NotNull(result);
            Assert.IsAssignableFrom<WorkshopTask>(result.Value);
        }
        
        [Theory]
        [InlineData(1)]
        public void GetWorkshopTask_ReturnsNotFound_WhenNoTaskFound(int id)
        {
            //Arrange
            var myDbConnection = A.Fake<IMyDbConnection>();
            var controller = new WorkshopTasksController(myDbConnection);
            
            A.CallTo(() => myDbConnection.GetWorkshopTask(id)).Returns(null);
            
            //Act
            var actionResult = controller.GetWorkshopTask(id);
        
            //Assert
            Assert.IsType<NotFoundResult>(actionResult.Result);
        }

        [Fact]
        public async void CreateWorkshopTask_ReturnsWorkshopTask_WhenAdded()
        {
            //Arrange
            var fakeInputTask = A.Dummy<WorkshopApiTask>();
            var fakeOutputTask = A.Dummy<WorkshopTask>();
            var fakeOutputErrorDictionary = A.Dummy<Dictionary<string, List<string>>>();
            var fakeOutputTuple = (fakeOutputErrorDictionary, fakeOutputTask);
            var myDbConnection = A.Fake<IMyDbConnection>();
            var controller = new WorkshopTasksController(myDbConnection);

            A.CallTo(() => myDbConnection.AddTaskFromApi(fakeInputTask)).Returns(fakeOutputTuple);

            //Act
            var actionResult = await controller.CreateWorkshopTask(fakeInputTask);

            //Assert
            Assert.IsType<CreatedAtActionResult>(actionResult.Result);

            var result = actionResult.Result as CreatedAtActionResult;

            Assert.NotNull(result);
            Assert.IsAssignableFrom<WorkshopTask>(result.Value);
        }

        [Fact]
        public async void CreateWorkshopTask_ReturnsSerializedErrorsString_WhenError()
        {
            //Arrange
            var fakeInputTask = A.Dummy<WorkshopApiTask>();
            var fakeOutputErrorDictionary = new Dictionary<string, List<string>>
            {
                {"error", new List<string>() {"error1", "error2"}}
            };

            var myDbConnection = A.Fake<IMyDbConnection>();
            var controller = new WorkshopTasksController(myDbConnection);

            A.CallTo(() => myDbConnection.AddTaskFromApi(fakeInputTask)).Returns((fakeOutputErrorDictionary, null));

            //Act
            var actionResult = await controller.CreateWorkshopTask(fakeInputTask);

            //Assert
            Assert.IsType<BadRequestObjectResult>(actionResult.Result);

            var result = actionResult.Result as BadRequestObjectResult;

            Assert.NotNull(result);
            Assert.Equal(JsonSerializer.Serialize(fakeOutputErrorDictionary), result.Value);
        }

        [Fact]
        public async void CreateWorkshopTask_ReturnsBadRequest_WhenWrongInput()
        {
            //Arrange
            var myDbConnection = A.Fake<IMyDbConnection>();
            var controller = new WorkshopTasksController(myDbConnection);

            //Act
            var actionResult = await controller.CreateWorkshopTask(null);

            //Assert
            Assert.IsType<BadRequestResult>(actionResult.Result);
        }
    }
}
