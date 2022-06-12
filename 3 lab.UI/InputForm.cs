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
    public partial class InputForm : Form
    {
        IDoctor doctor;
        bool Readonly;
        public InputForm(bool read, IDoctor d=null)
        {
            InitializeComponent();
            Readonly = read;
            doctor = d;
        }
         private void read()
        {
            string name = FioBox.Text;
            int exp = Int32.Parse(ExpBox.Text);
            int op = Int32.Parse(OpBox.Text);
            doctor = new Neurosurgeon(name, exp, op);
        }
        private void Save_Click(object sender, EventArgs e)
        {
            read();
            UserForm f = this.Owner as UserForm;
            f.add(doctor);
            this.Close();
        }

        private void InputForm_Load(object sender, EventArgs e)
        {
            if (Readonly)
            {
                FioBox.Text = doctor.Name;
                ExpBox.Text = doctor.Experience.ToString();
                //Op.Text=doctor
                FioBox.ReadOnly = true;
                ExpBox.ReadOnly = true;
                OpBox.ReadOnly = true;
                Save.Enabled = false;
            }
        }
    }
}
