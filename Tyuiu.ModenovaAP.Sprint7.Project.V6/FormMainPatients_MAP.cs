using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ModenovaAP.Sprint7.Project.V6.Lib;

namespace Tyuiu.ModenovaAP.Sprint7.Project.V6
{
    public partial class FormMainPatients_MAP : Form
    {
        public FormMainPatients_MAP()
        {
            InitializeComponent();
            openFileDialogExcel_MAP.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogExcel_MAP.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static string openFilePath;
        DataService ds = new DataService();
        private void DataGridViewPatients_MAP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void buttonGoToPAtient_MAP_Click(object sender, EventArgs e)
        {
            string str = DataGridViewPatients_MAP.SelectedCells.ToString();
            FormPatientCard_MAP formPatientCard_MAP = new FormPatientCard_MAP();
            formPatientCard_MAP.Text += str;
            formPatientCard_MAP.Show();
        }

        private void FormMainPatients_MAP_Resize(object sender, EventArgs e)
        {
            
        }

        private void dateTimePickerBirthday_MAP_ValueChanged(object sender, EventArgs e)
        {

        }

        private void FormMainPatients_MAP_Load(object sender, EventArgs e)
        {
            DataGridViewPatients_MAP.RowCount = 20;
            
        }

        private void textBoxSurname_MAP_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDownID_MAP_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItemUserGuide_MAP_Click(object sender, EventArgs e)
        {
            FormGuide_MAP formGuide_MAP = new FormGuide_MAP();
            formGuide_MAP.Show();
        }

        private void ToolStripMenuItemAbout_MAP_Click(object sender, EventArgs e)
        {
            FormAbout_MAP formAbout_MAP = new FormAbout_MAP();
            formAbout_MAP.Show();
        }

        private void ToolStripMenuItemOpen_MAP_Click(object sender, EventArgs e)
        {
            openFileDialogExcel_MAP.ShowDialog();
            openFilePath = openFileDialogExcel_MAP.FileName;
        }

        private void ToolStripMenuItemSave_MAP_Click(object sender, EventArgs e)
        {

        }

        private void ToolStripMenuItemSaveAs_MAP_Click(object sender, EventArgs e)
        {
            saveFileDialogExcel_MAP.FileName = "Patients.csv";
            saveFileDialogExcel_MAP.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogExcel_MAP.ShowDialog();

            string path = saveFileDialogExcel_MAP.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

        }
    }
}
