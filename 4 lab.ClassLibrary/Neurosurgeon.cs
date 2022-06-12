using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    class Neurosurgeon : Surgeon
    {
        public Neurosurgeon()
        {
            Name ="-";
            department = "Нейрохирургия";
            Diseases = new List<string>
            {
                "Дисфункция сосудов головного мозга",
                "Неврологический синдром",
                "Новообразование головного мозга"
            };
        }
        public override int Experience { get; set; }

       
        public override string Name { get; set; }


    }
}
