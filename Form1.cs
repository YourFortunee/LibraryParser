using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Windows;
using static System.Net.WebRequestMethods;


namespace library_parser
{
    public partial class Form1 : Form
    {
        


        public Form1()
        {
            InitializeComponent();
        }

        public void Button1_Click(object sender, EventArgs e, Control.ControlCollection control)
        {
            // Зададим книжечки
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
            for (int a = 0; a < ListPars.Length; a++) 
            {
                while (a < ListPars.Length)
                {
                    listBox1.Items.Add(ListPars[a]);
                }
            }
        }

    }
 }
