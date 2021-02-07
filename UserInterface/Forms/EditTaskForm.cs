using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Workshop.DataAccessLayer.Models.Dictionaries;
using Workshop.UserInterface.Forms.Base;

namespace Workshop.UserInterface.Forms
{
    public partial class EditTaskForm : BaseAddEditForm
    {
        public EditTaskForm()
        {
            InitializeComponent();
            InitializeData();
        }

        private void InitializeData()
        {
            IList<StatusModel> statuses = new List<StatusModel>()
            {
                new StatusModel("Przyjęty"),
                new StatusModel("Do odbioru"),
                new StatusModel("Zrealizowany"),
                new StatusModel("Anulowany - do odbioru"),
                new StatusModel("Anulowany - odebrany")
            };

            bsStatus.DataSource = statuses;
//Ustawienie aktualnego statusu
//cbStatus = 
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Anulowano");
            Close();
        }

        protected override void Save()
        {
            MessageBox.Show("Edytowano");
        }


    }
}
