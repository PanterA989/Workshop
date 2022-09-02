using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Workshop.DataAccessLayer.ViewModel;
using Dapper;
using System.Data;
using Workshop.DataAccessLayer.Models;
using Workshop.DataAccessLayer.Models.Dictionaries;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Workshop.DataAccessLayer.DataAccess;
using Workshop.DataAccessLayer.Enums;

namespace Workshop.DataAccessLayer.DatabaseConnection
{
    public static class MyDbConnection
    {
        /// <summary>
        /// Executes asynchronous database query gathering historical or active workshop tasks.
        /// </summary>
        /// <param name="listType">Type of searched tasks</param>
        /// <returns>List of task of given type</returns>
        public static async Task<List<TaskViewModel>> GetWorkshopTasks(WorkshopTasksListType listType)
        {
            using (WorkshopTaskContext dbContext = new WorkshopTaskContext())
            {
                var searchForActiveTasks = listType == WorkshopTasksListType.Active;

                return await dbContext.WorkshopTasks
                    .Where(x => x.Status.IsActive == searchForActiveTasks)
                    .Select(x => new TaskViewModel()
                    {
                        Id = x.Id,
                        BikeManufacturer = x.Bike.Manufacturer,
                        BikeModel = x.Bike.Model,
                        StartDate = x.StartDate,
                        EndDate = x.EndDate,
                        Status = x.Status.Value
                    }).ToListAsync();
            }
        }

        /// <summary>
        /// Gets specific task from databese, based on its id.
        /// </summary>
        /// <param name="id">id of task to be returned</param>
        /// <returns>Single task based on its id or null if not found</returns>
        public static WorkshopTask GetWorkshopTask(int id)
        {
            using (WorkshopTaskContext dbContext = new WorkshopTaskContext())
            {
                return dbContext.WorkshopTasks.Find(id);
            }
        }

        /// <summary>
        /// Gets all statuses from database.
        /// </summary>
        /// <returns>List of statuses.</returns>
        public static List<WorkshopTaskStatus> GetStatuses()
        {
            using (WorkshopTaskContext dbContext = new WorkshopTaskContext())
            {
                return dbContext.WorkshopTaskStatuses.ToList();
            }
        }

        /// <summary>
        /// Adds task to database.
        /// </summary>
        /// <param name="workshopTask">TaskModel object to be put into database.</param>
        /// <returns>True if task has been added successfully.</returns>
        public static bool AddTask(WorkshopTask workshopTask)
        {
            using (WorkshopTaskContext dbContext = new WorkshopTaskContext())
            {
                dbContext.WorkshopTasks.Add(workshopTask);
                dbContext.Entry(workshopTask.Status).State = EntityState.Unchanged;
                return dbContext.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// Updates all fields of given task in database.
        /// </summary>
        /// <param name="taskData">Task with all its fields to be updated in database</param>
        /// <returns>True if task has been updated successfully.</returns>
        public static bool UpdateTask(WorkshopTask taskData)
        {
            using (WorkshopTaskContext dbContext = new WorkshopTaskContext())
            {
                var result = dbContext.WorkshopTasks.Find(taskData.Id);
                if (result == null)
                    return false;
                
                dbContext.Entry(result).CurrentValues.SetValues(taskData);
                return true;
                //TODO: Test
                // dbContext.WorkshopTasks.Update(taskData);
                // dbContext.SaveChanges();
            }
        }

        /// <summary>
        /// Updates status of given task in database.
        /// </summary>
        /// <param name="taskId">Id of task of which status should be updated</param>
        /// <param name="newStatusId">id of new status</param>
        /// <returns></returns>
        public static bool UpdateStatus(int taskId, int newStatusId)
        {

            //TODO

            using (WorkshopTaskContext dbContext = new WorkshopTaskContext())
            {
                var result = dbContext.WorkshopTasks.Find(taskId);
                if (result == null)
                    return false;
            }

            using (IDbConnection connection = new SqlConnection(ConnectionHelper.GetConnectionString()))
            {
                string updateQuery = $@"UPDATE [dbo].Task SET [StatusID] = {newStatusId} WHERE [Id] = {taskId}";
                if (connection.Execute(updateQuery) == 1) return true;
                else return false;
            }
        }

        public static bool DeleteTask(int taskId)
        {
            using (WorkshopTaskContext dbContext = new WorkshopTaskContext())
            {
                var taskToDelete = dbContext.WorkshopTasks.SingleOrDefault(x => x.Id == taskId);
                if (taskToDelete != null)
                {
                    dbContext.WorkshopTasks.Remove(taskToDelete);
                    dbContext.SaveChanges();
                    return true;
                }

                return false;
            }

        }
    }
}
