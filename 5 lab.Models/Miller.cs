using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _5_lab.Models
{
    class Miller : MovableObj
    {
        private readonly List<Detail> details;
        private object detailsLocker;

        public Detail curDetail;
        
        public string detailKind { get; set; }
        private DateTime lastWork { get; set;}

        public Miller(List<Detail> details, object detailsLocker, 
            float defaultX, float defaultY, string detailKind): base(defaultX,defaultY)
        {
            this.detailKind = detailKind;
            this.details = details;
            this.detailsLocker = detailsLocker;

        }

        
        void Work()
        {
            if (IsCome())
            {
                Task.Delay(5 * 1000).Wait();

                curDetail.isReady = true;

                lastWork = DateTime.Now;

                DoSomething = null;
                IsLocked = false;

                ToX = defaultX;
                ToY = defaultY;
            }
        }

        protected override void CheckEvents()
        {
            if (IsLocked)
                return;
            lock (detailsLocker)
            {
                curDetail = details.Find(d => d.detailKind == this.detailKind && !d.waitProcessing);
                    
                if (curDetail != null)
                {
                    curDetail.waitProcessing = true;

                    IsLocked = true;
                    DoSomething = Work;
                }
            }
          
        }

    }
}