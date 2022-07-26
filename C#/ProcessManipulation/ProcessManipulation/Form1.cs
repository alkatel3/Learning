using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Management;

namespace ProcessManipulation
{
    public partial class Form1 : Form
    {
        #region
        const uint WM_SETTEXT =  0x0C;

        [DllImport("user32.dll")]
        public static extern IntPtr SendMessage(IntPtr hwnd, uint Msg, int wParam, [MarshalAs(UnmanagedType.LPStr)]string lParam);

        List<Process> Processes=new List<Process>();
        int Counter = 0;
        #endregion

        delegate void ProcessDelegate(Process proc);

        public Form1()
        {
            InitializeComponent();
            LoadAvailableAssemblies();
        }

        void LoadAvailableAssemblies()
        {
            string except = new FileInfo(Application.ExecutablePath).Name;

            except = except.Substring(0, except.IndexOf("."));

            string[] files = Directory.GetFiles(Application.StartupPath, "*.exe");
            foreach(var file in files)
            {
                string fileName=new FileInfo(file).Name;

                if (fileName.IndexOf(except) == -1)
                    AvailableAssemblies.Items.Add(fileName);
            }
        }

        void RunProcess(string AssamblyName)
        {
            Process proc = Process.Start(AssamblyName);
            Processes.Add(proc);
            if (Process.GetCurrentProcess().Id == GetParentProcessId(proc.Id))
                MessageBox.Show(proc.ProcessName + " actually a child process of the current process!");

            proc.EnableRaisingEvents = true;
            proc.Exited += proc_Exited;

            SetChildWindowText(proc.MainWindowHandle, "Child process #" + (++Counter));

            if (!StartedAssemblies.Items.Contains(proc.ProcessName))
            {
                StartedAssemblies.Items.Add(proc.ProcessName);
                AvailableAssemblies.Items.Remove(AvailableAssemblies.SelectedItem);
            }

        }

        void SetChildWindowText(IntPtr Handle, string text)
        {
            SendMessage(Handle, WM_SETTEXT, 0, text);
        }

        int GetParentProcessId(int Id)
        {
            int parentId = 0;
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            //!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
            using (ManagementObject obj = new ManagementObject("win32_process.handle=" + Id.ToString()))
            {
                obj.Get();
                parentId = Convert.ToInt32(obj["ParentProcessId"]);
            }
            return parentId;
        }

        void proc_Exited(object? sender, EventArgs e)
        {
            Process? proc = sender as Process;

            StartedAssemblies.Items.Remove(proc.ProcessName);

            AvailableAssemblies.Items.Add(proc.ProcessName);

            Processes.Remove(proc);

            Counter--;
            int index = 0;

            foreach (var p in Processes)
            {
                SetChildWindowText(p.MainWindowHandle, "Child process #" + ++index);
            }
        }

        void ExecuteOnProcessesByName(string ProcessName, ProcessDelegate func)
        {
            Process[] processes=Process.GetProcessesByName(ProcessName);
            foreach(var proc in processes)
            {
                if(Process.GetCurrentProcess().Id==GetParentProcessId(proc.Id))
                    func(proc);
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            RunProcess(AvailableAssemblies.SelectedItem.ToString());
        }

        void Kill(Process proc)
        {
            proc.Kill();

        }

        private void Stop_Click(object sender, EventArgs e)
        {
            ExecuteOnProcessesByName(StartedAssemblies.SelectedItem.ToString(), Kill);
            StartedAssemblies.Items.Remove(StartedAssemblies.SelectedItem);
        }
        void CloseMainWindow(Process proc)
        {
            proc.CloseMainWindow();
        }

        private void CloseWindow_Click(object sender, EventArgs e)
        {
            ExecuteOnProcessesByName(StartedAssemblies.SelectedItem.ToString(), CloseMainWindow);
            StartedAssemblies.Items.Remove(StartedAssemblies.SelectedItem);
        }

        void Refresh(Process proc) => proc.Refresh();

        private void refresh_Click(object sender, EventArgs e)
        {
            ExecuteOnProcessesByName(StartedAssemblies.SelectedItem.ToString(), Refresh);
        }

        private void AvailableAssemblies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (AvailableAssemblies.SelectedItems.Count == 0)
            {
                Start.Enabled = false;

            }
            else
                Start.Enabled = true;
        }

        private void StartedAssemblies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (StartedAssemblies.SelectedItems.Count == 0)
            {
                Stop.Enabled = false;
                
                CloseWindow.Enabled = false;

            }
            else
            {
                Stop.Enabled= true;
                CloseWindow.Enabled= true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach(var proc in Processes)
            {
                proc.Kill();
            }
        }

        private void RunCalc_Click(object sender, EventArgs e)
        {
            RunProcess("ChildProcess1.exe");
        }
    }
}