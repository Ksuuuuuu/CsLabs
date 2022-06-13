﻿using System;
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

        private  Graphics graphics;

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
            timer.Interval = 20;

            timer.Tick += new EventHandler((obj, e) =>
            {
                graphics.Clear(Color.White);

                lock (objectsLocker)
                {
                    foreach (var elem in objects)
                    {
                        Draw(elem);
                    }
                }

                lock (modelsLocker)
                {
                    foreach (var elem in models)
                    {
                        Draw(elem);
                    }
                }

                pictureBox.Image = bitmap;
            });
        }


        void Draw(DrawObj obj)
        {
           

            graphics.DrawImage(obj.image,obj.X, obj.Y);
        }

        public void Start()
        {
            timer.Start();
        }

        public void Stop()
        {
            timer.Stop();
        }

    }
}
