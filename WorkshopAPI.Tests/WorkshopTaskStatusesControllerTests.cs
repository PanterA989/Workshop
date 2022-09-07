using System;
using System.Collections.Generic;
using System.Linq;
using FakeItEasy;
using Microsoft.AspNetCore.Mvc;
using Workshop.DataAccessLayer.DatabaseConnection.Interfaces;
using Workshop.DataAccessLayer.Models.Dictionaries;
using WorkshopAPI.Controllers;
using Xunit;

namespace WorkshopAPI.Tests
{
    public class WorkshopTaskStatusesControllerTests
    {
        [Fact]
        public void GetWorkshopStatuses_Returns_Statuses_List()
        {
            //Arrange
            var fakeListOfStatuses = A.CollectionOfDummy<WorkshopTaskStatus>(5).ToList();
            var myDbConnection = A.Fake<IMyDbConnection>();
            A.CallTo(() => myDbConnection.GetStatuses()).Returns(fakeListOfStatuses);
            var controller = new WorkshopTaskStatusesController(myDbConnection);

            //Act
            var actionResult = controller.GetWorkshopStatuses();

            //Assert
            var result = actionResult.Result as OkObjectResult;

            Assert.NotNull(result);
            Assert.IsType<List<WorkshopTaskStatus>>(result.Value);
        }
    }
}
