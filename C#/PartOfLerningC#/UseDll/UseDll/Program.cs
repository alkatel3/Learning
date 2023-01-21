using static System.Console;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Text;

namespace UseDll
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DllImportExample.MessageBoxA(IntPtr.Zero, "Testing is successful", "TestDllImportAttribute_1", 0);
            //..........

            OsVersionInfo versionInfo = new OsVersionInfo();
            versionInfo.osVersionInfoSize = (uint)Marshal.SizeOf(versionInfo);
            bool result = DllImportExample.GetVersion(ref versionInfo);
            if (result)
            {
                WriteLine($"Assembly identifier: {versionInfo.buildNumber}");
            }
            //...........

            DllImportExample.MessageBox(IntPtr.Zero, "Testiog is successful", "Test DllImportAttribute_2", 0);
            //...........

            DllImportExample.printf("Print params: %i %f\n", 99, 99.99);
            DllImportExample.printf("Print params: %i %s\n", 99, "abcd");
            //...........

            int len = 20;
            StringBuilder builder = new StringBuilder(len);
            DllImportExample.GetUserName(builder, ref len);
            WriteLine($"User name: {builder}");
            //...........

            string processName = "notepad.exe", text;
            Write("Enter text: ");
            text = ReadLine();
            Process p = Process.Start(processName);
            p.WaitForInputIdle();
            IntPtr h = p.MainWindowHandle;
            DllImportExample.SetForegroundWindow(h);
            //SendKeys.SendWait(text)


            try
            {
                Write("Enter the first number: ");
                int number1 = int.Parse(ReadLine());
                Write("Enter the second number: ");
                int number2 = int.Parse(ReadLine());
                WriteLine($"\t{number1} + {number2} = {DllImportExample.add(number1, number2)}");
                WriteLine($"\t{number1} - {number2} = {DllImportExample.sub(number1, number2)}");
                WriteLine($"\t{number1} * {number2} = {DllImportExample.mult(number1, number2)}");
                WriteLine($"\t{number1} / {number2} = {DllImportExample.div(number1, number2)}");
            }
            catch (Exception ex)
            {
                WriteLine(ex.Message);
            }
        }
    }
}