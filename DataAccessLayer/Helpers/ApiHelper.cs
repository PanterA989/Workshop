using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop.DataAccessLayer.DatabaseConnection;
using Workshop.DataAccessLayer.Enums;
using Workshop.DataAccessLayer.Models;

namespace Workshop.DataAccessLayer.Helpers
{
    public static class ApiHelper
    {
        /// <summary>
        /// Validates task data received from API
        /// </summary>
        /// <param name="workshopTask">Simple representation of task</param>
        /// <param name="errorsDictionary">out parameter with <see cref="Dictionary{TKey,TValue}"/> of parameters and <see cref="List{T}"/> of errors for given parameter</param>
        /// <returns>True if object successfully passed validation, otherwise false</returns>
        public static bool ValidateTaskFromApi(WorkshopApiTask workshopTask, out Dictionary<string, List<string>> errorsDictionary)
        {
            errorsDictionary = new Dictionary<string, List<string>>();
            
            ValidateClient(workshopTask, errorsDictionary);
            ValidateBike(workshopTask, errorsDictionary);
            ValidateTaskInformations(workshopTask, errorsDictionary);

            return errorsDictionary.Count == 0;
        }


        /// <summary>
        /// Validates client data
        /// </summary>
        /// <param name="workshopTask">Simple representation of task</param>
        /// <param name="errorsDictionary">out parameter with dictionary of parameters and list of errors for given parameter</param>
        /// <returns>True if object successfully passed validation. If any errors are found - false</returns>
        private static bool ValidateClient(WorkshopApiTask workshopTask, Dictionary<string, List<string>> errorsDictionary)
        {
            Errors errors;

            //First name
            errors = DataValidatorHelper.ValidateFirstName(workshopTask.Client.FirstName);
            if (errors != 0)
            {
                errorsDictionary.Add(nameof(WorkshopApiTask.Client.FirstName), DataValidatorHelper.ErrorDescriptionCreator(errors));
            }

            //Last name
            errors = DataValidatorHelper.ValidateLastName(workshopTask.Client.LastName);
            if (errors != 0)
            {
                errorsDictionary.Add(nameof(WorkshopApiTask.Client.LastName), DataValidatorHelper.ErrorDescriptionCreator(errors));
            }

            //Phone number
            errors = DataValidatorHelper.ValidatePhone(workshopTask.Client.PhoneNumber);
            if (errors != 0)
            {
                errorsDictionary.Add(nameof(WorkshopApiTask.Client.PhoneNumber), DataValidatorHelper.ErrorDescriptionCreator(errors));
            }

            //Email
            errors = DataValidatorHelper.ValidateEmail(workshopTask.Client.Email);
            if (errors != 0)
            {
                errorsDictionary.Add(nameof(WorkshopApiTask.Client.Email), DataValidatorHelper.ErrorDescriptionCreator(errors));
            }

            return errors == 0;
        }

        /// <summary>
        /// Validates bike data
        /// </summary>
        /// <param name="workshopTask">Simple representation of task</param>
        /// <param name="errorsDictionary">out parameter with dictionary of parameters and list of errors for given parameter</param>
        /// <returns>True if object successfully passed validation. If any errors are found - false</returns>
        private static bool ValidateBike(WorkshopApiTask workshopTask, Dictionary<string, List<string>> errorsDictionary)
        {
            Errors errors;

            //Manufacturer
            errors = DataValidatorHelper.ValidateManufacturer(workshopTask.Bike.Manufacturer);
            if (errors != 0)
            {
                errorsDictionary.Add(nameof(WorkshopApiTask.Bike.Manufacturer), DataValidatorHelper.ErrorDescriptionCreator(errors));
            }

            //Model
            errors = DataValidatorHelper.ValidateModel(workshopTask.Bike.Model);
            if (errors != 0)
            {
                errorsDictionary.Add(nameof(WorkshopApiTask.Bike.Model), DataValidatorHelper.ErrorDescriptionCreator(errors));
            }

            //Frame number
            errors = DataValidatorHelper.ValidateFrameNo(workshopTask.Bike.FrameNumber);
            if (errors != 0)
            {
                errorsDictionary.Add(nameof(WorkshopApiTask.Bike.FrameNumber), DataValidatorHelper.ErrorDescriptionCreator(errors));
            }

            return errors == 0;
        }

        /// <summary>
        /// Validates task information data
        /// </summary>
        /// <param name="workshopTask">Simple representation of task</param>
        /// <param name="errorsDictionary">out parameter with dictionary of parameters and list of errors for given parameter</param>
        /// <returns>True if object successfully passed validation. If any errors are found - false</returns>
        private static bool ValidateTaskInformations(WorkshopApiTask workshopTask, Dictionary<string, List<string>> errorsDictionary)
        {
            Errors errors;

            //Dates
            errors = DataValidatorHelper.ValidateDate(workshopTask.StartDate, workshopTask.EndDate);
            if (errors != 0)
            {
                if(errors.HasFlag(Errors.StartFromFuture))
                    errorsDictionary.Add(nameof(WorkshopApiTask.StartDate), DataValidatorHelper.ErrorDescriptionCreator(Errors.StartFromFuture));

                if (errors.HasFlag(Errors.EndBeforeStart))
                    errorsDictionary.Add(nameof(WorkshopApiTask.EndDate), DataValidatorHelper.ErrorDescriptionCreator(Errors.EndBeforeStart));
            }

            //Cost
            errors = DataValidatorHelper.ValidateCost(workshopTask.Cost.ToString());
            if (errors != 0)
            {
                errorsDictionary.Add(nameof(workshopTask.Cost), DataValidatorHelper.ErrorDescriptionCreator(errors));
            }

            //Description
            errors = DataValidatorHelper.ValidateDescription(workshopTask.TaskDescription);
            if (errors != 0)
            {
                errorsDictionary.Add(nameof(workshopTask.TaskDescription), DataValidatorHelper.ErrorDescriptionCreator(errors));
            }

            //Status
            errors = DataValidatorHelper.ValidateStatusId(workshopTask.StatusId);
            if (errors != 0)
            {
                errorsDictionary.Add(nameof(workshopTask.StatusId), DataValidatorHelper.ErrorDescriptionCreator(errors));
            }

            return errors == 0;
        }

        /// <summary>
        /// Generates advanced WorkshopTask from simplified WorkshopApiTask
        /// </summary>
        /// <param name="workshopApiTask">Simple representation of task</param>
        /// <returns>WorkshopTask with data from simple WorkshopApiTask</returns>
        public static WorkshopTask GenerateWorkshopTaskFromWorkshopApiTask(WorkshopApiTask workshopApiTask)
        {
            WorkshopTask generatedWorkshopTask = new WorkshopTask(workshopApiTask);
            return generatedWorkshopTask;
        }

        /// <summary>
        /// Generates advanced WorkshopTask from simplified WorkshopApiTask with copying missing values from given
        /// </summary>
        /// <param name="workshopApiTask">Simple representation of task</param>
        /// <param name="baseWorkshopTask">Base for creating new WorkshopTask</param>
        /// <returns>WorkshopTask with data from simple WorkshopApiTask and given WorkshopTask</returns>
        public static WorkshopTask GenerateWorkshopTaskFromWorkshopApiTask(WorkshopApiTask workshopApiTask, WorkshopTask baseWorkshopTask)
        {
            WorkshopTask generatedWorkshopTask = new WorkshopTask(workshopApiTask)
            {
                Id = baseWorkshopTask.Id,
                ClientId = baseWorkshopTask.ClientId,
                BikeId = baseWorkshopTask.BikeId
            };

            generatedWorkshopTask.Client.Id = baseWorkshopTask.Client.Id;
            generatedWorkshopTask.Bike.Id = baseWorkshopTask.Bike.Id;

            return generatedWorkshopTask;
        }
    }
}
