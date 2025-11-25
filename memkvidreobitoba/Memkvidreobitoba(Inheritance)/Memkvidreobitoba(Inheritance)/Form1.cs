using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Memkvidreobitoba_Inheritance_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gverdi_1, gverdi_2, gverdi_3, kv_p, kv_area, mart_p, mart_area, samk_p;
            double samk_area;

            gverdi_1 = int.Parse(textBox1.Text);
            gverdi_2 = int.Parse(textBox2.Text);
            gverdi_3 = int.Parse(textBox3.Text);

            Kvadrati kv_obj = new Kvadrati(gverdi_1);
            Martkutxedi mart_obj = new Martkutxedi(gverdi_1,gverdi_2);
            Samkutxedi samk_obj = new Samkutxedi(gverdi_1, gverdi_2, gverdi_3);

            kv_p = kv_obj.GetPerimeterKvadrati();
            kv_area = kv_obj.GetAreaKvadrati();

            mart_p = mart_obj.GetPerimeterMartkutxedi();
            mart_area = mart_obj.GetAreaMartkutxedi();

            samk_p = samk_obj.GetPerimeterSamkutxedi();
            samk_area = samk_obj.GetAreaSamkutxedi();

            label4.Text = "კვადრატის პერიმეტრი: " + kv_p.ToString() + 
                ", " + "ფართობი: " + kv_area.ToString();
            label5.Text = "მართკუთხედის პერიმეტრი: " + mart_p.ToString() +
                ", " + "ფართობი: " + mart_area.ToString();
            label6.Text = "სამკუთხედის პერიმეტრი: " + samk_p.ToString() +
                ", " + "ფართობი: " + samk_area.ToString();



        }
    }
}
