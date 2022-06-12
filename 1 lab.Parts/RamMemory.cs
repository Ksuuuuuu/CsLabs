using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parts
{
    public class RamMemory
    {
        const int capacity = 8;
        bool isOn { get; set; }

        public void On()
        {
            isOn = true;
        }

        public void Off()
        {
            isOn = false;
        }

        public string getData()
        {
            return "Объем: " + capacity.ToString()+" ГБ";
        }
    }
}
