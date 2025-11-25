using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gv_1, gv_2, gv_3, samk_perimetri, kv_fartobi;

            gv_1 = int.Parse(textBox1.Text);
            gv_2 = int.Parse(textBox2.Text);
            gv_3 = int.Parse(textBox3.Text);


            Samkutxedi samk_obj = new Samkutxedi(gv_1, gv_2, gv_3);
            Kvadrati kv_obj = new Kvadrati(gv_1);

            samk_perimetri = samk_obj.perimetri;
            kv_fartobi = kv_obj.fartobi;

            label4.Text = "სამკუთხედის პერიმეტრი: " + samk_perimetri.ToString() + "\n"
                + "კვადრატის ფართობი: " + kv_fartobi.ToString();


        }
    }
}
