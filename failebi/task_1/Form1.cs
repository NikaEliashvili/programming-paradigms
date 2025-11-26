using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

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

            label1.Text = "";

            // 1) --- Create file and write 5 byte numbers ---
            byte[] nums = { 15, 7, 100, 33, 9 }; 

            FileStream f_out = new FileStream("task_file.dat", FileMode.Create);

            for (int i = 0; i < nums.Length; i++)
            {
                f_out.WriteByte(nums[i]);
            }

            f_out.Close();


            // 2) --- Open file again and read 5 bytes into array ---
            byte[] read_nums = new byte[5];

            FileStream f_in = new FileStream("task_file.dat", FileMode.Open);

            int value;
            int index = 0;

            for (; ; )
            {
                value = f_in.ReadByte();
                if (value == -1) break;

                if (index < read_nums.Length)
                    read_nums[index++] = (byte)value;
            }

            f_in.Close();


            // 3) --- Find minimum value ---
            byte min = read_nums.Min();


            // 4) --- Append minimum to the same file ---
            FileStream f_append = new FileStream("task_file.dat", FileMode.Append);
            f_append.WriteByte(min);
            f_append.Close();


            // 5) --- Display results in label ---
            label1.Text += "Original numbers:\n";
            for (int i = 0; i < read_nums.Length; i++)
                label1.Text += read_nums[i] + "   ";

            label1.Text += "\n\nMinimum added to file: " + min;
        }
    }
}
