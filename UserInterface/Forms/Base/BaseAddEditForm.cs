using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Workshop.UserInterface.Forms.Base
{
    public partial class BaseAddEditForm : Form
    {
        public BaseAddEditForm()
        {
            InitializeComponent();
        }

        private void BaseAddEditForm_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape)
            {
                if (MessageBox.Show("Czy na pewno chcesz zamknąć formularz?" + "\n" + "Wprowadzone dane nie zostaną zapisane!", "Anulowanie", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    Close();
                }
            }
        }

        protected virtual void Save() { }
    }
}
