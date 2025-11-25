using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    internal class Figure
    {
        public int gverdi_1, gverdi_2, gverdi_3;
        public Figure(int gverdi_1)
        {
            this.gverdi_1 = gverdi_1; 
        }

        public Figure(int gverdi_1, int gverdi_2, int gverdi_3)
        {
            this.gverdi_1 = gverdi_1;
            this.gverdi_2 = gverdi_2;
            this.gverdi_3 = gverdi_3;
        }

    }

    internal class Samkutxedi : Figure
    {
        public int perimetri;
        public Samkutxedi(int gverdi_1, int gverdi_2, int gverdi_3) : 
            base(gverdi_1, gverdi_2, gverdi_3)
        {
            perimetri = gverdi_1 + gverdi_2 + gverdi_3;
        }
    }

    internal class Kvadrati : Figure
    {
        public int fartobi;
        public Kvadrati(int gverdi_1) :
            base(gverdi_1)
        {
            fartobi = gverdi_1 * gverdi_1;
        }
    }

}
