using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_2
{
    internal class Samkutxedi
    {
        protected int gverdi_1, gverdi_2, gverdi_3;

        public Samkutxedi(int gverdi_1, int gverdi_2, int gverdi_3)
        {
            this.gverdi_1 = gverdi_1;
            this.gverdi_2 = gverdi_2;
            this.gverdi_3 = gverdi_3;
        }

    }


    internal class SamkutxediChild : Samkutxedi
    {
        private int perimeter;

        public SamkutxediChild(int gverdi_1, int gverdi_2, int gverdi_3)
            :base(gverdi_1, gverdi_2, gverdi_3)
        {

        }

        public double GetArea()
        {
            return (this.gverdi_1 * this.gverdi_2) / 2.0;
        }

        public int GetPerimeter()
        {
            this.perimeter = this.gverdi_1 + this.gverdi_2 + this.gverdi_3;
            return this.perimeter;
        }

    }

}
