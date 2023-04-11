//Copyright (c), Semeniuta Diana 202 TN, 2023
/*Задана послідовність символові. Роздрукувати цю послідовність:
а) витерши з неї всі цифри;
б) замінивши буквосполучення 'карб' на 'грн'.*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PrintSequenceButton_Click(object sender, EventArgs e)
        {
            try
            {
                
                string input = InputTextBox.Text;

                // видаляємо всі цифри з рядка
                string result = new string(input.Where(c => !Char.IsDigit(c)).ToArray());

                // замінюємо буквосполучення "карб" на "грн"
                result = result.Replace("карб", "грн");

                // виводимо результат
                OutputTextBox.Text = result;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
