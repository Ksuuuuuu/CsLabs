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

        List<Models.Loaders.Loader> loaders;
       
      

        public MainForm()
        {
            InitializeComponent();


            objects = new List<DrawObj>();
            objectsLocker = new object();

            models = new List<DrawModel>();
            modelsLocker = new object();

            details = new List<Detail>();
            detailsLocker = new object();

            //doctorTypes = Assembly.Load("Lab5.Models").GetTypes()
            //    .Where(type => !type.IsAbstract && type.GetInterface("IDoctor") != null);

            millers= new List<Miller>();
            loaders = new List<Models.Loaders.Loader>();
        }


        private void addDetailBtn_Click(object sender, EventArgs e)
        {
            
            InputDetail inputDetail = new InputDetail();

            if (inputDetail.ShowDialog() == DialogResult.OK)
            {
                string name = inputDetail.name;
                string kind = inputDetail.kind;
                Detail detail = new Detail(machine.X, machine.Y,
                   name , kind);


                objects.Add(new DrawObj(Properties.Resources.Detail, machine.X - 50, machine.Y));

                Task.Run(detail.start);
            }

           

        }

        private void addMillerBtn_Click(object sender, EventArgs e)
        {

        }

        private void addLoaderBtn_Click(object sender, EventArgs e)
        {
            InputLoader inputLoader = new InputLoader();
            string kind = "";
            if (inputLoader.ShowDialog() == DialogResult.OK)
                kind = inputLoader.kind;

            Loader loader = null;
            Image imgL = null;
            Image imgM = Properties.Resources.machine;
            if (kind == "Two")
            {
                imgL = Properties.Resources.LoaderKindSecond;
                loader = new LoaderKindTwo(storage.X, storage.Y, details,
                    detailsLocker, machine.X - imgM.Width/2, machine.Y);
            }

            if (kind == "One")
            {
                imgL = Properties.Resources.LoaderKindFirst;
                loader = new LoaderKindOne(storage.X, storage.Y, details,
                    detailsLocker, machine.X - imgM.Width / 2, machine.Y);
            }


            loaders.Add(loader);

            models.Add(new DrawModel(loader, imgL));

            Task.Run(loader.start);

        }

        void startMiller()
        {
            float startX = home.X;
            float startY = home.Y;

            float toX = machine.X;
            float toY = machine.Y;



            Miller miller = new Miller(details, detailsLocker, startX, startY, toX, toY, startX, startY);
            millers.Add(miller);

            models.Add(new DrawModel(miller, Properties.Resources.Miller));

            Task.Run(miller.start);


        }

        private void StartBtn_Click(object sender, EventArgs e)
        {

            paint = new DrawPicture(PictureBox, objects, objectsLocker, models, modelsLocker);


            home = new DrawObj(Properties.Resources.home);
            machine = new DrawObj(Properties.Resources.machine);
            storage = new DrawObj(Properties.Resources.Storage);

            home.X = Properties.Resources.home.Width / 2;
            home.Y = Properties.Resources.home.Height / 2;

            machine.X = PictureBox.Width - Properties.Resources.machine.Width / 2;
            machine.Y = (PictureBox.Height - Properties.Resources.machine.Height / 2) - 170;

            storage.X = Properties.Resources.Storage.Width / 2;
            storage.Y = (PictureBox.Height - Properties.Resources.Storage.Height / 2)- 120;

            objects.Add(home);
            objects.Add(machine);
            objects.Add(storage);


            addDetailBtn_Click(sender, e);

            startMiller();

            addLoaderBtn_Click(sender, e);


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
