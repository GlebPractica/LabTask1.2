using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task_2;

namespace Task1
{
    public partial class Form1 : Form
    {
        int[] P1 = new int[2];
        int[] P2 = new int[2];
        int[] P3 = new int[2];
        int[] P4 = new int[2];

        public Form1()
        {
            InitializeComponent();
        }

        private async void Execute_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();

            try
            {
                P1[0] = int.Parse(textBox1.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[0]);
                P1[1] = int.Parse(textBox1.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[1]);
                P2[0] = int.Parse(textBox2.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[0]);
                P2[1] = int.Parse(textBox2.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[1]);
                P3[0] = int.Parse(textBox3.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[0]);
                P3[1] = int.Parse(textBox3.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[1]);
                P4[0] = int.Parse(textBox4.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[0]);
                P4[1] = int.Parse(textBox4.Text.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)[1]);

                string outText = Solution.GetResult(new Rect(P1[0], P1[1], P2[0], P2[1]), new Rect(P3[0], P3[1], P4[0], P4[1])) ? "пересекается" : "не пересекается";

                listBox1.Items.Add($"Результат {outText}");
            }
            catch (Exception ex)
            {
                listBox1.Items.Add(ex.Message);
            }
        }
    }
}
