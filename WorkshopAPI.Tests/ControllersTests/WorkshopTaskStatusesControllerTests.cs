using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FakeItEasy;
using Microsoft.AspNetCore.Mvc;
using Workshop.DataAccessLayer.DatabaseConnection.Interfaces;
using Workshop.DataAccessLayer.Models;
using Workshop.DataAccessLayer.Models.Dictionaries;
using WorkshopAPI.Controllers;
using Xunit;

namespace WorkshopAPI.Tests.ControllersTests
{
    public class WorkshopTaskStatusesControllerTests
    {
        [Fact]
        public void GetWorkshopStatuses_ReturnsStatusesList()
        {
            //Arrange
            var fakeListOfStatuses = A.CollectionOfDummy<WorkshopTaskStatus>(5).ToList();
            var myDbConnection = A.Fake<IMyDbConnection>();
            var controller = new WorkshopTaskStatusesController(myDbConnection);

            A.CallTo(() => myDbConnection.GetStatuses()).Returns(fakeListOfStatuses);

            //Act
            var actionResult = controller.GetWorkshopStatuses();

            //Assert
            Assert.IsType<OkObjectResult>(actionResult.Result);

            var result = actionResult.Result as OkObjectResult;

            Assert.NotNull(result);
            Assert.IsType<List<WorkshopTaskStatus>>(result.Value);
        }

        [Fact]
        public void GetWorkshopStatuses_ReturnsNotFound_WhenNoStatuses()
        {
            //Arrange
            var myDbConnection = A.Fake<IMyDbConnection>();
            
            A.CallTo(() => myDbConnection.GetStatuses()).Returns(null);
            
            var controller = new WorkshopTaskStatusesController(myDbConnection);

            //Act
            var actionResult = controller.GetWorkshopStatuses();

            //Assert
            Assert.IsType<NotFoundResult>(actionResult.Result);
        }

        [Theory]
        [InlineData(1)]
        public void GetWorkshopStatus_ReturnsStatus_WhenStatusFound(int id)
        {
            //Arrange
            var fakeStatus = A.Fake<WorkshopTaskStatus>();
            var myDbConnection = A.Fake<IMyDbConnection>();
            
            A.CallTo(() => myDbConnection.GetStatus(id)).Returns(fakeStatus);
            
            var controller = new WorkshopTaskStatusesController(myDbConnection);

            //Act
            var actionResult = controller.GetWorkshopStatus(id);

            //Assert
            Assert.IsType<OkObjectResult>(actionResult.Result);

            var result = actionResult.Result as OkObjectResult;

            Assert.NotNull(result);
            Assert.IsAssignableFrom<WorkshopTaskStatus>(result.Value);
        }

        [Theory]
        [InlineData(1)]
        public void GetWorkshopStatus_ReturnsNotFound_WhenNoStatusFound(int id)
        {
            //Arrange
            var myDbConnection = A.Fake<IMyDbConnection>();
            A.CallTo(() => myDbConnection.GetStatus(id)).Returns(null);
            var controller = new WorkshopTaskStatusesController(myDbConnection);

            //Act
            var actionResult = controller.GetWorkshopStatus(id);

            //Assert
            Assert.IsType<NotFoundResult>(actionResult.Result);
        }
    }
}
