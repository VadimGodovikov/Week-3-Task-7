using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prog7._2form
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				string str = textBox1.Text;
				string res = $"Ваша строка: {str}\n";
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
				res += $"Количество слов состоящих только из прописных букв = {count}";
				MessageBox.Show(res, "Результат");
			}
			catch
			{
				MessageBox.Show("Введите корректное сообщение");
				return;
			}
		}
	}
}
