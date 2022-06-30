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
        int Size { get; set; }
        bool IsOn { get; set; }
        bool IsVirus { get; set; }

        public Winchester()
        {
            Size = 0;
            IsOn = false;
            IsVirus = false;
        }

        public void On()
        {
            IsOn = true;
        }

        public void Off()
        {
            IsOn = false;
        }
        public string GetVolumeData()
        {
            return "Общий объем: " + capacity.ToString()+" ГБ" + "\nЗаполненная память: "
                + Size.ToString() + " ГБ" + "\nСвободная память: " + (capacity - Size).ToString() + " ГБ";
        }


        public bool CheckVirus()
        {
            return IsVirus;
        }

        public int Download()
        {
            if (capacity == Size)
                return -1;
            Random rnd = new Random();
            int value = rnd.Next() % (capacity - Size)+1;
            Size += value;
            IsVirus = value % 2 != 0;
            return value;
        }
    }
}
