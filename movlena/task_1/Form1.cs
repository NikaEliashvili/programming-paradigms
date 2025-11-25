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
            int num_1, num_2;

            num_1 = int.Parse(textBox1.Text);
            num_2 = int.Parse(textBox2.Text);

            Class1 obj = new Class1();

            Delegati delegati = new Delegati(obj.Handler_1);

            obj.Movlena_1 += delegati;
            obj.Method_1(num_1, num_2);


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int num_1 = int.Parse(textBox1.Text);
            int num_2 = int.Parse(textBox2.Text);

            Class2 obj_2 = new Class2();

            Delegati_2 delegati_2 = new Delegati_2(obj_2.Handler_1);

            obj_2.Movlena_2 += delegati_2;
            obj_2.Method_2(num_1, num_2);

        }
    }
}
