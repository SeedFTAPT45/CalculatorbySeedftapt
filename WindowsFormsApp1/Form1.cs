using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public string D;
        public string N1;
        public bool n2;
        public Form1()
        {
            n2 = false;
            InitializeComponent();
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            // Окно приложения
        }

        public void button1_Click(object sender, EventArgs e)
        {
            // Остаток от деления
        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Вывод результата вычислений           

        }

        public void label4_Click(object sender, EventArgs e)
        {
            // Никнейм Автора
        }

        public void button4_Click(object sender, EventArgs e)
        {
            // Удаление последней цифры
            textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
            if (textBox1.Text == "")
                textBox1.Text = "0";
        }

        public void button5_Click(object sender, EventArgs e)
        {
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = 1 / dn;                                  // Дробное число
            textBox1.Text = res.ToString();
        }

        public void button19_Click(object sender, EventArgs e)
        {
            // Ввод чисел
            if (n2)
            {
                n2 = false;
                textBox1.Text = "0";
            }
            Button B = (Button)sender;
            if (textBox1.Text == "0")
                textBox1.Text = B.Text;
            else
                textBox1.Text = textBox1.Text + B.Text;
        }

        public void button3_Click(object sender, EventArgs e)
        {
            // Обнуление результата
            textBox1.Text = "0";
        }

        public void button21_Click(object sender, EventArgs e)
        {
            // Точка в десятичной дроби
            if (!textBox1.Text.Contains(","))
                textBox1.Text = textBox1.Text + ",";
        }

        public void button20_Click(object sender, EventArgs e)
        {
            Button B = (Button)sender;
            D = B.Text;
            N1 = textBox1.Text;
            n2 = true;
        }

        public void button24_Click(object sender, EventArgs e)
        {
            // Выбор операции над числами
            double dn1, dn2, res;
            res = 0;
            dn1 = Convert.ToDouble(N1);
            dn2 = Convert.ToDouble(textBox1.Text);

            switch (D)
            {
                case "+":
                    res = dn1 + dn2;
                    break;

                case "-":
                    res = dn1 - dn2;
                    break;

                case "×":
                    res = dn1 * dn2;
                    break;

                case "÷":
                    res = dn1 / dn2;
                    break;
                case "%":
                    res = dn1 * dn2 / 100;
                    break;
            }

            D = "=";
            n2 = true;
            textBox1.Text = res.ToString();
        }

        public void button9_Click(object sender, EventArgs e)
        {
            // Квадратный корень числа
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Sqrt(dn);
            textBox1.Text = res.ToString();
        }

        public void button7_Click(object sender, EventArgs e)
        {
            // Возведение числа в квадратную степень 
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = Math.Pow(dn, 2);
            textBox1.Text = res.ToString();
        }

        public void button23_Click(object sender, EventArgs e)
        {
            // Изменение знака числа 
            double dn, res;
            dn = Convert.ToDouble(textBox1.Text);
            res = -dn;
            textBox1.Text = res.ToString();
        }

        public void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
