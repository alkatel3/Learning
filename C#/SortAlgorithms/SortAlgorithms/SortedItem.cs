using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VerticalProgressBar;

namespace SortAlgorithms
{
    public class SortedItem
    {
        public VerticalProgressBar.VerticalProgressBar ProgressBar { get; private set; }
        public Label Label1 { get; private set; }
        public int Value { get; set; }

        public SortedItem(int value)
        {
            Value = value;

            ProgressBar = new VerticalProgressBar.VerticalProgressBar();
            Label1 = new Label();

            // 
            // VerticalProgressBar
            // 
            ProgressBar.BorderStyle = VerticalProgressBar.BorderStyles.Classic;
            ProgressBar.Color = System.Drawing.Color.Blue;
            ProgressBar.Location = new System.Drawing.Point(3, 0);
            ProgressBar.Maximum = 100;
            ProgressBar.Minimum = 0;
            ProgressBar.Name = "verticalProgressBar1";
            ProgressBar.Size = new System.Drawing.Size(18, 120);
            ProgressBar.Step = 1;
            ProgressBar.Style = VerticalProgressBar.Styles.Solid;
            ProgressBar.TabIndex = 3;
            ProgressBar.Value = Value;
            // 
            // Label
            // 
            Label1.AutoSize = true;
            Label1.Location = new System.Drawing.Point(3, 120);
            Label1.Name = "label1";
            Label1.Size = new System.Drawing.Size(19, 13);
            Label1.TabIndex = 4;
            Label1.Text = Value.ToString();
        }
    }
}
