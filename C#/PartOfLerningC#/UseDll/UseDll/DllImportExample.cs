using System.Runtime.InteropServices;
using System.Text;

namespace UseDll
{
    public class DllImportExample
    {
        [DllImport("User32.dll", ExactSpelling = true)]
        public static extern int MessageBoxA(IntPtr hWnd, string text, string caption, uint type);
        //..........
        [DllImport("Kernel32.dll", EntryPoint = "GetVersionEx")]
        public static extern bool GetVersion(ref OsVersionInfo versionInfo);
        //..........
        [DllImport("User32.dll",CharSet =CharSet.Auto)]
        public static extern int MessageBox(IntPtr hWnd, string text, string caption, uint type);
        //..........
        [DllImport("msvcrt.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.Cdecl)]
        public static extern int printf(string format, int i, double d);

        [DllImport("msvcrt.dll", CharSet=CharSet.Ansi,CallingConvention =CallingConvention.Cdecl)]
        public static extern int printf(string format, int i, string d);
        //..........
        [DllImport("Advapi32.dll", SetLastError = true)]
        public static extern bool GetUserName(StringBuilder builder, ref int len);
        //..........
        [DllImport("User32.dll")]
        public static extern int SetForegroundWindow(IntPtr point);
        //.........
        [DllImport("SimpleCalc.dll")]
        public static extern int add(int a, int b);

        [DllImport("SimpleCalc.dll")]
        public static extern int sub(int a, int b);

        [DllImport("SimpleCalc.dll")]
        public static extern int mult(int a, int b);

        [DllImport("SimpleCalc.dll")]
        public static extern int div(int a, int b);
    }
}
