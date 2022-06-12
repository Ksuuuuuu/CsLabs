using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parts
{
    public class Processor
    {
        string model = "intel core i5 9400f";
        int countCore = 6;
        bool isOn { get; set; }

        public string getData()
        {
            return "Модель процессора: " + model + "\nКол-во ядер: "
                + countCore.ToString();
        }

        public void On()
        {
            isOn = true;
        }

        public void Off()
        {
            isOn = false;
        }
    }
}
