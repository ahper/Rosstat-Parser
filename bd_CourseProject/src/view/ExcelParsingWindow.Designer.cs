namespace bd_CourseProject.src.view
{
    partial class ExcelParsingWindow
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
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tbTablename = new System.Windows.Forms.TextBox();
            this.cbSheet = new System.Windows.Forms.ComboBox();
            this.panelImportDb = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.numericDown = new System.Windows.Forms.NumericUpDown();
            this.numericUp = new System.Windows.Forms.NumericUpDown();
            this.btnImport = new MaterialSkin.Controls.MaterialRaisedButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnDownload = new MaterialSkin.Controls.MaterialRaisedButton();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label10 = new System.Windows.Forms.Label();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripExit = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripBdConntect = new System.Windows.Forms.ToolStripMenuItem();
            this.labelUrl = new System.Windows.Forms.Label();
            this.labelUrlFind = new System.Windows.Forms.Label();
            this.labelPrefix = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.territoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedworkedupreschoolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedworkedugnrlDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedworkeduaddchldrnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tchrseduorganprimsecondvocDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tchrseduhigherprofDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dctrshighermededumedsrvcsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parmedprsmedsrvcsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.juniordctrsmedsrvcsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.socialworkDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.workculturalinstitutionsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scientificstaffDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pedworkedumedsclsrvcsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averageSalaryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelImportDb.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUp)).BeginInit();
            this.panel2.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.averageSalaryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.territoryDataGridViewTextBoxColumn,
            this.pedworkedupreschoolDataGridViewTextBoxColumn,
            this.pedworkedugnrlDataGridViewTextBoxColumn,
            this.pedworkeduaddchldrnDataGridViewTextBoxColumn,
            this.tchrseduorganprimsecondvocDataGridViewTextBoxColumn,
            this.tchrseduhigherprofDataGridViewTextBoxColumn,
            this.dctrshighermededumedsrvcsDataGridViewTextBoxColumn,
            this.parmedprsmedsrvcsDataGridViewTextBoxColumn,
            this.juniordctrsmedsrvcsDataGridViewTextBoxColumn,
            this.socialworkDataGridViewTextBoxColumn,
            this.workculturalinstitutionsDataGridViewTextBoxColumn,
            this.scientificstaffDataGridViewTextBoxColumn,
            this.pedworkedumedsclsrvcsDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.averageSalaryBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(0, 63);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(0);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(903, 394);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dataGridView_RowsAdded);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(3, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Наименование \r\nтаблицы";
            // 
            // tbTablename
            // 
            this.tbTablename.Location = new System.Drawing.Point(134, 135);
            this.tbTablename.Name = "tbTablename";
            this.tbTablename.Size = new System.Drawing.Size(121, 20);
            this.tbTablename.TabIndex = 4;
            // 
            // cbSheet
            // 
            this.cbSheet.BackColor = System.Drawing.Color.White;
            this.cbSheet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSheet.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cbSheet.FormattingEnabled = true;
            this.cbSheet.Location = new System.Drawing.Point(134, 34);
            this.cbSheet.Name = "cbSheet";
            this.cbSheet.Size = new System.Drawing.Size(121, 21);
            this.cbSheet.TabIndex = 5;
            this.cbSheet.SelectedIndexChanged += new System.EventHandler(this.CbSheet_SelectedIndexChanged);
            // 
            // panelImportDb
            // 
            this.panelImportDb.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panelImportDb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelImportDb.Controls.Add(this.label1);
            this.panelImportDb.Controls.Add(this.numericDown);
            this.panelImportDb.Controls.Add(this.numericUp);
            this.panelImportDb.Controls.Add(this.btnImport);
            this.panelImportDb.Controls.Add(this.cbSheet);
            this.panelImportDb.Controls.Add(this.label6);
            this.panelImportDb.Controls.Add(this.label5);
            this.panelImportDb.Controls.Add(this.label4);
            this.panelImportDb.Controls.Add(this.tbTablename);
            this.panelImportDb.Controls.Add(this.label2);
            this.panelImportDb.Enabled = false;
            this.panelImportDb.Location = new System.Drawing.Point(328, 457);
            this.panelImportDb.Name = "panelImportDb";
            this.panelImportDb.Size = new System.Drawing.Size(343, 162);
            this.panelImportDb.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Текущий лист";
            // 
            // numericDown
            // 
            this.numericDown.Location = new System.Drawing.Point(134, 100);
            this.numericDown.Maximum = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.numericDown.Name = "numericDown";
            this.numericDown.Size = new System.Drawing.Size(49, 20);
            this.numericDown.TabIndex = 17;
            this.numericDown.ValueChanged += new System.EventHandler(this.NumericUpDown_Changed);
            // 
            // numericUp
            // 
            this.numericUp.Location = new System.Drawing.Point(134, 68);
            this.numericUp.Name = "numericUp";
            this.numericUp.Size = new System.Drawing.Size(49, 20);
            this.numericUp.TabIndex = 16;
            this.numericUp.ValueChanged += new System.EventHandler(this.NumericUpDown_Changed);
            // 
            // btnImport
            // 
            this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImport.Depth = 0;
            this.btnImport.Location = new System.Drawing.Point(263, 135);
            this.btnImport.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnImport.Name = "btnImport";
            this.btnImport.Primary = true;
            this.btnImport.Size = new System.Drawing.Size(75, 20);
            this.btnImport.TabIndex = 15;
            this.btnImport.Text = "ИМПОРТ";
            this.btnImport.UseVisualStyleBackColor = true;
            this.btnImport.Click += new System.EventHandler(this.BtnImport_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(2, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 17);
            this.label6.TabIndex = 7;
            this.label6.Text = "Конечная строка";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(2, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Начальная строка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(44, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(252, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Import settings into DataBase";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.labelPrefix);
            this.panel2.Controls.Add(this.labelUrlFind);
            this.panel2.Controls.Add(this.labelUrl);
            this.panel2.Controls.Add(this.btnDownload);
            this.panel2.Controls.Add(this.progressBar);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(0, 457);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(326, 162);
            this.panel2.TabIndex = 11;
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnDownload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDownload.Depth = 0;
            this.btnDownload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDownload.Font = new System.Drawing.Font("MS Gothic", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnDownload.Location = new System.Drawing.Point(235, 135);
            this.btnDownload.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Primary = true;
            this.btnDownload.Size = new System.Drawing.Size(86, 20);
            this.btnDownload.TabIndex = 13;
            this.btnDownload.Text = "СКАЧАТЬ";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.BtnDownload_Click);
            // 
            // progressBar
            // 
            this.progressBar.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.progressBar.Location = new System.Drawing.Point(7, 135);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(222, 20);
            this.progressBar.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(32, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(256, 18);
            this.label10.TabIndex = 5;
            this.label10.Text = "FINDING AND DOWNLOADING FILES";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // menuStrip
            // 
            this.menuStrip.AutoSize = false;
            this.menuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Font = new System.Drawing.Font("Baskerville Old Face", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip.GripMargin = new System.Windows.Forms.Padding(0);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripFile,
            this.ToolStripSettings});
            this.menuStrip.Location = new System.Drawing.Point(0, 23);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Padding = new System.Windows.Forms.Padding(0);
            this.menuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip.Size = new System.Drawing.Size(241, 40);
            this.menuStrip.TabIndex = 13;
            // 
            // ToolStripFile
            // 
            this.ToolStripFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.ToolStripFile.Checked = true;
            this.ToolStripFile.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ToolStripFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripOpenFile,
            this.toolStripExit});
            this.ToolStripFile.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ToolStripFile.Name = "ToolStripFile";
            this.ToolStripFile.Padding = new System.Windows.Forms.Padding(0);
            this.ToolStripFile.Size = new System.Drawing.Size(40, 40);
            this.ToolStripFile.Text = "Файл";
            this.ToolStripFile.DropDownClosed += new System.EventHandler(this.ToolStripMenuItem_DropDownClosed);
            this.ToolStripFile.DropDownOpening += new System.EventHandler(this.ToolStripMenuItem_DropDownOpening);
            // 
            // toolStripOpenFile
            // 
            this.toolStripOpenFile.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripOpenFile.Name = "toolStripOpenFile";
            this.toolStripOpenFile.Size = new System.Drawing.Size(118, 22);
            this.toolStripOpenFile.Text = "Открыть";
            this.toolStripOpenFile.Click += new System.EventHandler(this.ToolStripOpenFile_Click);
            // 
            // toolStripExit
            // 
            this.toolStripExit.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripExit.Name = "toolStripExit";
            this.toolStripExit.Size = new System.Drawing.Size(118, 22);
            this.toolStripExit.Text = "Выход";
            this.toolStripExit.Click += new System.EventHandler(this.ToolStripExit_Click);
            // 
            // ToolStripSettings
            // 
            this.ToolStripSettings.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(71)))), ((int)(((byte)(79)))));
            this.ToolStripSettings.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripBdConntect});
            this.ToolStripSettings.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ToolStripSettings.Name = "ToolStripSettings";
            this.ToolStripSettings.Padding = new System.Windows.Forms.Padding(0);
            this.ToolStripSettings.Size = new System.Drawing.Size(66, 40);
            this.ToolStripSettings.Text = "Настройка";
            this.ToolStripSettings.DropDownClosed += new System.EventHandler(this.ToolStripMenuItem_DropDownClosed);
            this.ToolStripSettings.DropDownOpening += new System.EventHandler(this.ToolStripMenuItem_DropDownOpening);
            // 
            // toolStripBdConntect
            // 
            this.toolStripBdConntect.Name = "toolStripBdConntect";
            this.toolStripBdConntect.Size = new System.Drawing.Size(224, 22);
            this.toolStripBdConntect.Text = "Подключиться к базе данных";
            this.toolStripBdConntect.Click += new System.EventHandler(this.ToolStripBdConnect_Click);
            // 
            // labelUrl
            // 
            this.labelUrl.Location = new System.Drawing.Point(99, 37);
            this.labelUrl.Name = "labelUrl";
            this.labelUrl.Size = new System.Drawing.Size(222, 13);
            this.labelUrl.TabIndex = 19;
            // 
            // labelUrlFind
            // 
            this.labelUrlFind.AutoEllipsis = true;
            this.labelUrlFind.Location = new System.Drawing.Point(99, 63);
            this.labelUrlFind.Name = "labelUrlFind";
            this.labelUrlFind.Size = new System.Drawing.Size(222, 37);
            this.labelUrlFind.TabIndex = 20;
            // 
            // labelPrefix
            // 
            this.labelPrefix.Location = new System.Drawing.Point(99, 100);
            this.labelPrefix.Name = "labelPrefix";
            this.labelPrefix.Size = new System.Drawing.Size(222, 13);
            this.labelPrefix.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(4, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 19);
            this.label3.TabIndex = 22;
            this.label3.Text = "URL";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(4, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 19);
            this.label7.TabIndex = 23;
            this.label7.Text = "URL_FIND";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(4, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 19);
            this.label8.TabIndex = 24;
            this.label8.Text = "PREFIX";
            // 
            // territoryDataGridViewTextBoxColumn
            // 
            this.territoryDataGridViewTextBoxColumn.DataPropertyName = "territory";
            this.territoryDataGridViewTextBoxColumn.HeaderText = "territory";
            this.territoryDataGridViewTextBoxColumn.Name = "territoryDataGridViewTextBoxColumn";
            this.territoryDataGridViewTextBoxColumn.ReadOnly = true;
            this.territoryDataGridViewTextBoxColumn.Width = 69;
            // 
            // pedworkedupreschoolDataGridViewTextBoxColumn
            // 
            this.pedworkedupreschoolDataGridViewTextBoxColumn.DataPropertyName = "ped_work_edu_preschool";
            this.pedworkedupreschoolDataGridViewTextBoxColumn.HeaderText = "ped_work_edu_preschool";
            this.pedworkedupreschoolDataGridViewTextBoxColumn.Name = "pedworkedupreschoolDataGridViewTextBoxColumn";
            this.pedworkedupreschoolDataGridViewTextBoxColumn.ReadOnly = true;
            this.pedworkedupreschoolDataGridViewTextBoxColumn.Width = 70;
            // 
            // pedworkedugnrlDataGridViewTextBoxColumn
            // 
            this.pedworkedugnrlDataGridViewTextBoxColumn.DataPropertyName = "ped_work_edu_gnrl";
            this.pedworkedugnrlDataGridViewTextBoxColumn.HeaderText = "ped_work_edu_gnrl";
            this.pedworkedugnrlDataGridViewTextBoxColumn.Name = "pedworkedugnrlDataGridViewTextBoxColumn";
            this.pedworkedugnrlDataGridViewTextBoxColumn.ReadOnly = true;
            this.pedworkedugnrlDataGridViewTextBoxColumn.Width = 69;
            // 
            // pedworkeduaddchldrnDataGridViewTextBoxColumn
            // 
            this.pedworkeduaddchldrnDataGridViewTextBoxColumn.DataPropertyName = "ped_work_edu_addchldrn";
            this.pedworkeduaddchldrnDataGridViewTextBoxColumn.HeaderText = "ped_work_edu_addchldrn";
            this.pedworkeduaddchldrnDataGridViewTextBoxColumn.Name = "pedworkeduaddchldrnDataGridViewTextBoxColumn";
            this.pedworkeduaddchldrnDataGridViewTextBoxColumn.ReadOnly = true;
            this.pedworkeduaddchldrnDataGridViewTextBoxColumn.Width = 69;
            // 
            // tchrseduorganprimsecondvocDataGridViewTextBoxColumn
            // 
            this.tchrseduorganprimsecondvocDataGridViewTextBoxColumn.DataPropertyName = "tchrs_edu_organprim_secondvoc";
            this.tchrseduorganprimsecondvocDataGridViewTextBoxColumn.HeaderText = "tchrs_edu_organprim_secondvoc";
            this.tchrseduorganprimsecondvocDataGridViewTextBoxColumn.Name = "tchrseduorganprimsecondvocDataGridViewTextBoxColumn";
            this.tchrseduorganprimsecondvocDataGridViewTextBoxColumn.ReadOnly = true;
            this.tchrseduorganprimsecondvocDataGridViewTextBoxColumn.Width = 70;
            // 
            // tchrseduhigherprofDataGridViewTextBoxColumn
            // 
            this.tchrseduhigherprofDataGridViewTextBoxColumn.DataPropertyName = "tchrs_edu_higherprof";
            this.tchrseduhigherprofDataGridViewTextBoxColumn.HeaderText = "tchrs_edu_higherprof";
            this.tchrseduhigherprofDataGridViewTextBoxColumn.Name = "tchrseduhigherprofDataGridViewTextBoxColumn";
            this.tchrseduhigherprofDataGridViewTextBoxColumn.ReadOnly = true;
            this.tchrseduhigherprofDataGridViewTextBoxColumn.Width = 69;
            // 
            // dctrshighermededumedsrvcsDataGridViewTextBoxColumn
            // 
            this.dctrshighermededumedsrvcsDataGridViewTextBoxColumn.DataPropertyName = "dctrs_highermed_edu_medsrvcs";
            this.dctrshighermededumedsrvcsDataGridViewTextBoxColumn.HeaderText = "dctrs_highermed_edu_medsrvcs";
            this.dctrshighermededumedsrvcsDataGridViewTextBoxColumn.Name = "dctrshighermededumedsrvcsDataGridViewTextBoxColumn";
            this.dctrshighermededumedsrvcsDataGridViewTextBoxColumn.ReadOnly = true;
            this.dctrshighermededumedsrvcsDataGridViewTextBoxColumn.Width = 69;
            // 
            // parmedprsmedsrvcsDataGridViewTextBoxColumn
            // 
            this.parmedprsmedsrvcsDataGridViewTextBoxColumn.DataPropertyName = "par_med_prs_medsrvcs";
            this.parmedprsmedsrvcsDataGridViewTextBoxColumn.HeaderText = "par_med_prs_medsrvcs";
            this.parmedprsmedsrvcsDataGridViewTextBoxColumn.Name = "parmedprsmedsrvcsDataGridViewTextBoxColumn";
            this.parmedprsmedsrvcsDataGridViewTextBoxColumn.ReadOnly = true;
            this.parmedprsmedsrvcsDataGridViewTextBoxColumn.Width = 69;
            // 
            // juniordctrsmedsrvcsDataGridViewTextBoxColumn
            // 
            this.juniordctrsmedsrvcsDataGridViewTextBoxColumn.DataPropertyName = "junior_dctrs_medsrvcs";
            this.juniordctrsmedsrvcsDataGridViewTextBoxColumn.HeaderText = "junior_dctrs_medsrvcs";
            this.juniordctrsmedsrvcsDataGridViewTextBoxColumn.Name = "juniordctrsmedsrvcsDataGridViewTextBoxColumn";
            this.juniordctrsmedsrvcsDataGridViewTextBoxColumn.ReadOnly = true;
            this.juniordctrsmedsrvcsDataGridViewTextBoxColumn.Width = 70;
            // 
            // socialworkDataGridViewTextBoxColumn
            // 
            this.socialworkDataGridViewTextBoxColumn.DataPropertyName = "social_work";
            this.socialworkDataGridViewTextBoxColumn.HeaderText = "social_work";
            this.socialworkDataGridViewTextBoxColumn.Name = "socialworkDataGridViewTextBoxColumn";
            this.socialworkDataGridViewTextBoxColumn.ReadOnly = true;
            this.socialworkDataGridViewTextBoxColumn.Width = 69;
            // 
            // workculturalinstitutionsDataGridViewTextBoxColumn
            // 
            this.workculturalinstitutionsDataGridViewTextBoxColumn.DataPropertyName = "work_cultural_institutions";
            this.workculturalinstitutionsDataGridViewTextBoxColumn.HeaderText = "work_cultural_institutions";
            this.workculturalinstitutionsDataGridViewTextBoxColumn.Name = "workculturalinstitutionsDataGridViewTextBoxColumn";
            this.workculturalinstitutionsDataGridViewTextBoxColumn.ReadOnly = true;
            this.workculturalinstitutionsDataGridViewTextBoxColumn.Width = 69;
            // 
            // scientificstaffDataGridViewTextBoxColumn
            // 
            this.scientificstaffDataGridViewTextBoxColumn.DataPropertyName = "scientific_staff";
            this.scientificstaffDataGridViewTextBoxColumn.HeaderText = "scientific_staff";
            this.scientificstaffDataGridViewTextBoxColumn.Name = "scientificstaffDataGridViewTextBoxColumn";
            this.scientificstaffDataGridViewTextBoxColumn.ReadOnly = true;
            this.scientificstaffDataGridViewTextBoxColumn.Width = 70;
            // 
            // pedworkedumedsclsrvcsDataGridViewTextBoxColumn
            // 
            this.pedworkedumedsclsrvcsDataGridViewTextBoxColumn.DataPropertyName = "ped_work_edu_med_sclsrvcs";
            this.pedworkedumedsclsrvcsDataGridViewTextBoxColumn.HeaderText = "ped_work_edu_med_sclsrvcs";
            this.pedworkedumedsclsrvcsDataGridViewTextBoxColumn.Name = "pedworkedumedsclsrvcsDataGridViewTextBoxColumn";
            this.pedworkedumedsclsrvcsDataGridViewTextBoxColumn.ReadOnly = true;
            this.pedworkedumedsclsrvcsDataGridViewTextBoxColumn.Width = 69;
            // 
            // averageSalaryBindingSource
            // 
            this.averageSalaryBindingSource.DataSource = typeof(bd_CourseProject.src.model.AverageSalary);
            // 
            // ExcelParsingWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 620);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelImportDb);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "ExcelParsingWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panelImportDb.ResumeLayout(false);
            this.panelImportDb.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUp)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.averageSalaryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbTablename;
        private System.Windows.Forms.ComboBox cbSheet;
        private System.Windows.Forms.Panel panelImportDb;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedworkedugeneralDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedworkeduaddchildrenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn paramedicalprsmedsrvcsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn socialworkesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workersculturalinstitutionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedworkedumedsocialsrvcsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn territoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedworkedupreschoolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedworkedugnrlDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedworkeduaddchldrnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tchrseduorganprimsecondvocDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tchrseduhigherprofDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dctrshighermededumedsrvcsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn parmedprsmedsrvcsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn juniordctrsmedsrvcsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn socialworkDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn workculturalinstitutionsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn scientificstaffDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn pedworkedumedsclsrvcsDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource averageSalaryBindingSource;
        private MaterialSkin.Controls.MaterialRaisedButton btnDownload;
        private MaterialSkin.Controls.MaterialRaisedButton btnImport;
        private System.Windows.Forms.NumericUpDown numericDown;
        private System.Windows.Forms.NumericUpDown numericUp;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripOpenFile;
        private System.Windows.Forms.ToolStripMenuItem toolStripExit;
        private System.Windows.Forms.ToolStripMenuItem ToolStripSettings;
        private System.Windows.Forms.ToolStripMenuItem toolStripBdConntect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPrefix;
        private System.Windows.Forms.Label labelUrlFind;
        private System.Windows.Forms.Label labelUrl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}