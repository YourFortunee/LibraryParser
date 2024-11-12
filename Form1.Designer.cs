using System;
using System.Windows.Forms;

namespace library_parser
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
            this.ParserStringTB = new System.Windows.Forms.TextBox();
            this.ParseBut = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // ParserStringTB
            // 
            this.ParserStringTB.Location = new System.Drawing.Point(42, 27);
            this.ParserStringTB.Name = "ParserStringTB";
            this.ParserStringTB.Size = new System.Drawing.Size(713, 22);
            this.ParserStringTB.TabIndex = 2;
            // 
            // ParseBut
            // 
            this.ParseBut.Location = new System.Drawing.Point(288, 313);
            this.ParseBut.Name = "ParseBut";
            this.ParseBut.Size = new System.Drawing.Size(208, 63);
            this.ParseBut.TabIndex = 7;
            this.ParseBut.Text = "Найти";
            this.ParseBut.UseVisualStyleBackColor = true;
            this.ParseBut.Click += new System.EventHandler(this.Button1_Click);
            this.ParseBut.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Button1_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(42, 93);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(713, 196);
            this.listBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ParseBut);
            this.Controls.Add(this.ParserStringTB);
            this.Name = "Form1";
            this.Text = "LibraBlock";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            string[] books = new string[3]
             {
                "О.С. Габриелян - Учебник по химии 8 класс",
                "Г.Н. Степанова - Учебник по физике 6 класс",
                "С.И. Колесников - Биология. Большой справочник для подготовки к ЕГЭ и ОГЭ"
             };
            // Считаем значение из нашей поисковой строки
            string ParsString = ParserStringTB.Text;
            string[] ListPars = new string[6];
            // Если (наш элемент массива содержит значение, считанное ранее)
            int j = 0;
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].Contains(ParsString))
                {
                    // Придадим ТБ значение этого элемента массива
                    ListPars[j] = books[i];
                    j++;
                }
                else if (ListPars[0] == string.Empty)
                {
                    ListPars[0] = "Кажется, в нашей библиотеке нет книг, соответствующих Вашему запросу";
                }
            }
            int a = 0;
           

            while (a < ListPars.Length)          
            {
                if (ListPars[a] != null)
                {
                    listBox1.Items.Add(ListPars[a].ToString());
                }
                a++;
            }
            
        }


        #endregion
        private System.Windows.Forms.TextBox ParserStringTB;
        private System.Windows.Forms.Button ParseBut;
        private ListBox listBox1;
    }
}

