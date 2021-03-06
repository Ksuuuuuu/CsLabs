using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _5_lab.Models
{

    public class Detail: Model
    {
        public string Name { get; set; }

        public bool isReady { get; set; }
        public string detailKind { get; set; }

        public bool waitProcessing { get; set; }

        public bool waitLoading { get; set; }


        public Detail(float x, float y,string name, string detailKind): base(x,y)
        {
            Name = name;
            this.detailKind = detailKind;
            isReady = false;
            waitProcessing = false;
            waitLoading = false;
        }

        public override void start()
        {

        }
    }
}