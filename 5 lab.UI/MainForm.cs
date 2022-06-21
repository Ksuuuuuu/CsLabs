using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _5_lab.Models.Loaders;
using _5_lab.Models;

namespace _5_lab.UI
{
    public partial class MainForm : Form
    {
        List<DrawObj> objects;
        object objectsLocker;

        List<DrawModel> models;
        object modelsLocker;

        DrawPicture paint;

        DrawObj home, storage, machine;
        List<Detail> details;
        object detailsLocker;

        List<Miller> millers;

        List<Loader> loaders;



        public MainForm()
        {
            InitializeComponent();


            objects = new List<DrawObj>();
            objectsLocker = new object();

            models = new List<DrawModel>();
            modelsLocker = new object();

            details = new List<Detail>();
            detailsLocker = new object();

            millers = new List<Miller>();
            loaders = new List<Loader>();
        }


        private void addDetailBtn_Click(object sender, EventArgs e)
        {

            InputDetail inputDetail = new InputDetail();

            if (inputDetail.ShowDialog() == DialogResult.OK)
            {
                string name = inputDetail.name;
                string kind = inputDetail.kind;
                
                Detail detail = new Detail(machine.X, machine.Y,
                   name, kind);

                details.Add(detail);
                //Task.Delay(10000);
                objects.Add(new DrawObj(Properties.Resources.Detail, machine.X - 50, machine.Y- 15));

                Task.Run(detail.start);
            }



        }

        private void addMillerBtn_Click(object sender, EventArgs e)
        {
            Miller miller = new Miller(details, detailsLocker, home.X, home.Y, printMessage);
            millers.Add(miller);

            models.Add(new DrawModel(miller, Properties.Resources.Miller));

            Task.Run(miller.start);


        }

        private void addLoaderBtn_Click(object sender, EventArgs e)
        {
            InputLoader inputLoader = new InputLoader();
            string kind = "";
            if (inputLoader.ShowDialog() == DialogResult.OK)
                kind = inputLoader.kind;

            Loader loader = null;
            Image imgL = null;
            Image imgM = Properties.Resources.Machine;
            if (kind == "Two")
            {
                imgL = Properties.Resources.LoaderKindSecond;
                loader = new LoaderKindTwo(storage.X, storage.Y, details,
                    detailsLocker, printMessage);
            }

            if (kind == "One")
            {
                imgL = Properties.Resources.LoaderKindFirst;
                loader = new LoaderKindOne(storage.X, storage.Y, details,
                    detailsLocker, printMessage);
            }


            loaders.Add(loader);

            models.Add(new DrawModel(loader, imgL));

            Task.Run(loader.start);

            models.RemoveAll(detail => detail.image == Properties.Resources.Detail);

        }

        void startMiller()
        {
            float startX = home.X;
            float startY = home.Y;

            Miller miller = new Miller(details, detailsLocker, startX, startY, printMessage);
            millers.Add(miller);

            models.Add(new DrawModel(miller, Properties.Resources.Miller));

            Task.Run(miller.start);


        }

        void startLoader()
        {

            Image imgL = Properties.Resources.LoaderKindFirst;
            Loader loader = new LoaderKindOne(storage.X, storage.Y, details,
                    detailsLocker, printMessage);

            loaders.Add(loader);

            models.Add(new DrawModel(loader, imgL));

            Task.Run(loader.start);

            


        }

        void startDetail()
        {
            string name = "Name1";
            string kind = "Kind One";

            Detail detail = new Detail(machine.X, machine.Y,
               name, kind);

            details.Add(detail);
            //Task.Delay(10000);
            objects.Add(new DrawObj(Properties.Resources.Detail, machine.X - 50, machine.Y - 15));

           // Task.Run(detail.start);
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {

            paint = new DrawPicture(PictureBox, objects, objectsLocker, models, modelsLocker);

            home = new DrawObj(Properties.Resources.Home);
            machine = new DrawObj(Properties.Resources.Machine);
            storage = new DrawObj(Properties.Resources.Storage);

            home.X = Properties.Resources.Home.Width / 2;
            home.Y = Properties.Resources.Home.Height / 2;

            machine.X = PictureBox.Width - Properties.Resources.Machine.Width / 2;
            machine.Y = (PictureBox.Height - Properties.Resources.Machine.Height / 2) - 170;

            storage.X = Properties.Resources.Storage.Width / 2;
            storage.Y = (PictureBox.Height - Properties.Resources.Storage.Height / 2) - 120;

            objects.Add(home);
            objects.Add(machine);
            objects.Add(storage);

            

            paint.start();
            startMiller();
           
            startDetail();
            //addDetailBtn_Click(sender, e);
            startLoader();
            //addLoaderBtn_Click(sender, e);
            //Task.Delay(5000);
            //objects.RemoveAll(detail => detail.image == Properties.Resources.Detail);
        }


        void printMessage(string message)
        {
            MessageBox.Invoke((MethodInvoker)delegate
            {
                MessageBox.Clear();
                MessageBox.Text += message;
            });
        }
    }
}
