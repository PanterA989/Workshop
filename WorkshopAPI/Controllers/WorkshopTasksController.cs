using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Workshop.DataAccessLayer.DatabaseConnection;
using Workshop.DataAccessLayer.Enums;
using Workshop.DataAccessLayer.Models;

namespace WorkshopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkshopTasksController : ControllerBase
    {
        [HttpGet]
        public async Task<ActionResult> GetWorkshopTaskList(WorkshopTasksListType isActive)
        {
            try
            {
                return Ok(await MyDbConnection.GetWorkshopTaskList(isActive));
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error while retrieving data from database");
            }
        }

        [HttpGet("{id:int}")]
        public ActionResult<WorkshopTask> GetWorkshopTask(int id)
        {
            try
            {
                var result = MyDbConnection.GetWorkshopTask(id);
                if (result == null)
                    return NotFound();

                return result;
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error while retrieving data from database");
            }
        }

        [HttpPost]
        public async Task<ActionResult<WorkshopTask>> CreateWorkshopTask(WorkshopApiTask workshopTask)
        {
            if (workshopTask == null)
                return BadRequest();

            try
            {
                var (errorDictionary, createdTask) = await MyDbConnection.AddTaskFromApi(workshopTask);

                if (createdTask == null)
                    return BadRequest(JsonConvert.SerializeObject(errorDictionary));

                return CreatedAtAction(nameof(GetWorkshopTask),
                    new {id = createdTask.Id}, createdTask);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error while creating workshop task");
            }
        }

        [HttpPut("{id:int}")]
        public async Task<ActionResult<WorkshopTask>> UpdateWorkshopTask(int id, WorkshopApiTask workshopTaskWithUpdates)
        {
            if (workshopTaskWithUpdates == null)
                return BadRequest();

            try
            {
                var taskToUpdate = MyDbConnection.GetWorkshopTask(id);

                if (taskToUpdate == null)
                    return NotFound($"Cannot find task with id = {id}");

                var (errorDictionary, updatedTask) = await MyDbConnection.UpdateTaskFromApi(workshopTaskWithUpdates, taskToUpdate);

                if (updatedTask == null)
                    return BadRequest(JsonConvert.SerializeObject(errorDictionary));

                return updatedTask;
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error while updating workshop task");
            }
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> DeleteWorkshopTask(int id)
        {
            try
            {
                var taskToDelete = MyDbConnection.GetWorkshopTask(id);

                if (taskToDelete == null)
                    return NotFound($"Cannot find task with id = {id}");

                MyDbConnection.DeleteTask(id);

                return Ok($"Successfully deleted task with id = {id}");
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error while deleting workshop task");
            }
        }
    }
}
