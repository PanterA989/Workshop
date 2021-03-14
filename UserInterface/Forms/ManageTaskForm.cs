using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workshop.DataAccessLayer.Models;
using Workshop.DataAccessLayer.Models.Dictionaries;
using Workshop.UserInterface.Forms.Base;
using Workshop.UserInterface.Helpers;

namespace Workshop.UserInterface.Forms
{
    public partial class ManageTaskForm : BaseAddEditForm
    {
        private readonly int editId;

        public ManageTaskForm()
        {
            InitializeComponent();
            InitializeErrorProviders();

            tlpStatus.Visible = false;

        }

        public ManageTaskForm(TaskModel taskModel)
        {
            //TODO:Handle null taskMocel
            InitializeComponent();
            InitializeData(taskModel);
            cbStartDateEditable.Text = "inna data";
            buttonConfirm.Image = Properties.Resources.edit_24;
            buttonConfirm.Text = "Edytuj";
            this.Text = "Edycja zlecenie";
            editId = taskModel.Id;
        }


        private void InitializeErrorProviders()
        {
            epFirstName.SetIconAlignment(labelFirstName, ErrorIconAlignment.MiddleLeft);
            epLastName.SetIconAlignment(labelLastName, ErrorIconAlignment.MiddleLeft);
            epPhone.SetIconAlignment(labelPhone, ErrorIconAlignment.MiddleLeft);
            epEmail.SetIconAlignment(labelEmail, ErrorIconAlignment.MiddleLeft);
            epManufacturer.SetIconAlignment(labelManufacturer, ErrorIconAlignment.MiddleLeft);
            epModel.SetIconAlignment(labelModel, ErrorIconAlignment.MiddleLeft);
            epFrameNo.SetIconAlignment(labelFrameNo, ErrorIconAlignment.MiddleLeft);
            epAddidtionalInfo.SetIconAlignment(labelAdditionalInfo, ErrorIconAlignment.MiddleLeft);
            epStartDate.SetIconAlignment(labelStartDate, ErrorIconAlignment.MiddleLeft);
            epEndDate.SetIconAlignment(labelEndDate, ErrorIconAlignment.MiddleLeft);
            epCost.SetIconAlignment(labelCost, ErrorIconAlignment.MiddleLeft);
            epDescription.SetIconAlignment(labelDescription, ErrorIconAlignment.MiddleRight);



            //epFirstName.SetError(labelFirstName, "TEST");
            //epLastName.SetError(labelLastName, "TEST");
            //epPhone.SetError(labelPhone, "TEST");
            //epEmail.SetError(labelEmail, "TEST");
            //epManufacturer.SetError(labelManufacturer, "TEST");
            //epModel.SetError(labelModel, "TEST");
            //epFrameNo.SetError(labelFrameNo, "TEST");
            //epAddidtionalInfo.SetError(labelAdditionalInfo, "TEST");
            //epStartDate.SetError(labelStartDate, "TEST");
            //epEndDate.SetError(labelEndDate, "TEST");
            //epCost.SetError(labelCost, "TEST");
            //epDescription.SetError(labelDescription, "TEST");


        }

        private bool ValidateControls()
        {
            bool validationResult = true;

            if (!FirstNameValidation(tbFirstName.Text)) validationResult = false;
            if (!LastNameValidation(tbLastName.Text)) validationResult = false;
            if (!PhoneValidation(tbPhone.Text)) validationResult = false;
            if (!EmailValidation(tbEmail.Text)) validationResult = false;
            if (!ManufacturerValidation(tbManufacturer.Text)) validationResult = false;
            if (!ModelValidation(tbModel.Text)) validationResult = false;
            if (!FrameNoValidation(tbFrameNo.Text)) validationResult = false;
            //if (!AdditionalInfoValidation(tbAdditionalInfo.Text)) validationResult = false;
            if (!DatesValidation(dtpStartDate.Value, dtpEndDate.Value)) validationResult = false;
            if (!CostValidation(tbCost.Text)) validationResult = false;
            if (!DescriptionValidation(tbDescription.Text)) validationResult = false;

            return validationResult;
        }

        private void InitializeData(TaskModel task)
        {
            List<StatusModel> statuses = new List<StatusModel>()
            {
                new StatusModel("Przyjęty"),
                new StatusModel("Do odbioru"),
                new StatusModel("Zrealizowany"),
                new StatusModel("Anulowany - do odbioru"),
                new StatusModel("Anulowany - odebrany")
            };

            bsStatus.DataSource = statuses;

            tbFirstName.Text = task?.FirstName;
            tbLastName.Text = task?.LastName;
            tbPhone.Text = task.PhoneNumber;
            tbEmail.Text = task?.Email;
            tbManufacturer.Text = task.BikeManufacturer;
            tbModel.Text = task.BikeModel;
            tbFrameNo.Text = task?.FrameNumber;
            tbAdditionalInfo.Text = task?.AdditionalInfo;
            dtpStartDate.Value = task.StartDate;
            if (task.EndDate.HasValue)
            {
                dtpEndDate.Value = task.EndDate.Value;
            }
            tbCost.Text = task?.Cost.ToString();
            tbDescription.Text = task.TaskDescription;
            cbStatus.Text = task.Status.Value;

        }

        private void isStartDateNotToday_CheckedChanged(object sender, EventArgs e)
        {
            if(cbStartDateEditable.Checked == true)
            {
                dtpStartDate.Enabled = true;
            }
            else
            {
                dtpStartDate.Value = DateTime.Now;
                dtpStartDate.Enabled = false;
            }
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Czy na pewno chcesz zamknąć formularz?" + "\n" + "Wprowadzone dane nie zostaną zapisane!", "Anulowanie", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                Close();
            }

        }

        protected override void Save()
        {
            TrimFields();
            if (ValidateControls())
            {
                //TODO: Adding data to database
                MessageBox.Show("Zapisano");
            }
            else
            {
                MessageBox.Show("Dane wprowadzone do formularza posiadają błędy", "Błędne dane", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.Format = DateTimePickerFormat.Long;
        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {
            PhoneValidation(tbPhone.Text);
        }

        private void tbManufacturer_TextChanged(object sender, EventArgs e)
        {
            ManufacturerValidation(tbManufacturer.Text);
        }

        private void tbModel_TextChanged(object sender, EventArgs e)
        {
            ModelValidation(tbModel.Text);
        }

        private void tbDescription_TextChanged(object sender, EventArgs e)
        {
            DescriptionValidation(tbDescription.Text);
        }

        //Ability to only use digits, spaces, controls, '+' and '-'
        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != ' ' && e.KeyChar != '+';
        }

        private void tbPhone_Validated(object sender, EventArgs e)
        {
            PhoneValidation(tbPhone.Text);
        }

        private void tbManufacturer_Validated(object sender, EventArgs e)
        {
            ManufacturerValidation(tbManufacturer.Text);
        }

        private void tbModel_Validated(object sender, EventArgs e)
        {
            ModelValidation(tbModel.Text);
        }


        private bool FirstNameValidation(string firstName)
        {
            Errors errors = ValidatorHelper.ValidateFirstName(firstName);
            string errorsDescription = ErrorDescriptionCreator(errors);
            epFirstName.SetError(labelFirstName, errorsDescription);
            return string.IsNullOrEmpty(errorsDescription);
        }

        private bool LastNameValidation(string lastName)
        {
            Errors errors = ValidatorHelper.ValidateLastName(lastName);
            string errorsDescription = ErrorDescriptionCreator(errors);
            epLastName.SetError(labelLastName, errorsDescription);
            return string.IsNullOrEmpty(errorsDescription);
        }

        private bool PhoneValidation(string phone)
        {
            Errors errors = ValidatorHelper.ValidatePhone(phone);
            string errorsDescription = ErrorDescriptionCreator(errors);
            epPhone.SetError(labelPhone, errorsDescription);
            return string.IsNullOrEmpty(errorsDescription);
        }

        private bool EmailValidation(string email)
        {
            Errors errors = ValidatorHelper.ValidateEmail(email);
            string errorsDescription = ErrorDescriptionCreator(errors);
            epEmail.SetError(labelEmail, errorsDescription);
            return string.IsNullOrEmpty(errorsDescription);
        }

        private bool ManufacturerValidation(string manufacturer)
        {
            Errors errors = ValidatorHelper.ValidateManufacturer(manufacturer);
            string errorsDescription = ErrorDescriptionCreator(errors);
            epManufacturer.SetError(labelManufacturer, errorsDescription);
            return string.IsNullOrEmpty(errorsDescription);
        }

        private bool ModelValidation(string model)
        {
            Errors errors = ValidatorHelper.ValidateModel(model);
            string errorsDescription = ErrorDescriptionCreator(errors);
            epModel.SetError(labelModel, errorsDescription);
            return string.IsNullOrEmpty(errorsDescription);
        }

        private bool FrameNoValidation(string frameNo)
        {
            Errors errors = ValidatorHelper.ValidateFrameNo(frameNo);
            string errorsDescription = ErrorDescriptionCreator(errors);
            epFrameNo.SetError(labelFrameNo, errorsDescription);
            return string.IsNullOrEmpty(errorsDescription);
        }

        //In case of need
        //private bool AdditionalInfoValidation(string additionalInfo)
        //{
        //    Errors errors = ValidatorHelper.ValidateAdditionalInfo(additionalInfo);
        //    string errorsDescription = ErrorDescriptionCreator(errors);
        //    epAddidtionalInfo.SetError(labelAdditionalInfo, errorsDescription);
        //    return string.IsNullOrEmpty(errorsDescription);
        //}

        private bool DatesValidation(DateTime startDate, DateTime endDate)
        {
            Errors errors = ValidatorHelper.ValidateDate(startDate, endDate);
            if (errors.HasFlag(Errors.StartFromFuture))
            {
                epStartDate.SetError(labelStartDate, "Data przyjęcia jest z przyszłości.");
            }
            else
            {
                epStartDate.SetError(labelStartDate, null);
            }

            if (errors.HasFlag(Errors.EndBeforeStart))
            {
                epEndDate.SetError(labelEndDate, "Data zakończenia przed przyjęciem.");
            }
            else
            {
                epEndDate.SetError(labelEndDate, null);
            }

            if (errors != 0)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private bool CostValidation(string cost)
        {
            cost = cost.Replace(',', '.');
            cost = cost.TrimStart('0');
            if (cost.IndexOf('.') == 0) cost = "0" + cost;
            tbCost.Text = cost;

            Errors errors = ValidatorHelper.ValidateCost(cost);
            string errorsDescription = ErrorDescriptionCreator(errors);
            epCost.SetError(labelCost, errorsDescription);
            return string.IsNullOrEmpty(errorsDescription);
        }

        private bool DescriptionValidation(string description)
        {
            Errors errors = ValidatorHelper.ValidateDescription(description);
            string errorsDescription = ErrorDescriptionCreator(errors);
            epDescription.SetError(labelDescription, errorsDescription);
            return string.IsNullOrEmpty(errorsDescription);
        }

        private string ErrorDescriptionCreator(Errors errors)
        {
            string text = null;

            if(errors == 0)
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
                    text += "Zły format.\n";
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

        private void TrimFields()
        {
            tbFirstName.Text = tbFirstName.Text.Trim();
            tbLastName.Text = tbLastName.Text.Trim();
            tbPhone.Text = tbPhone.Text.Trim();
            tbEmail.Text = tbEmail.Text.Trim();
            tbManufacturer.Text = tbManufacturer.Text.Trim();
            tbModel.Text = tbModel.Text.Trim();
            tbFrameNo.Text = tbFrameNo.Text.Trim();
            tbAdditionalInfo.Text = tbAdditionalInfo.Text.Trim();
            tbCost.Text = tbCost.Text.Trim();
            tbDescription.Text = tbDescription.Text.Trim();
        }
    }
}
