using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;

namespace _4._1._1_FILE_MANAGEMENT_SYSTEM
{
    class Supervision
	{
			private static string path = Directory.GetCurrentDirectory() + @"\TEST FILE";
			private static string logPath = Directory.GetCurrentDirectory() + @"\logs\log.txt";

			public static void Monitoring()
			{

				Console.Clear();
				Console.WriteLine($"Start monitoring {DateTime.Now}");
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("\nPress 'q' to quit\n");
				Console.ResetColor();


				using (FileSystemWatcher watcher = new FileSystemWatcher(Directory.GetCurrentDirectory() + @"\TEST FILE"))
				{
					watcher.IncludeSubdirectories = true;
					watcher.NotifyFilter = NotifyFilters.LastAccess
										 | NotifyFilters.LastWrite
										 | NotifyFilters.FileName
										 | NotifyFilters.DirectoryName;


					watcher.Filter = "*.txt";

					watcher.Changed += OnChanged;
					watcher.Created += OnCreateOrDeleted;
					watcher.Deleted += OnCreateOrDeleted;
					watcher.Renamed += OnRenamed;

					watcher.EnableRaisingEvents = true;

					while (Console.ReadLine() != "q") ;
				}
			}

			private static void OnChanged(object source, FileSystemEventArgs e)
			{
				using (var writer = new StreamWriter(logPath, true))
				{
					writer.WriteLine($"Date: {DateTime.Now}" +
						$"\n{e.ChangeType}: {e.FullPath}\n");
					Thread.Sleep(100);
					using (var stream = new FileStream(e.FullPath, FileMode.Open, FileAccess.Read, FileShare.Read))
					using (var reader = new StreamReader(stream))
					{
						writer.WriteLine(reader.ReadToEnd());
					}
				}
			}

			private static void OnCreateOrDeleted(object source, FileSystemEventArgs e)
			{
				using (var writer = new StreamWriter(logPath, true))
				{
					writer.WriteLine($"Date: {DateTime.Now}" +
						$"\n{e.ChangeType}: {e.FullPath}\n");
				}
			}

			private static void OnRenamed(object source, RenamedEventArgs e)
			{
				using (var writer = new StreamWriter(logPath, true))
				{
					writer.WriteLine($"Date: {DateTime.Now}" +
						$"\nRename: {e.OldName} to {e.FullPath}\n");
				}
			}
	}
}
