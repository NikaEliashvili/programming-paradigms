using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    delegate void Delegati(int[,] masivi);
    internal class Class1
    {

        public void Method_1(int[,] masivi)
        {
            for(int i=0; i<masivi.GetLength(0); i++)
                for (int j = 0; j < masivi.GetLength(1); j++)
                    if (masivi[i, j] % 2 == 1) masivi[i, j] *= 3;
        
        }

        public void Method_2(int[,] masivi)
        {
            for (int i = 0; i < masivi.GetLength(0); i++)
                for (int j = 0; j < masivi.GetLength(1); j++)
                    if (masivi[i, j] % 2 == 0) masivi[i, j] *= 2;
        }

        public void Method_3(int[,] masivi)
        {
            for (int i = 0; i < masivi.GetLength(0); i++)
                for (int j = 0; j < masivi.GetLength(1); j++)
                   masivi[i, j] *= 10;
        }

        public void Method_4(int[,] masivi)
        {
            for (int i = 0; i < masivi.GetLength(0); i++)
                for (int j = 0; j < masivi.GetLength(1); j++)
                    masivi[i, j] += 5;
        }

    }
}
