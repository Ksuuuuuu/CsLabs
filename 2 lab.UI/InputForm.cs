using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using lab2;

namespace _2_лаба__полиморфизм_
{
    public partial class InputForm : Form
    {
        Antenna1 antenna;
        int level;
        public InputForm(int level)
        {
            InitializeComponent();
            this.level = level;
        }
        public void readDataFirstLevel()
        {
            int d = int.Parse(diamBox.Text);
            string m = MatherialBox.Text;
            double c = double.Parse(CostBox.Text);
            antenna = new Antenna1(d, m, c);
        }

        public void readDataSecondLevel()
        {
            int d = int.Parse(diamBox.Text);
            string m = MatherialBox.Text;
            double c = double.Parse(CostBox.Text);

            string str = TypeBox.Text;
            SuspensionType t=default;
            switch(str)
            {
                case "азимутальная":
                    t = SuspensionType.Azimuthal;
                    break;
                case "полярная":
                    t = SuspensionType.Polar;
                    break;
                case "тороидальная":
                    t = SuspensionType.Toroidal;
                    break;
                default:
                    MessageBox.Show("error");
                    TypeBox.Text = "";
                    break;
            }

            antenna = new Antenna2(d, m, c,t);
        }

        private void Save_Click(object sender, EventArgs e)
        {
            if (Level1r.Checked == true)
            {
                readDataFirstLevel();
            }
            if (Level2r.Checked == true)
            {
                readDataSecondLevel();
            }
            Form1 f1 = this.Owner as Form1;
            f1.antenna = this.antenna;
            f1.level = this.level;
            this.Close();
            f1.Enabled = true;
        }

        private void Level1r_Click(object sender, EventArgs e)
        {
            diamBox.Enabled = true;
            MatherialBox.Enabled = true;
            CostBox.Enabled = true;
            level = 1;
        }

        private void Level2r_Click(object sender, EventArgs e)
        {
            Level1r_Click(sender, e);
            TypeBox.Enabled = Level2r.Checked;
            level = 2;
        }
    }
}
