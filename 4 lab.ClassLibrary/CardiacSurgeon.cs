using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    class CardiacSurgeon : Surgeon
    {

        public CardiacSurgeon()
        {
            Name ="-";
            department = "Кардиохирургия";
            Diseases = new List<string>
            {
                "Ишемическая болезнь",
                "Порок сердца",
                "Сердечная недостаточность"
            };
        }

        public override int Experience { get; set; }
        public override string Name { get; set; }
    }
}
