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
            int[] masivi = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            label1.Text = "";
            label2.Text = "";
            label3.Text = "";

            Class1 methodebi = new Class1();

            Delegati_1 deleg_1;

            Delegati_1 deleg_2 = new Delegati_1(methodebi.Method_1);
            Delegati_1 deleg_3 = new Delegati_1(methodebi.Method_2);
            Delegati_1 deleg_4 = new Delegati_1(methodebi.Method_3);

            for(int i=0; i < masivi.Length; i++)
            {
                label1.Text += masivi[i]+"  ";
            }

            deleg_1 = deleg_2;
            deleg_1 += deleg_3;

            deleg_1(masivi);

            for (int i = 0; i < masivi.Length; i++)
            {
                label2.Text += masivi[i] + "  ";
            }

            deleg_1 -= deleg_2;
            deleg_1 += deleg_4;
            deleg_1(masivi);

            for (int i = 0; i < masivi.Length; i++)
            {
                label3.Text += masivi[i] + "  ";
            }

        }
    }
}
