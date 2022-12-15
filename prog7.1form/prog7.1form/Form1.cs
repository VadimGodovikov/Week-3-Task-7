using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prog7._1form
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			try
			{
				StringBuilder str = new StringBuilder(strBox.Text);
				string res = $"Ваша исходная строка: {str}\n";
				string substr = substrBox.Text;
				res += $"Слово/символ которое нужно удалить: {substr}\n";
				StringBuilder result = str.Replace(substr, string.Empty);
				res += $"Результат\n {result}";
				MessageBox.Show(res, "Результат");
			}
			catch
			{
				MessageBox.Show("Введите корректные данные");
				return;
			}
		}
	}
}
