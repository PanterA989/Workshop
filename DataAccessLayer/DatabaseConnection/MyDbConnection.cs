using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using Workshop.DataAccessLayer.ViewModel;
using Dapper;
using System.Data;
using Workshop.DataAccessLayer.Models;
using Workshop.DataAccessLayer.Models.Dictionaries;

namespace Workshop.DataAccessLayer.DatabaseConnection
{
    public class MyDbConnection
    {

        public MyDbConnection()
        {
        }

        /// <summary>
        /// Executes database query gathering all active tasks.
        /// </summary>
        /// <returns>List of active tasks.</returns>
        public List<TaskViewModel> GetActiveTasks()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString()))
            {
                return connection.Query<TaskViewModel>("SELECT t.Id, BikeManufacturer, BikeModel, StartDate, EndDate, s.Status FROM Task t INNER JOIN Status s ON t.StatusId = s.Id WHERE s.Status IN ('Przyjęty', 'Do odbioru', 'Anulowany - do odbioru') ORDER BY 1 ASC;").ToList();
            }

        }

        /// <summary>
        /// Executes database query gathering all historical tasks.
        /// </summary>
        /// <returns>List of historical tasks.</returns>
        public List<TaskViewModel> GetHistoryTasks()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString()))
            {
                return connection.Query<TaskViewModel>("SELECT t.Id, BikeManufacturer, BikeModel, StartDate, EndDate, s.Status FROM Task t INNER JOIN Status s ON t.StatusId = s.Id WHERE s.Status IN ('Zrealizowany', 'Anulowany - odebrany') ORDER BY 1 DESC;").ToList();
            }
        }

        /// <summary>
        /// Gets specific task from databese, based on its id.
        /// </summary>
        /// <param name="id">id of task to be returned</param>
        /// <returns>Single task based on its id</returns>
        public TaskModel GetTaskModel(int id)
        {
            var sql = $"SELECT t.Id, FirstName, LastName, PhoneNumber, Email, BikeManufacturer, BikeModel, FrameNumber, AdditionalInfo, StartDate, EndDate, Cost, TaskDescription, s.Id, s.Status AS Value FROM Task t INNER JOIN Status s ON t.StatusId = s.Id WHERE t.Id = {id};";
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString()))
            {
                var result = connection.Query<TaskModel, StatusModel, TaskModel>(sql, (taskModel, statusModel) => { taskModel.Status = statusModel; return taskModel; });
                var post = result.First();
                return post;
            }
        }

        /// <summary>
        /// Gets all statuses from database.
        /// </summary>
        /// <returns>List of statuses.</returns>
        public List<StatusModel> GetStatuses()
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString()))
            {
                List<StatusModel> list = connection.Query<StatusModel>($"SELECT Id, Status as Value FROM Status;").ToList();
                return list;
            }
        }


        /// <summary>
        /// Adds task to database.
        /// </summary>
        /// <param name="taskData">TaskModel object to be put into database.</param>
        /// <returns>True if task has been added successfully.</returns>
        public bool AddTask(TaskModel taskData)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString()))
            {
                string addQuery = @"INSERT INTO [dbo].Task (FirstName, LastName, PhoneNumber, Email, BikeManufacturer, BikeModel, FrameNumber, AdditionalInfo, StartDate, EndDate, Cost, TaskDescription, StatusID) VALUES (@FirstName, @LastName, @PhoneNumber, @Email, @BikeManufacturer, @BikeModel, @FrameNumber, @AdditionalInfo, @StartDate, @EndDate, @Cost, @TaskDescription, @StatusID)";
                if (connection.Execute(addQuery, new { taskData.FirstName, taskData.LastName, taskData.PhoneNumber, taskData.Email, taskData.BikeManufacturer, taskData.BikeModel, taskData.FrameNumber, taskData.AdditionalInfo, taskData.StartDate, taskData.EndDate, taskData.Cost, taskData.TaskDescription, StatusID = taskData.Status.Id }) == 1) return true;
                else return false;

            }
        }

        /// <summary>
        /// Updates all fields of given task in database.
        /// </summary>
        /// <param name="taskData">Task with all its fields to be updated in database</param>
        /// <returns>True if task has been updated successfully.</returns>
        public bool UpdateTask(TaskModel taskData)
        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString()))
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
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionString()))
            {
                string updateQuery = $@"UPDATE [dbo].Task SET [StatusID] = {newStatusId} WHERE [Id] = {taskId}";
                if (connection.Execute(updateQuery) == 1) return true;
                else return false;
            }
        }
    }
}
