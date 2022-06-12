using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Info
{
    public class Neurosurgeon: Surgeon
    {
        public Neurosurgeon(string name,int exp, int cO)
        {
            Name = name;
            Experience = exp;
            countOperations = cO;
        }
        public override int Experience { get; set; }
        public override string Name { get; set; }

       // public int CountOperatoins { get => countOperations; }
        public override string Statement()
        {
            return "Меня зовут "+Name+". Я нейрохихург.\n" + "И я успешно провел " + countOperations + " операций.\n" +
                "Я работаю уже " + Experience + " лет.";
        }
        public override void Heal()
        {
            countOperations++;
            
        }
    }
}
