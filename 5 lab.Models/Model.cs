using System;
using System.Collections.Generic;
using System.Text;

namespace _5_lab.Models
{
    abstract public class Model
    {
        public float X { get; set; }
        public float Y { get; set; }

        public bool IsLocked { get;  set; }

        public bool IsCanceled { get; set; }

        public abstract void Start();
    }
}
