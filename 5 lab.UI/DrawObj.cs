using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace _5_lab.UI
{
    class DrawObj
    {
        //координаты центра картинки, сначала хотела через верхний левый угол цепляться, но через центр удобнее
        public virtual float X { get; set; }
        public virtual float Y { get; set; }

        public Image image { get; set; }

        public DrawObj(Image image)
        {
            this.image = image;
        }

        public DrawObj(Image image, float x, float y)
        {
            this.image = image;
            X = x;
            Y = y;
        }
    }
}
