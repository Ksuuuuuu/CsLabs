using System;
using System.Collections.Generic;
using System.Text;

namespace _5_lab.Models.Loaders
{
    class LoaderKindFirst: Loader
    {
        public override string detailKind { get => "Kind One"; }

        public LoaderKindFirst(float defaultX, float defaultY, List<Detail> details, object detailLosker, float tox, float toy) :
            base(defaultX, defaultY, details, detailLosker, tox, toy)
        {

        }
    }
}
