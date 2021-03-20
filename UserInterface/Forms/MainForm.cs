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
        //private List<TaskViewModel> fakeTasks;
        //private List<TaskModel> fakeTasksModel;

        private List<TaskViewModel> tasksViewModels = new List<TaskViewModel>();
        private MyDbConnection db = new MyDbConnection();
        private bool checkingHistory = false;

        //Singleton
        //private static MainForm _instance = null;
        //public static MainForm Instance { 
        //    get {
        //        if (_instance == null)
        //        {
        //            _instance = new MainForm();
        //            return _instance;
        //        }
        //        else return _instance;
        //    }
        //    private set { }
        //}

        public MainForm()
        {
            InitializeComponent();
            dgvTasks.RowTemplate.MinimumHeight = 22;


            PrepareTasksData();
        }

        private void PrepareTasksData()
        {
            if (!checkingHistory) tasksViewModels = db.GetActiveTasks();
            else tasksViewModels = db.GetHistoryTasks();
            
            
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

        private void dgvTasks_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("TEST", "TEST");
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            checkingHistory = !checkingHistory;

            if (checkingHistory)
            {
                btnHistory.Image = Properties.Resources.tasks64;
                btnHistory.Text = "Aktualne zlecenia";
            }
            else 
            {
                btnHistory.Image = Properties.Resources.history64;
                btnHistory.Text = "Historia zleceń";
            }

            PrepareTasksData();
        }

        private void tsmiAuthor_Click(object sender, EventArgs e)
        {
            new AuthorForm().ShowDialog();
        }
    }
}
