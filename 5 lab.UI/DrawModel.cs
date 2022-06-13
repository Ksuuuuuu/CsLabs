using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using _5_lab.Models;

namespace _5_lab.UI
{
    class DrawModel: DrawObj
    {
        public Model model { get; }

        public override float X { get => model.X; }
        public override float Y { get => model.Y; }

        public DrawModel (Model model, Image image)
            : base(image)
        {
            this.model = model;
        }
    }
}
