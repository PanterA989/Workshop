using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
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
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    [ApiController]
    public class WorkshopTasksController : ControllerBase
    {
        /// <summary>
        /// Gets list of all historical or active tasks
        /// </summary>
        /// <param name="isActive">Search for active or historical tasks</param>
        /// <returns><see cref="List{T}"/> of workshop tasks</returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<List<WorkshopTask>>> GetWorkshopTaskList(WorkshopTasksListType isActive)
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

        /// <summary>
        /// Gets specific task based on given id
        /// </summary>
        /// <param name="id">id of task to find</param>
        /// <returns><see cref="WorkshopTask"/> with given id</returns>
        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<WorkshopTask> GetWorkshopTask(int id)
        {
            try
            {
                var result = MyDbConnection.GetWorkshopTask(id);
                if (result == null)
                    return NotFound();

                return Ok(result);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error while retrieving data from database");
            }
        }

        /// <summary>
        /// Creates new workshop task
        /// </summary>
        /// <param name="workshopTask">Workshop task data</param>
        /// <returns>Created task</returns>
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
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

        /// <summary>
        /// Updates task with given id with provided data
        /// </summary>
        /// <param name="id">id of task to update</param>
        /// <param name="workshopTaskWithUpdates">New data for task</param>
        /// <returns>Updated task</returns>
        [HttpPut("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<WorkshopTask>> UpdateWorkshopTask(int id, WorkshopApiTask workshopTaskWithUpdates)
        {
            if (workshopTaskWithUpdates == null)
                return BadRequest();

            try
            {
                var (errorDictionary, updatedTask) = await MyDbConnection.UpdateTaskFromApi(id, workshopTaskWithUpdates);

                if (errorDictionary.ContainsKey(nameof(WorkshopTask.Id)))
                    return NotFound($"Cannot find task with id = {id}");

                if (updatedTask == null)
                    return BadRequest(JsonConvert.SerializeObject(errorDictionary));

                return Ok(updatedTask);
            }
            catch (Exception e)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error while updating workshop task");
            }
        }

        /// <summary>
        /// Deletes task with given id
        /// </summary>
        /// <param name="id">id of task which should be deleted</param>
        [HttpDelete("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
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
