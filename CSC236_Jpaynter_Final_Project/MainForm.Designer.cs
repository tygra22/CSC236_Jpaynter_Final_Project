
namespace CSC236_Jpaynter_Final_Project
{
    partial class MainForm
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
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.eventLog1 = new System.Diagnostics.EventLog();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.logsbtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ManageUsersBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).BeginInit();
            this.SuspendLayout();
            // 
            // eventLog1
            // 
            this.eventLog1.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Smart Home App";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(139, 109);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "--------";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.statusbtn);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Home Status";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // logsbtn
            // 
            this.logsbtn.Location = new System.Drawing.Point(139, 154);
            this.logsbtn.Name = "logsbtn";
            this.logsbtn.Size = new System.Drawing.Size(75, 23);
            this.logsbtn.TabIndex = 3;
            this.logsbtn.Text = "--------";
            this.logsbtn.UseVisualStyleBackColor = true;
            this.logsbtn.Click += new System.EventHandler(this.logsbtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Display Logs";
            // 
            // ManageUsersBtn
            // 
            this.ManageUsersBtn.Location = new System.Drawing.Point(139, 196);
            this.ManageUsersBtn.Name = "ManageUsersBtn";
            this.ManageUsersBtn.Size = new System.Drawing.Size(75, 23);
            this.ManageUsersBtn.TabIndex = 5;
            this.ManageUsersBtn.Text = "--------";
            this.ManageUsersBtn.UseVisualStyleBackColor = true;
            this.ManageUsersBtn.Click += new System.EventHandler(this.ManageUsersBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Manage Users";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(631, 280);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ManageUsersBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logsbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Smart Home App";
            ((System.ComponentModel.ISupportInitialize)(this.eventLog1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Diagnostics.EventLog eventLog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button logsbtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ManageUsersBtn;
    }
}

