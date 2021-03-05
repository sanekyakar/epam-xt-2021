using System;

namespace _1._1._6._FONT_ADJUSTMENT
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = "None", num;
            do
            {
                Console.WriteLine("Параметры надписи: {0}" +
                    "\nвведите:" +
                    "\n\t1: bold" +
                    "\n\t2: italic" +
                    "\n\t3: underline", type);
                num = Console.ReadLine();
                if (type.Contains("None"))
                {
                    type = type.Replace("None", " ");
                }
                switch (num)
                {
                    case "1":
                        if (type.Contains("bold"))
                        {
                            type = type.Replace("bold, ", "");
                        }
                        else
                        {
                            type = type.Insert(type.Length - 1, "bold, ");
                        }
                        break;
                    case "2":
                        if (type.Contains("italic"))
                        {
                            type = type.Replace("italic, ", "");
                        }
                        else
                        {
                            type = type.Insert(type.Length - 1, "italic, ");
                        }
                        break;
                    case "3":
                        if (type.Contains("underline"))
                        {
                            type = type.Replace("underline, ", "");
                        }
                        else
                        {
                            type = type.Insert(type.Length - 1, "underline, ");
                        }
                        break;

                    default:
                        break;
                }
            } while (num != "0");
        }
    }
}