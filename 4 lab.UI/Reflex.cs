using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;
using System.Reflection;

namespace _4_лабораторная
{


    public partial class Reflex : Form
    {
        Type[] types;
        Assembly lib;

        Type _type;
        MethodInfo[] methods = null;
        MethodInfo method = null;
        Object instance;


        public Reflex()
        {
            InitializeComponent();
           
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lib = Assembly.LoadFrom("ClassLibrary.dll");
            types = lib.GetTypes();
            foreach (Type type in types)
            {
                if (type.IsClass && !type.IsAbstract)
                    comboBox1.Items.Add(type.Name);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
           
            foreach (Type type in types)
            {
                if (type.Name == comboBox1.SelectedItem.ToString())
                {
                    _type = type;
                    methods = type.GetMethods();
                }
                    
            }
            foreach (var m in methods.Where(m => !m.Name.StartsWith("get_") && !m.Name.StartsWith("set_D")))
            {

                comboBox2.Items.Add(m.Name);
            }
            instance = Activator.CreateInstance(_type);
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            foreach (var m in methods)
            {
                if (m.Name == comboBox2.SelectedItem.ToString())
                    method = m;
            }
            // ParameterInfo[] p = method.GetParameters();
            

            
            if (method.Name == "Heal")
            {
                comboBox3.Enabled = true;
                var diseases = _type.GetProperty("Diseases");
                List<string> list = diseases.GetValue(instance) as List<string>;


                foreach (var item in list)
                    comboBox3.Items.Add(item);

            }
            


        }

        private void Do_Click(object sender, EventArgs e)
        {
            var param = textBox1.Text;
            Object result;
            switch (method.Name)
            {
                case "Statement":
                    {
                        result = method?.Invoke(instance, parameters: null);
                        MessageBox.Show(result.ToString());
                        break;
                    }
                case "Heal":
                    {
                        result = method?.Invoke(instance, new object[] { comboBox3.SelectedItem.ToString(), param });
                        MessageBox.Show(result.ToString());
                        break;
                    }
                default:
                    {
                        result = method?.Invoke(instance, new object[] { param});
                        MessageBox.Show("Добавлено значение");
                        break;
                    }
            }

            
        }
    }
}
