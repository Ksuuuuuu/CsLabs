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



        public Loader(float startX, float startY, List<Detail> details, object detailsLosker, Action<string> message) :
            base(startX, startY, startX, startY)
        {
            this.details = details;
            this.detailsLocker = detailsLosker;
            this.message = message;
        }

        void load()
        {
            if (isEndOfWay())
            {
                message($"Погрузка деталей вида {detailKind} начата");
                Task.Delay(5 * 1000).Wait();
                action = GoToStorage;

                toX = startX;
                toY = startY;

                message($"Детали вида {detailKind} доставляются на склад");

            }
        }


        void GoToStorage()
        {
            if (isEndOfWay())
            {
                action = null;
                isLocked = false;

                message($"Детали вида {detailKind} доставлены на склад");
            }
            else
                details.ForEach(d =>
                {
                    d.X = X;
                    d.Y = Y;
                });
        }

        protected override void check()
        {
            if (isLocked)
                return;

            lock (detailsLocker)
            {
                loadedDetails = details.FindAll(d => d.detailKind == this.detailKind && !d.waitLoading && d.isReady);
                details.RemoveAll(d => d.detailKind == this.detailKind && !d.waitLoading && d.isReady);
                if (loadedDetails.Count > 0)
                {
                    message($"Иду погружать детали типа {detailKind}");

                    Action<Detail> action = d => d.waitLoading = true;

                    loadedDetails.ForEach(action);
                    isLocked = true;
                    toX = loadedDetails[0].X - 300;
                    toY = loadedDetails[0].Y - 50;
                    base.action = load;
                }

            }
        }

    }
}
