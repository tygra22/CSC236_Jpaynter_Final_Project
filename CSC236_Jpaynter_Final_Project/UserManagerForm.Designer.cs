
namespace CSC236_Jpaynter_Final_Project
{
    partial class UserManagerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.userListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.addUserBtn = new System.Windows.Forms.Button();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.relationshipTextBox = new System.Windows.Forms.TextBox();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.removeUserBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userListBox
            // 
            this.userListBox.FormattingEnabled = true;
            this.userListBox.Location = new System.Drawing.Point(507, 33);
            this.userListBox.MultiColumn = true;
            this.userListBox.Name = "userListBox";
            this.userListBox.Size = new System.Drawing.Size(281, 381);
            this.userListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(613, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Allowed Users";
            // 
            // addUserBtn
            // 
            this.addUserBtn.Location = new System.Drawing.Point(29, 50);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(75, 23);
            this.addUserBtn.TabIndex = 2;
            this.addUserBtn.Text = "Add User";
            this.addUserBtn.UseVisualStyleBackColor = true;
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nameTextBox.Location = new System.Drawing.Point(129, 52);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Name";
            // 
            // relationshipTextBox
            // 
            this.relationshipTextBox.Location = new System.Drawing.Point(246, 53);
            this.relationshipTextBox.Name = "relationshipTextBox";
            this.relationshipTextBox.Size = new System.Drawing.Size(100, 20);
            this.relationshipTextBox.TabIndex = 5;
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(373, 53);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 20);
            this.ageTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(26, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Age";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(263, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Relationship";
            // 
            // removeUserBtn
            // 
            this.removeUserBtn.Location = new System.Drawing.Point(29, 89);
            this.removeUserBtn.Name = "removeUserBtn";
            this.removeUserBtn.Size = new System.Drawing.Size(75, 23);
            this.removeUserBtn.TabIndex = 9;
            this.removeUserBtn.Text = "Remove User";
            this.removeUserBtn.UseVisualStyleBackColor = true;
            this.removeUserBtn.Click += new System.EventHandler(this.removeUserBtn_Click);
            // 
            // UserManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.removeUserBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.relationshipTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.addUserBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userListBox);
            this.Name = "UserManagerForm";
            this.Text = "User Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox userListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addUserBtn;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox relationshipTextBox;
        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button removeUserBtn;
    }
}