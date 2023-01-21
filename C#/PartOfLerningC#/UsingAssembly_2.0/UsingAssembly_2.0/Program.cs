using System.Reflection;
using System.Text;

namespace UsingAssembly_2._0
{
    internal class Program
    {
        /// <summary>
        ///  Returns the security settings for the assembly
        /// </summary>
        public static string GetCasSecurityAttributes()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();

            StringBuilder sb= new StringBuilder();

            sb.AppendFormat($"Security rule: {assembly.SecurityRuleSet}\n");
            sb.AppendFormat($"Fully trusted assembly: {assembly.IsFullyTrusted}\n");

            Type t = assembly.GetType("UsingAssembly_2._0.Program");

            sb.AppendFormat($"Whether the current type is security-critical: " +
                $"{t.IsSecurityCritical}\n");
            sb.AppendFormat($"Whether the current type is security - safe - critical " +
                $"at the current trust level: { t.IsSecuritySafeCritical}\n");
            sb.AppendFormat($"Whether the current type is transparent" +
                $"at the current trust level:" +
                $"{t.IsSecurityTransparent}\n");

            //try
            //{
            //    sb.AppendFormat($"\nNumber of permissions" +
            //        $"of the current assembly:" +
            //        $"{assembly.PermissionSet.Count}");
            //}
            //catch(Exception ex)
            //{
            //    sb.AppendFormat($"\n{ex.Message}\n");
            //}
            return sb.ToString();
        }

        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine(GetCasSecurityAttributes());
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}