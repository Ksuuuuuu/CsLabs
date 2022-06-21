using System;
using System.Collections.Generic;
using System.Text;

namespace _5_lab.Models.Loaders
{
    public class LoaderKindTwo : Loader
    {
        string kind = "Kind Two";
        public override string DetailKind { get => kind; set => kind = value; }

        public LoaderKindTwo(float defaultX, float defaultY, List<Detail> details, object detailLosker, Action<string> message) :
            base(defaultX, defaultY, details, detailLosker, message)
        {

        }
    }
}
