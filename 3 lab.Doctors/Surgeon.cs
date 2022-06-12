using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Info
{
    public abstract class Surgeon : IDoctor
    {
        public int countOperations;
        public abstract int Experience { get; set; }
        public abstract string Name { get; set; }
        public abstract void Heal();
       public abstract string Statement();



    }
}
