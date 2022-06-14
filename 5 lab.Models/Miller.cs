using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _5_lab.Models
{
    public class Miller : MovableObj
    {
        private readonly List<Detail> details;
        private object detailsLocker;

        public Detail curDetail;
        
        //public string detailKind { get; set; }

        public Miller(List<Detail> details, object detailsLocker, float x, float y, float tox, float toy,
            float defaultX, float defaultY): base(x, y, tox, toy, defaultX, defaultY)
        {
            //this.detailKind = detailKind;
            this.details = details;
            this.detailsLocker = detailsLocker;

        }

        
        void work()
        {
            if (isEndOfWay())
            {
                Task.Delay(5 * 1000).Wait();

                curDetail.isReady = true;

               

                action = null;
                isLocked = false;

                toX = startX;
                toY = startY;
            }
        }

        protected override void check()
        {
            if (isLocked)
                return;
            lock (detailsLocker)
            {
                curDetail = details.Find(d =>  !d.waitProcessing);
                    
                if (curDetail != null)
                {
                    
                    curDetail.waitProcessing = true;

                    isLocked = true;
                    action = work;
                }
            }
          
        }

    }
}