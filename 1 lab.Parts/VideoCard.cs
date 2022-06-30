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
        bool IsOn { get; set; }

        public string GetData()
        {
            return "Модель: " + model + "\nОбъем: " + volume.ToString()+" ГБ";
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
