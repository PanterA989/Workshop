using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Workshop.DataAccessLayer.DatabaseConnection;
using Workshop.DataAccessLayer.DatabaseConnection.Interfaces;
using Workshop.DataAccessLayer.Models.Dictionaries;

namespace WorkshopAPI.Controllers
{
    [Route("api/[controller]")]
    [Produces(MediaTypeNames.Application.Json)]
    [Consumes(MediaTypeNames.Application.Json)]
    [ApiController]
    public class WorkshopTaskStatusesController : ControllerBase
    {
        private readonly IMyDbConnection _myDbConnection;
        public WorkshopTaskStatusesController(IMyDbConnection myDbConnection)
        {
            _myDbConnection = myDbConnection;
        }

        /// <summary>
        /// Gets list of all WorkshopTaskStatus available in workshop
        /// </summary>
        /// <returns><see cref="List{T}"/> of <see cref="WorkshopTaskStatus"/></returns>
        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<List<WorkshopTaskStatus>> GetWorkshopStatuses()
        {
            try
            {
                var result = _myDbConnection.GetStatuses();
                if (result == null)
                {
                    return NotFound();
                }

                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error while retrieving data from database");
            }
        }

        /// <summary>
        /// Gets specific status with given id.
        /// </summary>
        /// <param name="id">Id of the searched status</param>
        /// <returns><see cref="WorkshopTaskStatus"/> with given id</returns>
        [HttpGet("{id:int}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ActionResult<WorkshopTaskStatus> GetWorkshopStatus(int id)
        {
            try
            {
                var result = _myDbConnection.GetStatus(id);
                if (result == null)
                {
                    return NotFound();
                }

                return result;
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError,
                    "Error while retrieving data from database");
            }
        }
    }
}
