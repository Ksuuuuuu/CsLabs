using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace _5_lab.Models
{
    public abstract class MovableObj: Model
    {
        public float defaultX, defaultY;

        public float ToX { get; internal set; }
        public float ToY { get; internal set; }

        const float maxSpeed = 3;

        public Action DoSomething;

        public MovableObj(float x, float y,float tox, float toy, float defaultX,float  defaultY): base(x,y)
        {
            ToX = tox;
            ToY = toy;
            this.defaultX = defaultX;
            this.defaultY = defaultY;
        }


        protected abstract void CheckEvents();

        public bool IsCome()
        {

            return Math.Abs(X - ToX) < 2 && Math.Abs(Y - ToY) < 2;
        }

        public override void Start()
        {
            while (!IsCanceled)
            {
                CheckEvents();
                Go();

                DoSomething?.Invoke();

                Task.Delay(30).Wait();
            }


        }

        public void Go()
        {
            if (IsCome())
                return;

            if (X - ToX != 0)
            {
                Y += maxSpeed * (ToY - Y) / Math.Abs(X - ToX);
                X += maxSpeed * Math.Sign(ToX - X);
            }
            else
            {
                X += maxSpeed * (ToX - X) / Math.Abs(Y - ToY);
                Y += maxSpeed * Math.Sign(Y - ToY);
            }
        }
    }
}
