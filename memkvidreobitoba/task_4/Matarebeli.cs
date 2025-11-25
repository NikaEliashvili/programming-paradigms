using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_4
{
    internal class Matarebeli
    {
        protected double speed, hours;

        public Matarebeli(double speed, double hours)
        {
            this.speed = speed;
            this.hours = hours;
        }

    }

    internal class Memkvidre_1:Matarebeli
    {
        public double distance;
        public Memkvidre_1(double speed, double hours) :base(speed, hours) {
            distance = this.speed * this.hours;
        }
    }

    internal class Memkvidre_2 : Memkvidre_1
    {
        public double usedEnergy;
        public Memkvidre_2(double energyPerKM, double speed, double hours) :
            base(speed, hours)
        {
            usedEnergy = energyPerKM * this.distance;
        }
    }

}
