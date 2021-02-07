using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Workshop.UserInterface.Helpers
{
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
        public static Errors ValidateFirstName(string firstName)
        {
            Errors errors = Errors.None;

            if (!string.IsNullOrWhiteSpace(firstName))
            {
                if(firstName.Length > 50)
                {
                    errors |= Errors.TooManyChars;
                }
            }
            
            return errors;
        }

        public static Errors ValidateLastName(string lastName)
        {
            Errors errors = Errors.None;

            if (!string.IsNullOrWhiteSpace(lastName))
            {
                if (lastName.Length > 50)
                {
                    errors |= Errors.TooManyChars;
                }
            }

            return errors;
        }

        public static Errors ValidatePhone(string number)
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

        public static Errors ValidateFrameNo(string frameNo)
        {
            Errors errors = Errors.None;

            if (!string.IsNullOrWhiteSpace(frameNo))
            {
                if (frameNo.Length > 50)
                {
                    errors |= Errors.TooManyChars;
                }
            }

            return errors;
        }

        //In case of need
        //public static Errors ValidateAdditionalInfo(string additionalInfo)
        //{
        //    Errors errors = Errors.None;

        //    return errors;
        //}

        public static Errors ValidateDate(DateTime startDate, DateTime endDate)
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

        public static Errors ValidateCost(string cost)
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
        public static Errors ValidateDescription(string description)
        {
            Errors errors = Errors.None;

            if (string.IsNullOrWhiteSpace(description))
            {
                errors |= Errors.IsEmpty;
            }

            return errors;
        }

        public static bool IsPhoneNumber(string number)
        {
            Regex regex = new Regex(@"^\d{3}[\-\s]?\d{3}[\-\.\s]?\d{3}$");

            if (regex.IsMatch(number))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
