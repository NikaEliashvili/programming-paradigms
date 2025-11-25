using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memkvidreobitoba_Inheritance_
{
    internal class Kvadrati
    {
        public int gverdi_1;
        protected int perimeter;
        private int area;

        public Kvadrati(int gverdi_1)
        {
            this.gverdi_1 = gverdi_1;
        }

        public int GetPerimeterKvadrati() {
            this.perimeter = 4 * this.gverdi_1;
            return this.perimeter;    
        }

        public int GetAreaKvadrati()
        {
            this.area = this.gverdi_1 * this.gverdi_1;
            return this.area;
        }

    }


    internal class Martkutxedi : Kvadrati
    {
        public int gverdi_2;
        private int area;
        public Martkutxedi(int gverdi_1, int gverdi_2):base(gverdi_1)
        {
            this.gverdi_2 = gverdi_2;
        }

        public int GetPerimeterMartkutxedi()
        {
            this.perimeter = 2 * (this.gverdi_1 + this.gverdi_2);
            return this.perimeter;
        }

        public int GetAreaMartkutxedi()
        {
            this.area = this.gverdi_1 * this.gverdi_2;
            return this.area;
        }

    }

    internal class Samkutxedi : Martkutxedi
    {
        public int gverdi_3;
        private double area;

        public Samkutxedi(int gverdi_1, int gverdi_2, int gverdi_3):base(gverdi_1, gverdi_2)
        {
            this.gverdi_3 = gverdi_3;
        }

        public int GetPerimeterSamkutxedi()
        {
           this.perimeter = this.gverdi_1 + this.gverdi_2 + this.gverdi_3;
            return this.perimeter;
        }

        public double GetAreaSamkutxedi()
        {
            this.area = (this.gverdi_1 * this.gverdi_2) / 2.0;
            return this.area;
        }


    }


}
