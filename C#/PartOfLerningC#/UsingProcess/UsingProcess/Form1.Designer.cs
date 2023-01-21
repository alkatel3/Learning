namespace UsingProcess
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.MyProcess = new System.Diagnostics.Process();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Start.Location = new System.Drawing.Point(29, 37);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(194, 69);
            this.Start.TabIndex = 0;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Location = new System.Drawing.Point(29, 123);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(194, 65);
            this.Stop.TabIndex = 1;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // MyProcess
            // 
            this.MyProcess.StartInfo.Domain = "";
            this.MyProcess.StartInfo.LoadUserProfile = false;
            this.MyProcess.StartInfo.Password = null;
            this.MyProcess.StartInfo.StandardErrorEncoding = null;
            this.MyProcess.StartInfo.StandardInputEncoding = null;
            this.MyProcess.StartInfo.StandardOutputEncoding = null;
            this.MyProcess.StartInfo.UserName = "";
            this.MyProcess.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(254, 224);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private Button Stop;
        public Button Start;
        private System.Diagnostics.Process MyProcess;
    }
}