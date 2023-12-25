using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            // Будет писаться при сохранении и открытии файла
            openFileDialogExcel_MAP.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogExcel_MAP.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
        }
        // Задаём глобальные переменные, которые можно использовать во всех функциях
        static int rows = 0; //кол-во строк = 0
        static int columns = 10; //кол-во столбиков = 10
        static string FilePath = ""; // Путь к файлу
        static string[,] arrayValues = new string[rows, columns]; // двумерный массив служит для для хранения данных табл
        static bool buttonTrue = false; // Нужно для отключении кнопки, если было выделенно несколько строк
        static int addID = 0; // Переменная, которая будет возрастать с каждой созданной строкой
        static bool isSaved = true; // Были ли сделаны какие-либо действия, требующие сохранения
        static string[] filters = new string[8]; //массив строк длиной 8
        DataService ds = new DataService();


        private void ToolStripMenuItemNewTable_MAP_Click(object sender, EventArgs e)
        {
            // Функция создания пустой таблицы

            // Если были произведенны какие-либо действия (изменено значение таблицы, добавлина новая строка и тд.), то 
            // появляется диалоговое окно с вопросом, уверенны ли мы, что хотим создать новую талбицу.
            // Если да, то все переменные сбрасываются, а таблица очищается.
            // Если, изменений не было, то диалоговое окно не появляется, и сразу создаётся новая таблица.

            if (!isSaved)
            {
                DialogResult dialogResult = MessageBox.Show("У вас есть несохранённые данные.\nСоздать новую таблицу? ", "Новая таблица", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
                if (dialogResult == DialogResult.Yes)
                {
                    rows = 0;
                    columns = 10;
                    FilePath = "";
                    arrayValues = new string[rows, columns];
                    addID = 0;
                    dataGridViewPatients_MAP.Rows.Clear();
                    buttonGoToPatient_MAP.Enabled = false;
                    buttonDeletePatient_MAP.Enabled = false;
                    buttonTrue = false;
                    isSaved = true;
                    textBoxPatientSPN_MAP.Text = string.Empty;
                    textBoxDoctorSPN_MAP.Text = string.Empty;
                    textBoxDiagnosis_MAP.Text = string.Empty;
                    numericUpDownID_MAP.Value = 0;
                    numericUpDownDisabilityTime_MAP.Value = 0;
                    comboBoxAmbulatory_MAP.Text = string.Empty;
                    comboBoxDispanser_MAP.Text = string.Empty;
                    filters = new string[8];

                }
            }
            else
            {
                rows = 0;
                columns = 10;
                FilePath = "";
                arrayValues = new string[rows, columns];
                addID = 0;
                dataGridViewPatients_MAP.Rows.Clear();
                buttonGoToPatient_MAP.Enabled = false;
                buttonDeletePatient_MAP.Enabled = false;
                buttonTrue = false;
                isSaved = true;
                textBoxPatientSPN_MAP.Text = string.Empty;
                textBoxDoctorSPN_MAP.Text = string.Empty;
                textBoxDiagnosis_MAP.Text = string.Empty;
                numericUpDownID_MAP.Value = 0;
                numericUpDownDisabilityTime_MAP.Value = 0;
                comboBoxAmbulatory_MAP.Text = string.Empty;
                comboBoxDispanser_MAP.Text = string.Empty;
                filters = new string[8];

            }
        }

        // Загрузка таблицы из текстового файла .csv
        public static string[,] LoadFromFileData(string filePath)
        {
            try
            {
                string fileData = File.ReadAllText(filePath, Encoding.GetEncoding(1251)); //считывает содержимое и задается кодировка
                fileData = fileData.Replace("\n", "\r"); //замена переноса строки на возврат каретки для коректного чтения
                string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries); //полученная строка разбивается на массив строк
                try
                {
                    rows = lines.Length; //кол-во строк = длине массива 
                    arrayValues = new string[rows, columns];
                    for (int r = 0; r < rows; r++)
                    {
                        string[] line_r = lines[r].Split(';');
                        for (int c = 0; c < columns; c++)
                        {
                            arrayValues[r, c] = line_r[c];
                        }
                    }
                }
                catch //обработка возможных ошибок
                {
                    rows = 0;
                    columns = 10;
                    arrayValues = new string[rows, columns];
                }
            }
            catch { }

            return arrayValues;
        }

        // Функция сохранения таблицы в файл. К ней обращаются кнопки "Сохранить" и "Сохранить как..."
        private void Save()
        {

            FileInfo fileInfo = new FileInfo(FilePath);
            bool fileExists = fileInfo.Exists; //проверка существования файла по указанному пути

            if (fileExists)
            {
                File.Delete(FilePath); //если файл уже сущ, то он удаляется
            }
            string str = "";
            dataGridViewPatients_MAP.Sort(dataGridViewPatients_MAP.Columns[0], ListSortDirection.Ascending); //сортировка в таблицы по возрастанию по значениям из 1 столбца
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewPatients_MAP.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str += dataGridViewPatients_MAP.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(FilePath, str + Environment.NewLine, Encoding.GetEncoding(1251)); //запись стр в файл, добавление переноса стр, чтобы каждая стр табл сохранялась как отдельная стр в файле
                str = "";
            }
            isSaved = true; //данные сохранены
            Filter();
        }

        private void Filter()
        {
            dataGridViewPatients_MAP.Rows.Clear(); //очищает все стр в табл перед применением фильтра
            for (int i = 0; i < rows; i++)
            {
                if ((arrayValues[i, 0] == filters[0] || string.IsNullOrWhiteSpace(filters[0]) || filters[0] == "0") && (arrayValues[i, 2] == filters[2] || string.IsNullOrWhiteSpace(filters[2])) && (arrayValues[i, 6] == filters[5] || string.IsNullOrWhiteSpace(filters[5])) && (arrayValues[i, 7] == filters[6] || string.IsNullOrWhiteSpace(filters[6]) || filters[6] == "0") && (arrayValues[i, 8] == filters[7] || string.IsNullOrWhiteSpace(filters[7])))
                {
                    try
                    {
                        if ((arrayValues[i, 1].Contains(filters[1]) || string.IsNullOrWhiteSpace(filters[1])) && (arrayValues[i, 3].Contains(filters[3]) || string.IsNullOrWhiteSpace(filters[3])) && (arrayValues[i, 5].Contains(filters[4]) || string.IsNullOrWhiteSpace(filters[4])))
                        {
                            dataGridViewPatients_MAP.Rows.Add(arrayValues[i, 0]);
                            for (int k = 1; k < columns; k++)
                            {
                                dataGridViewPatients_MAP.Rows[dataGridViewPatients_MAP.RowCount - 1].Cells[k].Value = arrayValues[i, k];
                            }
                        }
                    }
                    catch
                    {
                        dataGridViewPatients_MAP.Rows.Add(arrayValues[i, 0]);
                        for (int k = 1; k < columns; k++)
                        {
                            dataGridViewPatients_MAP.Rows[dataGridViewPatients_MAP.RowCount - 1].Cells[k].Value = arrayValues[i, k];
                        }
                    }

                }
            }
        }

        // По нажатию кнопки сохранить, начинается проверка, сохраняли или открывали ли мы файл таблицы. Если да - то по уже заданному пути всё сохраняется
        // Если нет - вызывается диалоговое окно с выбором места сохранения
        private void ToolStripMenuItemSave_MAP_Click(object sender, EventArgs e)
        {
            UpdateTable();
            if (FilePath != "")
            {
                Save();
            }
            else
            {
                saveFileDialogExcel_MAP.FileName = "Пациенты.csv";
                saveFileDialogExcel_MAP.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialogExcel_MAP.ShowDialog();

                FilePath = saveFileDialogExcel_MAP.FileName;
                Save();
            }
        }
        // Вызывается диалоговое окно с выбором места сохранения
        private void ToolStripMenuItemSaveAs_MAP_Click(object sender, EventArgs e)
        {
            UpdateTable();
            saveFileDialogExcel_MAP.FileName = "Пациенты.csv";
            saveFileDialogExcel_MAP.InitialDirectory = Directory.GetCurrentDirectory();
            if (!(saveFileDialogExcel_MAP.ShowDialog() == DialogResult.Cancel))
            {
                FilePath = saveFileDialogExcel_MAP.FileName;
                Save();
            }
        }

        // Вызывается диалоговое окно с открытием файла
        private void ToolStripMenuItemOpen_MAP_Click(object sender, EventArgs e)
        {

            openFileDialogExcel_MAP.ShowDialog();
            FilePath = openFileDialogExcel_MAP.FileName;

            arrayValues = LoadFromFileData(FilePath);

            dataGridViewPatients_MAP.ColumnCount = columns;
            dataGridViewPatients_MAP.RowCount = rows;

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewPatients_MAP.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            if (rows > 0)
            {
                buttonGoToPatient_MAP.Enabled = true;
                buttonDeletePatient_MAP.Enabled = true;
                buttonTrue = true;
            }

        }

        //Функция обновления таблицы, приводящая её к значениям массива
        private void UpdateTable()
        {
            dataGridViewPatients_MAP.Rows.Clear();
            for (int r = 0; r < rows; r++)
            {
                dataGridViewPatients_MAP.Rows.Add();
                for (int c = 0; c < columns; c++)
                {
                    dataGridViewPatients_MAP.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
        }




        private void DataGridViewPatients_MAP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        //Открывается новое окно с мед. картой пациента
        private void buttonGoToPAtient_MAP_Click(object sender, EventArgs e)
        {
            FormPatientCard_MAP formPatienCard = new FormPatientCard_MAP();
            foreach (DataGridViewRow item in this.dataGridViewPatients_MAP.SelectedRows)
            {
                try
                {
                    formPatienCard.Text = Convert.ToString(dataGridViewPatients_MAP.Rows[item.Index].Cells[1].Value) + " - ";
                    formPatienCard.Text += "Медицинская Карта";
                    formPatienCard.patientName = Convert.ToString(dataGridViewPatients_MAP.Rows[item.Index].Cells[1].Value);
                }
                catch { }
            }
            formPatienCard.array = arrayValues;
            formPatienCard.Show();
        }

        private void FormMainPatients_MAP_Resize(object sender, EventArgs e)
        {
            
        }

        private void dateTimePickerBirthday_MAP_ValueChanged(object sender, EventArgs e)
        {
            filters[2] = dateTimePickerBirthday_MAP.Value.ToShortDateString().Replace("/", "."); //знач выбранной даты преобразуется в стр
            Filter();
        }

        private void FormMainPatients_MAP_Load(object sender, EventArgs e)
        {

        }

        private void textBoxSurname_MAP_TextChanged(object sender, EventArgs e)
        {
            filters[1] = Convert.ToString(textBoxPatientSPN_MAP.Text);
            Filter();
        }
        //Фильтрация по Номеру пациента
        private void numericUpDownID_MAP_ValueChanged(object sender, EventArgs e)
        {
            filters[0] = Convert.ToString(numericUpDownID_MAP.Value);
            Filter();
        }
        // Открывается форма с руководством пользователя
        private void ToolStripMenuItemUserGuide_MAP_Click(object sender, EventArgs e)
        {
            FormGuide_MAP formGuide_MAP = new FormGuide_MAP();
            formGuide_MAP.Show();
        }
        // Открывается форма "О программе"
        private void ToolStripMenuItemAbout_MAP_Click(object sender, EventArgs e)
        {
            FormAbout_MAP formAbout_MAP = new FormAbout_MAP();
            formAbout_MAP.Show();
        }

        // Фукнция добавления новой строки в таблице. Номер автоматически повышается на максимальное значение + 1
        private void buttonAddPatient_MAP_Click(object sender, EventArgs e)
        {
            dataGridViewPatients_MAP.Rows.Add(); //добавляет новую стр в табл
            buttonGoToPatient_MAP.Enabled = true;
            buttonDeletePatient_MAP.Enabled = true;
            buttonTrue = true;
            isSaved = false; //изменения не сохранены
            rows++; //увелич кол-во стр на 1

            for (int i = 1; i < columns; i++) //для каждой ячейке в добавленной стр устанавливается пустая стр
            {
                dataGridViewPatients_MAP.Rows[dataGridViewPatients_MAP.Rows.Count - 1].Cells[i].Value = "";
            }

            for (int i = 0; i < rows - 1; i++) //перебор сущ записей, чтобы найти макс значение, исп для идентификации новой стр
            {
                addID = Math.Max(Convert.ToInt32(arrayValues[i, 0]), addID);
            }
            addID++; //новое знач устанавливается в 1 ячейку новой стр
            dataGridViewPatients_MAP.Rows[dataGridViewPatients_MAP.Rows.Count - 1].Cells[0].Value = Convert.ToString(addID);
            string[,] tempValues = arrayValues; //временный массив
            arrayValues = new string[rows, columns];
            for (int r = 0; r < rows - 1; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = tempValues[r, c];
                }
            }
            for (int с = 0; с < columns; с++)
                arrayValues[rows - 1, с] = Convert.ToString(dataGridViewPatients_MAP.Rows[dataGridViewPatients_MAP.Rows.Count - 1].Cells[с].Value);
        }

        // Функция удаления строки
        private void buttonDeletePatient_MAP_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверенны, что хотите удалить выбранные элементы?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            isSaved = false; //изменения не сохранены
            if (dialogResult == DialogResult.Yes) //если "да", то удаление выбранных эл-в 
            {
                string[] tempArray = new string[dataGridViewPatients_MAP.SelectedRows.Count]; //создание временного массива для хранения удаляемых эл-в
                int cnt = 0;
                foreach (DataGridViewRow item in this.dataGridViewPatients_MAP.SelectedRows) //циклический перебор выбранных строк 
                {
                    tempArray[cnt] = Convert.ToString(dataGridViewPatients_MAP.Rows[item.Index].Cells[0].Value); //добавляется идентификатор для каждой выбранной стр  
                    dataGridViewPatients_MAP.Rows.RemoveAt(item.Index); //удаляет выбранну стр из объекта
                    cnt++;
                }

                UpdateTable(); //обновление табл

                for (int i = rows - 1; i >= 0; i--)
                {
                    for (int j = 0; j < tempArray.GetLength(0); j++) 
                    {
                        try //проверка для каждой стр на наличие идентификатора в массиве
                        {
                            if (Convert.ToString(dataGridViewPatients_MAP.Rows[i].Cells[0].Value) == tempArray[j])
                            {
                                dataGridViewPatients_MAP.Rows.RemoveAt(i); //удаление строки 
                                rows--;
                            }
                        }
                        catch //обработка исключения при ошибке
                        {
                            if (Convert.ToString(dataGridViewPatients_MAP.Rows[dataGridViewPatients_MAP.Rows.Count - 1].Cells[0].Value) == tempArray[j]) //берет значение из 1 ячейки помледней строки табл и преобраз его в строку
                            {
                                dataGridViewPatients_MAP.Rows.RemoveAt(dataGridViewPatients_MAP.Rows.Count - 1); //если "да", то удаляется последняя строка 
                                rows--;
                            }
                        }
                    }

                }
                arrayValues = new string[rows, columns];
                for (int r = 0; r < rows; r++) //присваивается значение каждой ячейки соотв эл-ту массива через циклы
                {
                    for (int c = 0; c < columns; c++)
                    {
                        arrayValues[r, c] = Convert.ToString(dataGridViewPatients_MAP.Rows[r].Cells[c].Value);

                    }
                }
                addID = 0;
                Filter();
            }
        }
        // Проверяет кол-во выделенных элементов. Если их больше 1, то отключает кнопку перехода к Мед. карте пациента
        private void dataGridViewPatients_MAP_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewPatients_MAP.SelectedRows.Count > 1)
            {
                buttonGoToPatient_MAP.Enabled = false;
            }
            else if (buttonTrue)
            {
                buttonGoToPatient_MAP.Enabled = true;
            }
        }
        // За счёт этой функции, в таблице номер сортируется как число, а не как строка
        private void dataGridViewPatients_MAP_SortCompare(object sender, DataGridViewSortCompareEventArgs e) //проверка на каком столбце происходит сортировка, и в зависимости от этого сравнивает значения ячеек в столбце
        {
            if (e.Column.Index == 0 || e.Column.Index == 7) //если сортируется 1 или 7 столбец, пытается преобразовать значения в целые числа и затем сравнивает их
            {
                try
                {
                    e.SortResult = int.Parse(e.CellValue1.ToString()).CompareTo(int.Parse(e.CellValue2.ToString()));
                    e.Handled = true;
                }
                catch { }
            }
            if (e.Column.Index == 2) //если сортируется 2 столбец, то значения сначала преобразуются в тип, а затем сравниваются
            {
                try //сравнивает 2 значения ячеек, кот содержат даты, как строки, затем сравнивает даты 
                {
                    e.SortResult = DateTime.Parse(e.CellValue1.ToString()).CompareTo(DateTime.Parse(e.CellValue2.ToString()));
                    e.Handled = true;
                }
                catch { }
            }
        }
        // Записываются изменения ячейки таблицы в массив
        private void dataGridViewPatients_MAP_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            isSaved = false; //не сохранены
            for (int i = 0; i < rows; i++)
                for (int j = 0; j < dataGridViewPatients_MAP.Rows.Count; j++)
                {
                    if (Convert.ToString(dataGridViewPatients_MAP.Rows[j].Cells[0].Value) == arrayValues[i, 0])
                    {
                        for (int k = 1; k < columns; k++)
                        {
                            arrayValues[i, k] = Convert.ToString(dataGridViewPatients_MAP.Rows[j].Cells[k].Value);
                        }
                    }

                }
        }
        // Сброс фильтров и сортировки
        private void buttonReset_MAP_Click(object sender, EventArgs e)
        {
            numericUpDownID_MAP.Value = 0;
            textBoxPatientSPN_MAP.Text = string.Empty;
            textBoxDoctorSPN_MAP.Text = string.Empty;
            textBoxDiagnosis_MAP.Text = string.Empty;
            comboBoxAmbulatory_MAP.Text = string.Empty;
            numericUpDownDisabilityTime_MAP.Value = 0;
            comboBoxDispanser_MAP.Text = string.Empty;
            UpdateTable();
        }

        private void textBoxSearch_MAP_TextChanged(object sender, EventArgs e) //когда пользователь вводит текст, код очищает все стр в табл
        {
            dataGridViewPatients_MAP.Rows.Clear();
            string text = textBoxSearch_MAP.Text;
            if (text != "")
            {
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        if (arrayValues[i, j].Contains(text)) //если есть совпадения, то удаляет строки в табл, кот есть в 1 ячейке
                        {
                            foreach (DataGridViewRow row in dataGridViewPatients_MAP.Rows)
                            {
                                if (row.Cells[0].Value.ToString().Contains(arrayValues[i, 0]))
                                {
                                    dataGridViewPatients_MAP.Rows.Remove(row);
                                }
                            }
                            dataGridViewPatients_MAP.Rows.Add(arrayValues[i, 0]);
                            for (int k = 1; k < columns; k++)
                            {
                                dataGridViewPatients_MAP.Rows[dataGridViewPatients_MAP.RowCount - 1].Cells[k].Value = arrayValues[i, k];
                            }
                        }
                    }
                }
            }
            else //если текстовое поле пустое, вызывается метод, кот обновляет все данные в табл
            {
                UpdateTable();
            }
        }
        private void textBoxName_MAP_TextChanged(object sender, EventArgs e)
        {
            filters[3] = Convert.ToString(textBoxDoctorSPN_MAP.Text);
            Filter();
        }

        private void textBoxPatronymic_MAP_TextChanged(object sender, EventArgs e)
        {
            filters[4] = Convert.ToString(textBoxDiagnosis_MAP.Text);
            Filter();

        }

        private void comboBoxAmbulatory_MAP_SelectedIndexChanged(object sender, EventArgs e)
        {
            filters[5] = Convert.ToString(comboBoxAmbulatory_MAP.Text);
            Filter();
        }

        private void numericUpDownDisabilityTime_MAP_ValueChanged(object sender, EventArgs e)
        {
            filters[6] = Convert.ToString(numericUpDownDisabilityTime_MAP.Value);
            Filter();
        }

        private void comboBoxDispanser_MAP_SelectedIndexChanged(object sender, EventArgs e)
        {
            filters[7] = Convert.ToString(comboBoxDispanser_MAP.Text);
            Filter();
        }
    }
}
