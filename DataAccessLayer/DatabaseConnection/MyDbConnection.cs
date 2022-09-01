using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Workshop.DataAccessLayer.ViewModel;
using Dapper;
using System.Data;
using Workshop.DataAccessLayer.Models;
using Workshop.DataAccessLayer.Models.Dictionaries;
using System.Threading.Tasks;

namespace Workshop.DataAccessLayer.DatabaseConnection
{
    public class MyDbConnection
    {

        public MyDbConnection()
        {
        }

        /// <summary>
        /// Executes asynchronous database query gathering all active tasks.
        /// </summary>
        /// <returns>List of active tasks.</returns>
        public async Task<List<TaskViewModel>> GetActiveTasks()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.GetConnectionString()))
            {
                var result = await connection.QueryAsync<TaskViewModel>("SELECT t.Id, BikeManufacturer, BikeModel, StartDate, EndDate, s.Status FROM Task t INNER JOIN Status s ON t.StatusId = s.Id WHERE s.Status IN ('Przyjęty', 'Do odbioru', 'Anulowany - do odbioru') ORDER BY 1 ASC;");
                return result.ToList();
            }

        }

        /// <summary>
        /// Executes asynchronous database query gathering all historical tasks.
        /// </summary>
        /// <returns>List of historical tasks.</returns>
        public async Task<List<TaskViewModel>> GetHistoryTasks()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.GetConnectionString()))
            {
                var restult = await connection.QueryAsync<TaskViewModel>("SELECT t.Id, BikeManufacturer, BikeModel, StartDate, EndDate, s.Status FROM Task t INNER JOIN Status s ON t.StatusId = s.Id WHERE s.Status IN ('Zrealizowany', 'Anulowany - odebrany') ORDER BY 1 DESC;");
                return restult.ToList();
            }
        }

        /// <summary>
        /// Gets specific task from databese, based on its id.
        /// </summary>
        /// <param name="id">id of task to be returned</param>
        /// <returns>Single task based on its id</returns>
        public WorkshopTask GetWorkshopTask(int id)
        {
            var sql = $"SELECT t.Id, FirstName, LastName, PhoneNumber, Email, BikeManufacturer, BikeModel, FrameNumber, AdditionalInfo, StartDate, EndDate, Cost, TaskDescription, s.Id, s.Status AS Value FROM Task t INNER JOIN Status s ON t.StatusId = s.Id WHERE t.Id = {id};";
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.GetConnectionString()))
            {
                var result = connection.Query<WorkshopTask, WorkshopTaskStatus, WorkshopTask>(sql, (workshopTask, statusModel) => { workshopTask.Status = statusModel; return workshopTask; });
                var post = result.First();
                return post;
            }
        }

        /// <summary>
        /// Gets all statuses from database.
        /// </summary>
        /// <returns>List of statuses.</returns>
        public List<WorkshopTaskStatus> GetStatuses()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.GetConnectionString()))
            {
                List<WorkshopTaskStatus> list = connection.Query<WorkshopTaskStatus>($"SELECT Id, Status as Value FROM Status;").ToList();
                return list;
            }
        }


        /// <summary>
        /// Adds task to database.
        /// </summary>
        /// <param name="workshopTask">TaskModel object to be put into database.</param>
        /// <returns>True if task has been added successfully.</returns>
        public bool AddTask(WorkshopTask workshopTask)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.GetConnectionString()))
            {
                string addQuery = @"INSERT INTO [dbo].Task (FirstName, LastName, PhoneNumber, Email, BikeManufacturer, BikeModel, FrameNumber, AdditionalInfo, StartDate, EndDate, Cost, TaskDescription, StatusID) VALUES (@FirstName, @LastName, @PhoneNumber, @Email, @BikeManufacturer, @BikeModel, @FrameNumber, @AdditionalInfo, @StartDate, @EndDate, @Cost, @TaskDescription, @StatusID)";
                if (connection.Execute(addQuery, new { workshopTask.Client.FirstName, workshopTask.Client.LastName, workshopTask.Client.PhoneNumber, workshopTask.Client.Email, workshopTask.Bike.Manufacturer, workshopTask.Bike.Model, workshopTask.Bike.FrameNumber, workshopTask.Bike.AdditionalInfo, workshopTask.StartDate, workshopTask.EndDate, workshopTask.Cost, workshopTask.TaskDescription, StatusID = workshopTask.Status.Id }) == 1) return true;
                else return false;

            }
        }

        /// <summary>
        /// Updates all fields of given task in database.
        /// </summary>
        /// <param name="taskData">Task with all its fields to be updated in database</param>
        /// <returns>True if task has been updated successfully.</returns>
        public bool UpdateTask(WorkshopTask taskData)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.GetConnectionString()))
            {
                string updateQuery = $@"UPDATE [dbo].Task SET [FirstName] = @FirstName, [LastName] = @LastName, [PhoneNumber] = @PhoneNumber, [Email] = @Email, [BikeManufacturer] = @BikeManufacturer, [BikeModel] = @BikeModel, [FrameNumber] = @FrameNumber, [AdditionalInfo] = @AdditionalInfo, [StartDate] = @StartDate, [EndDate] = @EndDate, [Cost] = @Cost, [TaskDescription] = @TaskDescription, [StatusID] = {taskData.Status.Id} WHERE [Id] = @Id";
                if (connection.Execute(updateQuery, taskData) == 1) return true;
                else return false;

            }
        }

        /// <summary>
        /// Updates status of given task in database.
        /// </summary>
        /// <param name="taskId">Id of task of which status should be updated</param>
        /// <param name="newStatusId">id of new status</param>
        /// <returns></returns>
        public bool UpdateStatus(int taskId, int newStatusId)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.GetConnectionString()))
            {
                string updateQuery = $@"UPDATE [dbo].Task SET [StatusID] = {newStatusId} WHERE [Id] = {taskId}";
                if (connection.Execute(updateQuery) == 1) return true;
                else return false;
            }
        }

        public bool DeleteTask(int taskId)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.GetConnectionString()))
            {
                string updateQuery = $@"DELETE FROM [dbo].Task WHERE [Id] = {taskId}";
                if (connection.Execute(updateQuery) == 1) return true;
                else return false;
            }
        }
    }
}
