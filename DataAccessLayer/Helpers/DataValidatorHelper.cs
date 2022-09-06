using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Workshop.DataAccessLayer.DatabaseConnection;
using Workshop.DataAccessLayer.Enums;

namespace Workshop.DataAccessLayer.Helpers
{
    public static class DataValidatorHelper
    {
        /// <summary>
        /// Validates first name.
        /// </summary>
        /// <param name="firstName">String representing first name.</param>
        /// <returns>Flags of errors.</returns>
        public static Errors ValidateFirstName(string firstName)
        {
            Errors errors = Errors.None;

            if (firstName.Length > 50)
            {
                errors |= Errors.TooManyChars;
            }

            return errors;
        }

        /// <summary>
        /// Validates last name.
        /// </summary>
        /// <param name="lastName">String representing last name.</param>
        /// <returns>Flags of errors.</returns>
        public static Errors ValidateLastName(string lastName)
        {
            Errors errors = Errors.None;

            if (lastName.Length > 50)
            {
                errors |= Errors.TooManyChars;
            }

            return errors;
        }

        /// <summary>
        /// Validates the phone number.
        /// </summary>
        /// <param name="number">String representing phone number.</param>
        /// <returns>Flags of errors.</returns>
        public static Errors ValidatePhone(string number)
        {
            Errors errors = Errors.None;

            if (string.IsNullOrWhiteSpace(number))
            {
                errors |= Errors.IsEmpty;
            }
            else
            {
                if (number.Length > 11)
                {
                    errors |= Errors.TooManyChars;
                }
                if (!IsPhoneNumber(number))
                {
                    errors |= Errors.BadFormat;
                }
            }

            return errors;
        }

        /// <summary>
        /// Validates the e-mail.
        /// </summary>
        /// <param name="email">String representing e-mail.</param>
        /// <returns>Flags of errors.</returns>
        public static Errors ValidateEmail(string email)
        {
            Errors errors = Errors.None;

            if (!string.IsNullOrWhiteSpace(email))
            {
                if (email.Length > 254)
                {
                    errors |= Errors.TooManyChars;
                }
                else
                {
                    try
                    {
                        MailAddress ma = new MailAddress(email);
                    }
                    catch
                    {
                        errors |= Errors.BadFormat;
                    }
                }
            }

            return errors;
        }

        /// <summary>
        /// Validates the bike manufacturer.
        /// </summary>
        /// <param name="manufacturer">String representing bike manufacturer.</param>
        /// <returns>Flags of errors.</returns>
        public static Errors ValidateManufacturer(string manufacturer)
        {
            Errors errors = Errors.None;

            if (string.IsNullOrWhiteSpace(manufacturer))
            {
                errors |= Errors.IsEmpty;
            }
            else if (manufacturer.Length > 50)
            {
                errors |= Errors.TooManyChars;
            }

            return errors;
        }

        /// <summary>
        /// Validates the bike model.
        /// </summary>
        /// <param name="model">String representing bike model.</param>
        /// <returns>Flags of errors.</returns>
        public static Errors ValidateModel(string model)
        {
            Errors errors = Errors.None;

            if (string.IsNullOrWhiteSpace(model))
            {
                errors |= Errors.IsEmpty;
            }
            else if (model.Length > 50)
            {
                errors |= Errors.TooManyChars;
            }

            return errors;
        }

        /// <summary>
        /// Validates the bike frame number.
        /// </summary>
        /// <param name="frameNo">String representing bike frame number.</param>
        /// <returns>Flags of errors.</returns>
        public static Errors ValidateFrameNo(string frameNo)
        {
            Errors errors = Errors.None;

            if (frameNo.Length > 50)
            {
                errors |= Errors.TooManyChars;
            }

            return errors;
        }

        /// <summary>
        /// Checks if given dates are correct. 
        /// </summary>
        /// <param name="startDate">DateTime of start</param>
        /// <param name="endDate">DateTime of end</param>
        /// <returns>Flags of errors.</returns>
        public static Errors ValidateDate(DateTime startDate, DateTime? endDate)
        {
            Errors errors = Errors.None;

            if (startDate > DateTime.Now)
            {
                errors |= Errors.StartFromFuture;
            }

            if (endDate == null) 
                return errors;

            if (endDate.Value.Date < startDate.Date)
            {
                errors |= Errors.EndBeforeStart;
            }

            return errors;
        }

        /// <summary>
        /// Checks that the provided cost is in the correct format.
        /// </summary>
        /// <param name="cost">String representing cost.</param>
        /// <returns>Flags of errors.</returns>
        public static Errors ValidateCost(string cost)
        {
            Errors errors = Errors.None;
            cost = cost.Replace(",", ".");

            if (!string.IsNullOrWhiteSpace(cost))
            {
                int dotCount = cost.Length - cost.Replace(".", "").Length;

                if (dotCount == 0 && cost.Length > 7) return errors |= Errors.TooManyChars;
                if (dotCount == 1)
                {
                    int dotIndex = cost.IndexOf('.');
                    if (cost.Substring(dotIndex + 1).Length > 2) return errors |= Errors.BadFormat;
                    if (cost.Substring(0, dotIndex).Length > 9) return errors |= Errors.TooManyChars;
                }
                if (dotCount > 1) return errors |= Errors.BadFormat;

                Regex regex = new Regex(@"^\d{1,7}(\.\d{0,2})?$");

                if (!regex.IsMatch(cost))
                {
                    errors |= Errors.BadFormat;
                }
            }

            return errors;
        }

        /// <summary>
        /// Validates status id to check if status exist in database
        /// </summary>
        /// <param name="statusId">id of status</param>
        /// <returns>Flags of errors.</returns>
        public static Errors ValidateStatusId(int statusId)
        {
            Errors errors = Errors.None;

            if(MyDbConnection.GetStatus(statusId) == null)
                errors |= Errors.BadStatus;
            
            return errors;
        }

        /// <summary>
        /// Validates description.
        /// </summary>
        /// <param name="description">String representing description.</param>
        /// <returns>Flags of errors.</returns>
        public static Errors ValidateDescription(string description)
        {
            Errors errors = Errors.None;

            if (string.IsNullOrWhiteSpace(description))
            {
                errors |= Errors.IsEmpty;
            }

            return errors;
        }

        /// <summary>
        /// Checks if given phone number is in valid format.
        /// </summary>
        /// <param name="number">String representing phone number.</param>
        /// <returns>Flags of errors.</returns>
        private static bool IsPhoneNumber(string number)
        {
            Regex regex = new Regex(@"^\d{3}[\-\s]?\d{3}[\-\.\s]?\d{3}$");

            return regex.IsMatch(number);
        }

        /// <summary>
        /// Creates error provider messages based on errors flags
        /// </summary>
        /// <param name="errors">Flags of errors</param>
        /// <returns>List of descriptions for matching errors</returns>
        public static List<string> ErrorDescriptionCreator(Errors errors)
        {
            List<string> errorList = new List<string>();

            if (errors.HasFlag(Errors.IsEmpty))
            {
                errorList.Add("Pole jest puste.");
            }
            if (errors.HasFlag(Errors.TooManyChars))
            {
                errorList.Add("Zbyt duża ilość znaków.");
            }
            if (errors.HasFlag(Errors.BadFormat))
            {
                errorList.Add("Błędny format.");
            }
            if (errors.HasFlag(Errors.EndBeforeStart))
            {
                errorList.Add("Data zakończenia przed przyjęciem.");
            }
            if (errors.HasFlag(Errors.StartFromFuture))
            {
                errorList.Add("Data przyjęcia jest z przyszłości.");
            }
            if (errors.HasFlag(Errors.BadStatus))
            {
                errorList.Add("Błędny status zlecenia.");
            }

            return errorList;
        }
    }
}
