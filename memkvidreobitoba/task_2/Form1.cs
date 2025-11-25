using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
            int gverdi_1, gverdi_2, gverdi_3, perimetri;
            double area;

            gverdi_1 = int.Parse(textBox1.Text);
            gverdi_2 = int.Parse(textBox2.Text);
            gverdi_3 = int.Parse(textBox3.Text);


            SamkutxediChild samk_obj = new SamkutxediChild(gverdi_1,
                gverdi_2,
                gverdi_3);

            perimetri = samk_obj.GetPerimeter();
            area = samk_obj.GetArea();

            label4.Text = "პერიმეტრი: " + perimetri.ToString() +
                ", ფართობი: " + area.ToString();


        }
    }
}
