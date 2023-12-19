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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMainPatients_MAP));
            this.dataGridViewPatients_MAP = new System.Windows.Forms.DataGridView();
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
            this.labelBirthday_MAP = new System.Windows.Forms.Label();
            this.numericUpDownID_MAP = new System.Windows.Forms.NumericUpDown();
            this.dateTimePickerBirthday_MAP = new System.Windows.Forms.DateTimePicker();
            this.labelPatronymic_MAP = new System.Windows.Forms.Label();
            this.labelName_MAP = new System.Windows.Forms.Label();
            this.labelSurname_MAP = new System.Windows.Forms.Label();
            this.labelID_MAP = new System.Windows.Forms.Label();
            this.textBoxPatronymic_MAP = new System.Windows.Forms.TextBox();
            this.textBoxName_MAP = new System.Windows.Forms.TextBox();
            this.textBoxSurname_MAP = new System.Windows.Forms.TextBox();
            this.groupBoxInstruments_MAP = new System.Windows.Forms.GroupBox();
            this.buttonDeletePatient_MAP = new System.Windows.Forms.Button();
            this.buttonAddPatient_MAP = new System.Windows.Forms.Button();
            this.buttonGoToPatient_MAP = new System.Windows.Forms.Button();
            this.panelForTable_MAP = new System.Windows.Forms.Panel();
            this.panelForGroupBoxes_MAP = new System.Windows.Forms.Panel();
            this.buttonReset_MAP = new System.Windows.Forms.Button();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Surname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PatientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Patronymic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BirthDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panelBetweenGroupBoxes_MAP = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPatients_MAP)).BeginInit();
            this.menuStripMust_MAP.SuspendLayout();
            this.groupBoxFilters_MAP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownID_MAP)).BeginInit();
            this.groupBoxInstruments_MAP.SuspendLayout();
            this.panelForTable_MAP.SuspendLayout();
            this.panelForGroupBoxes_MAP.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewPatients_MAP
            // 
            this.dataGridViewPatients_MAP.AllowUserToAddRows = false;
            this.dataGridViewPatients_MAP.AllowUserToDeleteRows = false;
            this.dataGridViewPatients_MAP.AllowUserToResizeColumns = false;
            this.dataGridViewPatients_MAP.AllowUserToResizeRows = false;
            this.dataGridViewPatients_MAP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewPatients_MAP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewPatients_MAP.ColumnHeadersHeight = 35;
            this.dataGridViewPatients_MAP.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Surname,
            this.PatientName,
            this.Patronymic,
            this.BirthDate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewPatients_MAP.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewPatients_MAP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPatients_MAP.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewPatients_MAP.Name = "dataGridViewPatients_MAP";
            this.dataGridViewPatients_MAP.RowHeadersVisible = false;
            this.dataGridViewPatients_MAP.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewPatients_MAP.RowTemplate.Height = 25;
            this.dataGridViewPatients_MAP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewPatients_MAP.Size = new System.Drawing.Size(1151, 454);
            this.dataGridViewPatients_MAP.TabIndex = 0;
            this.dataGridViewPatients_MAP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridViewPatients_MAP_CellContentClick);
            this.dataGridViewPatients_MAP.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPatients_MAP_CellEndEdit);
            this.dataGridViewPatients_MAP.SelectionChanged += new System.EventHandler(this.dataGridViewPatients_MAP_SelectionChanged);
            this.dataGridViewPatients_MAP.SortCompare += new System.Windows.Forms.DataGridViewSortCompareEventHandler(this.dataGridViewPatients_MAP_SortCompare);
            // 
            // menuStripMust_MAP
            // 
            this.menuStripMust_MAP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemFile_MAP,
            this.ToolStripMenuItemHelp_MAP});
            this.menuStripMust_MAP.Location = new System.Drawing.Point(0, 0);
            this.menuStripMust_MAP.Name = "menuStripMust_MAP";
            this.menuStripMust_MAP.Size = new System.Drawing.Size(1151, 25);
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
            this.ToolStripMenuItemFile_MAP.Name = "ToolStripMenuItemFile_MAP";
            this.ToolStripMenuItemFile_MAP.Size = new System.Drawing.Size(50, 21);
            this.ToolStripMenuItemFile_MAP.Text = "Файл";
            // 
            // ToolStripMenuItemNewTable_MAP
            // 
            this.ToolStripMenuItemNewTable_MAP.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemNewTable_MAP.Image")));
            this.ToolStripMenuItemNewTable_MAP.Name = "ToolStripMenuItemNewTable_MAP";
            this.ToolStripMenuItemNewTable_MAP.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemNewTable_MAP.Text = "Новая таблица";
            this.ToolStripMenuItemNewTable_MAP.Click += new System.EventHandler(this.ToolStripMenuItemNewTable_MAP_Click);
            // 
            // ToolStripMenuItemOpen_MAP
            // 
            this.ToolStripMenuItemOpen_MAP.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemOpen_MAP.Image")));
            this.ToolStripMenuItemOpen_MAP.Name = "ToolStripMenuItemOpen_MAP";
            this.ToolStripMenuItemOpen_MAP.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemOpen_MAP.Text = "Открыть...";
            this.ToolStripMenuItemOpen_MAP.Click += new System.EventHandler(this.ToolStripMenuItemOpen_MAP_Click);
            // 
            // ToolStripMenuItemSave_MAP
            // 
            this.ToolStripMenuItemSave_MAP.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemSave_MAP.Image")));
            this.ToolStripMenuItemSave_MAP.Name = "ToolStripMenuItemSave_MAP";
            this.ToolStripMenuItemSave_MAP.Size = new System.Drawing.Size(180, 22);
            this.ToolStripMenuItemSave_MAP.Text = "Сохранить";
            this.ToolStripMenuItemSave_MAP.Click += new System.EventHandler(this.ToolStripMenuItemSave_MAP_Click);
            // 
            // ToolStripMenuItemSaveAs_MAP
            // 
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
            this.ToolStripMenuItemHelp_MAP.Name = "ToolStripMenuItemHelp_MAP";
            this.ToolStripMenuItemHelp_MAP.Size = new System.Drawing.Size(68, 21);
            this.ToolStripMenuItemHelp_MAP.Text = "Помощь";
            // 
            // ToolStripMenuItemUserGuide_MAP
            // 
            this.ToolStripMenuItemUserGuide_MAP.Image = ((System.Drawing.Image)(resources.GetObject("ToolStripMenuItemUserGuide_MAP.Image")));
            this.ToolStripMenuItemUserGuide_MAP.Name = "ToolStripMenuItemUserGuide_MAP";
            this.ToolStripMenuItemUserGuide_MAP.Size = new System.Drawing.Size(223, 22);
            this.ToolStripMenuItemUserGuide_MAP.Text = "Руководство Пользователя";
            this.ToolStripMenuItemUserGuide_MAP.Click += new System.EventHandler(this.ToolStripMenuItemUserGuide_MAP_Click);
            // 
            // ToolStripMenuItemAbout_MAP
            // 
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
            this.groupBoxFilters_MAP.Controls.Add(this.buttonReset_MAP);
            this.groupBoxFilters_MAP.Controls.Add(this.labelBirthday_MAP);
            this.groupBoxFilters_MAP.Controls.Add(this.numericUpDownID_MAP);
            this.groupBoxFilters_MAP.Controls.Add(this.dateTimePickerBirthday_MAP);
            this.groupBoxFilters_MAP.Controls.Add(this.labelPatronymic_MAP);
            this.groupBoxFilters_MAP.Controls.Add(this.labelName_MAP);
            this.groupBoxFilters_MAP.Controls.Add(this.labelSurname_MAP);
            this.groupBoxFilters_MAP.Controls.Add(this.labelID_MAP);
            this.groupBoxFilters_MAP.Controls.Add(this.textBoxPatronymic_MAP);
            this.groupBoxFilters_MAP.Controls.Add(this.textBoxName_MAP);
            this.groupBoxFilters_MAP.Controls.Add(this.textBoxSurname_MAP);
            this.groupBoxFilters_MAP.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupBoxFilters_MAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxFilters_MAP.Location = new System.Drawing.Point(322, 0);
            this.groupBoxFilters_MAP.Name = "groupBoxFilters_MAP";
            this.groupBoxFilters_MAP.Size = new System.Drawing.Size(829, 93);
            this.groupBoxFilters_MAP.TabIndex = 3;
            this.groupBoxFilters_MAP.TabStop = false;
            this.groupBoxFilters_MAP.Text = "Фильтры";
            // 
            // labelBirthday_MAP
            // 
            this.labelBirthday_MAP.AutoSize = true;
            this.labelBirthday_MAP.Location = new System.Drawing.Point(537, 26);
            this.labelBirthday_MAP.Name = "labelBirthday_MAP";
            this.labelBirthday_MAP.Size = new System.Drawing.Size(118, 18);
            this.labelBirthday_MAP.TabIndex = 11;
            this.labelBirthday_MAP.Text = "Дата Рождения";
            // 
            // numericUpDownID_MAP
            // 
            this.numericUpDownID_MAP.Location = new System.Drawing.Point(24, 47);
            this.numericUpDownID_MAP.Name = "numericUpDownID_MAP";
            this.numericUpDownID_MAP.Size = new System.Drawing.Size(67, 24);
            this.numericUpDownID_MAP.TabIndex = 10;
            this.numericUpDownID_MAP.ValueChanged += new System.EventHandler(this.numericUpDownID_MAP_ValueChanged);
            // 
            // dateTimePickerBirthday_MAP
            // 
            this.dateTimePickerBirthday_MAP.Location = new System.Drawing.Point(508, 47);
            this.dateTimePickerBirthday_MAP.Name = "dateTimePickerBirthday_MAP";
            this.dateTimePickerBirthday_MAP.Size = new System.Drawing.Size(173, 24);
            this.dateTimePickerBirthday_MAP.TabIndex = 4;
            this.dateTimePickerBirthday_MAP.ValueChanged += new System.EventHandler(this.dateTimePickerBirthday_MAP_ValueChanged);
            // 
            // labelPatronymic_MAP
            // 
            this.labelPatronymic_MAP.AutoSize = true;
            this.labelPatronymic_MAP.Location = new System.Drawing.Point(393, 26);
            this.labelPatronymic_MAP.Name = "labelPatronymic_MAP";
            this.labelPatronymic_MAP.Size = new System.Drawing.Size(75, 18);
            this.labelPatronymic_MAP.TabIndex = 9;
            this.labelPatronymic_MAP.Text = "Отчество";
            // 
            // labelName_MAP
            // 
            this.labelName_MAP.AutoSize = true;
            this.labelName_MAP.Location = new System.Drawing.Point(284, 26);
            this.labelName_MAP.Name = "labelName_MAP";
            this.labelName_MAP.Size = new System.Drawing.Size(38, 18);
            this.labelName_MAP.TabIndex = 8;
            this.labelName_MAP.Text = "Имя";
            // 
            // labelSurname_MAP
            // 
            this.labelSurname_MAP.AutoSize = true;
            this.labelSurname_MAP.Location = new System.Drawing.Point(148, 26);
            this.labelSurname_MAP.Name = "labelSurname_MAP";
            this.labelSurname_MAP.Size = new System.Drawing.Size(73, 18);
            this.labelSurname_MAP.TabIndex = 7;
            this.labelSurname_MAP.Text = "Фамилия";
            // 
            // labelID_MAP
            // 
            this.labelID_MAP.AutoSize = true;
            this.labelID_MAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelID_MAP.Location = new System.Drawing.Point(6, 26);
            this.labelID_MAP.Name = "labelID_MAP";
            this.labelID_MAP.Size = new System.Drawing.Size(122, 18);
            this.labelID_MAP.TabIndex = 6;
            this.labelID_MAP.Text = "Номер пациента";
            // 
            // textBoxPatronymic_MAP
            // 
            this.textBoxPatronymic_MAP.Location = new System.Drawing.Point(361, 47);
            this.textBoxPatronymic_MAP.Name = "textBoxPatronymic_MAP";
            this.textBoxPatronymic_MAP.Size = new System.Drawing.Size(141, 24);
            this.textBoxPatronymic_MAP.TabIndex = 5;
            // 
            // textBoxName_MAP
            // 
            this.textBoxName_MAP.Location = new System.Drawing.Point(255, 47);
            this.textBoxName_MAP.Name = "textBoxName_MAP";
            this.textBoxName_MAP.Size = new System.Drawing.Size(100, 24);
            this.textBoxName_MAP.TabIndex = 4;
            // 
            // textBoxSurname_MAP
            // 
            this.textBoxSurname_MAP.Location = new System.Drawing.Point(124, 47);
            this.textBoxSurname_MAP.Name = "textBoxSurname_MAP";
            this.textBoxSurname_MAP.Size = new System.Drawing.Size(125, 24);
            this.textBoxSurname_MAP.TabIndex = 3;
            this.textBoxSurname_MAP.TextChanged += new System.EventHandler(this.textBoxSurname_MAP_TextChanged);
            // 
            // groupBoxInstruments_MAP
            // 
            this.groupBoxInstruments_MAP.Controls.Add(this.buttonDeletePatient_MAP);
            this.groupBoxInstruments_MAP.Controls.Add(this.buttonAddPatient_MAP);
            this.groupBoxInstruments_MAP.Controls.Add(this.buttonGoToPatient_MAP);
            this.groupBoxInstruments_MAP.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBoxInstruments_MAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxInstruments_MAP.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInstruments_MAP.Name = "groupBoxInstruments_MAP";
            this.groupBoxInstruments_MAP.Size = new System.Drawing.Size(282, 93);
            this.groupBoxInstruments_MAP.TabIndex = 4;
            this.groupBoxInstruments_MAP.TabStop = false;
            this.groupBoxInstruments_MAP.Text = "Инструменты";
            // 
            // buttonDeletePatient_MAP
            // 
            this.buttonDeletePatient_MAP.Enabled = false;
            this.buttonDeletePatient_MAP.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeletePatient_MAP.Image")));
            this.buttonDeletePatient_MAP.Location = new System.Drawing.Point(193, 26);
            this.buttonDeletePatient_MAP.Name = "buttonDeletePatient_MAP";
            this.buttonDeletePatient_MAP.Size = new System.Drawing.Size(66, 56);
            this.buttonDeletePatient_MAP.TabIndex = 3;
            this.buttonDeletePatient_MAP.UseVisualStyleBackColor = true;
            this.buttonDeletePatient_MAP.Click += new System.EventHandler(this.buttonDeletePatient_MAP_Click);
            // 
            // buttonAddPatient_MAP
            // 
            this.buttonAddPatient_MAP.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddPatient_MAP.Image")));
            this.buttonAddPatient_MAP.Location = new System.Drawing.Point(121, 26);
            this.buttonAddPatient_MAP.Name = "buttonAddPatient_MAP";
            this.buttonAddPatient_MAP.Size = new System.Drawing.Size(66, 56);
            this.buttonAddPatient_MAP.TabIndex = 1;
            this.buttonAddPatient_MAP.UseVisualStyleBackColor = true;
            this.buttonAddPatient_MAP.Click += new System.EventHandler(this.buttonAddPatient_MAP_Click);
            // 
            // buttonGoToPatient_MAP
            // 
            this.buttonGoToPatient_MAP.Enabled = false;
            this.buttonGoToPatient_MAP.Image = ((System.Drawing.Image)(resources.GetObject("buttonGoToPatient_MAP.Image")));
            this.buttonGoToPatient_MAP.Location = new System.Drawing.Point(16, 20);
            this.buttonGoToPatient_MAP.Name = "buttonGoToPatient_MAP";
            this.buttonGoToPatient_MAP.Size = new System.Drawing.Size(80, 71);
            this.buttonGoToPatient_MAP.TabIndex = 0;
            this.buttonGoToPatient_MAP.UseVisualStyleBackColor = true;
            this.buttonGoToPatient_MAP.Click += new System.EventHandler(this.buttonGoToPAtient_MAP_Click);
            // 
            // panelForTable_MAP
            // 
            this.panelForTable_MAP.Controls.Add(this.dataGridViewPatients_MAP);
            this.panelForTable_MAP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelForTable_MAP.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.panelForTable_MAP.Location = new System.Drawing.Point(0, 118);
            this.panelForTable_MAP.Name = "panelForTable_MAP";
            this.panelForTable_MAP.Size = new System.Drawing.Size(1151, 454);
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
            this.panelForGroupBoxes_MAP.Size = new System.Drawing.Size(1151, 93);
            this.panelForGroupBoxes_MAP.TabIndex = 6;
            // 
            // buttonReset_MAP
            // 
            this.buttonReset_MAP.Location = new System.Drawing.Point(699, 26);
            this.buttonReset_MAP.Name = "buttonReset_MAP";
            this.buttonReset_MAP.Size = new System.Drawing.Size(115, 56);
            this.buttonReset_MAP.TabIndex = 12;
            this.buttonReset_MAP.Text = "Сбросить фильтры";
            this.buttonReset_MAP.UseVisualStyleBackColor = true;
            this.buttonReset_MAP.Click += new System.EventHandler(this.buttonReset_MAP_Click);
            // 
            // Id
            // 
            this.Id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Id.HeaderText = "Номер";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Id.Width = 85;
            // 
            // Surname
            // 
            this.Surname.HeaderText = "Фамилия";
            this.Surname.MinimumWidth = 200;
            this.Surname.Name = "Surname";
            this.Surname.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // PatientName
            // 
            this.PatientName.HeaderText = "Имя";
            this.PatientName.Name = "PatientName";
            this.PatientName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Patronymic
            // 
            this.Patronymic.HeaderText = "Отчество";
            this.Patronymic.Name = "Patronymic";
            this.Patronymic.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // BirthDate
            // 
            this.BirthDate.HeaderText = "Дата Рождения";
            this.BirthDate.Name = "BirthDate";
            this.BirthDate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // panelBetweenGroupBoxes_MAP
            // 
            this.panelBetweenGroupBoxes_MAP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBetweenGroupBoxes_MAP.Location = new System.Drawing.Point(282, 0);
            this.panelBetweenGroupBoxes_MAP.Name = "panelBetweenGroupBoxes_MAP";
            this.panelBetweenGroupBoxes_MAP.Size = new System.Drawing.Size(40, 93);
            this.panelBetweenGroupBoxes_MAP.TabIndex = 5;
            // 
            // FormMainPatients_MAP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 572);
            this.Controls.Add(this.panelForTable_MAP);
            this.Controls.Add(this.panelForGroupBoxes_MAP);
            this.Controls.Add(this.menuStripMust_MAP);
            this.MainMenuStrip = this.menuStripMust_MAP;
            this.MinimumSize = new System.Drawing.Size(1124, 351);
            this.Name = "FormMainPatients_MAP";
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
        private System.Windows.Forms.Label labelPatronymic_MAP;
        private System.Windows.Forms.Label labelName_MAP;
        private System.Windows.Forms.Label labelSurname_MAP;
        private System.Windows.Forms.Label labelID_MAP;
        private System.Windows.Forms.TextBox textBoxPatronymic_MAP;
        private System.Windows.Forms.TextBox textBoxName_MAP;
        private System.Windows.Forms.TextBox textBoxSurname_MAP;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Surname;
        private System.Windows.Forms.DataGridViewTextBoxColumn PatientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Patronymic;
        private System.Windows.Forms.DataGridViewTextBoxColumn BirthDate;
        private System.Windows.Forms.Panel panelBetweenGroupBoxes_MAP;
    }
}

