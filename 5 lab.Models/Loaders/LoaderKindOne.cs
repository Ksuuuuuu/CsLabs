using System;
using System.Collections.Generic;
using System.Text;

namespace _5_lab.Models.Loaders
{
    public class LoaderKindOne: Loader
    {
        string kind= "Kind One";
        public override string detailKind { get => kind; set => kind = value; }

        public LoaderKindOne(float defaultX, float defaultY, List<Detail> details, object detailLosker, float tox, float toy) :
            base(defaultX, defaultY, details, detailLosker, tox, toy)
        {

        }
    }
}
