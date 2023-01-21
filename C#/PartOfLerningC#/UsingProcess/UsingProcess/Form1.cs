using System.Diagnostics;

namespace UsingProcess
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MyProcess.StartInfo=new ProcessStartInfo("calc.exe");
        }

        private void Start_Click(object sender, EventArgs e)
        {
            MyProcess.Start();
        }

        private void Stop_Click(object sender, EventArgs e)
        {
            MyProcess.CloseMainWindow();
            MyProcess.Close();
            this.Close();
        }
    }
}