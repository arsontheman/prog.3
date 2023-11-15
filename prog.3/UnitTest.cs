using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prog._3
{
    public partial class UnitTest : Form
    {
        public UnitTest()
        {
            InitializeComponent();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form form = Application.OpenForms[0];
            form.Show();
            this.Close();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (int.TryParse(textBox4.Text, out int a) && int.TryParse(textBox5.Text, out int b))
            {
                ex2 calculator = new ex2(a, b);
                int result = calculator.SumOfMultiplesOf17AndDivisibleBy4Mod2();
                label6.Text = $"Сума чисел, кратних 17 і дільних на 4 за модулем 2: {result}";
            }
            else
            {
                MessageBox.Show("Некоректний ввід чисел.");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int number1, number2, number3;

            if (int.TryParse(textBox1.Text, out number1) &&
                int.TryParse(textBox2.Text, out number2) &&
                int.TryParse(textBox3.Text, out number3))
            {
                int[] numbers = { number1, number2, number3 };

                ex1 calculator = new ex1(numbers);
                int count = calculator.CountMultiplesOf27();

                label7.Text = $"Кількість чисел, кратних 27: {count}";
            }
            else
            {
                MessageBox.Show("Некоректний ввід чисел.");
            }
        }
    }
}
