using System;
using System.Collections.Generic;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_1
{
    delegate void Delegati();
    internal class Class1
    {
        public event Delegati Movlena_1;

        public void Method_1(int num_1, int num_2)
        {
            if (num_1 > num_2) Movlena_1();
            else MessageBox.Show("მოვლენა არ აღიძრა!");
        }

        public void Handler_1()
        {
            MessageBox.Show("მოვლენა აღიძრა!");
        }
    }
}
