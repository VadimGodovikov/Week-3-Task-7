using System;
using System.Text;

namespace prog7._1
{
	class Class
	{
		static void Main()
		{
			try
			{
				Console.WriteLine("Введите строку: ");
				StringBuilder a = new StringBuilder(Console.ReadLine());
				Console.WriteLine("Исходная строка: " + a);
				Console.WriteLine("Введите символы/слово которые нужно удалить: ");
				string substr = Console.ReadLine();
				
				StringBuilder result = a.Replace(substr, string.Empty);
				Console.WriteLine(result);
			}
			catch
			{
				Console.WriteLine("Введите корректные данные");
				return;
			}
		}
	}
}
