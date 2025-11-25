using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[,] masivi = new int[,] { 
                { 1, 2, 3 }, 
                { 4, 5, 6 }, 
                { 7, 8, 9 }, 
                { 10, 11, 12 } 
            };
            label1.Text = "";
            label2.Text = "";
            label3.Text = "";

            Class1 obj = new Class1();

            Delegati delegati;
            Delegati delegati_1 = new Delegati(obj.Method_1);
            Delegati delegati_2 = new Delegati(obj.Method_2);
            Delegati delegati_3 = new Delegati(obj.Method_3);
            Delegati delegati_4 = new Delegati(obj.Method_4);

            for (int i = 0; i < masivi.GetLength(0); i++)
            {
                for (int j = 0; j < masivi.GetLength(1); j++)
                    label1.Text += masivi[i, j].ToString() + "     ";
                label1.Text += "\n";
            }

            delegati = delegati_1;
            delegati += delegati_2;
            delegati += delegati_3;
            delegati(masivi);

            for (int i = 0; i < masivi.GetLength(0); i++)
            {
                for (int j = 0; j < masivi.GetLength(1); j++)
                    label2.Text += masivi[i, j].ToString() + "     ";
                label2.Text += "\n";
            }

            delegati -= delegati_1;
            delegati -= delegati_3;
            delegati += delegati_4;
            delegati(masivi);

            for (int i = 0; i < masivi.GetLength(0); i++)
            {
                for (int j = 0; j < masivi.GetLength(1); j++)
                    label3.Text += masivi[i, j].ToString() + "     ";
                label3.Text += "\n";
            }

        }
    }
}
