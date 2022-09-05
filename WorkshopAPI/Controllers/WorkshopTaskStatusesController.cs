using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Workshop.DataAccessLayer.DatabaseConnection;
using Workshop.DataAccessLayer.Models.Dictionaries;

namespace WorkshopAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WorkshopTaskStatusesController : ControllerBase
    {
        [HttpGet("{id:int}")]
        public ActionResult<WorkshopTaskStatus> GetWorkshopStatus(int id)
        {
            try
            {
                var result = MyDbConnection.GetStatus(id);
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

        [HttpGet]
        public ActionResult<List<WorkshopTaskStatus>> GetWorkshopStatuses()
        {
            try
            {
                var result = MyDbConnection.GetStatuses();
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
    }
}
