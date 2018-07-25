using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileWatcherConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var fileSystemWatcher = new FileSystemWatcher();

            fileSystemWatcher.Created += FileSystemWatcher_Created;
            fileSystemWatcher.Path = @"C:\Test";
            fileSystemWatcher.Filter = "*.xml";
            fileSystemWatcher.EnableRaisingEvents = true;

            Console.WriteLine("Listening...");
            Console.WriteLine("Press any key to exit.");

            Console.ReadLine();

        }
        
        private static void FileSystemWatcher_Created(object sender, FileSystemEventArgs e)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"A new file has been created - {e.Name}");

        }
    }
}
