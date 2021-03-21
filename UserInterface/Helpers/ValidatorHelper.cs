using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop.UserInterface.Helpers
{
    /// <summary>
    /// Flags of errors in form fields.
    /// </summary>
    [Flags]
    public enum Errors
    {
        None            = 0,
        IsEmpty         = 1 << 0,
        TooManyChars    = 1 << 1,
        BadFormat       = 1 << 2,
        EndBeforeStart  = 1 << 3,
        StartFromFuture = 1 << 4,
        Additional1     = 1 << 5,
        Additional2     = 1 << 6,
        Additional3     = 1 << 7
    }

    public static class ValidatorHelper
    {
        /// <summary>
        /// Validates first name.
        /// </summary>
        /// <param name="firstName">String representing first name.</param>
        /// <returns>Flags of errors.</returns>
        private static Errors ValidateFirstName(string firstName)
        {
            Errors errors = Errors.None;

            if(firstName.Length > 50)
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
        private static Errors ValidateLastName(string lastName)
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
        private static Errors ValidatePhone(string number)
        {
            Errors errors = Errors.None;

            if (string.IsNullOrWhiteSpace(number))
            {
                errors |= Errors.IsEmpty;
            }
            else
            {
                if(number.Length > 11)
                {
                    errors |= Errors.TooManyChars;
                }
                else
                {
                    if(!IsPhoneNumber(number))
                    {
                        errors |= Errors.BadFormat;
                    }
                }
            }

            return errors;
        }

        /// <summary>
        /// Validates the e-mail.
        /// </summary>
        /// <param name="email">String representing e-mail.</param>
        /// <returns>Flags of errors.</returns>
        private static Errors ValidateEmail(string email)
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
        private static Errors ValidateManufacturer(string manufacturer)
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
        private static Errors ValidateModel(string model)
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
        private static Errors ValidateFrameNo(string frameNo)
        {
            Errors errors = Errors.None;

            if (frameNo.Length > 50)
            {
                errors |= Errors.TooManyChars;
            }

            return errors;
        }

        //In case of need
        //private static Errors ValidateAdditionalInfo(string additionalInfo)
        //{
        //    Errors errors = Errors.None;

        //    return errors;
        //}

        /// <summary>
        /// Checks if given dates are correct. 
        /// </summary>
        /// <param name="startDate">DateTime of start</param>
        /// <param name="endDate">DateTime of end</param>
        /// <returns>Flags of errors.</returns>
        private static Errors ValidateDate(DateTime startDate, DateTime endDate)
        {
            Errors errors = Errors.None;

            if(startDate > DateTime.Now)
            {
                errors |= Errors.StartFromFuture;
            }

            if (!endDate.Equals(' '))
            {
                if (endDate.Date < startDate.Date)
                {
                    errors |= Errors.EndBeforeStart;
                }
            }

            return errors;
        }

        /// <summary>
        /// Checks that the provided cost is in the correct format.
        /// </summary>
        /// <param name="cost">String representing cost.</param>
        /// <returns>Flags of errors.</returns>
        private static Errors ValidateCost(string cost)
        {
            Errors errors = Errors.None;

            if (!string.IsNullOrWhiteSpace(cost))
            {
                int dotCount = cost.Length - cost.Replace(".", "").Length;
                
                if (dotCount == 0 && cost.Length > 7) return errors |= Errors.TooManyChars;
                if(dotCount == 1)
                {
                    int dotIndex = cost.IndexOf('.');
                    if (cost.Substring(dotIndex + 1).Length > 2) return errors |= Errors.BadFormat;
                    if (cost.Substring(0, dotIndex).Length > 9) return errors |= Errors.TooManyChars;
                }
                if (dotCount > 1) return errors |= Errors.BadFormat;

                Regex regex = new Regex(@"^\d{1,7}(\.\d{0,2})?$");

                if (!regex.IsMatch(cost)) {
                    errors |= Errors.BadFormat;
                }
            }

            return errors;
        }

        /// <summary>
        /// Validates description.
        /// </summary>
        /// <param name="description">String representing description.</param>
        /// <returns>Flags of errors.</returns>
        private static Errors ValidateDescription(string description)
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
        /// Validates first name and sets eventual message in errors provider.
        /// </summary>
        /// <param name="firstName">String representing first name.</param>
        /// <param name="errorProvider">ErrorProvider for validated field.</param>
        /// <param name="label">Label coresponding to error provider.</param>
        /// <returns>True if field has been validated succesfully.</returns>
        public static bool FirstNameCheckAndSetErrors(string firstName, ErrorProvider errorProvider, Label label)
        {
            Errors errors = ValidateFirstName(firstName);
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
            Errors errors = ValidateLastName(lastName);
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
            Errors errors = ValidatePhone(phone);
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
            Errors errors = ValidateEmail(email);
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
            Errors errors = ValidateManufacturer(manufacturer);
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
            Errors errors = ValidateModel(model);
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
            Errors errors = ValidateFrameNo(frameNo);
            return SetAndCheckErrors(errorProvider, label, errors);
        }

        //In case of need
        //private bool AdditionalInfoValidation(string additionalInfo, ErrorProvider errorProvider, Label label)
        //{
        //    Errors errors = ValidatorHelper.ValidateAdditionalInfo(additionalInfo);
        //    return SetAndCheckErrors(errorProvider, label, errors);
        //}

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
        public static bool DatesCheckAndSetErrors(DateTime startDate, DateTime endDate, ErrorProvider errorProviderStart, ErrorProvider errorProviderEnd, Label labelStart, Label labelEnd)
        {
            Errors errors = ValidateDate(startDate, endDate);
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

            Errors errors = ValidateCost(cost);
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
            Errors errors = ValidateDescription(description);
            return SetAndCheckErrors(errorProvider, label, errors);
        }

        /// <summary>
        /// Creates error provider messages based on errors flags
        /// </summary>
        /// <param name="errors">Flags of errors</param>
        /// <returns>Full errors description.</returns>
        private static string ErrorDescriptionCreator(Errors errors)
        {
            string text = null;

            if (errors == 0)
            {
                return null;
            }
            else
            {
                if (errors.HasFlag(Errors.IsEmpty))
                {
                    text += "Pole jest puste.\n";
                }
                if (errors.HasFlag(Errors.TooManyChars))
                {
                    text += "Zbyt duża ilość znaków.\n";
                }
                if (errors.HasFlag(Errors.BadFormat))
                {
                    text += "Błędny format.\n";
                }
                if (errors.HasFlag(Errors.EndBeforeStart))
                {
                    text += "Data zakończenia przed przyjęciem.\n";
                }
                if (errors.HasFlag(Errors.StartFromFuture))
                {
                    text += "Data przyjęcia jest z przyszłości.\n";
                }
            }

            return text;
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
            string errorsDescription = ErrorDescriptionCreator(errors);
            errorProvider.SetError(label, errorsDescription);
            return string.IsNullOrEmpty(errorsDescription);
        }
    }
}
