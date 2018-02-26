using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab.D_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear(); // очистка полей
            textBox2.Clear();
            label3.Visible = false;
        }

        bool region1(double x, double y)
	    {
            return ((y>=2*x-2)&&(y>=-2*x-2)&&(y<=0)); // вычисление выражения для первой области //
	    }
        bool region2(double x, double y)
        {
            return ((((x + 1) * (x + 1) + (y - 1) * (y - 1)) <= 1) && (x * x + (y - 1) * (y - 1) >= 1));  // вычисление выражения для второй области //
        }
        bool region3(double x, double y)
        {
            return ((((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 1) && (x * x + (y - 1) * (y - 1) >= 1)&& (((x + 1) * (x + 1) + (y - 1) * (y - 1)) <= 1)); // вычисление выражения для третьей области //
        }

        bool region4(double x, double y)
        {
            return ((x * x + (y - 1) * (y - 1) >= 1)&& (((x - 1) * (x - 1) + (y - 1) * (y - 1)) <= 1)); // вычисление выражения для четвертой области //
        }
    private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double y = Convert.ToDouble(textBox2.Text); // считывание координаты Y
                double x = Convert.ToDouble(textBox1.Text); // считывание координаты X
                label3.Visible = false;
                if (region1(x,y)|| region2(x, y)|| region3(x, y)|| region4(x, y)) // условие попадания точки в область
                {
                    label3.Text = "Точка принадлежит выделенной области";
                    label3.Visible = true;
                }
                else
                    label3.Text = "Точка не принадлежит выделенной области";
                    label3.Visible = true;
            }
            catch(Exception)
            {
                MessageBox.Show("Не верные типы данных. Повторите ввод.", "Error 404"); // отлавливание исключений
            }
        }
    }
}