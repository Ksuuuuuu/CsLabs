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
        Action<string> message;

        //public string detailKind { get; set; }

        public Miller(List<Detail> details, object detailsLocker, float x, float y,
            Action<string> message) :
            base(x, y, x,y)
        {
            this.details = details;
            this.detailsLocker = detailsLocker;
            this.message = message;
        }

        void work()
        {
            if (isEndOfWay())
            {
                message($"Делаю деталь {curDetail.Name} вида { curDetail.detailKind}");
                Task.Delay(5 * 1000).Wait();
                message($"Сделал деталь {curDetail.Name} вида { curDetail.detailKind}");

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
                curDetail = details.Find(d => !d.waitProcessing);

                if (curDetail != null)
                {
                    message($"Иду делать деталь {curDetail.Name} вида { curDetail.detailKind}");
                    curDetail.waitProcessing = true;

                    isLocked = true;

                    toX = curDetail.X;
                    toY = curDetail.Y;
                    action = work;
                }
            }

        }

    }
}