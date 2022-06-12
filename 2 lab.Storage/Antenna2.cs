using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
   public  enum SuspensionType
    {
        Azimuthal, Polar, Toroidal
    }
    public class Antenna2: Antenna1
    {
        private SuspensionType Type { get; set; }

        public Antenna2(int d, string m, double c, SuspensionType t): base(d, m, c)
        {
            Type = t;
        }

        public override double getQuality()
        {
            if (Type == SuspensionType.Azimuthal)
                return base.getQuality();
            if (Type==SuspensionType.Polar)
                return 2*base.getQuality();
            if (Type == SuspensionType.Toroidal)
                return 2.5 * base.getQuality();
            return 0;
        }

        public override string getData()
        {
            return base.getData() + "\nТип подвески " + Type;
        }
    }
}
