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
        bool IsOn { get; set; }

        public string GetData()
        {
            return "Модель процессора: " + model + "\nКол-во ядер: "
                + countCore.ToString();
        }

        public void On()
        {
            IsOn = true;
        }

        public void Off()
        {
            IsOn = false;
        }
    }
}
