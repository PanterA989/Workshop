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
        public async Task<ActionResult> GetWorkshopTaskList(WorkshopTasksListType listType)
        {
            try
            {
                return Ok(await MyDbConnection.GetWorkshopTaskList(listType));
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
                {
                    return NotFound();
                }

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
    }
}
