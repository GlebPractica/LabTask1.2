using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Execute_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            try
            {
                int result = 0;

                if (radioButton1.Checked)
                    result = await Task.Run(() => Solution.GetResult(int.Parse(textBox1.Text), int.Parse(textBox2.Text)));
                else if (radioButton2.Checked)
                    result = await Task.Run(() => Solution.GetResult(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text)));
                else if (radioButton3.Checked)
                    result = await Task.Run(() => Solution.GetResult(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text)));
                else if (radioButton4.Checked)
                    result = await Task.Run(() => Solution.GetResult(int.Parse(textBox1.Text), int.Parse(textBox2.Text), int.Parse(textBox3.Text), int.Parse(textBox4.Text), int.Parse(textBox5.Text)));

                listBox1.Items.Add($"Результат равен {result}");
            }
            catch (Exception ex)
            {
                listBox1.Items.Add(ex.Message);
            }
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = true;
            label5.Visible = false;
            label6.Visible = false;
            textBox3.Visible = true;
            textBox4.Visible = false;
            textBox5.Visible = false;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            label4.Visible = true;
            textBox3.Visible = true;
            label5.Visible = true;
            label6.Visible = false;
            textBox4.Visible = true;
            textBox5.Visible = false;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
        }
    }
}
