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
        bool IsOn { get; set; }

        public void On()
        {
            IsOn = true;
        }

        public void Off()
        {
            IsOn = false;
        }

        public string GetData()
        {
            return "Объем: " + capacity.ToString()+" ГБ";
        }
    }
}
