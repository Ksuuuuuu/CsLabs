using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace _5_lab.Models
{
    abstract public class Model
    {
        public float X { get; set; }
        public float Y { get; set; }

        public bool isLocked { get;  set; }

        public bool isCompleted { get; set; }

        public abstract void start();

        public Model(float x, float y)
        {
            X = x;
            Y = y;
        }
    }
}
