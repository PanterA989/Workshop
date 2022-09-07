using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workshop.DataAccessLayer.DataAccess;
using Workshop.DataAccessLayer.DatabaseConnection;
using Workshop.DataAccessLayer.DatabaseConnection.Interfaces;
using Workshop.DataAccessLayer.Enums;
using Workshop.DataAccessLayer.Models;
using Workshop.DataAccessLayer.Models.Dictionaries;
using Workshop.DataAccessLayer.ViewModel;

namespace Workshop.UserInterface.Forms
{
    public partial class MainForm : Form
    {

        private List<TaskViewModel> tasksViewModels = new List<TaskViewModel>();
        private WorkshopTasksListType listType = WorkshopTasksListType.Active;
        private IMyDbConnection _myDbConnection;

        public MainForm(IMyDbConnection myDbConnection)
        {
            _myDbConnection = myDbConnection;
            InitializeComponent();
            dgvTasks.RowTemplate.MinimumHeight = 22;
            
            PrepareTasksData();
        }

        /// <summary>
        /// Checks which list of tasks (historical or current) is beeing viewed and updates its content in dataGridView inside MainForm.
        /// </summary>
        private async void PrepareTasksData()
        {
            tasksViewModels = await _myDbConnection.GetWorkshopTaskList(listType);
            
            bsTasks.DataSource = new BindingList<TaskViewModel>(tasksViewModels);
            dgvTasks.DataSource = bsTasks;
        }

        //TODO: Implement in future
        private void btnCall_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Funkcja nie jest jeszcze wspierana.", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ManageTaskForm addTaskForm = new ManageTaskForm(_myDbConnection);
            addTaskForm.ShowDialog();
            PrepareTasksData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if(dgvTasks.CurrentRow == null)
                    return;

                var id = (int)dgvTasks.CurrentRow.Cells[0].Value;
                ManageTaskForm manageTaskForm = new ManageTaskForm(_myDbConnection, id);
                manageTaskForm.ShowDialog();
                PrepareTasksData();
            }
            catch (Exception err)
            {
                MessageBox.Show($"Błąd podczas edycji.\n" +
                    $"{err.Message}", "Błąd");
            }
        }

        /// <summary>
        /// Changes history button image and text and updates list of tasks.
        /// </summary>
        private void btnHistory_Click(object sender, EventArgs e)
        {
            if (listType == WorkshopTasksListType.Active)
            {
                btnHistory.Image = Properties.Resources.tasks64;
                btnHistory.Text = "Aktualne zlecenia";
                btnFinish.Image = Properties.Resources.delete64;
                btnFinish.Text = "Usuń";
                listType = WorkshopTasksListType.Historical;
            }
            else 
            {
                btnHistory.Image = Properties.Resources.history64;
                btnHistory.Text = "Historia zleceń";
                btnFinish.Image = Properties.Resources.checked64;
                btnFinish.Text = "Zakończ";
                listType = WorkshopTasksListType.Active;
            };
            
            PrepareTasksData();
        }

        private void dgvTasks_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("TEST", "TEST");
        }

        private void tsmiAuthor_Click(object sender, EventArgs e)
        {
            new AuthorForm().ShowDialog();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            int taskId;
            try
            {
                if(dgvTasks.CurrentRow == null)
                    return;

                taskId = (int)dgvTasks.CurrentRow.Cells[0].Value;
            }
            catch (Exception err)
            {
                MessageBox.Show("Błąd podczas zakończania zlecenia.\n" +
                    $"{err.Message}", "Błąd");
                return;
            }

            if (listType == WorkshopTasksListType.Historical)
            {
                DialogResult result = MessageBox.Show("Czy na pewno chcesz usunąć zlecenie dla:\n" +
                    $"Producent: {dgvTasks.CurrentRow.Cells[1].Value}\n" +
                    $"Model: {dgvTasks.CurrentRow.Cells[2].Value}",
                    "Usuwanie zlecenia",
                    MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    if (_myDbConnection.DeleteTask(taskId)) MessageBox.Show("Zlecenie zostało usunięte pomyślnie.", "Usunięto");
                    else MessageBox.Show("Wystąpił błąd podczas usuwania zlecenia.", "Błąd");
                }
            }
            else 
            {
                FinishTaskForm finishTaskForm = new FinishTaskForm(_myDbConnection, taskId);
                finishTaskForm.ShowDialog();
            }
            
            PrepareTasksData();
        }
    }
}
