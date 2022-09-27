using CrmBl.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CrmUi
{
    public partial class ModelForm : Form
    {
        ShopComputerModel model=new ShopComputerModel();

        public ModelForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cashBoxes = new List<CashBoxView>();

            for(int i =0; i < model.CashDesks.Count; i++)
            {
                var box = new CashBoxView(model.CashDesks[i], i, 10, 26 * i);
                cashBoxes.Add(box);
                Controls.Add(box.Label);
                Controls.Add(box.NumericUpDown);
            }

            model.Start();
        }
    }
}
