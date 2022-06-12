using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Info
{
    public interface IDoctor
    {
        string Name { get; set; }
        int Experience { get; set; }
        string Statement();
        void Heal();
    }
}
