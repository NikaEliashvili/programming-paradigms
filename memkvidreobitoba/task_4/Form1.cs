using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double speed, hours, energyPerKm, km, distance, usedEnergy;

            speed = double.Parse(textBox1.Text);
            hours = double.Parse(textBox2.Text);
            energyPerKm = double.Parse(textBox3.Text); 

            Memkvidre_1 obj_1 = new Memkvidre_1(speed, hours);
            Memkvidre_2 obj_2 = new Memkvidre_2(energyPerKm, speed, hours);

            distance = obj_1.distance;
            usedEnergy = obj_2.usedEnergy;

            label5.Text = "გავლილი მანძილი: " + distance.ToString() +
                "\n დახარჯული ენერგია: " + usedEnergy.ToString();

        }
    }
}
