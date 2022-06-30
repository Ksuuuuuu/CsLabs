using System;
using System.Windows.Forms;
using Device;

namespace WinForm
{

    //7.
    //Создать объект класса Компьютер, используя классы Винчестер, Оперативная память, Процессор, Видеокарта.
    //Методы: включить, выключить, проверить на вирусы, вывести размер винчестера.
    public partial class WinForm : Form
    {

        bool isOn = false;
        Computer Computer = new Computer();
        public WinForm()
        {
            InitializeComponent();
        }

        private void OnOff_Click(object sender, EventArgs e)
        {
            if (isOn)
            {
                isOn = Computer.Off();
                CheckV.Enabled = false;
                GetData.Enabled = false;
                Download.Enabled = false;
                MessageBox.Show("Компьютер выключен\nДействия недоступны", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            else
            {
                isOn = Computer.On();
                CheckV.Enabled = true;
                GetData.Enabled = true;
                Download.Enabled = true;
                MessageBox.Show("Компьютер включен\nДействия доступны", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void GetData_Click(object sender, EventArgs e)
        {
            string data = Computer.GetData();
            MessageBox.Show(data, "Данные", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Download_Click(object sender, EventArgs e)
        {
            int volume = Computer.Download();
            if (volume == -1)
                MessageBox.Show("Диск заполнен", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            else
                MessageBox.Show("Файл успешно скачан\nОбъем: " + volume, "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void CheckV_Click(object sender, EventArgs e)
        {
            bool isVirus = Computer.СheckViruC();
            if (isVirus)
                MessageBox.Show("Найден вирус", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
                MessageBox.Show("Вирус не найден", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void WinForm_Load(object sender, EventArgs e)
        {

        }
    }
}
