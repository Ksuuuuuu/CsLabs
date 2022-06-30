using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Parts;

namespace Device
{
    public class Computer
    {
        string model = "ASUS";
        Winchester Winchester;
        RamMemory RamMemory;
        Processor Processor;
        VideoCard VideoCard;

        public Computer()
        {
            Winchester = new Winchester();
            RamMemory = new RamMemory();
            Processor = new Processor();
            VideoCard = new VideoCard();
        }

        public bool On()
        {
            Winchester.On();
            RamMemory.On();
            Processor.On();
            VideoCard.On();
            return true;
        }

        public bool Off()
        {
            Winchester.Off();
            RamMemory.Off();
            Processor.Off();
            VideoCard.Off();
            return false;
        }

        public bool СheckViruC()
        {
            return Winchester.CheckVirus();
        }

        public int Download()
        {
            return Winchester.Download();
        }

        public string GetData()
        {
            return "Модель: " + model + "\nДанные о жестком диске\n" + Winchester.GetVolumeData() +
                "\nДанные об оперативной памяти\n" + RamMemory.GetData() +
                "\nДанные о процессоре\n" + Processor.GetData() +
                "\nДанные о видеокарте\n" + VideoCard.GetData();
        }

      
    }
}
