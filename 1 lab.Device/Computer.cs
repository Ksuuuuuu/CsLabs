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

        public bool checkVirus()
        {
            return Winchester.checkVirus();
        }

        public int download()
        {
            return Winchester.download();
        }

        public string getData()
        {
            return "Модель: " + model + "\nДанные о жестком диске\n" + Winchester.getVolumeData() +
                "\nДанные об оперативной памяти\n" + RamMemory.getData() +
                "\nДанные о процессоре\n" + Processor.getData() +
                "\nДанные о видеокарте\n" + VideoCard.getData();
        }

      
    }
}
