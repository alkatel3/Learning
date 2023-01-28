using VerticalProgressBar;

namespace SortAlgorithms
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.AddTextBox = new System.Windows.Forms.TextBox();
            this.AddButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.FillTextBox = new System.Windows.Forms.TextBox();
            this.FillButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.BubbleSortButton = new System.Windows.Forms.Button();
            this.timeLable = new System.Windows.Forms.Label();
            this.compereLabel = new System.Windows.Forms.Label();
            this.swopLabel = new System.Windows.Forms.Label();
            this.GnomeSortButton = new System.Windows.Forms.Button();
            this.SellectionSortButton = new System.Windows.Forms.Button();
            this.HeapSortButton = new System.Windows.Forms.Button();
            this.TreeSortButton = new System.Windows.Forms.Button();
            this.ShellSortButton = new System.Windows.Forms.Button();
            this.InsertionSortButton = new System.Windows.Forms.Button();
            this.CoctailSortButton = new System.Windows.Forms.Button();
            this.LsdRadixSortButton = new System.Windows.Forms.Button();
            this.MsdRadixSortButton = new System.Windows.Forms.Button();
            this.MargeSortButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.AddTextBox);
            this.panel1.Controls.Add(this.AddButton);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 82);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(11, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Add Number";
            // 
            // AddTextBox
            // 
            this.AddTextBox.Location = new System.Drawing.Point(11, 33);
            this.AddTextBox.Name = "AddTextBox";
            this.AddTextBox.Size = new System.Drawing.Size(253, 22);
            this.AddTextBox.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(270, 33);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(75, 23);
            this.AddButton.TabIndex = 1;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.FillTextBox);
            this.panel2.Controls.Add(this.FillButton);
            this.panel2.Location = new System.Drawing.Point(1, 88);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(357, 82);
            this.panel2.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(155, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Fill array random number";
            // 
            // FillTextBox
            // 
            this.FillTextBox.Location = new System.Drawing.Point(11, 33);
            this.FillTextBox.Name = "FillTextBox";
            this.FillTextBox.Size = new System.Drawing.Size(253, 22);
            this.FillTextBox.TabIndex = 0;
            // 
            // FillButton
            // 
            this.FillButton.Location = new System.Drawing.Point(270, 32);
            this.FillButton.Name = "FillButton";
            this.FillButton.Size = new System.Drawing.Size(75, 23);
            this.FillButton.TabIndex = 1;
            this.FillButton.Text = "Fill";
            this.FillButton.UseVisualStyleBackColor = true;
            this.FillButton.Click += new System.EventHandler(this.FillButton_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Location = new System.Drawing.Point(364, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(642, 170);
            this.panel3.TabIndex = 3;
            // 
            // BubbleSortButton
            // 
            this.BubbleSortButton.Location = new System.Drawing.Point(4, 176);
            this.BubbleSortButton.Name = "BubbleSortButton";
            this.BubbleSortButton.Size = new System.Drawing.Size(116, 29);
            this.BubbleSortButton.TabIndex = 7;
            this.BubbleSortButton.Text = "Bubble Sort";
            this.BubbleSortButton.UseVisualStyleBackColor = true;
            this.BubbleSortButton.Click += new System.EventHandler(this.BubbleSortButton_Click);
            // 
            // timeLable
            // 
            this.timeLable.AutoSize = true;
            this.timeLable.Location = new System.Drawing.Point(9, 248);
            this.timeLable.Name = "timeLable";
            this.timeLable.Size = new System.Drawing.Size(38, 16);
            this.timeLable.TabIndex = 8;
            this.timeLable.Text = "Time";
            // 
            // compereLabel
            // 
            this.compereLabel.AutoSize = true;
            this.compereLabel.Location = new System.Drawing.Point(9, 275);
            this.compereLabel.Name = "compereLabel";
            this.compereLabel.Size = new System.Drawing.Size(121, 16);
            this.compereLabel.TabIndex = 9;
            this.compereLabel.Text = "Comperation Count";
            // 
            // swopLabel
            // 
            this.swopLabel.AutoSize = true;
            this.swopLabel.Location = new System.Drawing.Point(9, 303);
            this.swopLabel.Name = "swopLabel";
            this.swopLabel.Size = new System.Drawing.Size(78, 16);
            this.swopLabel.TabIndex = 10;
            this.swopLabel.Text = "Swop Count";
            // 
            // GnomeSortButton
            // 
            this.GnomeSortButton.Location = new System.Drawing.Point(871, 176);
            this.GnomeSortButton.Name = "GnomeSortButton";
            this.GnomeSortButton.Size = new System.Drawing.Size(120, 29);
            this.GnomeSortButton.TabIndex = 11;
            this.GnomeSortButton.Text = "Gnome Sort";
            this.GnomeSortButton.UseVisualStyleBackColor = true;
            this.GnomeSortButton.Click += new System.EventHandler(this.GnomSortButton_Click);
            // 
            // SellectionSortButton
            // 
            this.SellectionSortButton.Location = new System.Drawing.Point(755, 176);
            this.SellectionSortButton.Name = "SellectionSortButton";
            this.SellectionSortButton.Size = new System.Drawing.Size(110, 29);
            this.SellectionSortButton.TabIndex = 12;
            this.SellectionSortButton.Text = "Sellection Sort";
            this.SellectionSortButton.UseVisualStyleBackColor = true;
            this.SellectionSortButton.Click += new System.EventHandler(this.SellectionSortButton_Click);
            // 
            // HeapSortButton
            // 
            this.HeapSortButton.Location = new System.Drawing.Point(632, 176);
            this.HeapSortButton.Name = "HeapSortButton";
            this.HeapSortButton.Size = new System.Drawing.Size(117, 29);
            this.HeapSortButton.TabIndex = 13;
            this.HeapSortButton.Text = "Heap Sort";
            this.HeapSortButton.UseVisualStyleBackColor = true;
            this.HeapSortButton.Click += new System.EventHandler(this.HeapSortButton_Click);
            // 
            // TreeSortButton
            // 
            this.TreeSortButton.Location = new System.Drawing.Point(504, 176);
            this.TreeSortButton.Name = "TreeSortButton";
            this.TreeSortButton.Size = new System.Drawing.Size(122, 29);
            this.TreeSortButton.TabIndex = 14;
            this.TreeSortButton.Text = "Tree Sort";
            this.TreeSortButton.UseVisualStyleBackColor = true;
            this.TreeSortButton.Click += new System.EventHandler(this.TreeSortButton_Click);
            // 
            // ShellSortButton
            // 
            this.ShellSortButton.Location = new System.Drawing.Point(380, 176);
            this.ShellSortButton.Name = "ShellSortButton";
            this.ShellSortButton.Size = new System.Drawing.Size(118, 29);
            this.ShellSortButton.TabIndex = 15;
            this.ShellSortButton.Text = "Shell Sort";
            this.ShellSortButton.UseVisualStyleBackColor = true;
            this.ShellSortButton.Click += new System.EventHandler(this.ShellSortButton_Click);
            // 
            // InsertionSortButton
            // 
            this.InsertionSortButton.Location = new System.Drawing.Point(252, 176);
            this.InsertionSortButton.Name = "InsertionSortButton";
            this.InsertionSortButton.Size = new System.Drawing.Size(122, 29);
            this.InsertionSortButton.TabIndex = 16;
            this.InsertionSortButton.Text = "Insertion Sort";
            this.InsertionSortButton.UseVisualStyleBackColor = true;
            this.InsertionSortButton.Click += new System.EventHandler(this.InsertionSortButton_Click);
            // 
            // CoctailSortButton
            // 
            this.CoctailSortButton.Location = new System.Drawing.Point(126, 176);
            this.CoctailSortButton.Name = "CoctailSortButton";
            this.CoctailSortButton.Size = new System.Drawing.Size(120, 29);
            this.CoctailSortButton.TabIndex = 17;
            this.CoctailSortButton.Text = "Coctail Sort";
            this.CoctailSortButton.UseVisualStyleBackColor = true;
            this.CoctailSortButton.Click += new System.EventHandler(this.CoctailSortButton_Click);
            // 
            // LsdRadixSortButton
            // 
            this.LsdRadixSortButton.Location = new System.Drawing.Point(4, 211);
            this.LsdRadixSortButton.Name = "LsdRadixSortButton";
            this.LsdRadixSortButton.Size = new System.Drawing.Size(126, 29);
            this.LsdRadixSortButton.TabIndex = 18;
            this.LsdRadixSortButton.Text = "LSD Radix Sort";
            this.LsdRadixSortButton.UseVisualStyleBackColor = true;
            this.LsdRadixSortButton.Click += new System.EventHandler(this.LsdRadixSortButton_Click);
            // 
            // MsdRadixSortButton
            // 
            this.MsdRadixSortButton.Location = new System.Drawing.Point(139, 211);
            this.MsdRadixSortButton.Name = "MsdRadixSortButton";
            this.MsdRadixSortButton.Size = new System.Drawing.Size(126, 29);
            this.MsdRadixSortButton.TabIndex = 19;
            this.MsdRadixSortButton.Text = "LSD Radix Sort";
            this.MsdRadixSortButton.UseVisualStyleBackColor = true;
            this.MsdRadixSortButton.Click += new System.EventHandler(this.MsdRadixSortButton_Click);
            // 
            // MargeSortButton
            // 
            this.MargeSortButton.Location = new System.Drawing.Point(271, 211);
            this.MargeSortButton.Name = "MargeSortButton";
            this.MargeSortButton.Size = new System.Drawing.Size(110, 29);
            this.MargeSortButton.TabIndex = 20;
            this.MargeSortButton.Text = "Marge Sort";
            this.MargeSortButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 516);
            this.Controls.Add(this.MargeSortButton);
            this.Controls.Add(this.MsdRadixSortButton);
            this.Controls.Add(this.LsdRadixSortButton);
            this.Controls.Add(this.CoctailSortButton);
            this.Controls.Add(this.InsertionSortButton);
            this.Controls.Add(this.ShellSortButton);
            this.Controls.Add(this.TreeSortButton);
            this.Controls.Add(this.HeapSortButton);
            this.Controls.Add(this.SellectionSortButton);
            this.Controls.Add(this.GnomeSortButton);
            this.Controls.Add(this.swopLabel);
            this.Controls.Add(this.compereLabel);
            this.Controls.Add(this.timeLable);
            this.Controls.Add(this.BubbleSortButton);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.TextBox AddTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox FillTextBox;
        private System.Windows.Forms.Button FillButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button BubbleSortButton;
        private System.Windows.Forms.Label timeLable;
        private System.Windows.Forms.Label compereLabel;
        private System.Windows.Forms.Label swopLabel;
        private System.Windows.Forms.Button GnomeSortButton;
        private System.Windows.Forms.Button SellectionSortButton;
        private System.Windows.Forms.Button HeapSortButton;
        private System.Windows.Forms.Button TreeSortButton;
        private System.Windows.Forms.Button ShellSortButton;
        private System.Windows.Forms.Button InsertionSortButton;
        private System.Windows.Forms.Button CoctailSortButton;
        private System.Windows.Forms.Button LsdRadixSortButton;
        private System.Windows.Forms.Button MsdRadixSortButton;
        private System.Windows.Forms.Button MargeSortButton;
    }
}

