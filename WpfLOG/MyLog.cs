using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfLOG
{
    internal class MyLog
    {
         static readonly string path = Environment.CurrentDirectory +  @"\MYlog.txt"; 
        public static void LogError(string error)
        {
            File.AppendAllText(Environment.CurrentDirectory, $"------------------ LogError {DateTime.Now} --------------------" + Environment.NewLine);

            File.AppendAllText( path, error + Environment.NewLine);
        }

        public static void LogInfo(string info)
        {
            File.AppendAllText(Environment.CurrentDirectory, $"##################### LogInfo {DateTime.Now} #####################" + Environment.NewLine);

            File.AppendAllText(path, info + Environment.NewLine);
        }
    }
}
