using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._1._1_MyLibrary
{
	public class MyString : IComparable<MyString>
	{
		private char[] sstring;
		public int Length
		{ get => sstring.Length; }
		public MyString(string strng)
		{
			sstring = strng.ToCharArray();
		}
		public MyString(char[] strng)
		{
			sstring = strng;
		}
		public int CompareTo(MyString other)
		{
			if (Length > other.sstring.Length)
			{
				return 1;
			}
			else if (Length < other.sstring.Length)
			{
				return -1;
			}
			else
			{
				return 0;
			}
		}
		public int Compare(MyString secondString)
		{
			if (Length == secondString.Length)
			{
				for (int i = 0; i < Length; i++)
				{
					if (sstring[i] != secondString[i])
					{
						return 0;
					}
				}
				return 1;
			}
			else
				return 0;
		}

		public int Search(char element)
		{
			for (int i = 0; i < Length; i++)
			{
				if (sstring[i] == element)
					return i;
			}
			return 0;
		}

		public string Contact(MyString otherString)
		{
			StringBuilder resultString = new StringBuilder();
			for (int i = 0; i < Length; i++)
			{
				resultString.Append(sstring[i]);
			}
			for (int i = 0; i < otherString.Length; i++)
			{
				resultString.Append(otherString[i]);
			}
			return resultString.ToString();
		}

		public override string ToString()
		{
			StringBuilder resultString = new StringBuilder();
			for (int i = 0; i < Length; i++)
			{
				resultString.Append(sstring[i]);
			}
			return resultString.ToString();
		}

		public MyString Backward()
		{
			char[] resultString = new char[Length];
			for (int i = 0; i < Length; i++)
			{
				resultString[i] = sstring[Length - 1 - i];
			}
			return new MyString(resultString);
		}

		public char this[int index]
		{
			get
			{
				if (sstring.Length > index && index > -1)
				{
					return sstring[index];
				}
				else
				{
					throw new ArgumentOutOfRangeException($"Index '{index}' incorrect!");
				}
			}
			set
			{
				if (sstring.Length > index && index > -1)
				{
					sstring[index] = value;
				}
				else
				{
					throw new ArgumentOutOfRangeException($"Index '{index}' incorrect!");
				}
			}
		}
	}
}
