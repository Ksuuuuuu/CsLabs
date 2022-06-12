using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parts
{
    public class Winchester
    {
        const int capacity = 256;
        int size { get; set; }
        bool isOn { get; set; }
        bool isVirus { get; set; }

        public Winchester()
        {
            size = 0;
            isOn = false;
            isVirus = false;
        }

        public void On()
        {
            isOn = true;
        }

        public void Off()
        {
            isOn = false;
        }
        public string getVolumeData()
        {
            return "Общий объем: " + capacity.ToString()+" ГБ" + "\nЗаполненная память: "
                + size.ToString() + " ГБ" + "\nСвободная память: " + (capacity - size).ToString() + " ГБ";
        }


        public bool checkVirus()
        {
            return isVirus;
        }

        public int download()
        {
            if (capacity == size)
                return -1;
            Random rnd = new Random();
            int value = rnd.Next() % (capacity - size)+1;
            size += value;
            isVirus = value % 2 != 0;
            return value;
        }
    }
}
