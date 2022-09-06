using System;
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
using Workshop.DataAccessLayer.Helpers;

namespace Workshop.DataAccessLayer.DatabaseConnection
{
    public static class MyDbConnection
    {
        /// <summary>
        /// Executes asynchronous database query gathering historical or active workshop tasks.
        /// </summary>
        /// <param name="listType">Type of searched tasks</param>
        /// <returns>List of task of given type</returns>
        public static async Task<List<TaskViewModel>> GetWorkshopTaskList(WorkshopTasksListType listType)
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
        /// Gets specific task from database, based on its id.
        /// </summary>
        /// <param name="id">id of task to be returned</param>
        /// <returns>Single task based on its id or null if not found</returns>
        public static WorkshopTask GetWorkshopTask(int id)
        {
            using (WorkshopTaskContext dbContext = new WorkshopTaskContext())
            {
                return dbContext.WorkshopTasks
                    .Include(t => t.Bike)
                    .Include(t => t.Client)
                    .Include(t => t.Status)
                    .FirstOrDefault(x => x.Id == id);
            }
        }

        /// <summary>
        /// Gets all possible statuses from database.
        /// </summary>
        /// <returns>List of statuses</returns>
        public static List<WorkshopTaskStatus> GetStatuses()
        {
            using (WorkshopTaskContext dbContext = new WorkshopTaskContext())
            {
                return dbContext.WorkshopTaskStatuses.ToList();
            }
        }

        /// <summary>
        /// Gets specific status with given id.
        /// </summary>
        /// <param name="id">Id of the searched status</param>
        /// <returns></returns>
        public static WorkshopTaskStatus GetStatus(int id)
        {
            using (WorkshopTaskContext dbContext = new WorkshopTaskContext())
            {
                return dbContext.WorkshopTaskStatuses.FirstOrDefault(x => x.Id == id);
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
        /// <param name="updatedTaskData">Task with all its fields to be updated in database</param>
        /// <returns>True if task has been updated successfully.</returns>
        public static bool UpdateTask(WorkshopTask updatedTaskData)
        {
            using (WorkshopTaskContext dbContext = new WorkshopTaskContext())
            {
                var existingTask = GetWorkshopTask(updatedTaskData.Id);
                if (existingTask == null)
                    return false;

                dbContext.Update(updatedTaskData);
                dbContext.Entry(updatedTaskData.Status).State = EntityState.Unchanged;
                return dbContext.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// Updates status of given task in database.
        /// </summary>
        /// <param name="taskId">Id of task of which status should be updated</param>
        /// <param name="newStatusId">id of new status</param>
        /// <returns>True if status has been changed</returns>
        public static bool UpdateStatus(int taskId, int newStatusId)
        {
            using (WorkshopTaskContext dbContext = new WorkshopTaskContext())
            {
                var updatedWorkshopTask = dbContext.WorkshopTasks
                    .FirstOrDefault(x => x.Id == taskId);

                if (updatedWorkshopTask == null)
                    return false;
                
                updatedWorkshopTask.StatusId = newStatusId;
                return dbContext.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// Deletes task with given id
        /// </summary>
        /// <param name="taskId">Id of task which should be deleted</param>
        /// <returns>True if task was deleted</returns>
        public static bool DeleteTask(int taskId)
        {
            using (WorkshopTaskContext dbContext = new WorkshopTaskContext())
            {
                var taskToDelete = dbContext.WorkshopTasks.SingleOrDefault(x => x.Id == taskId);
                
                if (taskToDelete == null) 
                    return false;

                dbContext.WorkshopTasks.Remove(taskToDelete);
                return dbContext.SaveChanges() > 0;
            }
        }

        /// <summary>
        /// Executes asynchronous adding task to database.
        /// </summary>
        /// <param name="workshopApiTask">Simple representation of task to add</param>
        /// <returns>When failed returns tuple with errors dictionary representing problematic fields with list of all errors, and null for added object.
        /// When successful returns tuple with empty errors dictionary and object which has been added</returns>
        public static async Task<(Dictionary<string, List<string>> errorsDictionary, WorkshopTask CreatedWorkshopTask)> 
            AddTaskFromApi(WorkshopApiTask workshopApiTask)
        {
            if (!ApiHelper.ValidateTaskFromAPI(workshopApiTask, out Dictionary<string, List<string>> errorList))
                return (errorList,null);

            var workshopTask = ApiHelper.GenerateWorkshopTaskFromWorkshopApiTask(workshopApiTask);
            workshopTask.Status = GetStatus(workshopTask.StatusId);

            using (WorkshopTaskContext dbContext = new WorkshopTaskContext())
            {
                if (workshopTask.Status != null)
                {
                    dbContext.Entry(workshopTask.Status).State = EntityState.Unchanged;
                }

                var result = await dbContext.WorkshopTasks.AddAsync(workshopTask);

                await dbContext.SaveChangesAsync();
                return (errorList, result.Entity);
            }
        }

        /// <summary>
        /// Executes asynchronous updating task in database.
        /// </summary>
        /// <param name="id">id of task which should be updated</param>
        /// <param name="workshopApiTaskWithUpdates">Simple representation of task with updated values</param>
        /// <returns>When failed returns tuple with errors dictionary representing problematic fields with list of all errors, and null for updated object.
        /// When successful returns tuple with empty errors dictionary and updated object</returns>
        public static async Task<(Dictionary<string, List<string>> errorsDictionary, WorkshopTask CreatedWorkshopTask)>
            UpdateTaskFromApi(int id, WorkshopApiTask workshopApiTaskWithUpdates)
        {
            var oldWorkshopTask = GetWorkshopTask(id);
            Dictionary<string, List<string>> errorDictionary = new Dictionary<string, List<string>>();

            if (oldWorkshopTask == null)
            {
                errorDictionary.Add(nameof(WorkshopTask.Id), new List<string>(){"Cannot find task with given id"});
                return (errorDictionary, null);
            }

            if (!ApiHelper.ValidateTaskFromAPI(workshopApiTaskWithUpdates, out errorDictionary))
                return (errorDictionary, null);

            using (WorkshopTaskContext dbContext = new WorkshopTaskContext())
            {
                var updatedWorkshopTask = ApiHelper.GenerateWorkshopTaskFromWorkshopApiTask(workshopApiTaskWithUpdates, oldWorkshopTask);
                updatedWorkshopTask.Status = GetStatus(updatedWorkshopTask.StatusId);

                dbContext.Entry(updatedWorkshopTask.Status).State = EntityState.Unchanged;
                var result = dbContext.WorkshopTasks.Update(updatedWorkshopTask);

                await dbContext.SaveChangesAsync();
                return (errorDictionary, result.Entity);
            }
        }
    }
}
