using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    interface IDoctor
    {
        string Name { get; set; }
        int Experience { get; set; }

        string Statement();
        string Heal(string patient, string diagnosis);
    }
}
