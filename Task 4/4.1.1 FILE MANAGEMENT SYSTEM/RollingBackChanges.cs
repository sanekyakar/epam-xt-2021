//using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace _4._1._1_FILE_MANAGEMENT_SYSTEM
{
    class RollingBackChanges
    {
		private static string path = Directory.GetCurrentDirectory() + @"\TEST FILE";
		private static string logPath = Directory.GetCurrentDirectory() + @"\logs\log.txt";

		public static void Changes()
		{

			int dateNumber;
			int i = 0;
			int j = 0;
			string str = "";
			Console.Clear();
			Console.WriteLine("Select the date until which you want to rollback changes\n");
			using (var reader = new StreamReader(logPath))
			{
				while (!reader.EndOfStream)
				{
					str = reader.ReadLine();
					if (str.Contains("Date:"))
					{
						str = str.Remove(0, 6);
						Console.WriteLine($"{++i}. {str}");
					}
				}
				j = i;
			}

			str = Console.ReadLine();
			if (int.TryParse(str, out int res))
			{
				dateNumber = int.Parse(str);
			}
			else
			{
				throw new ArgumentException("The entered value is not an integer");
			}

			if (dateNumber > i)
			{
				throw new ArgumentException("The entered value cannot exceed the number of options in the list");
			}

			while (j != dateNumber)
			{
				using (var reader = new StreamReader(logPath))
				{
					i = 0;

					while (i != j)
					{
						str = reader.ReadLine();
						if (str != null)
						{

							if (str.Contains("Date:"))
							{
								i++;
							}
						}
					}

					str = reader.ReadLine();
					if (str.Contains("Changed:"))
					{

						str = str.Remove(0, 9);
						using (var writer = new StreamWriter(str))
						{
							str = reader.ReadLine();
							for (i = 0; i == 0;)
							{
								str = reader.ReadLine();
								if (str != null)
								{
									if (!str.Contains("Date:"))
									{
										writer.WriteLine(str);
									}
									else
									{
										i++;
									}
								}
							}
						}
					}

					if (str.Contains("Created:"))
					{
						str = str.Remove(0, 9);
						File.Delete(str);
					}
					else if (str.Contains("Deleted:"))
					{
						str = str.Remove(0, 9);
						File.Create(str);
					}
					else if (str.Contains("Rename:"))
					{
						string str1 = str.Remove(0, 8);
						str1 = str1.Remove(str1.IndexOf("to") - 3, str1.Length - str1.IndexOf("to") - 1);
						str = str.Remove(0, str.IndexOf("to") + 3);
						//FileSystem.RenameFile(str, str1);
					}

					j--;
				}
			}
		}
	}
}

