using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Info;

namespace _3_лаб
{
    public partial class UserForm : Form
    {
        int count = 0;
       
        List<IDoctor> list=new List<IDoctor>();
        public UserForm()
        {
            InitializeComponent();
        }

        public void add(IDoctor doctor)
        {
            list.Add(doctor);
        }

        void show()
        {
            List.Items.Clear();
            foreach (IDoctor d in list)
            {
                List.Items.Add(d.Name);
            }
            
        }

        private void UserForm_Load(object sender, EventArgs e)
        {
            if (List.Items.Count==0)
            {
                Delete.Enabled = false;
                Heal.Enabled = false;
                Data.Enabled = false;
                //Search.Enabled = false;
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            InputForm f2 = new InputForm(false);
            f2.Owner = this;
            f2.ShowDialog();
            show();
            count++;
            Delete.Enabled = true;
            //Search.Enabled = true;
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (count!=0)
            {
                list.RemoveAt(List.SelectedIndex);
                show();
                count--;
            }
        }

        private void List_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            InputForm f2 = new InputForm(true,list[List.SelectedIndex]);
            f2.Owner = this;
            f2.ShowDialog();
        }

        private void List_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (List.SelectedIndex<0)
            {
                Heal.Enabled = false;
                Data.Enabled = false;
            }
            else
            {
                Heal.Enabled = true;
                Data.Enabled = true;
            }
        }

        private void Heal_Click(object sender, EventArgs e)
        {

            if (List.SelectedIndex >= 0)
            {
                list[List.SelectedIndex].Heal();
                MessageBox.Show("+1 успешная операция!");
            }
        }

        private void Data_Click(object sender, EventArgs e)
        {
            if (List.SelectedIndex >= 0)
                MessageBox.Show(list[List.SelectedIndex].Statement());
        }





    }
}
