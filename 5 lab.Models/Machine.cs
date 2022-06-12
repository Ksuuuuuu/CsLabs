using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _5_lab.Models
{
    class Machine : Model
    {
        public Detail curDetail;
        object DetailLocker;

        public List<Detail> preparedDetails;

        public Action<string> notification;

        public Machine(Detail detail, object detailLocker, float x, float y)
        {
            curDetail = detail;
            DetailLocker = detailLocker;
            X = x;
            Y = y;
            preparedDetails = new List<Detail>();
        }

        void processingDetail()
        {
            notification($"Обработка детали {curDetail.Name} началась");
            Task.Delay(7000).Wait();

            notification($"Обработка детали {curDetail.Name} закончилась");
            curDetail.isReady = true;

            preparedDetails.Add(curDetail);
        }

        public override void Start()
        {
            while (!IsCanceled)
            {
                notification("Обработка детали");
                Task.Delay(4000).Wait();

                processingDetail();

                Task.Delay(3000).Wait();
            }
        }
    }
}
