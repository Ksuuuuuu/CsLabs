using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _5_lab.Models.Loaders
{
    abstract class Loader : MovableObj, ILoader
    {
        private readonly List<Detail> details;
        private  object detailsLocker;

        //загруженные детали
        public List<Detail> loadedDetails;
        Action<string> message;

        abstract public string detailKind { get; };

        public Loader(float defaultX, float defaultY, List<Detail> details, object detailLosker, float tox, float toy):
            base (tox,toy,defaultX, defaultY)
        {
            loadedDetails = new List<Detail>();
            this.details = details;
            this.detailsLocker = detailsLocker;
        }


        void load()
        {
            if (IsCome())
            {
                message($"Погрузка деталей вида {detailKind} начата");

                Task.Delay(5 * 1000).Wait();
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
               loadedDetails = details.FindAll(d => d.detailKind == this.detailKind);
               int count = details.RemoveAll(d => d.detailKind == this.detailKind);
                if (count != 0)
                {
                    Action<Detail> action = d => d.waitLoading = true ;

                    loadedDetails.ForEach(action);
                    IsLocked = true;
                    DoSomething = load; 
                   

                }
                
            }
        }

    }
}
