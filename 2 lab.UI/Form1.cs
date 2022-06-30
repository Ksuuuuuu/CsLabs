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
    public partial class Form1 : Form
    {
        public Antenna1 antenna;
        public int level;
        public Form1()
        {
            InitializeComponent();
        }

        private void Input_Click(object sender, EventArgs e)
        {
            InputForm f2 = new InputForm(level);
            f2.Owner = this;
            f2.ShowDialog();
            Output.Enabled = true;
        }

        private void Level_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Уровень- "+level+"\n"+antenna.GetData() + "\nКачество " + antenna.GetQuality(),"Данные",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
