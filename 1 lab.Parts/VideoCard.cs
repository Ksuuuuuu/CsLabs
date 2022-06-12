using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parts
{
    public class VideoCard
    {
        string model = "GeForce GTX 1050 Ti";
        int volume = 4;
        bool isOn { get; set; }

        public string getData()
        {
            return "Модель: " + model + "\nОбъем: " + volume.ToString()+" ГБ";
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
