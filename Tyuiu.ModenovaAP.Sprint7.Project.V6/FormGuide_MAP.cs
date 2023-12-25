using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tyuiu.ModenovaAP.Sprint7.Project.V6
{
    public partial class FormGuide_MAP : Form
    {
        public FormGuide_MAP()
        {
            InitializeComponent();
        }
        static int curentImage = 0;
        private void ChangeImage() //в зависимости от значения переменной устанавливается изображение из ресурсов
        {
            if (curentImage == 0)
            {
                pictureBoxManual_MAP.BackgroundImage = Properties.Resources._1;
            }
            if (curentImage == 1)
            {
                pictureBoxManual_MAP.BackgroundImage = Properties.Resources._2;
            }

        }
        private void buttonNext_MAP_Click(object sender, EventArgs e) //листать изображения
        {
            curentImage++;
            buttonPrev_MAP.Enabled = true;
            if (curentImage == 1)
            {
                buttonNext_MAP.Enabled = false;
            }
            ChangeImage();
        }

        private void buttonPrev_MAP_Click(object sender, EventArgs e)
        {
            curentImage--;
            buttonNext_MAP.Enabled = true;
            if (curentImage == 0)
            {
                buttonPrev_MAP.Enabled = false;
            }
            ChangeImage();
        }
    }
}
