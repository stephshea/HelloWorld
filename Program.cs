using System;
using System.Linq;
using System.Diagnostics;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var processList = Process.GetProcesses();
            var process = processList.Where(p=> p.ProcessName == "dotnet").First();
            Console.WriteLine("Processing your feelings is " + process.PriorityClass);
        }
    }
}
