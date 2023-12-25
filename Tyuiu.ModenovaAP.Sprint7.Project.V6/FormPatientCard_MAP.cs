using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tyuiu.ModenovaAP.Sprint7.Project.V6.Lib;

namespace Tyuiu.ModenovaAP.Sprint7.Project.V6
{
    public partial class FormPatientCard_MAP : Form
    {
        public FormPatientCard_MAP()
        {
            InitializeComponent();
        }
        public string[,] array;
        public string patientName;
        DataService ds = new DataService();
        //загружает данные пациента в форму, включая график, и отбражает значения
        private void FormPatientCard_MAP_Load(object sender, EventArgs e)
        {
            int cnt = 0;
            for (int i = 0; i < array.GetLength(0); i++)
            {
                try
                {
                    if (array[i, 1] == patientName)
                    {
                        cnt++;
                        try
                        {
                            chartStats_MAP.Series[0].Points.AddXY(cnt, Convert.ToInt32(array[i, 7]));
                        }
                        catch { chartStats_MAP.Series[0].Points.AddXY(cnt, 0); cnt++; }
                    }
                }
                catch { }
            }
            textBoxPatientsTimes_MAP.Text = Convert.ToString(ds.TimesPatient(array, patientName));
            textBoxMinTime_MAP.Text = Convert.ToString(ds.MinTime(array, patientName));
            textBoxMaxTime_MAP.Text = Convert.ToString(ds.MaxTime(array, patientName));
            textBoxAvgTime_MAP.Text = Convert.ToString(ds.AvgTime(array, patientName));
        }
    }
}
