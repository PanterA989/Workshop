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

namespace Workshop.DataAccessLayer.DatabaseConnection
{
    public class MyDbConnection
    {

        public MyDbConnection()
        {
            SqlMapper.AddTypeHandler(new StatusModelHandler());
        }

        public List<TaskViewModel> GetTaskViewModels()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.CnnVal()))
            {
                return connection.Query<TaskViewModel>("SELECT t.Id, BikeManufacturer, BikeModel, StartDate, EndDate, s.Status FROM Task t INNER JOIN Status s ON t.StatusId = s.Id;").ToList();
            }
        }

        public TaskModel GetTaskModel(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(ConnectionHelper.CnnVal()))
            {
                return connection.QuerySingle<TaskModel>($"SELECT t.Id, FirstName, LastName, PhoneNumber, Email, BikeManufacturer, BikeModel, FrameNumber, AdditionalInfo, StartDate, EndDate, Cost, s.Status FROM Task t INNER JOIN Status s ON t.StatusId = s.Id WHERE t.Id = {id};");
            }
        }


    }
}
