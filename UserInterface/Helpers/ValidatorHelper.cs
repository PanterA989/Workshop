using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workshop.DataAccessLayer.Enums;
using Workshop.DataAccessLayer.Helpers;

namespace Workshop.UserInterface.Helpers
{


    public static class ValidatorHelper
    {

        /// <summary>
        /// Validates first name and sets eventual message in errors provider.
        /// </summary>
        /// <param name="firstName">String representing first name.</param>
        /// <param name="errorProvider">ErrorProvider for validated field.</param>
        /// <param name="label">Label coresponding to error provider.</param>
        /// <returns>True if field has been validated succesfully.</returns>
        public static bool FirstNameCheckAndSetErrors(string firstName, ErrorProvider errorProvider, Label label)
        {
            Errors errors = DataValidatorHelper.ValidateFirstName(firstName);
            return SetAndCheckErrors(errorProvider, label, errors);
        }

        /// <summary>
        /// Validates last name and sets eventual message in errors provider.
        /// </summary>
        /// <param name="lastName">String representing last name.</param>
        /// <param name="errorProvider">ErrorProvider for validated field.</param>
        /// <param name="label">Label coresponding to error provider.</param>
        /// <returns>True if field has been validated succesfully.</returns>
        public static bool LastNameCheckAndSetErrors(string lastName, ErrorProvider errorProvider, Label label)
        {
            Errors errors = DataValidatorHelper.ValidateLastName(lastName);
            return SetAndCheckErrors(errorProvider, label, errors);
        }

        /// <summary>
        /// Validates phone number and sets eventual message in errors provider.
        /// </summary>
        /// <param name="phone">String representing phone number.</param>
        /// <param name="errorProvider">ErrorProvider for validated field.</param>
        /// <param name="label">Label coresponding to error provider.</param>
        /// <returns>True if field has been validated succesfully.</returns>
        public static bool PhoneCheckAndSetErrors(string phone, ErrorProvider errorProvider, Label label)
        {
            Errors errors = DataValidatorHelper.ValidatePhone(phone);
            return SetAndCheckErrors(errorProvider, label, errors);
        }

        /// <summary>
        /// Validates e-mail and sets eventual message in errors provider.
        /// </summary>
        /// <param name="email">String representing e-mail.</param>
        /// <param name="errorProvider">ErrorProvider for validated field.</param>
        /// <param name="label">Label coresponding to error provider.</param>
        /// <returns>True if field has been validated succesfully.</returns>
        public static bool EmailCheckAndSetErrors(string email, ErrorProvider errorProvider, Label label)
        {
            Errors errors = DataValidatorHelper.ValidateEmail(email);
            return SetAndCheckErrors(errorProvider, label, errors);
        }

        /// <summary>
        /// Validates bike manufacturer and sets eventual message in errors provider.
        /// </summary>
        /// <param name="manufacturer">String representing bike manufacturer.</param>
        /// <param name="errorProvider">ErrorProvider for validated field.</param>
        /// <param name="label">Label coresponding to error provider.</param>
        /// <returns>True if field has been validated succesfully.</returns>
        public static bool ManufacturerCheckAndSetErrors(string manufacturer, ErrorProvider errorProvider, Label label)
        {
            Errors errors = DataValidatorHelper.ValidateManufacturer(manufacturer);
            return SetAndCheckErrors(errorProvider, label, errors);
        }

        /// <summary>
        /// Validates bike model and sets eventual message in errors provider.
        /// </summary>
        /// <param name="model">String representing bike model.</param>
        /// <param name="errorProvider">ErrorProvider for validated field.</param>
        /// <param name="label">Label coresponding to error provider.</param>
        /// <returns>True if field has been validated succesfully.</returns>
        public static bool ModelCheckAndSetErrors(string model, ErrorProvider errorProvider, Label label)
        {
            Errors errors = DataValidatorHelper.ValidateModel(model);
            return SetAndCheckErrors(errorProvider, label, errors);
        }

        /// <summary>
        /// Validates frame number and sets eventual message in errors provider.
        /// </summary>
        /// <param name="frameNo">String representing frame number.</param>
        /// <param name="errorProvider">ErrorProvider for validated field.</param>
        /// <param name="label">Label coresponding to error provider.</param>
        /// <returns>True if field has been validated succesfully.</returns>
        public static bool FrameNoCheckAndSetErrors(string frameNo, ErrorProvider errorProvider, Label label)
        {
            Errors errors = DataValidatorHelper.ValidateFrameNo(frameNo);
            return SetAndCheckErrors(errorProvider, label, errors);
        }


        /// <summary>
        /// Validates start and end date and sets eventual message in errors provider.
        /// </summary>
        /// <param name="startDate">DateTime of start date</param>
        /// <param name="endDate">DateTime of end date</param>
        /// <param name="errorProviderStart">ErrorProvider for start date.</param>
        /// <param name="errorProviderEnd">ErrorProvider for end date.</param>
        /// <param name="labelStart">Label coresponding to start date error provider.</param>
        /// <param name="labelEnd">Label coresponding to end date error provider.</param>
        /// <returns>True if field has been validated succesfully.</returns>
        public static bool DatesCheckAndSetErrors(DateTime startDate, DateTime? endDate, ErrorProvider errorProviderStart, ErrorProvider errorProviderEnd, Label labelStart, Label labelEnd)
        {
            Errors errors = DataValidatorHelper.ValidateDate(startDate, endDate);
            if (errors.HasFlag(Errors.StartFromFuture))
            {
                errorProviderStart.SetError(labelStart, "Data przyjęcia jest z przyszłości.");
            }
            else
            {
                errorProviderStart.SetError(labelStart, null);
            }

            if (errors.HasFlag(Errors.EndBeforeStart))
            {
                errorProviderEnd.SetError(labelEnd, "Data zakończenia przed przyjęciem.");
            }
            else
            {
                errorProviderEnd.SetError(labelEnd, null);
            }

            return errors == 0;
        }

        /// <summary>
        /// Validates cost and sanitizes its TextBox content.
        /// </summary>
        /// <param name="cost">String representing frame cost.</param>
        /// <param name="errorProvider">ErrorProvider for validated field.</param>
        /// <param name="label">Label coresponding to error provider.</param>
        /// <param name="tbCost">TextBox of cost</param>
        /// <returns>True if field has been validated succesfully.</returns>
        public static bool CostCheckAndSetErrors(string cost, ErrorProvider errorProvider, Label label, TextBox tbCost)
        {
            cost = cost.Replace(',', '.');
            cost = cost.TrimStart('0');
            if (cost.IndexOf('.') == 0) cost = "0" + cost;
            tbCost.Text = cost;

            Errors errors = DataValidatorHelper.ValidateCost(cost);
            return SetAndCheckErrors(errorProvider, label, errors);
        }

        /// <summary>
        /// Validates description and sets eventual message in errors provider.
        /// </summary>
        /// <param name="description">String representing description.</param>
        /// <param name="errorProvider">ErrorProvider for validated field.</param>
        /// <param name="label">Label coresponding to error provider.</param>
        /// <returns>True if field has been validated succesfully.</returns>
        public static bool DescriptionCheckAndSetErrors(string description, ErrorProvider errorProvider, Label label)
        {
            Errors errors = DataValidatorHelper.ValidateDescription(description);
            return SetAndCheckErrors(errorProvider, label, errors);
        }

        /// <summary>
        /// Sets and checks error providers messages.
        /// </summary>
        /// <param name="errorProvider">ErrorProvider for validated field.</param>
        /// <param name="label">Label coresponding to error provider.</param>
        /// <param name="errors">Flags of errors</param>
        /// <returns>True if validation returned no errors.</returns>
        private static bool SetAndCheckErrors(ErrorProvider errorProvider, Label label, Errors errors)
        {
            var errorsList = DataValidatorHelper.ErrorDescriptionCreator(errors);
            var errorsDescription = String.Join("\n", errorsList);

            errorProvider.SetError(label, errorsDescription);
            return string.IsNullOrEmpty(errorsDescription);
        }
    }
}
