using System;
using System.Diagnostics;
using System.IO;

namespace SmartDataCollector
{
    class Program
    {
        static void Main(string[] args)
        {
            string drive = "/dev/sda";
            string smartData = GetSmartData(drive);
            Console.WriteLine(smartData);
            Console.ReadLine();
        }

        private static string GetSmartData(string drive)
        {
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo()
                {
                    FileName = @"C:\Program Files\smartmontools\bin\smartctl.exe", 
                    Arguments = "-a /dev/sda", 
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true
                };
                ;

                using (Process process = Process.Start(startInfo))
                {
                    using (StreamReader reader = process.StandardOutput)
                    {
                        string result = reader.ReadToEnd();
                        return result;
                    }
                }
            }
            catch (Exception ex)
            {
                return $"Erro ao executar smartctl: {ex.Message}";
            }
        }
    }
}