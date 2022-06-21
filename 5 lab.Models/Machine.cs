using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _5_lab.Models
{
    class Machine : Model
    {
        public Detail curDetail;
        object DetailLocker;

        public List<Detail> preparedDetails;

    

        public Machine(Detail detail, object detailLocker, float x, float y): base(x,y)
        {
            curDetail = detail;
            DetailLocker = detailLocker;
           
            preparedDetails = new List<Detail>();
        }

        void processingDetail()
        {
           // message($"Обработка детали {curDetail.Name} началась");
            Task.Delay(7000).Wait();

           // message($"Обработка детали {curDetail.Name} закончилась");
            curDetail.isReady = true;

            preparedDetails.Add(curDetail);
        }

        public override void start()
        {
            while (!isCompleted)
            {
               // message("Обработка детали");
                Task.Delay(4000).Wait();

                processingDetail();

                Task.Delay(3000).Wait();
            }
        }
    }
}

