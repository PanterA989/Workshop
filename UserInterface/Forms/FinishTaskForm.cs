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

namespace Workshop.UserInterface.Forms
{
    public partial class FinishTaskForm : Form
    {
        private int taskId;
        private int newStatusId;
        public FinishTaskForm(WorkshopTask task)
        {
            taskId = task.Id;
            newStatusId = ++task.Status.Id;
            List<WorkshopTaskStatus> statuses = MyDbConnection.GetStatuses();
            WorkshopTaskStatus newStatus = statuses.FirstOrDefault(x => x.Id == newStatusId);
            if (newStatus == null)
            {
                this.Opacity = 0;
                MessageBox.Show("Błąd podczas wyznaczania nowego statusu!", "Błąd.");
                this.Close();
                return;
            }

            InitializeComponent();
            labelTaskManufacturer.Text = task.Bike.Manufacturer;
            labelTaskModel.Text = task.Bike.Model;
            labelTaskPhone.Text = task.Client.PhoneNumber;
            labelTaskStatus.Text = newStatus.Value;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (MyDbConnection.UpdateStatus(taskId, newStatusId))
            {
                this.Opacity = 0;
                MessageBox.Show("Pomyślnie zaktualizowano status!", "Zaktualizowano.");
                this.Close();
            }
            else
            {
                this.Opacity = 0;
                MessageBox.Show("Błąd podczas aktualizacji statusu!", "Błąd.");
                this.Close();
            }
        }
    }
}
