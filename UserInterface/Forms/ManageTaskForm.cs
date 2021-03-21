using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workshop.DataAccessLayer.DatabaseConnection;
using Workshop.DataAccessLayer.Models;
using Workshop.DataAccessLayer.Models.Dictionaries;
using Workshop.UserInterface.Forms.Base;
using Workshop.UserInterface.Helpers;

namespace Workshop.UserInterface.Forms
{
    public partial class ManageTaskForm : BaseAddEditForm
    {
        private readonly int? taskId = null;
        private MyDbConnection db;
        private List<StatusModel> statuses;

        /// <summary>
        /// Creates add form.
        /// </summary>
        public ManageTaskForm()
        {
            db = new MyDbConnection();
            InitializeComponent();
            InitializeErrorProviders();
            InitializeStatuses();
        }

        /// <summary>
        /// Creates edit form with filled fields, based on TaskModel object.
        /// </summary>
        /// <param name="taskModel">Task which should be put into edit form.</param>
        public ManageTaskForm(TaskModel taskModel) : this()
        {
            cbStartDateEditable.Text = "Inna data";
            buttonConfirm.Image = Properties.Resources.edit_24;
            buttonConfirm.Text = "Edytuj";
            this.Text = "Edycja zlecenie";

            InitializeData(taskModel);
            taskId = taskModel.Id;
            if (taskModel.EndDate.HasValue) dtpEndDate.Checked = true;
        }

        /// <summary>
        /// Initializes error providers with their position relative to coresponding labels.
        /// </summary>
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
        }

        /// <summary>
        /// Checks if fields, containg mandatory and compulsory data, has been filled with valid data.
        /// </summary>
        /// <returns>Bool telling if fields contains valid data.</returns>
        private bool ValidateControls()
        {
            bool validationResult = true;

            if (!ValidatorHelper.FirstNameCheckAndSetErrors(tbFirstName.Text, epFirstName, labelFirstName)) validationResult = false;
            if (!ValidatorHelper.LastNameCheckAndSetErrors(tbLastName.Text, epLastName, labelLastName)) validationResult = false;
            if (!ValidatorHelper.PhoneCheckAndSetErrors(tbPhone.Text, epPhone, labelPhone)) validationResult = false;
            if (!ValidatorHelper.EmailCheckAndSetErrors(tbEmail.Text, epEmail, labelEmail)) validationResult = false;
            if (!ValidatorHelper.ManufacturerCheckAndSetErrors(tbManufacturer.Text, epManufacturer, labelManufacturer)) validationResult = false;
            if (!ValidatorHelper.ModelCheckAndSetErrors(tbModel.Text, epModel, labelModel)) validationResult = false;
            if (!ValidatorHelper.FrameNoCheckAndSetErrors(tbFrameNo.Text, epFrameNo, labelFrameNo)) validationResult = false;
            //if (!ValidatorHelper.AdditionalInfoValidation(tbAdditionalInfo.Text, epAddidtionalInfo, labelAdditionalInfo)) validationResult = false;
            if (!ValidatorHelper.DatesCheckAndSetErrors(dtpStartDate.Value, dtpEndDate.Value, epStartDate, epEndDate, labelStartDate, labelEndDate)) validationResult = false;

            if (!ValidatorHelper.CostCheckAndSetErrors(tbCost.Text, epCost, labelCost, tbCost)) validationResult = false;
            if (!ValidatorHelper.DescriptionCheckAndSetErrors(tbDescription.Text, epDescription, labelDescription)) validationResult = false;

            return validationResult;
        }

        /// <summary>
        /// Fills form with task data.
        /// </summary>
        /// <param name="task">object representing task to be done.</param>
        private void InitializeData(TaskModel task)
        {

            tbFirstName.Text = task?.FirstName;
            tbLastName.Text = task?.LastName;
            tbPhone.Text = task.PhoneNumber;
            tbEmail.Text = task?.Email;
            tbManufacturer.Text = task.BikeManufacturer;
            tbModel.Text = task.BikeModel;
            tbFrameNo.Text = task?.FrameNumber;
            tbAdditionalInfo.Text = task?.AdditionalInfo;
            dtpStartDate.Value = task.StartDate;
            if (task.EndDate.HasValue) dtpEndDate.Value = task.EndDate.Value;
            tbCost.Text = task?.Cost.ToString();
            tbDescription.Text = task.TaskDescription;
            cbStatus.Text = task.Status.Value;

        }

        /// <summary>
        /// Loads all possible statuses and loads them to ComboBox inside a form.
        /// </summary>
        private void InitializeStatuses()
        {
            statuses = db.GetStatuses();
            bsStatus.DataSource = statuses;
        }



        /// <summary>
        /// Uploads task to database and closes form. Uses taskId do determine if action should be executed as INSERT(taskId == null) or UPDATE(taskId != null).
        /// </summary>
        private void Save()
        {
            TrimFields();
            if (ValidateControls())
            {
                TaskModel taskData = CreateTaskFromFields();

                if (taskId == null)
                {

                    if (!db.AddTask(taskData))
                    {
                        MessageBox.Show("Wystąpił błąd podczas dodawania zlecenia", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        this.Opacity = 0.0;
                        MessageBox.Show("Zlecenie zostało dodane.");
                        this.Close();
                    }
                }
                else
                {
                    taskData.Id = (int)taskId;
                    if (!db.UpdateTask(taskData))
                    {
                        MessageBox.Show("Wystąpił błąd podczas edycji zlecenia", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else 
                    {
                        
                        this.Opacity = 0.0;
                        MessageBox.Show("Zlecenie edytowane pomyślnie.");
                        this.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Dane wprowadzone do formularza posiadają błędy", "Błędne dane", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Creates TaskModel based on data gathered in form.
        /// </summary>
        /// <returns>TaskModel object with values given in form.</returns>
        private TaskModel CreateTaskFromFields()
        {
            TaskModel taskData = new TaskModel();

            taskData.FirstName = tbFirstName.Text;
            taskData.LastName = tbLastName.Text;
            taskData.PhoneNumber = tbPhone.Text;
            taskData.Email = tbEmail.Text;
            taskData.BikeManufacturer = tbManufacturer.Text;
            taskData.BikeModel = tbModel.Text;
            taskData.FrameNumber = tbFrameNo.Text;
            taskData.AdditionalInfo = tbAdditionalInfo.Text;
            taskData.StartDate = dtpStartDate.Value.Date;
            if (dtpEndDate.Checked) taskData.EndDate = dtpEndDate.Value.Date;
            if (ValidatorHelper.CostCheckAndSetErrors(tbCost.Text, epCost, labelCost, tbCost) && !string.IsNullOrWhiteSpace(tbCost.Text)) taskData.Cost = decimal.Parse(tbCost.Text, CultureInfo.InvariantCulture);
            taskData.TaskDescription = tbDescription.Text;
            taskData.Status = statuses.FirstOrDefault(x => x.Id == (int)cbStatus.SelectedValue);
            //taskData.Status = cbStatus.SelectedValue;

            return taskData;
        }

        /// <summary>
        /// Removes all leading and trailing white-spaces characters form fields in form.
        /// </summary>
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

        private void IsStartDateNotToday_CheckedChanged(object sender, EventArgs e)
        {
            if (cbStartDateEditable.Checked == true)
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

        private void dtpEndDate_ValueChanged(object sender, EventArgs e)
        {
            dtpEndDate.Format = DateTimePickerFormat.Long;
        }

        private void tbPhone_TextChanged(object sender, EventArgs e)
        {
            ValidatorHelper.PhoneCheckAndSetErrors(tbPhone.Text, epPhone, labelPhone);
        }

        private void tbManufacturer_TextChanged(object sender, EventArgs e)
        {
            ValidatorHelper.ManufacturerCheckAndSetErrors(tbManufacturer.Text, epManufacturer, labelManufacturer);
        }

        private void tbModel_TextChanged(object sender, EventArgs e)
        {
            ValidatorHelper.ModelCheckAndSetErrors(tbModel.Text, epModel, labelModel);
        }

        private void tbDescription_TextChanged(object sender, EventArgs e)
        {
            ValidatorHelper.DescriptionCheckAndSetErrors(tbDescription.Text, epDescription, labelDescription);
        }

        private void tbPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Ability to only use digits, spaces, controls, '+' and '-'
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '-' && e.KeyChar != ' ' && e.KeyChar != '+';
        }

        private void tbPhone_Validated(object sender, EventArgs e)
        {
            ValidatorHelper.PhoneCheckAndSetErrors(tbPhone.Text, epPhone, labelPhone);
        }

        private void tbManufacturer_Validated(object sender, EventArgs e)
        {
            ValidatorHelper.ManufacturerCheckAndSetErrors(tbManufacturer.Text, epManufacturer, labelManufacturer);
        }

        private void tbModel_Validated(object sender, EventArgs e)
        {
            ValidatorHelper.ModelCheckAndSetErrors(tbModel.Text, epModel, labelModel);
        }


    }
}
