using System;

namespace _1._2._4._VALIDATOR
{
    class Program
    {
        static void Main(string[] args)
        {

			Console.WriteLine("Введите строку:");
			string input = Console.ReadLine();
			char[] swap = input.ToCharArray();
			string swapString = swap[0].ToString().ToUpper();
			char[] swapSymbol = swapString.ToCharArray();
			swap[0] = swapSymbol[0];
			int[] array = new int[swap.Length];
			int index = 0;
			while (index != -1)
			{

				if (input.IndexOf('.') != -1)
				{
					index = input.IndexOf('.');
					swap[index] = ' ';
					array[index] = 1;
				}
				else if (input.IndexOf('!') != -1)
				{
					index = input.IndexOf('!');
					swap[index] = ' ';
					array[index] = 2;
				}
				else if (input.IndexOf('?') != -1)
				{
					index = input.IndexOf('?');
					swap[index] = ' ';
					array[index] = 3;
				}
				else
				{
					break;
				}
				if (index > 0 & index < swap.Length - 2)
				{
					index += 2;
					swapString = swap[index].ToString().ToUpper();
					swapSymbol = swapString.ToCharArray();
					swap[index] = swapSymbol[0];
					input = String.Concat<char>(swap);
				}
				else
				{
					input = String.Concat<char>(swap);
				}
			}
			for (int i = 0; i < swap.Length; i++)
			{
				if (array[i] == 1)
				{
					swap[i] = '.';
				}
				else if (array[i] == 2)
				{
					swap[i] = '!';
				}
				else if (array[i] == 3)
				{
					swap[i] = '?';
				}
			}
			input = String.Concat<char>(swap);
			Console.WriteLine("Измененная строка:\n{0}", input);

		}
	}
}