using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using _5_lab.Models.Loaders;

namespace _5_lab.UI
{
    public partial class InputLoader : Form
    {
        public string kind;
        public InputLoader()
        {
            InitializeComponent();
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            if (ListBox.SelectedIndex == -1)
            {
                ListBox.SelectedIndex = 0;
                
            }
            kind = ListBox.SelectedItem.ToString().Trim().Split(" ")[1];
            DialogResult = DialogResult.OK;

        }
    }
}
