using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using _5_lab.Models;

namespace _5_lab.UI
{
    public partial class InputDetail : Form
    {
        public string kind;
        public string name;
        public InputDetail()
        {
            InitializeComponent();
 
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
                kind = "One";

            if (radioButton2.Checked == true)
                kind = "Two";

            name = NameBox.Text.Trim();
            DialogResult = DialogResult.OK;
            Close();

        }
    }
}
