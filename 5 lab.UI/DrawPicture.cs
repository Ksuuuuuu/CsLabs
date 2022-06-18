using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace _5_lab.UI
{
    class DrawPicture
    {
        private PictureBox pictureBox;
        Bitmap bitmap;

        List<DrawObj> objects;
        private object objectsLocker;

        private List<DrawModel> models;
        private object modelsLocker;

        private Graphics graphics;

        Timer timer;

        public DrawPicture(PictureBox pictureBox,
            List<DrawObj> objects, object objectsLocker,
            List<DrawModel> models, object modelsLocker)
        {
            this.pictureBox = pictureBox;
            this.objects = objects;
            this.objectsLocker = objectsLocker;
            this.models = models;
            this.modelsLocker = modelsLocker;
            bitmap = new Bitmap(pictureBox.Width, pictureBox.Height);
            graphics = Graphics.FromImage(bitmap);

            timer = new Timer();
            timer.Interval = 40;
            start();

            timer.Tick += new EventHandler((obj, e) =>
            {
                graphics.Clear(Color.White);

                lock (objectsLocker)
                {
                    foreach (var elem in objects)
                    {
                        draw(elem);
                    }
                }

                lock (modelsLocker)
                {
                    foreach (var elem in models)
                    {
                        draw(elem);
                    }
                }

                pictureBox.Image = bitmap;
            });
        }


        void draw(DrawObj obj)
        {


            graphics.DrawImage(obj.image, obj.X - obj.image.Width / 2, obj.Y - obj.image.Height / 2);
        }

        public void start()
        {
            timer.Start();
        }

        public void stop()
        {
            timer.Stop();
        }

    }
}
