using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop.DataAccessLayer.Enums;
using Workshop.DataAccessLayer.Models;
using Workshop.DataAccessLayer.Models.Dictionaries;
using Workshop.DataAccessLayer.ViewModel;

namespace Workshop.DataAccessLayer.DatabaseConnection.Interfaces
{
    public interface IMyDbConnection
    {
       Task<List<TaskViewModel>> GetWorkshopTaskList(WorkshopTasksListType listType);
       WorkshopTask GetWorkshopTask(int id);
       List<WorkshopTaskStatus> GetStatuses();
       WorkshopTaskStatus GetStatus(int id);
       bool AddTask(WorkshopTask workshopTask);
       bool UpdateTask(WorkshopTask updatedTaskData);
       bool UpdateStatus(int taskId, int newStatusId);
       bool DeleteTask(int taskId);
       Task<(Dictionary<string, List<string>> errorsDictionary, WorkshopTask CreatedWorkshopTask)> AddTaskFromApi(
           WorkshopApiTask workshopApiTask); 
       Task<(Dictionary<string, List<string>> errorsDictionary, WorkshopTask CreatedWorkshopTask)> UpdateTaskFromApi(
           int id, WorkshopApiTask workshopApiTaskWithUpdates);
    }
}
