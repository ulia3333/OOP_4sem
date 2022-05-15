using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Laba_1.Classes;
using System.Text.RegularExpressions;


namespace Laba_1
{
    public partial class Form : System.Windows.Forms.Form
    {
        Calculator calc = new Calculator();
        private void Delete()
        {
            InputStr.Text = String.Empty;
            ResultStr.Text = String.Empty;
            SubStr0.Text = String.Empty;
            SubStr1.Text = String.Empty;
            indexStr.Text = String.Empty;
            ConsonantStr.Text = String.Empty;
            VowelsStr.Text = String.Empty;
        }
        public Form()
        {
            InitializeComponent();
        }

               private void Clear_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void ReplaceBut_Click(object sender, EventArgs e)//изменить подстроку
        {
            if (SubStr0.Text != String.Empty)
            {
                if (SubStr1.Text != String.Empty)
                {
                    Regex reg=new Regex(SubStr0.Text);
                    ResultStr.Text = reg.Replace(InputStr.Text,SubStr1.Text,1);
                    InputStr.Text = reg.Replace(InputStr.Text,SubStr1.Text,1);
                   /* ResultStr.Text = InputStr.Text.Replace(SubStr0.Text, SubStr1.Text);*/
                }
                else ResultStr.Text = "Введите подстроку, которая изменяет";
            }
            else if (SubStr0.Text == String.Empty)
            {
                ResultStr.Text = "Введите подстроку для изменения";
            }
        }

        private void DeleteSubstr_Click(object sender, EventArgs e)//удалить подстроку
        {
            if (SubStr0.Text != String.Empty)
            {
                ResultStr.Text = InputStr.Text.Replace(SubStr0.Text, String.Empty);
            }
            else ResultStr.Text = "Введите подстроку для удаления";
        }

        private void SymbolByIndexBut_Click(object sender, EventArgs e)//получить сим по индексу
        {
            try
            {
                if (Convert.ToInt32(indexStr.Text) < 0 || indexStr.Text.Length == 0) MessageBox.Show("Индекс некорректный.");
                else       
                    if (indexStr.Text != String.Empty)
                    {
                        ResultStr.Text = String.Empty;
                        int index = int.Parse(indexStr.Text);
                        char res = InputStr.Text[index];
                        ResultStr.Text += res;
                    }
                    else ResultStr.Text = "Введите подстроку для удаления";
                
             
            }
            catch (IndexOutOfRangeException ex)
            {
                ResultStr.Text = ex.Message;
            }
          
        }

        private void VowBut_Click(object sender, EventArgs e)//кол слов
        {
            if (InputStr.Text != String.Empty)
            {
                ResultStr.Text = calc.WordCount(InputStr.Text);
            }
            else ResultStr.Text = "Введите текст";
        }

        private void ConsBut_Click(object sender, EventArgs e) //кол согл и гл
        {
            if (InputStr.Text != String.Empty)
            {
                var result = calc.ConsonantsAndVowels(InputStr.Text);
                ConsonantStr.Text = result[0].ToString();
                VowelsStr.Text = result[1].ToString();
            }
            else ResultStr.Text = "Введите текст!";
        }

        private void SenBut_Click(object sender, EventArgs e)//подсчитать количество предложений
        {
            if (InputStr.Text != String.Empty)
            {
                ResultStr.Text = calc.SenCount(InputStr.Text);
            }
            else ResultStr.Text = "Введите текст";
        }

        private void lenghtStrBut_Click(object sender, EventArgs e)//длинна строки
        {
            if (InputStr.Text != String.Empty)
            {
                ResultStr.Text = calc.GetLength(InputStr.Text);
            }
            else ResultStr.Text = "Вы не ввели строку. Пожалуйста, введите строку";
        }
    }
}
