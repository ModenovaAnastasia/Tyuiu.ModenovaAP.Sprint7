namespace Tyuiu.ModenovaAP.Sprint7.Project.V6
{
    partial class FormMainPatients_MAP
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainPatients_MAP));
            this.dataGridViewPatients_MAP = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SNP_MAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorSNP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorPosition_MAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.diagnosis_MAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ambulatoryCare_MAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.disabilityTime_MAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dispanser_MAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.notes_MAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStripMust_MAP = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemFile_MAP = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemNewTable_MAP = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemOpen_MAP = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSave_MAP = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemSaveAs_MAP = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemHelp_MAP = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemUserGuide_MAP = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAbout_MAP = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialogExcel_MAP = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogExcel_MAP = new System.Windows.Forms.SaveFileDialog();
            this.toolTipForButtons_MAP = new System.Windows.Forms.ToolTip(this.components);
            this.groupBoxFilters_MAP = new System.Windows.Forms.GroupBox();
            this.labelSearch_MAP = new System.Windows.Forms.Label();
            this.textBoxSearch_MAP = new System.Windows.Forms.TextBox();
            this.buttonReset_MAP = new System.Windows.Forms.Button();
            this.labelBirthday_MAP = new System.Windows.Forms.Label();
            this.numericUpDownID_MAP = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerBirthday_MAP = new System.Windows.Forms.DateTimePicker();
            this.labelDiagnosis_MAP = new System.Windows.Forms.Label();
            this.labelDoctorSPN_MAP = new System.Windows.Forms.Label();
            this.labelPatientSPN_MAP = new System.Windows.Forms.Label();
            this.labelID_MAP = new System.Windows.Forms.Label();
            this.textBoxDiagnosis_MAP = new System.Windows.Forms.TextBox();
            this.textBoxDoctorSPN_MAP = new System.Windows.Forms.TextBox();
            this.textBoxPatientSPN_MAP = new System.Windows.Forms.TextBox();
            this.groupBoxInstruments_MAP = new System.Windows.Forms.GroupBox();
            this.buttonDeletePatient_MAP = new System.Windows.Forms.Button();
            this.buttonAddPatient_MAP = new System.Windows.Forms.Button();
            this.buttonGoToPatient_MAP = new System.Windows.Forms.Button();
            this.panelForTable_MAP = new System.Windows.Forms.Panel();
            this.panelForGroupBoxes_MAP = new System.Windows.Forms.Panel();
            this.panelBetweenGroupBoxes_MAP = new System.Windows.Forms.Panel();
            this.numericUpDownDisabilityTime_MAP = new System.Windows.Forms.NumericUpDown();
            this.comboBoxAmbulatory_MAP = new System.Windows.Forms.ComboBox();
            this.comboBoxDispanser_MAP = new System.Windows.Forms.ComboBox();
            this.labelAmbulatoryCare_MAP = new System.Windows.Forms.Label();
            this.labelDisabilityTime_MAP = new System.Windows.Forms.Label();
            this.labelDispanser_MAP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients_MAP)).BeginInit();
            this.menuStripMust_MAP.SuspendLayout();
            this.groupBoxFilters_MAP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID_MAP)).BeginInit();
            this.groupBoxInstruments_MAP.SuspendLayout();
            this.panelForTable_MAP.SuspendLayout();
            this.panelForGroupBoxes_MAP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDisabilityTime_MAP)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewPatients_MAP
            // 
            this.dataGridViewPatients_MAP.AllowUserToAddRows = false;
            this.dataGridViewPatients_MAP.AllowUserToDeleteRows = false;
            this.dataGridViewPatients_MAP.AllowUserToResizeColumns = false;
            this.dataGridViewPatients_MAP.AllowUserToResizeRows = false;
            this.dataGridViewPatients_MAP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewPatients_MAP.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.Purple;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.Fuchsia;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPatients_MAP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewPatients_MAP.ColumnHeadersHeight = 45;
            this.dataGridViewPatients_MAP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.SNP_MAP,
            this.BirthDate,
            this.doctorSNP,
            this.doctorPosition_MAP,
            this.diagnosis_MAP,
            this.ambulatoryCare_MAP,
            this.disabilityTime_MAP,
            this.dispanser_MAP,
            this.notes_MAP});
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPatients_MAP.DefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewPatients_MAP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPatients_MAP.EnableHeadersVisualStyles = false;
            this.dataGridViewPatients_MAP.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPatients_MAP.Name = "dataGridViewPatients_MAP";
            this.dataGridViewPatients_MAP.RowHeadersVisible = false;
            this.dataGridViewPatients_MAP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.dataGridViewPatients_MAP.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridViewPatients_MAP.RowTemplate.Height = 25;
            this.dataGridViewPatients_MAP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPatients_MAP.Size = new System.Drawing.Size(1258, 415);
            this.dataGridViewPatients_MAP.TabIndex = 0;
            this.dataGridViewPatients_MAP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewPatients_MAP_CellContentClick);
            this.dataGridViewPatients_MAP.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPatients_MAP_CellEndEdit);
            this.dataGridViewPatients_MAP.SelectionChanged += new System.EventHandler(this.dataGridViewPatients_MAP_SelectionChanged);
            this.dataGridViewPatients_MAP.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dataGridViewPatients_MAP_SortCompare);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Id.HeaderText = "Номер";
            this.Id.Name = "Id";
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Width = 85;
            // 
            // SNP_MAP
            // 
            this.SNP_MAP.HeaderText = "ФИО пациента";
            this.SNP_MAP.MinimumWidth = 200;
            this.SNP_MAP.Name = "SNP_MAP";
            this.SNP_MAP.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // BirthDate
            // 
            this.BirthDate.HeaderText = "Дата Рождения";
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // doctorSNP
            // 
            this.doctorSNP.HeaderText = "ФИО врача";
            this.doctorSNP.Name = "doctorSNP";
            // 
            // doctorPosition_MAP
            // 
            this.doctorPosition_MAP.HeaderText = "Должность врача";
            this.doctorPosition_MAP.Name = "doctorPosition_MAP";
            // 
            // diagnosis_MAP
            // 
            this.diagnosis_MAP.HeaderText = "Диагноз";
            this.diagnosis_MAP.Name = "diagnosis_MAP";
            // 
            // ambulatoryCare_MAP
            // 
            this.ambulatoryCare_MAP.HeaderText = "Амбулаторное лечение";
            this.ambulatoryCare_MAP.Name = "ambulatoryCare_MAP";
            // 
            // disabilityTime_MAP
            // 
            this.disabilityTime_MAP.HeaderText = "Срок потери трудоспособности";
            this.disabilityTime_MAP.Name = "disabilityTime_MAP";
            // 
            // dispanser_MAP
            // 
            this.dispanser_MAP.HeaderText = "Диспансерный учёт";
            this.dispanser_MAP.Name = "dispanser_MAP";
            // 
            // notes_MAP
            // 
            this.notes_MAP.HeaderText = "Примечание";
            this.notes_MAP.Name = "notes_MAP";
            // 
            // menuStripMust_MAP
            // 
            this.menuStripMust_MAP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.menuStripMust_MAP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFile_MAP,
            this.ToolStripMenuItemHelp_MAP});
            this.menuStripMust_MAP.Location = new System.Drawing.Point(0, 0);
            this.menuStripMust_MAP.Name = "menuStripMust_MAP";
            this.menuStripMust_MAP.Size = new System.Drawing.Size(1258, 25);
            this.menuStripMust_MAP.TabIndex = 1;
            this.menuStripMust_MAP.Text = "menuStrip1";
            // 
            // ToolStripMenuItemFile_MAP
            // 
            this.ToolStripMenuItemFile_MAP.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemNewTable_MAP,
            this.ToolStripMenuItemOpen_MAP,
            this.ToolStripMenuItemSave_MAP,
            this.ToolStripMenuItemSaveAs_MAP});
            this.ToolStripMenuItemFile_MAP.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ToolStripMenuItemFile_MAP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.ToolStripMenuItemFile_MAP.Name = "ToolStripMenuItemFile_MAP";
            this.ToolStripMenuItemFile_MAP.Size = new System.Drawing.Size(50, 21);
            this.ToolStripMenuItemFile_MAP.Text = "Файл";
            // 
            // ToolStripMenuItemNewTable_MAP
            // 
            this.ToolStripMenuItemNewTable_MAP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ToolStripMenuItemNewTable_MAP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.ToolStripMenuItemNewTable_MAP.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemNewTable_MAP.Image")));
            this.ToolStripMenuItemNewTable_MAP.Name = "ToolStripMenuItemNewTable_MAP";
            this.ToolStripMenuItemNewTable_MAP.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemNewTable_MAP.Text = "Новая таблица";
            this.ToolStripMenuItemNewTable_MAP.Click += new System.EventHandler(this.ToolStripMenuItemNewTable_MAP_Click);
            // 
            // ToolStripMenuItemOpen_MAP
            // 
            this.ToolStripMenuItemOpen_MAP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ToolStripMenuItemOpen_MAP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.ToolStripMenuItemOpen_MAP.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemOpen_MAP.Image")));
            this.ToolStripMenuItemOpen_MAP.Name = "ToolStripMenuItemOpen_MAP";
            this.ToolStripMenuItemOpen_MAP.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemOpen_MAP.Text = "Открыть...";
            this.ToolStripMenuItemOpen_MAP.Click += new System.EventHandler(this.ToolStripMenuItemOpen_MAP_Click);
            // 
            // ToolStripMenuItemSave_MAP
            // 
            this.ToolStripMenuItemSave_MAP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ToolStripMenuItemSave_MAP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.ToolStripMenuItemSave_MAP.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemSave_MAP.Image")));
            this.ToolStripMenuItemSave_MAP.Name = "ToolStripMenuItemSave_MAP";
            this.ToolStripMenuItemSave_MAP.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemSave_MAP.Text = "Сохранить";
            this.ToolStripMenuItemSave_MAP.Click += new System.EventHandler(this.ToolStripMenuItemSave_MAP_Click);
            // 
            // ToolStripMenuItemSaveAs_MAP
            // 
            this.ToolStripMenuItemSaveAs_MAP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ToolStripMenuItemSaveAs_MAP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.ToolStripMenuItemSaveAs_MAP.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemSaveAs_MAP.Image")));
            this.ToolStripMenuItemSaveAs_MAP.Name = "ToolStripMenuItemSaveAs_MAP";
            this.ToolStripMenuItemSaveAs_MAP.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemSaveAs_MAP.Text = "Сохранить как...";
            this.ToolStripMenuItemSaveAs_MAP.Click += new System.EventHandler(this.ToolStripMenuItemSaveAs_MAP_Click);
            // 
            // ToolStripMenuItemHelp_MAP
            // 
            this.ToolStripMenuItemHelp_MAP.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemUserGuide_MAP,
            this.ToolStripMenuItemAbout_MAP});
            this.ToolStripMenuItemHelp_MAP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.ToolStripMenuItemHelp_MAP.Name = "ToolStripMenuItemHelp_MAP";
            this.ToolStripMenuItemHelp_MAP.Size = new System.Drawing.Size(68, 21);
            this.ToolStripMenuItemHelp_MAP.Text = "Помощь";
            // 
            // ToolStripMenuItemUserGuide_MAP
            // 
            this.ToolStripMenuItemUserGuide_MAP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ToolStripMenuItemUserGuide_MAP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.ToolStripMenuItemUserGuide_MAP.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemUserGuide_MAP.Image")));
            this.ToolStripMenuItemUserGuide_MAP.Name = "ToolStripMenuItemUserGuide_MAP";
            this.ToolStripMenuItemUserGuide_MAP.Size = new System.Drawing.Size(223, 22);
            this.ToolStripMenuItemUserGuide_MAP.Text = "Руководство Пользователя";
            this.ToolStripMenuItemUserGuide_MAP.Click += new System.EventHandler(this.ToolStripMenuItemUserGuide_MAP_Click);
            // 
            // ToolStripMenuItemAbout_MAP
            // 
            this.ToolStripMenuItemAbout_MAP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ToolStripMenuItemAbout_MAP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.ToolStripMenuItemAbout_MAP.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemAbout_MAP.Image")));
            this.ToolStripMenuItemAbout_MAP.Name = "ToolStripMenuItemAbout_MAP";
            this.ToolStripMenuItemAbout_MAP.Size = new System.Drawing.Size(223, 22);
            this.ToolStripMenuItemAbout_MAP.Text = "О программме";
            this.ToolStripMenuItemAbout_MAP.Click += new System.EventHandler(this.ToolStripMenuItemAbout_MAP_Click);
            // 
            // openFileDialogExcel_MAP
            // 
            this.openFileDialogExcel_MAP.FileName = "openFileDialog1";
            // 
            // groupBoxFilters_MAP
            // 
            this.groupBoxFilters_MAP.Controls.Add(this.labelDispanser_MAP);
            this.groupBoxFilters_MAP.Controls.Add(this.labelDisabilityTime_MAP);
            this.groupBoxFilters_MAP.Controls.Add(this.labelAmbulatoryCare_MAP);
            this.groupBoxFilters_MAP.Controls.Add(this.comboBoxDispanser_MAP);
            this.groupBoxFilters_MAP.Controls.Add(this.comboBoxAmbulatory_MAP);
            this.groupBoxFilters_MAP.Controls.Add(this.numericUpDownDisabilityTime_MAP);
            this.groupBoxFilters_MAP.Controls.Add(this.labelSearch_MAP);
            this.groupBoxFilters_MAP.Controls.Add(this.textBoxSearch_MAP);
            this.groupBoxFilters_MAP.Controls.Add(this.buttonReset_MAP);
            this.groupBoxFilters_MAP.Controls.Add(this.labelBirthday_MAP);
            this.groupBoxFilters_MAP.Controls.Add(this.numericUpDownID_MAP);
            this.groupBoxFilters_MAP.Controls.Add(this.dateTimePickerBirthday_MAP);
            this.groupBoxFilters_MAP.Controls.Add(this.labelDiagnosis_MAP);
            this.groupBoxFilters_MAP.Controls.Add(this.labelDoctorSPN_MAP);
            this.groupBoxFilters_MAP.Controls.Add(this.labelPatientSPN_MAP);
            this.groupBoxFilters_MAP.Controls.Add(this.labelID_MAP);
            this.groupBoxFilters_MAP.Controls.Add(this.textBoxDiagnosis_MAP);
            this.groupBoxFilters_MAP.Controls.Add(this.textBoxDoctorSPN_MAP);
            this.groupBoxFilters_MAP.Controls.Add(this.textBoxPatientSPN_MAP);
            this.groupBoxFilters_MAP.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxFilters_MAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxFilters_MAP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.groupBoxFilters_MAP.Location = new System.Drawing.Point(343, 0);
            this.groupBoxFilters_MAP.Name = "groupBoxFilters_MAP";
            this.groupBoxFilters_MAP.Size = new System.Drawing.Size(915, 144);
            this.groupBoxFilters_MAP.TabIndex = 3;
            this.groupBoxFilters_MAP.TabStop = false;
            this.groupBoxFilters_MAP.Text = "Фильтры";
            // 
            // labelSearch_MAP
            // 
            this.labelSearch_MAP.AutoSize = true;
            this.labelSearch_MAP.Location = new System.Drawing.Point(21, 20);
            this.labelSearch_MAP.Name = "labelSearch_MAP";
            this.labelSearch_MAP.Size = new System.Drawing.Size(52, 18);
            this.labelSearch_MAP.TabIndex = 14;
            this.labelSearch_MAP.Text = "Поиск";
            // 
            // textBoxSearch_MAP
            // 
            this.textBoxSearch_MAP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.textBoxSearch_MAP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.textBoxSearch_MAP.Location = new System.Drawing.Point(24, 41);
            this.textBoxSearch_MAP.Name = "textBoxSearch_MAP";
            this.textBoxSearch_MAP.Size = new System.Drawing.Size(225, 24);
            this.textBoxSearch_MAP.TabIndex = 13;
            this.textBoxSearch_MAP.TextChanged += new System.EventHandler(this.textBoxSearch_MAP_TextChanged);
            // 
            // buttonReset_MAP
            // 
            this.buttonReset_MAP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.buttonReset_MAP.Location = new System.Drawing.Point(826, 41);
            this.buttonReset_MAP.Name = "buttonReset_MAP";
            this.buttonReset_MAP.Size = new System.Drawing.Size(86, 79);
            this.buttonReset_MAP.TabIndex = 12;
            this.buttonReset_MAP.Text = "Сбросить фильтры";
            this.buttonReset_MAP.UseVisualStyleBackColor = false;
            this.buttonReset_MAP.Click += new System.EventHandler(this.buttonReset_MAP_Click);
            // 
            // labelBirthday_MAP
            // 
            this.labelBirthday_MAP.AutoSize = true;
            this.labelBirthday_MAP.Location = new System.Drawing.Point(556, 20);
            this.labelBirthday_MAP.Name = "labelBirthday_MAP";
            this.labelBirthday_MAP.Size = new System.Drawing.Size(118, 18);
            this.labelBirthday_MAP.TabIndex = 11;
            this.labelBirthday_MAP.Text = "Дата Рождения";
            // 
            // numericUpDownID_MAP
            // 
            this.numericUpDownID_MAP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.numericUpDownID_MAP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.numericUpDownID_MAP.Location = new System.Drawing.Point(279, 41);
            this.numericUpDownID_MAP.Name = "numericUpDownID_MAP";
            this.numericUpDownID_MAP.Size = new System.Drawing.Size(67, 24);
            this.numericUpDownID_MAP.TabIndex = 10;
            this.numericUpDownID_MAP.ValueChanged += new System.EventHandler(this.numericUpDownID_MAP_ValueChanged);
            // 
            // dateTimePickerBirthday_MAP
            // 
            this.dateTimePickerBirthday_MAP.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerBirthday_MAP.Location = new System.Drawing.Point(554, 41);
            this.dateTimePickerBirthday_MAP.Name = "dateTimePickerBirthday_MAP";
            this.dateTimePickerBirthday_MAP.Size = new System.Drawing.Size(120, 24);
            this.dateTimePickerBirthday_MAP.TabIndex = 4;
            this.dateTimePickerBirthday_MAP.ValueChanged += new System.EventHandler(this.dateTimePickerBirthday_MAP_ValueChanged);
            // 
            // labelDiagnosis_MAP
            // 
            this.labelDiagnosis_MAP.AutoSize = true;
            this.labelDiagnosis_MAP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.labelDiagnosis_MAP.Location = new System.Drawing.Point(238, 89);
            this.labelDiagnosis_MAP.Name = "labelDiagnosis_MAP";
            this.labelDiagnosis_MAP.Size = new System.Drawing.Size(67, 18);
            this.labelDiagnosis_MAP.TabIndex = 9;
            this.labelDiagnosis_MAP.Text = "Диагноз";
            // 
            // labelDoctorSPN_MAP
            // 
            this.labelDoctorSPN_MAP.AutoSize = true;
            this.labelDoctorSPN_MAP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.labelDoctorSPN_MAP.Location = new System.Drawing.Point(57, 90);
            this.labelDoctorSPN_MAP.Name = "labelDoctorSPN_MAP";
            this.labelDoctorSPN_MAP.Size = new System.Drawing.Size(88, 18);
            this.labelDoctorSPN_MAP.TabIndex = 8;
            this.labelDoctorSPN_MAP.Text = "ФИО врача";
            // 
            // labelPatientSPN_MAP
            // 
            this.labelPatientSPN_MAP.AutoSize = true;
            this.labelPatientSPN_MAP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.labelPatientSPN_MAP.Location = new System.Drawing.Point(393, 20);
            this.labelPatientSPN_MAP.Name = "labelPatientSPN_MAP";
            this.labelPatientSPN_MAP.Size = new System.Drawing.Size(111, 18);
            this.labelPatientSPN_MAP.TabIndex = 7;
            this.labelPatientSPN_MAP.Text = "ФИО пациента";
            // 
            // labelID_MAP
            // 
            this.labelID_MAP.AutoSize = true;
            this.labelID_MAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelID_MAP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.labelID_MAP.Location = new System.Drawing.Point(251, 20);
            this.labelID_MAP.Name = "labelID_MAP";
            this.labelID_MAP.Size = new System.Drawing.Size(122, 18);
            this.labelID_MAP.TabIndex = 6;
            this.labelID_MAP.Text = "Номер пациента";
            // 
            // textBoxDiagnosis_MAP
            // 
            this.textBoxDiagnosis_MAP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.textBoxDiagnosis_MAP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.textBoxDiagnosis_MAP.Location = new System.Drawing.Point(205, 111);
            this.textBoxDiagnosis_MAP.Name = "textBoxDiagnosis_MAP";
            this.textBoxDiagnosis_MAP.Size = new System.Drawing.Size(141, 24);
            this.textBoxDiagnosis_MAP.TabIndex = 5;
            this.textBoxDiagnosis_MAP.TextChanged += new System.EventHandler(this.textBoxPatronymic_MAP_TextChanged);
            // 
            // textBoxDoctorSPN_MAP
            // 
            this.textBoxDoctorSPN_MAP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.textBoxDoctorSPN_MAP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.textBoxDoctorSPN_MAP.Location = new System.Drawing.Point(24, 111);
            this.textBoxDoctorSPN_MAP.Name = "textBoxDoctorSPN_MAP";
            this.textBoxDoctorSPN_MAP.Size = new System.Drawing.Size(172, 24);
            this.textBoxDoctorSPN_MAP.TabIndex = 4;
            this.textBoxDoctorSPN_MAP.TextChanged += new System.EventHandler(this.textBoxName_MAP_TextChanged);
            // 
            // textBoxPatientSPN_MAP
            // 
            this.textBoxPatientSPN_MAP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.textBoxPatientSPN_MAP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.textBoxPatientSPN_MAP.Location = new System.Drawing.Point(374, 41);
            this.textBoxPatientSPN_MAP.Name = "textBoxPatientSPN_MAP";
            this.textBoxPatientSPN_MAP.Size = new System.Drawing.Size(145, 24);
            this.textBoxPatientSPN_MAP.TabIndex = 3;
            this.textBoxPatientSPN_MAP.TextChanged += new System.EventHandler(this.textBoxSurname_MAP_TextChanged);
            // 
            // groupBoxInstruments_MAP
            // 
            this.groupBoxInstruments_MAP.Controls.Add(this.buttonDeletePatient_MAP);
            this.groupBoxInstruments_MAP.Controls.Add(this.buttonAddPatient_MAP);
            this.groupBoxInstruments_MAP.Controls.Add(this.buttonGoToPatient_MAP);
            this.groupBoxInstruments_MAP.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxInstruments_MAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInstruments_MAP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.groupBoxInstruments_MAP.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInstruments_MAP.Name = "groupBoxInstruments_MAP";
            this.groupBoxInstruments_MAP.Size = new System.Drawing.Size(282, 144);
            this.groupBoxInstruments_MAP.TabIndex = 4;
            this.groupBoxInstruments_MAP.TabStop = false;
            this.groupBoxInstruments_MAP.Text = "Инструменты";
            // 
            // buttonDeletePatient_MAP
            // 
            this.buttonDeletePatient_MAP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.buttonDeletePatient_MAP.Enabled = false;
            this.buttonDeletePatient_MAP.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeletePatient_MAP.Image")));
            this.buttonDeletePatient_MAP.Location = new System.Drawing.Point(193, 41);
            this.buttonDeletePatient_MAP.Name = "buttonDeletePatient_MAP";
            this.buttonDeletePatient_MAP.Size = new System.Drawing.Size(66, 56);
            this.buttonDeletePatient_MAP.TabIndex = 3;
            this.toolTipForButtons_MAP.SetToolTip(this.buttonDeletePatient_MAP, "Удалить строку");
            this.buttonDeletePatient_MAP.UseVisualStyleBackColor = false;
            this.buttonDeletePatient_MAP.Click += new System.EventHandler(this.buttonDeletePatient_MAP_Click);
            // 
            // buttonAddPatient_MAP
            // 
            this.buttonAddPatient_MAP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.buttonAddPatient_MAP.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddPatient_MAP.Image")));
            this.buttonAddPatient_MAP.Location = new System.Drawing.Point(121, 41);
            this.buttonAddPatient_MAP.Name = "buttonAddPatient_MAP";
            this.buttonAddPatient_MAP.Size = new System.Drawing.Size(66, 56);
            this.buttonAddPatient_MAP.TabIndex = 1;
            this.toolTipForButtons_MAP.SetToolTip(this.buttonAddPatient_MAP, "Добавить строку");
            this.buttonAddPatient_MAP.UseVisualStyleBackColor = false;
            this.buttonAddPatient_MAP.Click += new System.EventHandler(this.buttonAddPatient_MAP_Click);
            // 
            // buttonGoToPatient_MAP
            // 
            this.buttonGoToPatient_MAP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.buttonGoToPatient_MAP.Enabled = false;
            this.buttonGoToPatient_MAP.Image = ((System.Drawing.Image)(resources.GetObject("buttonGoToPatient_MAP.Image")));
            this.buttonGoToPatient_MAP.Location = new System.Drawing.Point(16, 35);
            this.buttonGoToPatient_MAP.Name = "buttonGoToPatient_MAP";
            this.buttonGoToPatient_MAP.Size = new System.Drawing.Size(80, 71);
            this.buttonGoToPatient_MAP.TabIndex = 0;
            this.toolTipForButtons_MAP.SetToolTip(this.buttonGoToPatient_MAP, "Перейти к пациенту");
            this.buttonGoToPatient_MAP.UseVisualStyleBackColor = false;
            this.buttonGoToPatient_MAP.Click += new System.EventHandler(this.buttonGoToPAtient_MAP_Click);
            // 
            // panelForTable_MAP
            // 
            this.panelForTable_MAP.Controls.Add(this.dataGridViewPatients_MAP);
            this.panelForTable_MAP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForTable_MAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelForTable_MAP.Location = new System.Drawing.Point(0, 169);
            this.panelForTable_MAP.Name = "panelForTable_MAP";
            this.panelForTable_MAP.Size = new System.Drawing.Size(1258, 415);
            this.panelForTable_MAP.TabIndex = 5;
            // 
            // panelForGroupBoxes_MAP
            // 
            this.panelForGroupBoxes_MAP.Controls.Add(this.panelBetweenGroupBoxes_MAP);
            this.panelForGroupBoxes_MAP.Controls.Add(this.groupBoxInstruments_MAP);
            this.panelForGroupBoxes_MAP.Controls.Add(this.groupBoxFilters_MAP);
            this.panelForGroupBoxes_MAP.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelForGroupBoxes_MAP.Location = new System.Drawing.Point(0, 25);
            this.panelForGroupBoxes_MAP.Name = "panelForGroupBoxes_MAP";
            this.panelForGroupBoxes_MAP.Size = new System.Drawing.Size(1258, 144);
            this.panelForGroupBoxes_MAP.TabIndex = 6;
            // 
            // panelBetweenGroupBoxes_MAP
            // 
            this.panelBetweenGroupBoxes_MAP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBetweenGroupBoxes_MAP.Location = new System.Drawing.Point(282, 0);
            this.panelBetweenGroupBoxes_MAP.Name = "panelBetweenGroupBoxes_MAP";
            this.panelBetweenGroupBoxes_MAP.Size = new System.Drawing.Size(61, 144);
            this.panelBetweenGroupBoxes_MAP.TabIndex = 5;
            // 
            // numericUpDownDisabilityTime_MAP
            // 
            this.numericUpDownDisabilityTime_MAP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.numericUpDownDisabilityTime_MAP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.numericUpDownDisabilityTime_MAP.Location = new System.Drawing.Point(541, 110);
            this.numericUpDownDisabilityTime_MAP.Name = "numericUpDownDisabilityTime_MAP";
            this.numericUpDownDisabilityTime_MAP.Size = new System.Drawing.Size(67, 24);
            this.numericUpDownDisabilityTime_MAP.TabIndex = 15;
            this.numericUpDownDisabilityTime_MAP.ValueChanged += new System.EventHandler(this.numericUpDownDisabilityTime_MAP_ValueChanged);
            // 
            // comboBoxAmbulatory_MAP
            // 
            this.comboBoxAmbulatory_MAP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.comboBoxAmbulatory_MAP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAmbulatory_MAP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.comboBoxAmbulatory_MAP.FormattingEnabled = true;
            this.comboBoxAmbulatory_MAP.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.comboBoxAmbulatory_MAP.Location = new System.Drawing.Point(352, 109);
            this.comboBoxAmbulatory_MAP.Name = "comboBoxAmbulatory_MAP";
            this.comboBoxAmbulatory_MAP.Size = new System.Drawing.Size(121, 26);
            this.comboBoxAmbulatory_MAP.TabIndex = 16;
            this.comboBoxAmbulatory_MAP.SelectedIndexChanged += new System.EventHandler(this.comboBoxAmbulatory_MAP_SelectedIndexChanged);
            // 
            // comboBoxDispanser_MAP
            // 
            this.comboBoxDispanser_MAP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(56)))), ((int)(((byte)(56)))), ((int)(((byte)(56)))));
            this.comboBoxDispanser_MAP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxDispanser_MAP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.comboBoxDispanser_MAP.FormattingEnabled = true;
            this.comboBoxDispanser_MAP.Items.AddRange(new object[] {
            "Да",
            "Нет"});
            this.comboBoxDispanser_MAP.Location = new System.Drawing.Point(669, 107);
            this.comboBoxDispanser_MAP.Name = "comboBoxDispanser_MAP";
            this.comboBoxDispanser_MAP.Size = new System.Drawing.Size(121, 26);
            this.comboBoxDispanser_MAP.TabIndex = 17;
            this.comboBoxDispanser_MAP.SelectedIndexChanged += new System.EventHandler(this.comboBoxDispanser_MAP_SelectedIndexChanged);
            // 
            // labelAmbulatoryCare_MAP
            // 
            this.labelAmbulatoryCare_MAP.AutoSize = true;
            this.labelAmbulatoryCare_MAP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.labelAmbulatoryCare_MAP.Location = new System.Drawing.Point(359, 73);
            this.labelAmbulatoryCare_MAP.Name = "labelAmbulatoryCare_MAP";
            this.labelAmbulatoryCare_MAP.Size = new System.Drawing.Size(114, 36);
            this.labelAmbulatoryCare_MAP.TabIndex = 18;
            this.labelAmbulatoryCare_MAP.Text = "Амбулаторное \r\nлечение";
            this.labelAmbulatoryCare_MAP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelDisabilityTime_MAP
            // 
            this.labelDisabilityTime_MAP.AutoSize = true;
            this.labelDisabilityTime_MAP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.labelDisabilityTime_MAP.Location = new System.Drawing.Point(506, 74);
            this.labelDisabilityTime_MAP.Name = "labelDisabilityTime_MAP";
            this.labelDisabilityTime_MAP.Size = new System.Drawing.Size(139, 36);
            this.labelDisabilityTime_MAP.TabIndex = 19;
            this.labelDisabilityTime_MAP.Text = "Срок потери\r\nтрудоспособности";
            this.labelDisabilityTime_MAP.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // labelDispanser_MAP
            // 
            this.labelDispanser_MAP.AutoSize = true;
            this.labelDispanser_MAP.Location = new System.Drawing.Point(654, 87);
            this.labelDispanser_MAP.Name = "labelDispanser_MAP";
            this.labelDispanser_MAP.Size = new System.Drawing.Size(145, 18);
            this.labelDispanser_MAP.TabIndex = 20;
            this.labelDispanser_MAP.Text = "Диспансерный учёт";
            // 
            // FormMainPatients_MAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1258, 584);
            this.Controls.Add(this.panelForTable_MAP);
            this.Controls.Add(this.panelForGroupBoxes_MAP);
            this.Controls.Add(this.menuStripMust_MAP);
            this.MainMenuStrip = this.menuStripMust_MAP;
            this.MinimumSize = new System.Drawing.Size(1212, 351);
            this.Name = "FormMainPatients_MAP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Список Пациентов";
            this.Load += new System.EventHandler(this.FormMainPatients_MAP_Load);
            this.Resize += new System.EventHandler(this.FormMainPatients_MAP_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients_MAP)).EndInit();
            this.menuStripMust_MAP.ResumeLayout(false);
            this.menuStripMust_MAP.PerformLayout();
            this.groupBoxFilters_MAP.ResumeLayout(false);
            this.groupBoxFilters_MAP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID_MAP)).EndInit();
            this.groupBoxInstruments_MAP.ResumeLayout(false);
            this.panelForTable_MAP.ResumeLayout(false);
            this.panelForGroupBoxes_MAP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDisabilityTime_MAP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewPatients_MAP;
        private System.Windows.Forms.MenuStrip menuStripMust_MAP;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemFile_MAP;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemOpen_MAP;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSave_MAP;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemSaveAs_MAP;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemHelp_MAP;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemUserGuide_MAP;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAbout_MAP;
        private System.Windows.Forms.OpenFileDialog openFileDialogExcel_MAP;
        private System.Windows.Forms.SaveFileDialog saveFileDialogExcel_MAP;
        private System.Windows.Forms.ToolTip toolTipForButtons_MAP;
        private System.Windows.Forms.GroupBox groupBoxFilters_MAP;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday_MAP;
        private System.Windows.Forms.Label labelDiagnosis_MAP;
        private System.Windows.Forms.Label labelDoctorSPN_MAP;
        private System.Windows.Forms.Label labelPatientSPN_MAP;
        private System.Windows.Forms.Label labelID_MAP;
        private System.Windows.Forms.TextBox textBoxDiagnosis_MAP;
        private System.Windows.Forms.TextBox textBoxDoctorSPN_MAP;
        private System.Windows.Forms.TextBox textBoxPatientSPN_MAP;
        private System.Windows.Forms.GroupBox groupBoxInstruments_MAP;
        private System.Windows.Forms.Button buttonGoToPatient_MAP;
        private System.Windows.Forms.Button buttonDeletePatient_MAP;
        private System.Windows.Forms.Button buttonAddPatient_MAP;
        private System.Windows.Forms.Panel panelForTable_MAP;
        private System.Windows.Forms.Panel panelForGroupBoxes_MAP;
        private System.Windows.Forms.NumericUpDown numericUpDownID_MAP;
        private System.Windows.Forms.Label labelBirthday_MAP;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemNewTable_MAP;
        private System.Windows.Forms.Button buttonReset_MAP;
        private System.Windows.Forms.Panel panelBetweenGroupBoxes_MAP;
        private System.Windows.Forms.Label labelSearch_MAP;
        private System.Windows.Forms.TextBox textBoxSearch_MAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn SNP_MAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorSNP;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorPosition_MAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn diagnosis_MAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ambulatoryCare_MAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn disabilityTime_MAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn dispanser_MAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn notes_MAP;
        private System.Windows.Forms.Label labelDispanser_MAP;
        private System.Windows.Forms.Label labelDisabilityTime_MAP;
        private System.Windows.Forms.Label labelAmbulatoryCare_MAP;
        private System.Windows.Forms.ComboBox comboBoxDispanser_MAP;
        private System.Windows.Forms.ComboBox comboBoxAmbulatory_MAP;
        private System.Windows.Forms.NumericUpDown numericUpDownDisabilityTime_MAP;
    }
}

