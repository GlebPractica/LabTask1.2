using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            double a, b, c, xStart, xEnd, dx;

            if (!double.TryParse(textBox1.Text, out a) ||
                !double.TryParse(textBox2.Text, out b) ||
                !double.TryParse(textBox3.Text, out c) ||
                !double.TryParse(textBox4.Text, out xStart) ||
                !double.TryParse(textBox5.Text, out xEnd) ||
                !double.TryParse(textBox6.Text, out dx))
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения.");
                return;
            }

            for (double x = xStart; x <= xEnd; x += dx)
            {
                try
                {
                    double f = Solution.CalculateFunction(a, b, c, x);
                    dataGridView1.Rows.Add(x, f);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при вычислении: " + ex.Message);
                    return;
                }
            }
        }
    }
}
