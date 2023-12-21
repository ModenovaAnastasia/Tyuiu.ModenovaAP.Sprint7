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
        static int rows = 0;
        static int columns = 5;
        static string FilePath = ""; // Путь к файлу
        static string[,] arrayValues = new string[rows, columns]; // Массив для таблицы
        static bool buttonTrue = false; // Нужно для отключении кнопки, если было выделенно несколько строк
        static int addID = 0; // Переменная, которая будет возрастать с каждой созданной строкой
        static bool isSaved = true; // Были ли сделаны какие-либо действия, требующие сохранения
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
                    columns = 5;
                    FilePath = "";
                    arrayValues = new string[rows, columns];
                    addID = 0;
                    dataGridViewPatients_MAP.Rows.Clear();
                    buttonGoToPatient_MAP.Enabled = false;
                    buttonDeletePatient_MAP.Enabled = false;
                    buttonTrue = false;
                    isSaved = true;
                }
            }
            else
            {
                rows = 0;
                columns = 5;
                FilePath = "";
                arrayValues = new string[rows, columns];
                addID = 0;
                dataGridViewPatients_MAP.Rows.Clear();
                buttonGoToPatient_MAP.Enabled = false;
                buttonDeletePatient_MAP.Enabled = false;
                buttonTrue = false;
                isSaved = true;
            }
        }

        // Загрузка таблицы из текстового файла .csv
        public static string[,] LoadFromFileData(string filePath)
        {
            string fileData = File.ReadAllText(filePath, Encoding.GetEncoding(1251)); // Открывается файл по заданному пути, с кодировкой Windows-1251 (для корректного отображения русских символов)
            fileData = fileData.Replace("\n", "\r"); // Заменям управляющий символ новой строки на символ возврата каретки
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries); // И теперь разделяем на строки 
            try
            {
                rows = lines.Length; // Число строк
                columns = lines[0].Split(';').Length; // Число столбцов (разделяем по ;)

                arrayValues = new string[rows, columns];  // Пересоздаём массив с новыми значениями строк и столбцов

                for (int r = 0; r < rows; r++)  // Заполняем массив
                {
                    string[] line_r = lines[r].Split(';');
                    for (int c = 0; c < columns; c++)
                    {
                        arrayValues[r, c] = line_r[c];
                    }
                }
            }
            catch // Если на каком-либо этапе загрузки произошла ошибка, то сбрасываем значения переменных к изначальным
            {
                rows = 0;
                columns = 5;
                arrayValues = new string[rows, columns];
            }


            return arrayValues;
        }

        // Функция сохранения таблицы в файл. К ней обращаются кнопки "Сохранить" и "Сохранить как..."
        private void Save() 
        {

            FileInfo fileInfo = new FileInfo(FilePath);
            bool fileExists = fileInfo.Exists;

            if (fileExists) // Проверяем, существует ли уже этот файл. Если да, то удаляем.
            {
                File.Delete(FilePath);
            }
            string str = "";
            dataGridViewPatients_MAP.Sort(dataGridViewPatients_MAP.Columns[0], ListSortDirection.Ascending); // Сбрасываем сортировку (возвращяем её к сортировке по возрастанию номеров)
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++) 
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridViewPatients_MAP.Rows[i].Cells[j].Value + ";"; // В переменную записываем значения из ячейки, добавляя ;
                    }
                    else
                    {
                        str += dataGridViewPatients_MAP.Rows[i].Cells[j].Value; // Если это последний элемент, то ; не добавляем
                    }
                }
                File.AppendAllText(FilePath, str + Environment.NewLine, Encoding.GetEncoding(1251)); // Добавляем переменную в файл и переносим на новую строку
                str = "";
            }
            isSaved = true; // Меняем переменную "Сохранения" на истину
        }
        // По нажатию кнопки сохранить, начинается проверка, сохраняли или открывали ли мы файл таблицы. Если да - то по уже заданному пути всё сохраняется
        // Если нет - вызывается диалоговое окно с выбором места сохранения
        private void ToolStripMenuItemSave_MAP_Click(object sender, EventArgs e)
        {
            if (FilePath != "")
            {
                Save();
            }
            else
            {
                saveFileDialogExcel_MAP.FileName = "Пациенты.csv"; // Предложение названия файла
                saveFileDialogExcel_MAP.InitialDirectory = Directory.GetCurrentDirectory();
                saveFileDialogExcel_MAP.ShowDialog();

                FilePath = saveFileDialogExcel_MAP.FileName;
                Save();
            }
        }
        // Вызывается диалоговое окно с выбором места сохранения
        private void ToolStripMenuItemSaveAs_MAP_Click(object sender, EventArgs e)
        {
            saveFileDialogExcel_MAP.FileName = "Пациенты.csv";
            saveFileDialogExcel_MAP.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialogExcel_MAP.ShowDialog();

            FilePath = saveFileDialogExcel_MAP.FileName;
            Save();
        }

        // Вызывается диалоговое окно с выбором места сохранения
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
            buttonGoToPatient_MAP.Enabled = true;
            buttonDeletePatient_MAP.Enabled = true;
            buttonTrue = true;
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
            string str = dataGridViewPatients_MAP.SelectedCells.ToString();
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

        }

        private void textBoxSurname_MAP_TextChanged(object sender, EventArgs e)
        {

        }
        //Фильтрация по Номеру пациента
        private void numericUpDownID_MAP_ValueChanged(object sender, EventArgs e)
        {
            dataGridViewPatients_MAP.Rows.Clear(); //Очищается таблица
            for (int i = 0; i < rows; i++)
            {
                if (arrayValues[i, 0] == Convert.ToString(numericUpDownID_MAP.Value)) //Если значение номера в массиве совпадает с таковым в numericUpDown
                {
                    dataGridViewPatients_MAP.Rows.Add(arrayValues[i, 0]); // То добавляется новая строка с этим номером
                    for (int j = 1; j < columns; j++)
                    {
                        dataGridViewPatients_MAP.Rows[dataGridViewPatients_MAP.RowCount - 1].Cells[j].Value = arrayValues[i, j]; // в неё добавляются остальные элементы этой строки из других стобцов
                    }

                }

            }
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
            dataGridViewPatients_MAP.Rows.Add(); // Добавляет строку
            // Включает некоторые кнопки
            buttonGoToPatient_MAP.Enabled = true;
            buttonDeletePatient_MAP.Enabled = true;
            buttonTrue = true; 
            isSaved = false;
            rows++; // Увеличивает кол-во строк

            for (int i = 1; i < columns; i++)
            {
                dataGridViewPatients_MAP.Rows[rows - 1].Cells[i].Value = ""; // Созданную строку заполняет пустыми значениями
            }

            for (int i = 0; i < rows - 1; i++)
            {
                addID = Math.Max(Convert.ToInt32(dataGridViewPatients_MAP.Rows[i].Cells[0].Value), addID); // Находит максимальный номер в таблице
            }
            addID++; 
            dataGridViewPatients_MAP.Rows[rows - 1].Cells[0].Value = Convert.ToString(addID); // Заменяет ячейку первого столбца на макс номер + 1
            // Пересоздаёт массив и заполняет его предыдущими значениями с учётом новой строки
            arrayValues = new string[rows, columns];
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToString(dataGridViewPatients_MAP.Rows[r].Cells[c].Value); 

                }
            }
        }

        // Функция удаления строки
        private void buttonDeletePatient_MAP_Click(object sender, EventArgs e)
        {
            // Спрашивает пользователя в диалоговом окне, подтверждает ли он удаление
            DialogResult dialogResult = MessageBox.Show("Вы уверенны, что хотите удалить выбранные элементы?", "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2);
            // Если да, то...
            if (dialogResult == DialogResult.Yes)
            {
                isSaved = false;
                foreach (DataGridViewRow item in this.dataGridViewPatients_MAP.SelectedRows) 
                {
                    dataGridViewPatients_MAP.Rows.RemoveAt(item.Index); // Каждую выделенную строку он удаляет из таблицы, уменьшает переменную 
                    rows--;
                }
                // Пересоздаёт массив и заполняет его предыдущими значениями с учётом удалённых строк
                arrayValues = new string[rows, columns];
                for (int r = 0; r < rows; r++)
                {
                    for (int c = 0; c < columns; c++)
                    {
                        arrayValues[r, c] = Convert.ToString(dataGridViewPatients_MAP.Rows[r].Cells[c].Value);

                    }
                }
                addID = 0;
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
        private void dataGridViewPatients_MAP_SortCompare(object sender, DataGridViewSortCompareEventArgs e)
        {
            if (e.Column.Index == 0)
            {
                e.SortResult = int.Parse(e.CellValue1.ToString()).CompareTo(int.Parse(e.CellValue2.ToString()));
                e.Handled = true;
            }
        }
        // Записываются изменения ячейки таблицы в массив
        private void dataGridViewPatients_MAP_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            isSaved = false;
            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < columns; c++)
                {
                    arrayValues[r, c] = Convert.ToString(dataGridViewPatients_MAP.Rows[r].Cells[c].Value);
                }
            }
        }
        // Сброс фильтров и сортировки
        private void buttonReset_MAP_Click(object sender, EventArgs e)
        {
            UpdateTable();
        }
    }
}
