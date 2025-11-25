using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task_1
{
    delegate void Delegati_2();
    internal class Class2
    {
        public event Delegati_2 Movlena_2;

        public void Method_2(int num1, int num2)
        {
            if (num1 % 2 == 0 && num2 % 2 == 0) Movlena_2();
            else MessageBox.Show("მოვლენა არ აღიძრა.");
        }

        public void Handler_1()
        {
            MessageBox.Show("მოვლენა აღიძრა. ორივე რიცხვი ლუწია!");
        }

    }
}
