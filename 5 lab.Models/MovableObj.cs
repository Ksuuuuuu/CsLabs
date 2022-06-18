using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _5_lab.Models
{
    public abstract class MovableObj: Model
    {
        public float startX, startY;

        public float toX { get; internal set; }
        public float toY { get; internal set; }

        const int countPixels = 3;

        public Action action;

        public MovableObj(float x, float y, float startX,float  startY): base(x,y)
        {
            this.startX = startX;
            this.startY = startY;
            toX = startX;
            toY = startY;
        }


        protected abstract void check();

        public bool isEndOfWay()
        {

            return Math.Abs(X - toX) < 2 && Math.Abs(Y - toY) < 2;
        }

        public override void start()
        {
            while (!isCompleted)
            {
                check();
                move();

                action?.Invoke();

                Task.Delay(30).Wait();
            }


        }

        public void move()
        {
            if (isEndOfWay())
                return;

            if (X - toX != 0)
            {
                Y += countPixels * (toY - Y) / Math.Abs(X - toX);
                X += countPixels * Math.Sign(toX - X);
            }
            else
            {
                X += countPixels * (toX - X) / Math.Abs(Y - toY);
                Y += countPixels * Math.Sign(Y - toY);
            }
        }
    }
}
