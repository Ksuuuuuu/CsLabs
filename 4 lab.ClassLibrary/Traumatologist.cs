using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    class Traumatologist : Surgeon
    {
        public Traumatologist()
        {
            Name = "-";
            department = "Травмотология";
            Diseases = new List<string>
            {
                "Перелом",
                "Дисплазия суставов",
                "Сколиоз"
            };
        }

        public override int Experience { get; set; }
        public override string Name { get; set; }
    }
}
