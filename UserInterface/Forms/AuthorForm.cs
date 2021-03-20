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
    public partial class AuthorForm : Form
    {
        public AuthorForm()
        {
            InitializeComponent();
        }

        private void linkGit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkGit.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/PanterA989");
        }

        private void linkMail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkMail.LinkVisited = true;
            System.Diagnostics.Process.Start("mailto:krzysztof.kania98@gmail.com");
        }
    }
}
