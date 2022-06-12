using System;
using System.Collections.Generic;

namespace ClassLibrary
{
   
    public abstract class Surgeon : IDoctor
    {
        public int countOperations;
        public string department;
        public List<string> Diseases { get; set; }
        public abstract int Experience { get; set; }
        public abstract string Name { get; set; }
        public virtual string Heal(string patient, string diagnosis)
        {
            countOperations++;
            return "+1 успешная операция!\n" + "Я вылечил " + patient + " от " + diagnosis;
        }
        public virtual string Statement()
        {
            return "Меня зовут " + Name + ". Я работаю в " + department + "\nИ я успешно провел " + countOperations + " операций.\n" +
                "Я работаю уже " + Experience + " лет.";
        }

    }
}
