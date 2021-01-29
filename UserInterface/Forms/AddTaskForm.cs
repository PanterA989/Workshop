using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop.UserInterface.Forms
{
    public partial class AddTaskForm : Form
    {
        public AddTaskForm()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void isStartDateNotToday_CheckedChanged(object sender, EventArgs e)
        {
            if(this.cbStartDateNotToday.Checked == true)
            {
                this.dtpStartDate.Enabled = true;
            }
            else
            {
                this.dtpStartDate.Value = DateTime.Now;
                this.dtpStartDate.Enabled = false;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            //Sprawdzanie czy data końca nie jest z przeszłości
        }
    }
}
