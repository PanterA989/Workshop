using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public List<TaskViewModel> GetTaskViewModels(string sql)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.ConnectionString()))
            {
                return connection.Query<TaskViewModel>(sql).ToList();
            }
        }

        public List<TaskViewModel> GetActiveTasks()
        {
            string sql = "SELECT t.Id, BikeManufacturer, BikeModel, StartDate, EndDate, s.Status FROM Task t INNER JOIN Status s ON t.StatusId = s.Id WHERE s.Status IN ('Przyjęty', 'Do odbioru', 'Anulowany - do odbioru') ORDER BY 1 DESC;";

            return GetTaskViewModels(sql);
        }

        public List<TaskViewModel> GetHistoryTasks()
        {
            string sql = "SELECT t.Id, BikeManufacturer, BikeModel, StartDate, EndDate, s.Status FROM Task t INNER JOIN Status s ON t.StatusId = s.Id WHERE s.Status IN ('Zrealizowany', 'Anulowany - odebrany') ORDER BY 1 DESC;";

            return GetTaskViewModels(sql);
        }

        public List<TaskViewModel> GetTaskViewModels()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.ConnectionString()))
            {
                return connection.Query<TaskViewModel>("SELECT t.Id, BikeManufacturer, BikeModel, StartDate, EndDate, s.Status FROM Task t INNER JOIN Status s ON t.StatusId = s.Id;").ToList();
            }
        }

        //public TaskModel GetTaskModel(int id)
        //{
        //    using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.ConnectionString()))
        //    {
        //        return  connection.QuerySingle<TaskModel>($"SELECT t.Id, FirstName, LastName, PhoneNumber, Email, BikeManufacturer, BikeModel, FrameNumber, AdditionalInfo, StartDate, EndDate, Cost, TaskDescription, s.Status FROM Task t INNER JOIN Status s ON t.StatusId = s.Id WHERE t.Id = {id};");
        //    }
        //}

        public TaskModel GetTaskModel(int id)
        {
            var sql = $"SELECT t.Id, FirstName, LastName, PhoneNumber, Email, BikeManufacturer, BikeModel, FrameNumber, AdditionalInfo, StartDate, EndDate, Cost, TaskDescription, s.Id, s.Status AS Value FROM Task t INNER JOIN Status s ON t.StatusId = s.Id WHERE t.Id = {id};";
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.ConnectionString()))
            {
                //var sql = $"SELECT * FROM Task t LEFT JOIN Status s ON t.StatusId = s.Id WHERE t.Id = {id};";
                var result = connection.Query<TaskModel, StatusModel, TaskModel>(sql, (taskModel, statusModel) => { taskModel.Status = statusModel; return taskModel; });
                var post = result.First();
                return post;
            }
        }


        public List<StatusModel> GetStatuses()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.ConnectionString()))
            {
                List<StatusModel> list = connection.Query<StatusModel>($"SELECT Id, Status as Value FROM Status;").ToList();
                return list;
            }
        }

        public bool AddTask(TaskModel taskData)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.ConnectionString()))
            {
                string addQuery = @"INSERT INTO [dbo].Task (FirstName, LastName, PhoneNumber, Email, BikeManufacturer, BikeModel, FrameNumber, AdditionalInfo, StartDate, EndDate, Cost, TaskDescription, StatusID) VALUES (@FirstName, @LastName, @PhoneNumber, @Email, @BikeManufacturer, @BikeModel, @FrameNumber, @AdditionalInfo, @StartDate, @EndDate, @Cost, @TaskDescription, @StatusID)";
                if (connection.Execute(addQuery, new { taskData.FirstName, taskData.LastName, taskData.PhoneNumber, taskData.Email, taskData.BikeManufacturer, taskData.BikeModel, taskData.FrameNumber, taskData.AdditionalInfo, taskData.StartDate, taskData.EndDate, taskData.Cost, taskData.TaskDescription, StatusID = taskData.Status.Id }) == 1) return true;
                else return false;

            }
        }

        public bool UpdateTask(TaskModel taskData)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.ConnectionString()))
            {
                string updateQuery = $@"UPDATE [dbo].Task SET [FirstName] = @FirstName, [LastName] = @LastName, [PhoneNumber] = @PhoneNumber, [Email] = @Email, [BikeManufacturer] = @BikeManufacturer, [BikeModel] = @BikeModel, [FrameNumber] = @FrameNumber, [AdditionalInfo] = @AdditionalInfo, [StartDate] = @StartDate, [EndDate] = @EndDate, [Cost] = @Cost, [TaskDescription] = @TaskDescription, [StatusID] = {taskData.Status.Id} WHERE [Id] = @Id";
                if (connection.Execute(updateQuery, taskData) > 0) return true;
                //if (connection.Execute($"UPDATE [dbo].Task SET [FirstName] = {taskData.FirstName}, [LastName] = {taskData.LastName}, [PhoneNumber] = {taskData.PhoneNumber}, [Email] = {taskData.Email}, [BikeManufacturer] = {taskData.BikeManufacturer}, [BikeModel] = {taskData.BikeModel}, [FrameNumber] = {taskData.FrameNumber}, [AdditionalInfo] = {taskData.AdditionalInfo}, [StartDate] = {taskData.StartDate.Date.ToString()}, [EndDate] = {taskData.EndDate.Value.Date.ToString()}, [Cost] = {taskData.Cost}, [TaskDescription] = {taskData.TaskDescription}, [StatusID] = {taskData.Status.Id} WHERE [Id] = {taskData.Id}") > 0) return true;
                else return false;

            }
        }
    }
}
