using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VerticalProgressBar;

namespace SortAlgorithms
{
    public class SortedItem:IComparable
    {
        public VerticalProgressBar.VerticalProgressBar ProgressBar { get; private set; }
        public Label Label1 { get; private set; }
        public int Value { get; private set; }

        public SortedItem(int value, int number )
        {
            Value = value;

            ProgressBar = new VerticalProgressBar.VerticalProgressBar();
            Label1 = new Label();
            var x = number * 20;
            // 
            // VerticalProgressBar
            // 
            ProgressBar.BorderStyle = VerticalProgressBar.BorderStyles.Classic;
            ProgressBar.Color = System.Drawing.Color.Blue;
            ProgressBar.Location = new System.Drawing.Point(x, 0);
            ProgressBar.Maximum = 100;
            ProgressBar.Minimum = 0;
            ProgressBar.Name = "ProgressBar"+number;
            ProgressBar.Size = new System.Drawing.Size(18, 120);
            ProgressBar.Step = 1;
            ProgressBar.Style = VerticalProgressBar.Styles.Solid;
            ProgressBar.TabIndex = number;
            ProgressBar.Value = Value;
            // 
            // Label
            // 
            Label1.AutoSize = true;
            Label1.Location = new System.Drawing.Point(x, 120);
            Label1.Name = "label"+number;
            Label1.Size = new System.Drawing.Size(19, 13);
            Label1.TabIndex = number;
            Label1.Text = Value.ToString();
        }

        public void SetValue(int value)
        {
            Value = value;
            ProgressBar.Value = value;
            Label1.Text = value.ToString();
        }

        public void SetColor(System.Drawing.Color Color)
        {
            ProgressBar.Color = Color;
        }

        public int CompareTo(object obj)
        {
            if(obj is SortedItem item)
            {
                return Value.CompareTo(item.Value);
            }
            else
            {
                throw new ArgumentException($"obj isn't {nameof(SortedItem)}",nameof(obj));
            }
        }
    }
}
