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
    public partial class UserManagerForm : Form
    {
        Core core = Core.Instance;
        private static LogEntries logBook = new LogEntries();
        UserEventListener listener = new UserEventListener(logBook);
        public UserManagerForm()
        {
            InitializeComponent();
        }

        private void addUserBtn_Click(object sender, EventArgs e)
        {
            string userInformation, name, relationship, age;
            name = nameTextBox.Text;
            relationship = relationshipTextBox.Text;
            age = ageTextBox.Text;
            if (name == "" || relationship == "" || age == "")
            {
                MessageBox.Show("You must enter a name, relationship, and age");
                return;
            }
            core.createNewUser(name, relationship, age);
            userInformation = $"Name: {name},  Relationship: {relationship},  Age: {age},";
            userListBox.Items.Add(userInformation);

            nameTextBox.Clear();
            relationshipTextBox.Clear();
            ageTextBox.Clear();
            Console.WriteLine("USER ADDED");
        }

        private void removeUserBtn_Click(object sender, EventArgs e)
        {
            
            int index = userListBox.SelectedIndex;
            try
            {
                userListBox.Items.RemoveAt(index);
                core.removeUser(index);
            } catch(ArgumentOutOfRangeException)
            {
                MessageBox.Show("Please select an item from the list box");
            }
        }
    }
}
