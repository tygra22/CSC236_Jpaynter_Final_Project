using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSC236_Jpaynter_Final_Project
{
    
    public partial class LogsForm : Form
    {

        public LogsForm()
        {
            InitializeComponent();
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e){}

        private void loadLogsBtn(object sender, EventArgs e)
        {
            int counter = 0;
            const string DIR = @"C:\Users\Jonah-Laptop\source\repos\CSC236_Jpaynter_Final_Project\CSC236_Jpaynter_Final_Project\logs.txt";

            if (System.IO.File.Exists(DIR))
            {
                // Read the file and display it line by line into the logsListBox.  
                foreach (string line in System.IO.File.ReadLines(DIR))
                {
                    logsListBox.Items.Add(line);
                    Console.WriteLine(line);
                    counter++;
                }
            } else
            {
                Console.WriteLine("FILE DOES NOT EXIST");
            }
        }
    }
}
