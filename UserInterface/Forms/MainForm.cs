using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workshop.DataAccessLayer.DatabaseConnection;
using Workshop.DataAccessLayer.Models;
using Workshop.DataAccessLayer.Models.Dictionaries;
using Workshop.DataAccessLayer.ViewModel;

namespace Workshop.UserInterface.Forms
{
    public partial class MainForm : Form
    {

        private List<TaskViewModel> tasksViewModels = new List<TaskViewModel>();
        private MyDbConnection db = new MyDbConnection();
        private bool checkingHistory = false;

        public MainForm()
        {
            InitializeComponent();
            dgvTasks.RowTemplate.MinimumHeight = 22;

            PrepareTasksData();
        }

        /// <summary>
        /// Checks which list of tasks (historical or current) is beeing viewed and updates its content.
        /// </summary>
        private async void PrepareTasksData()
        {
            if (!checkingHistory) tasksViewModels = await db.GetActiveTasks();
            else tasksViewModels = await db.GetHistoryTasks();
            
            
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
            ManageTaskForm addTaskForm = new ManageTaskForm();
            addTaskForm.ShowDialog();
            PrepareTasksData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                var id = (int)dgvTasks.CurrentRow.Cells[0].Value;
                ManageTaskForm manageTaskForm = new ManageTaskForm(db.GetTaskModel(id));
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
            checkingHistory = !checkingHistory;

            if (checkingHistory)
            {
                btnHistory.Image = Properties.Resources.tasks64;
                btnHistory.Text = "Aktualne zlecenia";
                btnFinish.Visible = false;
            }
            else 
            {
                btnHistory.Image = Properties.Resources.history64;
                btnHistory.Text = "Historia zleceń";
                btnFinish.Visible = true;
            }

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

            try
            {
                var id = (int)dgvTasks.CurrentRow.Cells[0].Value;
                FinishTaskForm finishTaskForm = new FinishTaskForm(db.GetTaskModel(id));
                finishTaskForm.ShowDialog();
                PrepareTasksData();

            }
            catch (Exception err)
            {
                MessageBox.Show($"Błąd podczas zakończania zlecenia.\n" +
                    $"{err.Message}", "Błąd");
            }
        }
    }
}
