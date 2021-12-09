using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC236_Jpaynter_Final_Project
{


    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        StatusForm statusForm = new StatusForm();
        private void statusbtn(object sender, EventArgs e)
        {
            if (statusForm.Visible)
            {
                statusForm.Hide();
            } else
            {
                statusForm.Show();
            }
        }

        LogsForm logsForm = new LogsForm();
        private void logsbtn_Click(object sender, EventArgs e)
        {
            if (logsForm.Visible) 
            {
                logsForm.Hide();
            } else
            {
                logsForm.Show();
            }
        }
        UserManagerForm userManagerForm = new UserManagerForm();
        private void ManageUsersBtn_Click(object sender, EventArgs e)
        {
            if (userManagerForm.Visible)
            {
                userManagerForm.Hide();
            } else
            {
                userManagerForm.Show();
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //exit application when form is closed

            Application.Exit();
        }
    }
}
