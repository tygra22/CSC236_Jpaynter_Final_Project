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

        private void backDoorBtn_Click(object sender, EventArgs e)
        {
            if (core.backDoor == false)
            {
                backDoorProgressBar.Value = 1;
                core.backDoor = true;
            }
            else
            {
                backDoorProgressBar.Value = 0;
                core.backDoor = false;
            }
        }

        private void garageDoorBtn_Click(object sender, EventArgs e)
        {
            if (core.garageDoor == false)
            {
                garageDoorProgressBar.Value = 1;
                core.garageDoor = true;
            }
            else
            {
                garageDoorProgressBar.Value = 0;
                core.garageDoor = false;
            }
        }

        private void kitchenLightsBtn_Click(object sender, EventArgs e)
        {
            if (core.kitchenLights == false)
            {
                kitchenLightsProgressBar.Value = 1;
                core.kitchenLights = true;
            }
            else
            {
                kitchenLightsProgressBar.Value = 0;
                core.kitchenLights = false;
            }
        }

        private void familyRoomLightsBtn_Click(object sender, EventArgs e)
        {
            if (core.familyRoomLights == false)
            {
                familyRoomLightsProgress.Value = 1;
                core.familyRoomLights = true;
            }
            else
            {
                familyRoomLightsProgress.Value = 0;
                core.familyRoomLights = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (core.masterBedroomLight == false)
            {
                masterLightsProgressBar.Value = 1;
                core.masterBedroomLight = true;
            }
            else
            {
                masterLightsProgressBar.Value = 0;
                core.masterBedroomLight = false;
            }
        }
    }
}
