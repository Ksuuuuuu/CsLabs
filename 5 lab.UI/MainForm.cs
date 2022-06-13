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
                Detail detail = new Detail(machine.X + Properties.Resources.Machine.Width / 2, machine.Y + Properties.Resources.Machine.Height / 2,
                   name , kind);


                objects.Add(new DrawObj(Properties.Resources.Detail));

                Task.Run(detail.Start);
            }

           

        }

        private void addMillerBtn_Click(object sender, EventArgs e)
        {

        }

        private void addLoaderBtn_Click(object sender, EventArgs e)
        {
            InputLoader inputLoader = new InputLoader();
            string kind="";
            if (inputLoader.ShowDialog() == DialogResult.OK)
                kind = inputLoader.kind;


            IEnumerable<Type> nameClasses = Assembly.Load("5 lab.Models").GetTypes().Where(type => !type.IsAbstract && !type.IsInterface && type.Name.Contains(kind));
            ConstructorInfo method = nameClasses.First<Type>().GetConstructor(new Type[] { typeof(float), typeof(float),
                typeof(List < Detail >), typeof(object), typeof(float), typeof(float)});

            Image imgM = Properties.Resources.Machine;
            Image imgS = Properties.Resources.Storage;
            Image imgL;

            if (kind == "Two")
                imgL = Properties.Resources.LoaderKindSecond;
            else
                imgL = Properties.Resources.LoaderKindFirst;


            
                _5_lab.Models.Loaders.Loader loader = (Models.Loaders.Loader)method.Invoke(new object[] { storage.X - imgS.Width/2, imgS.Height / 2, details,
                    detailsLocker, machine.X -imgM.Width/2, machine.Y - imgM.Height/2 });
                loaders.Add(loader);

                models.Add(new DrawModel(loader, imgL));

                Task.Run(loader.Start);

        }

        void startMiller()
        {
            float startX = Properties.Resources.Home.Width / 2;
            float startY = Properties.Resources.Home.Height / 2;

            float toX = machine.X + Properties.Resources.Machine.Width / 2;
            float toY = machine.Y + Properties.Resources.Machine.Height / 2;



            Miller miller = new Miller(details, detailsLocker, startX, startY, toX, toY, startX, startY);
            millers.Add(miller);

            models.Add(new DrawModel(miller, Properties.Resources.Miller));

            Task.Run(miller.Start);


        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            paint = new DrawPicture(PictureBox, objects, objectsLocker, models, modelsLocker);


            home = new DrawObj(Properties.Resources.Home);
            machine = new DrawObj(Properties.Resources.Machine);
            storage = new DrawObj(Properties.Resources.Storage);

            home.X = 0;
            home.Y = 0;

            machine.X = PictureBox.Width - Properties.Resources.Machine.Width;
            machine.Y = PictureBox.Height - Properties.Resources.Machine.Height-20;

            storage.X = PictureBox.Width - Properties.Resources.Storage.Width;
            storage.Y = 0;

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
