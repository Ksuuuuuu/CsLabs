using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _5_lab.Models.Loaders
{
    public abstract class Loader : MovableObj, ILoader
    {
        private readonly List<Detail> details;
        private object detailsLocker;

        //загруженные детали
        public List<Detail> loadedDetails;
        Action<string> message;

        public abstract string detailKind { get; set; }



        public Loader(float startX, float startY, List<Detail> details, object detailsLosker, float tox, float toy):
            base (startX, startY,tox, toy,startX, startY)
        {
            
            loadedDetails = new List<Detail>();
            this.details = details;
            this.detailsLocker = detailsLosker;
        }


        void load()
        {
            if (isEndOfWay())
            {
                message($"Погрузка деталей вида {detailKind} начата");

                Task.Delay(5 * 1000).Wait();
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
               loadedDetails = details.FindAll(d => d.detailKind == this.detailKind);
               int count = details.RemoveAll(d => d.detailKind == this.detailKind);
                if (count != 0)
                {
                    Action<Detail> action = d => d.waitLoading = true ;

                    loadedDetails.ForEach(action);
                    isLocked = true;
                    base.action = load; 
                   

                }
                
            }
        }

    }
}
