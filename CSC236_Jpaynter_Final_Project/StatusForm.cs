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
    public partial class StatusForm : Form
    {

        Core core = Core.Instance;
        public StatusForm()
        {
            InitializeComponent();
        }

        private void FrontDoorBtn_Click(object sender, EventArgs e)
        {
            if(core.frontDoor == false)
            {
                frontDoorStatus.Value = 1;
                core.frontDoor = true;
            } else
            {
            frontDoorStatus.Value = 0;
                core.frontDoor = false;
            }
        }
    }
}
