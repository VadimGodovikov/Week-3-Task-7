namespace prog7._1form
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.strBox = new System.Windows.Forms.TextBox();
			this.substrBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(86, 13);
			this.label1.TabIndex = 0;
			this.label1.Text = "Введите строку";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(13, 61);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(248, 13);
			this.label2.TabIndex = 1;
			this.label2.Text = "Введите слово/символ которые нужно удалить";
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 91);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(249, 58);
			this.button1.TabIndex = 2;
			this.button1.Text = "Пуск";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// strBox
			// 
			this.strBox.Location = new System.Drawing.Point(126, 28);
			this.strBox.Name = "strBox";
			this.strBox.Size = new System.Drawing.Size(662, 20);
			this.strBox.TabIndex = 3;
			// 
			// substrBox
			// 
			this.substrBox.Location = new System.Drawing.Point(267, 58);
			this.substrBox.Name = "substrBox";
			this.substrBox.Size = new System.Drawing.Size(521, 20);
			this.substrBox.TabIndex = 4;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 161);
			this.Controls.Add(this.substrBox);
			this.Controls.Add(this.strBox);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox strBox;
		private System.Windows.Forms.TextBox substrBox;
	}
}

