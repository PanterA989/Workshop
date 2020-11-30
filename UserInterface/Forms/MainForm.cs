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
    public partial class MainForm : Form
    {
        private static MainForm _Okno = null;
        public static MainForm Instance { 
            get {
                if (_Okno == null)
                {
                    _Okno = new MainForm();
                    return _Okno;
                }
                else return _Okno;
            }
            private set { }
        }

        private MainForm()
        {
            InitializeComponent();
        }

        private void btnCall_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Funkcja nie jest jeszcze wspierana.", "Uwaga!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
