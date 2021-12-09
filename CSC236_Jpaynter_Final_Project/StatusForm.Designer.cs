
namespace CSC236_Jpaynter_Final_Project
{
    partial class StatusForm
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
            this.FrontDoorBtn = new System.Windows.Forms.Button();
            this.frontDoorStatus = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // FrontDoorBtn
            // 
            this.FrontDoorBtn.Location = new System.Drawing.Point(27, 25);
            this.FrontDoorBtn.Name = "FrontDoorBtn";
            this.FrontDoorBtn.Size = new System.Drawing.Size(75, 23);
            this.FrontDoorBtn.TabIndex = 0;
            this.FrontDoorBtn.Text = "Front Door";
            this.FrontDoorBtn.UseVisualStyleBackColor = true;
            this.FrontDoorBtn.Click += new System.EventHandler(this.FrontDoorBtn_Click);
            // 
            // frontDoorStatus
            // 
            this.frontDoorStatus.BackColor = System.Drawing.Color.ForestGreen;
            this.frontDoorStatus.ForeColor = System.Drawing.Color.DarkRed;
            this.frontDoorStatus.Location = new System.Drawing.Point(127, 25);
            this.frontDoorStatus.Maximum = 1;
            this.frontDoorStatus.Name = "frontDoorStatus";
            this.frontDoorStatus.Size = new System.Drawing.Size(100, 23);
            this.frontDoorStatus.TabIndex = 1;
            // 
            // StatusForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(698, 303);
            this.Controls.Add(this.frontDoorStatus);
            this.Controls.Add(this.FrontDoorBtn);
            this.Name = "StatusForm";
            this.Text = "Status Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button FrontDoorBtn;
        private System.Windows.Forms.ProgressBar frontDoorStatus;
    }
}