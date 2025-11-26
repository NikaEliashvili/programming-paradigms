using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] random_nums = new int[10];
            System.Random generator = new System.Random();
            
            label1.Text = "";


            for (int i = 0; i < random_nums.Length; i++)
                random_nums[i] = generator.Next(20);

            for (int i = 0; i < random_nums.Length; i++)
                label1.Text += random_nums[i].ToString() + "  " ;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double[] random_nums = new double[10];
            System.Random generator = new System.Random();

            label1.Text = "";

            for (int i = 0; i < random_nums.Length; i++)
                random_nums[i] = Math.Round(generator.NextDouble() - 0.5, 3);

            for (int i = 0; i < random_nums.Length; i++)
                label1.Text += random_nums[i].ToString() + "  ";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            byte[] random_nums = new byte[10];
            Random generator = new Random();

            label1.Text = "";

            generator.NextBytes(random_nums);

            for (int i = 0; i < random_nums.Length; i++)
                label1.Text += random_nums[i].ToString() + "  ";
        }
    }
}
