using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using _5_lab.Models;

namespace _5_lab.UI
{
    class DrawModel: DrawObj
    {
        public Model Model { get; }

        public override float X { get => Model.X; }
        public override float Y { get => Model.Y; }

        public DrawModel (Model model, Image image)
            : base(image)
        {
            this.Model = model;
        }
    }
}
