namespace ProcessManipulation
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
            this.AvailableAssemblies = new System.Windows.Forms.ListBox();
            this.StartedAssemblies = new System.Windows.Forms.ListBox();
            this.Start = new System.Windows.Forms.Button();
            this.Stop = new System.Windows.Forms.Button();
            this.CloseWindow = new System.Windows.Forms.Button();
            this.refresh = new System.Windows.Forms.Button();
            this.RunCalc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // AvailableAssemblies
            // 
            this.AvailableAssemblies.FormattingEnabled = true;
            this.AvailableAssemblies.ItemHeight = 20;
            this.AvailableAssemblies.Location = new System.Drawing.Point(12, 30);
            this.AvailableAssemblies.Name = "AvailableAssemblies";
            this.AvailableAssemblies.Size = new System.Drawing.Size(319, 404);
            this.AvailableAssemblies.TabIndex = 0;
            this.AvailableAssemblies.SelectedIndexChanged += new System.EventHandler(this.AvailableAssemblies_SelectedIndexChanged);
            // 
            // StartedAssemblies
            // 
            this.StartedAssemblies.FormattingEnabled = true;
            this.StartedAssemblies.ItemHeight = 20;
            this.StartedAssemblies.Location = new System.Drawing.Point(457, 32);
            this.StartedAssemblies.Name = "StartedAssemblies";
            this.StartedAssemblies.Size = new System.Drawing.Size(331, 404);
            this.StartedAssemblies.TabIndex = 1;
            this.StartedAssemblies.SelectedIndexChanged += new System.EventHandler(this.StartedAssemblies_SelectedIndexChanged);
            // 
            // Start
            // 
            this.Start.Enabled = false;
            this.Start.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.Start.Location = new System.Drawing.Point(337, 50);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(114, 29);
            this.Start.TabIndex = 2;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // Stop
            // 
            this.Stop.Enabled = false;
            this.Stop.Location = new System.Drawing.Point(337, 123);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(114, 29);
            this.Stop.TabIndex = 3;
            this.Stop.Text = "Stop";
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // CloseWindow
            // 
            this.CloseWindow.Enabled = false;
            this.CloseWindow.Location = new System.Drawing.Point(337, 186);
            this.CloseWindow.Name = "CloseWindow";
            this.CloseWindow.Size = new System.Drawing.Size(114, 29);
            this.CloseWindow.TabIndex = 4;
            this.CloseWindow.Text = "CloseWindow";
            this.CloseWindow.UseVisualStyleBackColor = true;
            this.CloseWindow.Click += new System.EventHandler(this.CloseWindow_Click);
            // 
            // Refresh
            // 
            this.refresh.Enabled = false;
            this.refresh.Location = new System.Drawing.Point(337, 252);
            this.refresh.Name = "Refresh";
            this.refresh.Size = new System.Drawing.Size(114, 29);
            this.refresh.TabIndex = 5;
            this.refresh.Text = "Refresh";
            this.refresh.UseVisualStyleBackColor = true;
            this.refresh.Click += new System.EventHandler(this.refresh_Click);
            // 
            // RunCalc
            // 
            this.RunCalc.Location = new System.Drawing.Point(337, 316);
            this.RunCalc.Name = "RunCalc";
            this.RunCalc.Size = new System.Drawing.Size(114, 29);
            this.RunCalc.TabIndex = 6;
            this.RunCalc.Text = "RunCalc";
            this.RunCalc.UseVisualStyleBackColor = true;
            this.RunCalc.Click += new System.EventHandler(this.RunCalc_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RunCalc);
            this.Controls.Add(this.refresh);
            this.Controls.Add(this.CloseWindow);
            this.Controls.Add(this.Stop);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.StartedAssemblies);
            this.Controls.Add(this.AvailableAssemblies);
            this.Name = "Form1";
            this.Text = "Management of child processes";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ListBox AvailableAssemblies;
        private ListBox StartedAssemblies;
        private Button Start;
        private Button Stop;
        private Button CloseWindow;
        private Button refresh;
        private Button RunCalc;
    }
}