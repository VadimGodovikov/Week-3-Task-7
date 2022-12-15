using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prog7._2
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.WriteLine("Введите осмысленное предложение: ");
				string str = Console.ReadLine();

				int up = 0;
				int low = 0;
				int index = 0;
				int count = 0;
				while (index < str.Length)
				{
					up = 0;
					low = 0;
					while (index < str.Length && char.IsLetter(str[index]))
					{
						if (char.IsUpper(str[index])) up++;
						if (char.IsLower(str[index])) low++;
						index++;
					}
					if (up > 0 && low == 0) count++;
					while (index < str.Length && !char.IsLetter(str[index]))
					{
						index++;
					}
				}
				Console.WriteLine(count);
			}
			catch
			{
				Console.WriteLine("Введите корректное сообщение");
				return;
			}
		}
	}
}
