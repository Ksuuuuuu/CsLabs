using System;
using System.Collections.Generic;
using System.Text;

namespace _5_lab.Models
{

    class Detail
    {
        public string Name { get; set; }
        //public float X { get; set; }
        //public float Y { get; set; }

        public bool isReady { get; set; }
        public string detailKind { get; set; }

        public bool waitProcessing { get; set; }

        public bool waitLoading { get; set; }
    }
}