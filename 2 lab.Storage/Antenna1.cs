using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Antenna1
    {
        private int Diam { get; set; }
        private string Matherial { get; set; }
        private double Cost { get; set; }

        public Antenna1(int d,string m, double c)
        {
            Diam = d;
            Matherial = m;
            Cost = c;
        }

        public virtual double getQuality()
        {
            return Diam / Cost;
        }

        public virtual string getData()
        {
            return "Диаметр " + Diam + "\nМатериал " + Matherial + "\nЦена " + Cost;
        }
    }
}
