using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1
{
    delegate void Delegati_1(int[] masivi);

    internal class Class1
    {

        public void Method_1(int[] masivi)
        {
            for (int i = 0; i < masivi.Length; i++)
            {
                if (masivi[i] % 2 == 1) masivi[i] *= 3; 
            } 
        }

        public void Method_2(int[] masivi)
        {
            for (int i = 0; i < masivi.Length; i++)
            {
                if (masivi[i] % 2 == 0) masivi[i] *= 2;
            } 
        }

        public void Method_3(int[] masivi)
        {
            for (int i = 0; i < masivi.Length; i++)
            {
                masivi[i] *= 10;
            }
        }

    }
}
