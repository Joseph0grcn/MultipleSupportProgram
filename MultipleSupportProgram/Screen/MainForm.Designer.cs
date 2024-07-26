namespace MultipleSupportProgram
{
    partial class MainForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControlProcessHeaders = new System.Windows.Forms.TabControl();
            this.tpBackup = new System.Windows.Forms.TabPage();
            this.grpBoxPatch = new System.Windows.Forms.GroupBox();
            this.cbxDbNameBackup = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnBackupFileLocationSelect = new System.Windows.Forms.Button();
            this.txtBackupPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tpRestore = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbxDbNameRestore = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRestore = new System.Windows.Forms.Button();
            this.btnRestoreFile = new System.Windows.Forms.Button();
            this.txtRestorePath = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tpSQLFile = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSQLRun = new System.Windows.Forms.Button();
            this.btnSQLFileSelect = new System.Windows.Forms.Button();
            this.txtSQLFile = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tpSPWinDatabasePhotoDelete = new System.Windows.Forms.TabPage();
            this.lblDateFinish = new System.Windows.Forms.Label();
            this.lblDateStart = new System.Windows.Forms.Label();
            this.dtpFinish = new System.Windows.Forms.DateTimePicker();
            this.rdbAll = new System.Windows.Forms.RadioButton();
            this.rdbPeriod = new System.Windows.Forms.RadioButton();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.rbAllPhoto = new System.Windows.Forms.RadioButton();
            this.rbInTheFolderPhoto = new System.Windows.Forms.RadioButton();
            this.rbOneAndTwoPhoto = new System.Windows.Forms.RadioButton();
            this.btnWeighPhotoDelete = new System.Windows.Forms.Button();
            this.tpDatabaseRepair = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.cbxDbNameRepair = new System.Windows.Forms.ComboBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tpSPWinScaleAndDBAConsolidation = new System.Windows.Forms.TabPage();
            this.btnMoveDbaToScale = new System.Windows.Forms.Button();
            this.tpTablolar = new System.Windows.Forms.TabPage();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.CbxtableList = new System.Windows.Forms.ComboBox();
            this.btngoster = new System.Windows.Forms.Button();
            this.dataGV1 = new System.Windows.Forms.DataGridView();
            this.tpQuary = new System.Windows.Forms.TabPage();
            this.label7 = new System.Windows.Forms.Label();
            this.lblQuaryName = new System.Windows.Forms.Label();
            this.tbxQuaryName = new System.Windows.Forms.TextBox();
            this.tbxQuarySaveLoc = new System.Windows.Forms.TextBox();
            this.btnloc = new System.Windows.Forms.Button();
            this.btnQuaryClear = new System.Windows.Forms.Button();
            this.btnQuarySave = new System.Windows.Forms.Button();
            this.tbxQuary = new System.Windows.Forms.RichTextBox();
            this.tbSorgu = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.rtbSorgula = new System.Windows.Forms.RichTextBox();
            this.esitUserEkle = new System.Windows.Forms.TabPage();
            this.cbUserAddUserRole = new System.Windows.Forms.ComboBox();
            this.lbUserAddUserRole = new System.Windows.Forms.Label();
            this.tbUserAddUserPassword = new System.Windows.Forms.TextBox();
            this.tbUserAddUserName = new System.Windows.Forms.TextBox();
            this.lbUserAddUserPassword = new System.Windows.Forms.Label();
            this.lbUserAddUserName = new System.Windows.Forms.Label();
            this.btnEsitUserEkle = new System.Windows.Forms.Button();
            this.EsitScaleSil = new System.Windows.Forms.TabPage();
            this.btnEsitScaleSil = new System.Windows.Forms.Button();
            this.tpCamPhotoLink = new System.Windows.Forms.TabPage();
            this.btnLinkCopy = new System.Windows.Forms.Button();
            this.tbCamLink = new System.Windows.Forms.TextBox();
            this.btnCamLinkCreate = new System.Windows.Forms.Button();
            this.cbCamType = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCamPassword = new System.Windows.Forms.TextBox();
            this.tbCamUser = new System.Windows.Forms.TextBox();
            this.tbCamIpAddress = new System.Windows.Forms.TextBox();
            this.lblCamPassword = new System.Windows.Forms.Label();
            this.lblCamUser = new System.Windows.Forms.Label();
            this.lblCamIpAddress = new System.Windows.Forms.Label();
            this.tpTartımSilme = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rbTartım1 = new System.Windows.Forms.RadioButton();
            this.rbTartım2 = new System.Windows.Forms.RadioButton();
            this.btnTartımSilme = new System.Windows.Forms.Button();
            this.lbTartımEnd = new System.Windows.Forms.Label();
            this.lbTartımStart = new System.Windows.Forms.Label();
            this.dtpTartımDateEnd = new System.Windows.Forms.DateTimePicker();
            this.rbTartımAllDelete = new System.Windows.Forms.RadioButton();
            this.rbTartımPeriodDelete = new System.Windows.Forms.RadioButton();
            this.dtpTartımDateStart = new System.Windows.Forms.DateTimePicker();
            this.gbConnectionSettings = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbxUsername = new System.Windows.Forms.ComboBox();
            this.cbxDbName = new System.Windows.Forms.ComboBox();
            this.lblServer = new System.Windows.Forms.Label();
            this.CbWindowsAuthentication = new System.Windows.Forms.CheckBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.CBServers = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnConnectionTest = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dtpTartımSaatEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpTartımSaatStart = new System.Windows.Forms.DateTimePicker();
            this.tabControlProcessHeaders.SuspendLayout();
            this.tpBackup.SuspendLayout();
            this.grpBoxPatch.SuspendLayout();
            this.tpRestore.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tpSQLFile.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tpSPWinDatabasePhotoDelete.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tpDatabaseRepair.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tpSPWinScaleAndDBAConsolidation.SuspendLayout();
            this.tpTablolar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV1)).BeginInit();
            this.tpQuary.SuspendLayout();
            this.tbSorgu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.esitUserEkle.SuspendLayout();
            this.EsitScaleSil.SuspendLayout();
            this.tpCamPhotoLink.SuspendLayout();
            this.tpTartımSilme.SuspendLayout();
            this.panel3.SuspendLayout();
            this.gbConnectionSettings.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlProcessHeaders
            // 
            this.tabControlProcessHeaders.Controls.Add(this.tpBackup);
            this.tabControlProcessHeaders.Controls.Add(this.tpRestore);
            this.tabControlProcessHeaders.Controls.Add(this.tpSQLFile);
            this.tabControlProcessHeaders.Controls.Add(this.tpSPWinDatabasePhotoDelete);
            this.tabControlProcessHeaders.Controls.Add(this.tpDatabaseRepair);
            this.tabControlProcessHeaders.Controls.Add(this.tpSPWinScaleAndDBAConsolidation);
            this.tabControlProcessHeaders.Controls.Add(this.tpTablolar);
            this.tabControlProcessHeaders.Controls.Add(this.tpQuary);
            this.tabControlProcessHeaders.Controls.Add(this.tbSorgu);
            this.tabControlProcessHeaders.Controls.Add(this.esitUserEkle);
            this.tabControlProcessHeaders.Controls.Add(this.EsitScaleSil);
            this.tabControlProcessHeaders.Controls.Add(this.tpCamPhotoLink);
            this.tabControlProcessHeaders.Controls.Add(this.tpTartımSilme);
            this.tabControlProcessHeaders.Enabled = false;
            this.tabControlProcessHeaders.Location = new System.Drawing.Point(3, 262);
            this.tabControlProcessHeaders.Multiline = true;
            this.tabControlProcessHeaders.Name = "tabControlProcessHeaders";
            this.tabControlProcessHeaders.SelectedIndex = 0;
            this.tabControlProcessHeaders.Size = new System.Drawing.Size(661, 350);
            this.tabControlProcessHeaders.TabIndex = 0;
            // 
            // tpBackup
            // 
            this.tpBackup.BackColor = System.Drawing.SystemColors.Control;
            this.tpBackup.Controls.Add(this.grpBoxPatch);
            this.tpBackup.Location = new System.Drawing.Point(4, 40);
            this.tpBackup.Name = "tpBackup";
            this.tpBackup.Padding = new System.Windows.Forms.Padding(3);
            this.tpBackup.Size = new System.Drawing.Size(653, 306);
            this.tpBackup.TabIndex = 0;
            this.tpBackup.Text = "Yedekle";
            // 
            // grpBoxPatch
            // 
            this.grpBoxPatch.Controls.Add(this.cbxDbNameBackup);
            this.grpBoxPatch.Controls.Add(this.label2);
            this.grpBoxPatch.Controls.Add(this.btnBackup);
            this.grpBoxPatch.Controls.Add(this.btnBackupFileLocationSelect);
            this.grpBoxPatch.Controls.Add(this.txtBackupPath);
            this.grpBoxPatch.Controls.Add(this.label1);
            this.grpBoxPatch.Location = new System.Drawing.Point(105, 97);
            this.grpBoxPatch.Name = "grpBoxPatch";
            this.grpBoxPatch.Size = new System.Drawing.Size(432, 130);
            this.grpBoxPatch.TabIndex = 5;
            this.grpBoxPatch.TabStop = false;
            this.grpBoxPatch.Text = "Veritabanı Yedekleme";
            // 
            // cbxDbNameBackup
            // 
            this.cbxDbNameBackup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDbNameBackup.FormattingEnabled = true;
            this.cbxDbNameBackup.Location = new System.Drawing.Point(160, 28);
            this.cbxDbNameBackup.Name = "cbxDbNameBackup";
            this.cbxDbNameBackup.Size = new System.Drawing.Size(264, 21);
            this.cbxDbNameBackup.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Veritabanı Adı :";
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(160, 82);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(264, 31);
            this.btnBackup.TabIndex = 4;
            this.btnBackup.Text = "Yedekle";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.BtnBackup_Click);
            // 
            // btnBackupFileLocationSelect
            // 
            this.btnBackupFileLocationSelect.Location = new System.Drawing.Point(360, 54);
            this.btnBackupFileLocationSelect.Name = "btnBackupFileLocationSelect";
            this.btnBackupFileLocationSelect.Size = new System.Drawing.Size(64, 22);
            this.btnBackupFileLocationSelect.TabIndex = 3;
            this.btnBackupFileLocationSelect.Text = "- - -";
            this.btnBackupFileLocationSelect.UseVisualStyleBackColor = true;
            this.btnBackupFileLocationSelect.Click += new System.EventHandler(this.BtnBackupFileLocationSelect_Click);
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.Location = new System.Drawing.Point(160, 55);
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.Size = new System.Drawing.Size(194, 20);
            this.txtBackupPath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veritabanı Dosya Konumu :";
            // 
            // tpRestore
            // 
            this.tpRestore.BackColor = System.Drawing.SystemColors.Control;
            this.tpRestore.Controls.Add(this.groupBox1);
            this.tpRestore.Location = new System.Drawing.Point(4, 40);
            this.tpRestore.Name = "tpRestore";
            this.tpRestore.Padding = new System.Windows.Forms.Padding(3);
            this.tpRestore.Size = new System.Drawing.Size(653, 306);
            this.tpRestore.TabIndex = 1;
            this.tpRestore.Text = "Geri Yükle";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbxDbNameRestore);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnRestore);
            this.groupBox1.Controls.Add(this.btnRestoreFile);
            this.groupBox1.Controls.Add(this.txtRestorePath);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(105, 97);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(432, 130);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veritabanı Geri Yükleme";
            // 
            // cbxDbNameRestore
            // 
            this.cbxDbNameRestore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxDbNameRestore.FormattingEnabled = true;
            this.cbxDbNameRestore.Location = new System.Drawing.Point(160, 28);
            this.cbxDbNameRestore.Name = "cbxDbNameRestore";
            this.cbxDbNameRestore.Size = new System.Drawing.Size(264, 21);
            this.cbxDbNameRestore.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Veritabanı Adı :";
            // 
            // btnRestore
            // 
            this.btnRestore.Location = new System.Drawing.Point(160, 82);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(264, 31);
            this.btnRestore.TabIndex = 4;
            this.btnRestore.Text = "Veritabanını Geri Yükle";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.BtnRestore_Click);
            // 
            // btnRestoreFile
            // 
            this.btnRestoreFile.Location = new System.Drawing.Point(360, 54);
            this.btnRestoreFile.Name = "btnRestoreFile";
            this.btnRestoreFile.Size = new System.Drawing.Size(64, 22);
            this.btnRestoreFile.TabIndex = 3;
            this.btnRestoreFile.Text = "- - -";
            this.btnRestoreFile.UseVisualStyleBackColor = true;
            this.btnRestoreFile.Click += new System.EventHandler(this.BtnRestoreFile_Click);
            // 
            // txtRestorePath
            // 
            this.txtRestorePath.Location = new System.Drawing.Point(160, 55);
            this.txtRestorePath.Name = "txtRestorePath";
            this.txtRestorePath.Size = new System.Drawing.Size(194, 20);
            this.txtRestorePath.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Veritabanı Dosyası :";
            // 
            // tpSQLFile
            // 
            this.tpSQLFile.BackColor = System.Drawing.SystemColors.Control;
            this.tpSQLFile.Controls.Add(this.groupBox2);
            this.tpSQLFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpSQLFile.Location = new System.Drawing.Point(4, 40);
            this.tpSQLFile.Name = "tpSQLFile";
            this.tpSQLFile.Padding = new System.Windows.Forms.Padding(3);
            this.tpSQLFile.Size = new System.Drawing.Size(653, 306);
            this.tpSQLFile.TabIndex = 2;
            this.tpSQLFile.Text = "SQL Dosyası Çalıştırma";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnSQLRun);
            this.groupBox2.Controls.Add(this.btnSQLFileSelect);
            this.groupBox2.Controls.Add(this.txtSQLFile);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(105, 97);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(432, 130);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SQL Dosyası Çalıştırma";
            // 
            // btnSQLRun
            // 
            this.btnSQLRun.Location = new System.Drawing.Point(160, 66);
            this.btnSQLRun.Name = "btnSQLRun";
            this.btnSQLRun.Size = new System.Drawing.Size(264, 31);
            this.btnSQLRun.TabIndex = 4;
            this.btnSQLRun.Text = "SQL Dosyasını Çalıştır";
            this.btnSQLRun.UseVisualStyleBackColor = true;
            this.btnSQLRun.Click += new System.EventHandler(this.BtnSQLRun_Click);
            // 
            // btnSQLFileSelect
            // 
            this.btnSQLFileSelect.Location = new System.Drawing.Point(360, 38);
            this.btnSQLFileSelect.Name = "btnSQLFileSelect";
            this.btnSQLFileSelect.Size = new System.Drawing.Size(64, 22);
            this.btnSQLFileSelect.TabIndex = 3;
            this.btnSQLFileSelect.Text = "- - -";
            this.btnSQLFileSelect.UseVisualStyleBackColor = true;
            this.btnSQLFileSelect.Click += new System.EventHandler(this.BtnSQLFileSelect_Click);
            // 
            // txtSQLFile
            // 
            this.txtSQLFile.Location = new System.Drawing.Point(160, 39);
            this.txtSQLFile.Name = "txtSQLFile";
            this.txtSQLFile.Size = new System.Drawing.Size(194, 20);
            this.txtSQLFile.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(70, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "SQL Dosyası :";
            // 
            // tpSPWinDatabasePhotoDelete
            // 
            this.tpSPWinDatabasePhotoDelete.BackColor = System.Drawing.SystemColors.Control;
            this.tpSPWinDatabasePhotoDelete.Controls.Add(this.lblDateFinish);
            this.tpSPWinDatabasePhotoDelete.Controls.Add(this.lblDateStart);
            this.tpSPWinDatabasePhotoDelete.Controls.Add(this.dtpFinish);
            this.tpSPWinDatabasePhotoDelete.Controls.Add(this.rdbAll);
            this.tpSPWinDatabasePhotoDelete.Controls.Add(this.rdbPeriod);
            this.tpSPWinDatabasePhotoDelete.Controls.Add(this.dtpStart);
            this.tpSPWinDatabasePhotoDelete.Controls.Add(this.groupBox5);
            this.tpSPWinDatabasePhotoDelete.Location = new System.Drawing.Point(4, 40);
            this.tpSPWinDatabasePhotoDelete.Name = "tpSPWinDatabasePhotoDelete";
            this.tpSPWinDatabasePhotoDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tpSPWinDatabasePhotoDelete.Size = new System.Drawing.Size(653, 306);
            this.tpSPWinDatabasePhotoDelete.TabIndex = 3;
            this.tpSPWinDatabasePhotoDelete.Text = "Veritabanından Fotoğraf Silme";
            // 
            // lblDateFinish
            // 
            this.lblDateFinish.AutoSize = true;
            this.lblDateFinish.Location = new System.Drawing.Point(8, 257);
            this.lblDateFinish.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateFinish.Name = "lblDateFinish";
            this.lblDateFinish.Size = new System.Drawing.Size(55, 13);
            this.lblDateFinish.TabIndex = 17;
            this.lblDateFinish.Text = "Bitiş Tarihi";
            this.lblDateFinish.Visible = false;
            // 
            // lblDateStart
            // 
            this.lblDateStart.AutoSize = true;
            this.lblDateStart.Location = new System.Drawing.Point(8, 234);
            this.lblDateStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateStart.Name = "lblDateStart";
            this.lblDateStart.Size = new System.Drawing.Size(82, 13);
            this.lblDateStart.TabIndex = 16;
            this.lblDateStart.Text = "Başlangıç Tarihi";
            this.lblDateStart.Visible = false;
            // 
            // dtpFinish
            // 
            this.dtpFinish.Location = new System.Drawing.Point(90, 253);
            this.dtpFinish.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFinish.Name = "dtpFinish";
            this.dtpFinish.Size = new System.Drawing.Size(112, 20);
            this.dtpFinish.TabIndex = 15;
            this.dtpFinish.Value = new System.DateTime(2023, 7, 25, 23, 59, 59, 0);
            this.dtpFinish.Visible = false;
            // 
            // rdbAll
            // 
            this.rdbAll.AutoSize = true;
            this.rdbAll.Location = new System.Drawing.Point(10, 174);
            this.rdbAll.Margin = new System.Windows.Forms.Padding(2);
            this.rdbAll.Name = "rdbAll";
            this.rdbAll.Size = new System.Drawing.Size(76, 17);
            this.rdbAll.TabIndex = 14;
            this.rdbAll.Text = "Tümünü sil";
            this.rdbAll.UseVisualStyleBackColor = true;
            this.rdbAll.CheckedChanged += new System.EventHandler(this.rdbAll_CheckedChanged);
            // 
            // rdbPeriod
            // 
            this.rdbPeriod.AutoSize = true;
            this.rdbPeriod.Location = new System.Drawing.Point(10, 195);
            this.rdbPeriod.Margin = new System.Windows.Forms.Padding(2);
            this.rdbPeriod.Name = "rdbPeriod";
            this.rdbPeriod.Size = new System.Drawing.Size(63, 17);
            this.rdbPeriod.TabIndex = 12;
            this.rdbPeriod.Text = "Aralık sil";
            this.rdbPeriod.UseVisualStyleBackColor = true;
            this.rdbPeriod.CheckedChanged += new System.EventHandler(this.rdbPeriod_CheckedChanged);
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(90, 230);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(2);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(112, 20);
            this.dtpStart.TabIndex = 10;
            this.dtpStart.Value = new System.DateTime(2023, 7, 25, 0, 1, 0, 0);
            this.dtpStart.Visible = false;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.rbAllPhoto);
            this.groupBox5.Controls.Add(this.rbInTheFolderPhoto);
            this.groupBox5.Controls.Add(this.rbOneAndTwoPhoto);
            this.groupBox5.Controls.Add(this.btnWeighPhotoDelete);
            this.groupBox5.Location = new System.Drawing.Point(147, 72);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(333, 152);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Tartım Fotoğraflarını Silme";
            // 
            // rbAllPhoto
            // 
            this.rbAllPhoto.AutoSize = true;
            this.rbAllPhoto.Location = new System.Drawing.Point(37, 102);
            this.rbAllPhoto.Name = "rbAllPhoto";
            this.rbAllPhoto.Size = new System.Drawing.Size(52, 17);
            this.rbAllPhoto.TabIndex = 10;
            this.rbAllPhoto.Text = "Hepsi";
            this.rbAllPhoto.UseVisualStyleBackColor = true;
            // 
            // rbInTheFolderPhoto
            // 
            this.rbInTheFolderPhoto.AutoSize = true;
            this.rbInTheFolderPhoto.Location = new System.Drawing.Point(37, 79);
            this.rbInTheFolderPhoto.Name = "rbInTheFolderPhoto";
            this.rbInTheFolderPhoto.Size = new System.Drawing.Size(54, 17);
            this.rbInTheFolderPhoto.TabIndex = 9;
            this.rbInTheFolderPhoto.Text = "Klasör";
            this.rbInTheFolderPhoto.UseVisualStyleBackColor = true;
            // 
            // rbOneAndTwoPhoto
            // 
            this.rbOneAndTwoPhoto.AutoSize = true;
            this.rbOneAndTwoPhoto.Location = new System.Drawing.Point(37, 57);
            this.rbOneAndTwoPhoto.Name = "rbOneAndTwoPhoto";
            this.rbOneAndTwoPhoto.Size = new System.Drawing.Size(75, 17);
            this.rbOneAndTwoPhoto.TabIndex = 8;
            this.rbOneAndTwoPhoto.Text = "Veri tabanı";
            this.rbOneAndTwoPhoto.UseVisualStyleBackColor = true;
            // 
            // btnWeighPhotoDelete
            // 
            this.btnWeighPhotoDelete.Location = new System.Drawing.Point(128, 115);
            this.btnWeighPhotoDelete.Name = "btnWeighPhotoDelete";
            this.btnWeighPhotoDelete.Size = new System.Drawing.Size(194, 31);
            this.btnWeighPhotoDelete.TabIndex = 4;
            this.btnWeighPhotoDelete.Text = "Tartım Fotoğraflarını Sil";
            this.btnWeighPhotoDelete.UseVisualStyleBackColor = true;
            this.btnWeighPhotoDelete.Click += new System.EventHandler(this.BtnWeighPhotoDelete_Click);
            // 
            // tpDatabaseRepair
            // 
            this.tpDatabaseRepair.BackColor = System.Drawing.SystemColors.Control;
            this.tpDatabaseRepair.Controls.Add(this.groupBox6);
            this.tpDatabaseRepair.Location = new System.Drawing.Point(4, 40);
            this.tpDatabaseRepair.Name = "tpDatabaseRepair";
            this.tpDatabaseRepair.Padding = new System.Windows.Forms.Padding(3);
            this.tpDatabaseRepair.Size = new System.Drawing.Size(653, 306);
            this.tpDatabaseRepair.TabIndex = 7;
            this.tpDatabaseRepair.Text = "Veritabanı Onarma";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.cbxDbNameRepair);
            this.groupBox6.Controls.Add(this.textBox4);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Controls.Add(this.textBox6);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Location = new System.Drawing.Point(155, 86);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(333, 152);
            this.groupBox6.TabIndex = 8;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Veritabanı Dosya Boyutunu Küçültme";
            this.groupBox6.Visible = false;
            // 
            // cbxDbNameRepair
            // 
            this.cbxDbNameRepair.FormattingEnabled = true;
            this.cbxDbNameRepair.Location = new System.Drawing.Point(128, 28);
            this.cbxDbNameRepair.Name = "cbxDbNameRepair";
            this.cbxDbNameRepair.Size = new System.Drawing.Size(194, 21);
            this.cbxDbNameRepair.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(128, 81);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(194, 20);
            this.textBox4.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Boyut :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "Veritabanı Adı :";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(128, 107);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(194, 31);
            this.button2.TabIndex = 4;
            this.button2.Text = "Dosya Boyutunu Küçült";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(128, 55);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(194, 20);
            this.textBox6.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(69, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 13);
            this.label11.TabIndex = 0;
            this.label11.Text = "Status :";
            // 
            // tpSPWinScaleAndDBAConsolidation
            // 
            this.tpSPWinScaleAndDBAConsolidation.BackColor = System.Drawing.SystemColors.Control;
            this.tpSPWinScaleAndDBAConsolidation.Controls.Add(this.btnMoveDbaToScale);
            this.tpSPWinScaleAndDBAConsolidation.Location = new System.Drawing.Point(4, 40);
            this.tpSPWinScaleAndDBAConsolidation.Name = "tpSPWinScaleAndDBAConsolidation";
            this.tpSPWinScaleAndDBAConsolidation.Padding = new System.Windows.Forms.Padding(3);
            this.tpSPWinScaleAndDBAConsolidation.Size = new System.Drawing.Size(653, 306);
            this.tpSPWinScaleAndDBAConsolidation.TabIndex = 6;
            this.tpSPWinScaleAndDBAConsolidation.Text = "SPWin Scale ve DBA Birleştirme";
            // 
            // btnMoveDbaToScale
            // 
            this.btnMoveDbaToScale.Location = new System.Drawing.Point(161, 124);
            this.btnMoveDbaToScale.Name = "btnMoveDbaToScale";
            this.btnMoveDbaToScale.Size = new System.Drawing.Size(288, 48);
            this.btnMoveDbaToScale.TabIndex = 0;
            this.btnMoveDbaToScale.Text = "Eski Versiyondaki DBA Verilerini Yeni Versiyona Taşı";
            this.btnMoveDbaToScale.UseVisualStyleBackColor = true;
            this.btnMoveDbaToScale.Click += new System.EventHandler(this.BtnMoveDbaToScale_Click);
            // 
            // tpTablolar
            // 
            this.tpTablolar.Controls.Add(this.checkedListBox1);
            this.tpTablolar.Controls.Add(this.CbxtableList);
            this.tpTablolar.Controls.Add(this.btngoster);
            this.tpTablolar.Controls.Add(this.dataGV1);
            this.tpTablolar.Location = new System.Drawing.Point(4, 40);
            this.tpTablolar.Margin = new System.Windows.Forms.Padding(2);
            this.tpTablolar.Name = "tpTablolar";
            this.tpTablolar.Padding = new System.Windows.Forms.Padding(2);
            this.tpTablolar.Size = new System.Drawing.Size(653, 306);
            this.tpTablolar.TabIndex = 8;
            this.tpTablolar.Text = "Tablolar";
            this.tpTablolar.UseVisualStyleBackColor = true;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(4, 32);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(111, 229);
            this.checkedListBox1.TabIndex = 20;
            // 
            // CbxtableList
            // 
            this.CbxtableList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxtableList.FormattingEnabled = true;
            this.CbxtableList.Location = new System.Drawing.Point(4, 5);
            this.CbxtableList.Margin = new System.Windows.Forms.Padding(2);
            this.CbxtableList.Name = "CbxtableList";
            this.CbxtableList.Size = new System.Drawing.Size(111, 21);
            this.CbxtableList.TabIndex = 11;
            this.CbxtableList.SelectedIndexChanged += new System.EventHandler(this.CbxtableList_SelectedIndexChanged);
            this.CbxtableList.Click += new System.EventHandler(this.CbxtableList_Click);
            // 
            // btngoster
            // 
            this.btngoster.Enabled = false;
            this.btngoster.Location = new System.Drawing.Point(4, 275);
            this.btngoster.Margin = new System.Windows.Forms.Padding(2);
            this.btngoster.Name = "btngoster";
            this.btngoster.Size = new System.Drawing.Size(110, 44);
            this.btngoster.TabIndex = 1;
            this.btngoster.Text = "göster";
            this.btngoster.UseVisualStyleBackColor = true;
            this.btngoster.Click += new System.EventHandler(this.Goster_Click);
            // 
            // dataGV1
            // 
            this.dataGV1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGV1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGV1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGV1.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGV1.Location = new System.Drawing.Point(118, 2);
            this.dataGV1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGV1.Name = "dataGV1";
            this.dataGV1.ReadOnly = true;
            this.dataGV1.RowHeadersWidth = 51;
            this.dataGV1.RowTemplate.Height = 24;
            this.dataGV1.Size = new System.Drawing.Size(533, 302);
            this.dataGV1.TabIndex = 0;
            // 
            // tpQuary
            // 
            this.tpQuary.Controls.Add(this.label7);
            this.tpQuary.Controls.Add(this.lblQuaryName);
            this.tpQuary.Controls.Add(this.tbxQuaryName);
            this.tpQuary.Controls.Add(this.tbxQuarySaveLoc);
            this.tpQuary.Controls.Add(this.btnloc);
            this.tpQuary.Controls.Add(this.btnQuaryClear);
            this.tpQuary.Controls.Add(this.btnQuarySave);
            this.tpQuary.Controls.Add(this.tbxQuary);
            this.tpQuary.Location = new System.Drawing.Point(4, 40);
            this.tpQuary.Margin = new System.Windows.Forms.Padding(2);
            this.tpQuary.Name = "tpQuary";
            this.tpQuary.Padding = new System.Windows.Forms.Padding(2);
            this.tpQuary.Size = new System.Drawing.Size(653, 306);
            this.tpQuary.TabIndex = 9;
            this.tpQuary.Text = "Quary.sql";
            this.tpQuary.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(131, 299);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 17);
            this.label7.TabIndex = 8;
            this.label7.Text = "Kayıt Konumu :";
            // 
            // lblQuaryName
            // 
            this.lblQuaryName.AutoSize = true;
            this.lblQuaryName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblQuaryName.Location = new System.Drawing.Point(4, 5);
            this.lblQuaryName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuaryName.Name = "lblQuaryName";
            this.lblQuaryName.Size = new System.Drawing.Size(127, 17);
            this.lblQuaryName.TabIndex = 7;
            this.lblQuaryName.Text = "Quary Dosya ismi :";
            // 
            // tbxQuaryName
            // 
            this.tbxQuaryName.Location = new System.Drawing.Point(135, 5);
            this.tbxQuaryName.Margin = new System.Windows.Forms.Padding(2);
            this.tbxQuaryName.Name = "tbxQuaryName";
            this.tbxQuaryName.Size = new System.Drawing.Size(516, 20);
            this.tbxQuaryName.TabIndex = 6;
            // 
            // tbxQuarySaveLoc
            // 
            this.tbxQuarySaveLoc.Location = new System.Drawing.Point(235, 297);
            this.tbxQuarySaveLoc.Name = "tbxQuarySaveLoc";
            this.tbxQuarySaveLoc.Size = new System.Drawing.Size(225, 20);
            this.tbxQuarySaveLoc.TabIndex = 5;
            // 
            // btnloc
            // 
            this.btnloc.Location = new System.Drawing.Point(465, 290);
            this.btnloc.Name = "btnloc";
            this.btnloc.Size = new System.Drawing.Size(90, 32);
            this.btnloc.TabIndex = 4;
            this.btnloc.Text = "Konum Seçiniz";
            this.btnloc.UseVisualStyleBackColor = true;
            this.btnloc.Click += new System.EventHandler(this.btnloc_Click);
            // 
            // btnQuaryClear
            // 
            this.btnQuaryClear.Location = new System.Drawing.Point(4, 287);
            this.btnQuaryClear.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuaryClear.Name = "btnQuaryClear";
            this.btnQuaryClear.Size = new System.Drawing.Size(90, 32);
            this.btnQuaryClear.TabIndex = 3;
            this.btnQuaryClear.Text = "Temizle";
            this.btnQuaryClear.UseVisualStyleBackColor = true;
            this.btnQuaryClear.Click += new System.EventHandler(this.btnQuaryClear_Click);
            // 
            // btnQuarySave
            // 
            this.btnQuarySave.Location = new System.Drawing.Point(560, 289);
            this.btnQuarySave.Margin = new System.Windows.Forms.Padding(2);
            this.btnQuarySave.Name = "btnQuarySave";
            this.btnQuarySave.Size = new System.Drawing.Size(90, 32);
            this.btnQuarySave.TabIndex = 2;
            this.btnQuarySave.Text = "Quary Kaydet";
            this.btnQuarySave.UseVisualStyleBackColor = true;
            this.btnQuarySave.Click += new System.EventHandler(this.btnQuarySave_Click);
            // 
            // tbxQuary
            // 
            this.tbxQuary.Location = new System.Drawing.Point(4, 28);
            this.tbxQuary.Margin = new System.Windows.Forms.Padding(2);
            this.tbxQuary.Name = "tbxQuary";
            this.tbxQuary.Size = new System.Drawing.Size(647, 258);
            this.tbxQuary.TabIndex = 1;
            this.tbxQuary.Text = "";
            // 
            // tbSorgu
            // 
            this.tbSorgu.Controls.Add(this.panel1);
            this.tbSorgu.Location = new System.Drawing.Point(4, 40);
            this.tbSorgu.Margin = new System.Windows.Forms.Padding(2);
            this.tbSorgu.Name = "tbSorgu";
            this.tbSorgu.Padding = new System.Windows.Forms.Padding(2);
            this.tbSorgu.Size = new System.Drawing.Size(653, 306);
            this.tbSorgu.TabIndex = 10;
            this.tbSorgu.Text = "Sorgu";
            this.tbSorgu.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.btnTemizle);
            this.panel1.Controls.Add(this.btnSorgula);
            this.panel1.Controls.Add(this.rtbSorgula);
            this.panel1.Location = new System.Drawing.Point(4, 5);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(646, 317);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(2, 65);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(639, 249);
            this.panel2.TabIndex = 4;
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(521, 36);
            this.btnTemizle.Margin = new System.Windows.Forms.Padding(2);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(120, 24);
            this.btnTemizle.TabIndex = 3;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // btnSorgula
            // 
            this.btnSorgula.Location = new System.Drawing.Point(521, 0);
            this.btnSorgula.Margin = new System.Windows.Forms.Padding(2);
            this.btnSorgula.Name = "btnSorgula";
            this.btnSorgula.Size = new System.Drawing.Size(120, 24);
            this.btnSorgula.TabIndex = 2;
            this.btnSorgula.Text = "Sorgula";
            this.btnSorgula.UseVisualStyleBackColor = true;
            this.btnSorgula.Click += new System.EventHandler(this.btnSorgula_Click);
            // 
            // rtbSorgula
            // 
            this.rtbSorgula.Location = new System.Drawing.Point(0, 0);
            this.rtbSorgula.Margin = new System.Windows.Forms.Padding(2);
            this.rtbSorgula.Name = "rtbSorgula";
            this.rtbSorgula.Size = new System.Drawing.Size(518, 61);
            this.rtbSorgula.TabIndex = 1;
            this.rtbSorgula.Text = "";
            // 
            // esitUserEkle
            // 
            this.esitUserEkle.Controls.Add(this.cbUserAddUserRole);
            this.esitUserEkle.Controls.Add(this.lbUserAddUserRole);
            this.esitUserEkle.Controls.Add(this.tbUserAddUserPassword);
            this.esitUserEkle.Controls.Add(this.tbUserAddUserName);
            this.esitUserEkle.Controls.Add(this.lbUserAddUserPassword);
            this.esitUserEkle.Controls.Add(this.lbUserAddUserName);
            this.esitUserEkle.Controls.Add(this.btnEsitUserEkle);
            this.esitUserEkle.Location = new System.Drawing.Point(4, 40);
            this.esitUserEkle.Name = "esitUserEkle";
            this.esitUserEkle.Padding = new System.Windows.Forms.Padding(3);
            this.esitUserEkle.Size = new System.Drawing.Size(653, 306);
            this.esitUserEkle.TabIndex = 11;
            this.esitUserEkle.Text = "Esit-User Ekle";
            this.esitUserEkle.UseVisualStyleBackColor = true;
            // 
            // cbUserAddUserRole
            // 
            this.cbUserAddUserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserAddUserRole.FormattingEnabled = true;
            this.cbUserAddUserRole.Items.AddRange(new object[] {
            "Read-Only",
            "Admin"});
            this.cbUserAddUserRole.Location = new System.Drawing.Point(184, 130);
            this.cbUserAddUserRole.Name = "cbUserAddUserRole";
            this.cbUserAddUserRole.Size = new System.Drawing.Size(167, 21);
            this.cbUserAddUserRole.TabIndex = 6;
            // 
            // lbUserAddUserRole
            // 
            this.lbUserAddUserRole.AutoSize = true;
            this.lbUserAddUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbUserAddUserRole.Location = new System.Drawing.Point(56, 130);
            this.lbUserAddUserRole.Name = "lbUserAddUserRole";
            this.lbUserAddUserRole.Size = new System.Drawing.Size(122, 24);
            this.lbUserAddUserRole.TabIndex = 5;
            this.lbUserAddUserRole.Text = "Yetki Düzeyi :";
            // 
            // tbUserAddUserPassword
            // 
            this.tbUserAddUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbUserAddUserPassword.Location = new System.Drawing.Point(184, 80);
            this.tbUserAddUserPassword.Name = "tbUserAddUserPassword";
            this.tbUserAddUserPassword.PasswordChar = '*';
            this.tbUserAddUserPassword.Size = new System.Drawing.Size(167, 29);
            this.tbUserAddUserPassword.TabIndex = 4;
            // 
            // tbUserAddUserName
            // 
            this.tbUserAddUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbUserAddUserName.Location = new System.Drawing.Point(184, 30);
            this.tbUserAddUserName.Name = "tbUserAddUserName";
            this.tbUserAddUserName.Size = new System.Drawing.Size(167, 29);
            this.tbUserAddUserName.TabIndex = 3;
            // 
            // lbUserAddUserPassword
            // 
            this.lbUserAddUserPassword.AutoSize = true;
            this.lbUserAddUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbUserAddUserPassword.Location = new System.Drawing.Point(46, 80);
            this.lbUserAddUserPassword.Name = "lbUserAddUserPassword";
            this.lbUserAddUserPassword.Size = new System.Drawing.Size(132, 24);
            this.lbUserAddUserPassword.TabIndex = 2;
            this.lbUserAddUserPassword.Text = "Kullanıcı Şifre :";
            // 
            // lbUserAddUserName
            // 
            this.lbUserAddUserName.AutoSize = true;
            this.lbUserAddUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbUserAddUserName.Location = new System.Drawing.Point(55, 30);
            this.lbUserAddUserName.Name = "lbUserAddUserName";
            this.lbUserAddUserName.Size = new System.Drawing.Size(123, 24);
            this.lbUserAddUserName.TabIndex = 1;
            this.lbUserAddUserName.Text = "Kullanıcı Adı :";
            // 
            // btnEsitUserEkle
            // 
            this.btnEsitUserEkle.BackColor = System.Drawing.Color.ForestGreen;
            this.btnEsitUserEkle.ForeColor = System.Drawing.Color.White;
            this.btnEsitUserEkle.Location = new System.Drawing.Point(432, 217);
            this.btnEsitUserEkle.Name = "btnEsitUserEkle";
            this.btnEsitUserEkle.Size = new System.Drawing.Size(214, 80);
            this.btnEsitUserEkle.TabIndex = 0;
            this.btnEsitUserEkle.Text = "Esit-User Ekle";
            this.btnEsitUserEkle.UseVisualStyleBackColor = false;
            this.btnEsitUserEkle.Click += new System.EventHandler(this.btnEsitUserEkle_Click);
            // 
            // EsitScaleSil
            // 
            this.EsitScaleSil.Controls.Add(this.btnEsitScaleSil);
            this.EsitScaleSil.Location = new System.Drawing.Point(4, 40);
            this.EsitScaleSil.Name = "EsitScaleSil";
            this.EsitScaleSil.Padding = new System.Windows.Forms.Padding(3);
            this.EsitScaleSil.Size = new System.Drawing.Size(653, 306);
            this.EsitScaleSil.TabIndex = 12;
            this.EsitScaleSil.Text = "www.EsitScale.com Sil";
            this.EsitScaleSil.UseVisualStyleBackColor = true;
            // 
            // btnEsitScaleSil
            // 
            this.btnEsitScaleSil.Location = new System.Drawing.Point(210, 86);
            this.btnEsitScaleSil.Name = "btnEsitScaleSil";
            this.btnEsitScaleSil.Size = new System.Drawing.Size(197, 130);
            this.btnEsitScaleSil.TabIndex = 0;
            this.btnEsitScaleSil.Text = "www.EsitScale.com dosyalarını  Sil";
            this.btnEsitScaleSil.UseVisualStyleBackColor = true;
            this.btnEsitScaleSil.Click += new System.EventHandler(this.btnEsitScaleSil_Click);
            // 
            // tpCamPhotoLink
            // 
            this.tpCamPhotoLink.Controls.Add(this.btnLinkCopy);
            this.tpCamPhotoLink.Controls.Add(this.tbCamLink);
            this.tpCamPhotoLink.Controls.Add(this.btnCamLinkCreate);
            this.tpCamPhotoLink.Controls.Add(this.cbCamType);
            this.tpCamPhotoLink.Controls.Add(this.label8);
            this.tpCamPhotoLink.Controls.Add(this.tbCamPassword);
            this.tpCamPhotoLink.Controls.Add(this.tbCamUser);
            this.tpCamPhotoLink.Controls.Add(this.tbCamIpAddress);
            this.tpCamPhotoLink.Controls.Add(this.lblCamPassword);
            this.tpCamPhotoLink.Controls.Add(this.lblCamUser);
            this.tpCamPhotoLink.Controls.Add(this.lblCamIpAddress);
            this.tpCamPhotoLink.Location = new System.Drawing.Point(4, 40);
            this.tpCamPhotoLink.Name = "tpCamPhotoLink";
            this.tpCamPhotoLink.Padding = new System.Windows.Forms.Padding(3);
            this.tpCamPhotoLink.Size = new System.Drawing.Size(653, 306);
            this.tpCamPhotoLink.TabIndex = 13;
            this.tpCamPhotoLink.Text = "kamera link";
            this.tpCamPhotoLink.UseVisualStyleBackColor = true;
            // 
            // btnLinkCopy
            // 
            this.btnLinkCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLinkCopy.Location = new System.Drawing.Point(494, 214);
            this.btnLinkCopy.Name = "btnLinkCopy";
            this.btnLinkCopy.Size = new System.Drawing.Size(135, 46);
            this.btnLinkCopy.TabIndex = 6;
            this.btnLinkCopy.Text = "Linki kopyala";
            this.btnLinkCopy.UseVisualStyleBackColor = true;
            this.btnLinkCopy.Click += new System.EventHandler(this.btnLinkCopy_Click);
            // 
            // tbCamLink
            // 
            this.tbCamLink.Location = new System.Drawing.Point(38, 228);
            this.tbCamLink.Name = "tbCamLink";
            this.tbCamLink.ReadOnly = true;
            this.tbCamLink.Size = new System.Drawing.Size(450, 20);
            this.tbCamLink.TabIndex = 5;
            // 
            // btnCamLinkCreate
            // 
            this.btnCamLinkCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCamLinkCreate.Location = new System.Drawing.Point(163, 116);
            this.btnCamLinkCreate.Name = "btnCamLinkCreate";
            this.btnCamLinkCreate.Size = new System.Drawing.Size(325, 46);
            this.btnCamLinkCreate.TabIndex = 4;
            this.btnCamLinkCreate.Text = "Kamera Linki Oluştur";
            this.btnCamLinkCreate.UseVisualStyleBackColor = true;
            this.btnCamLinkCreate.Click += new System.EventHandler(this.btnCamLinkCreate_Click);
            // 
            // cbCamType
            // 
            this.cbCamType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCamType.FormattingEnabled = true;
            this.cbCamType.Items.AddRange(new object[] {
            "Aver",
            "Dahua",
            "Hikvision"});
            this.cbCamType.Location = new System.Drawing.Point(451, 75);
            this.cbCamType.Name = "cbCamType";
            this.cbCamType.Size = new System.Drawing.Size(118, 21);
            this.cbCamType.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(302, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(143, 24);
            this.label8.TabIndex = 6;
            this.label8.Text = "Kamera Model :";
            // 
            // tbCamPassword
            // 
            this.tbCamPassword.Location = new System.Drawing.Point(163, 75);
            this.tbCamPassword.Name = "tbCamPassword";
            this.tbCamPassword.Size = new System.Drawing.Size(118, 20);
            this.tbCamPassword.TabIndex = 1;
            // 
            // tbCamUser
            // 
            this.tbCamUser.Location = new System.Drawing.Point(163, 49);
            this.tbCamUser.Name = "tbCamUser";
            this.tbCamUser.Size = new System.Drawing.Size(118, 20);
            this.tbCamUser.TabIndex = 0;
            // 
            // tbCamIpAddress
            // 
            this.tbCamIpAddress.Location = new System.Drawing.Point(451, 49);
            this.tbCamIpAddress.Name = "tbCamIpAddress";
            this.tbCamIpAddress.Size = new System.Drawing.Size(118, 20);
            this.tbCamIpAddress.TabIndex = 2;
            // 
            // lblCamPassword
            // 
            this.lblCamPassword.AutoSize = true;
            this.lblCamPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCamPassword.Location = new System.Drawing.Point(100, 71);
            this.lblCamPassword.Name = "lblCamPassword";
            this.lblCamPassword.Size = new System.Drawing.Size(57, 24);
            this.lblCamPassword.TabIndex = 2;
            this.lblCamPassword.Text = "Şifre :";
            // 
            // lblCamUser
            // 
            this.lblCamUser.AutoSize = true;
            this.lblCamUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCamUser.Location = new System.Drawing.Point(34, 45);
            this.lblCamUser.Name = "lblCamUser";
            this.lblCamUser.Size = new System.Drawing.Size(123, 24);
            this.lblCamUser.TabIndex = 1;
            this.lblCamUser.Text = "Kullanıcı Adı :";
            // 
            // lblCamIpAddress
            // 
            this.lblCamIpAddress.AutoSize = true;
            this.lblCamIpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCamIpAddress.Location = new System.Drawing.Point(409, 44);
            this.lblCamIpAddress.Name = "lblCamIpAddress";
            this.lblCamIpAddress.Size = new System.Drawing.Size(36, 24);
            this.lblCamIpAddress.TabIndex = 0;
            this.lblCamIpAddress.Text = "IP :";
            // 
            // tpTartımSilme
            // 
            this.tpTartımSilme.Controls.Add(this.dtpTartımSaatEnd);
            this.tpTartımSilme.Controls.Add(this.dtpTartımSaatStart);
            this.tpTartımSilme.Controls.Add(this.panel3);
            this.tpTartımSilme.Controls.Add(this.btnTartımSilme);
            this.tpTartımSilme.Controls.Add(this.lbTartımEnd);
            this.tpTartımSilme.Controls.Add(this.lbTartımStart);
            this.tpTartımSilme.Controls.Add(this.dtpTartımDateEnd);
            this.tpTartımSilme.Controls.Add(this.rbTartımAllDelete);
            this.tpTartımSilme.Controls.Add(this.rbTartımPeriodDelete);
            this.tpTartımSilme.Controls.Add(this.dtpTartımDateStart);
            this.tpTartımSilme.Location = new System.Drawing.Point(4, 40);
            this.tpTartımSilme.Name = "tpTartımSilme";
            this.tpTartımSilme.Padding = new System.Windows.Forms.Padding(3);
            this.tpTartımSilme.Size = new System.Drawing.Size(653, 306);
            this.tpTartımSilme.TabIndex = 14;
            this.tpTartımSilme.Text = "Tartım Silme";
            this.tpTartımSilme.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rbTartım1);
            this.panel3.Controls.Add(this.rbTartım2);
            this.panel3.Location = new System.Drawing.Point(360, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(158, 108);
            this.panel3.TabIndex = 26;
            // 
            // rbTartım1
            // 
            this.rbTartım1.AutoSize = true;
            this.rbTartım1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbTartım1.Location = new System.Drawing.Point(14, 30);
            this.rbTartım1.Name = "rbTartım1";
            this.rbTartım1.Size = new System.Drawing.Size(100, 28);
            this.rbTartım1.TabIndex = 8;
            this.rbTartım1.Text = "1. Tartım";
            this.rbTartım1.UseVisualStyleBackColor = true;
            // 
            // rbTartım2
            // 
            this.rbTartım2.AutoSize = true;
            this.rbTartım2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbTartım2.Location = new System.Drawing.Point(14, 57);
            this.rbTartım2.Name = "rbTartım2";
            this.rbTartım2.Size = new System.Drawing.Size(100, 28);
            this.rbTartım2.TabIndex = 9;
            this.rbTartım2.Text = "2. Tartım";
            this.rbTartım2.UseVisualStyleBackColor = true;
            // 
            // btnTartımSilme
            // 
            this.btnTartımSilme.BackColor = System.Drawing.Color.Red;
            this.btnTartımSilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTartımSilme.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTartımSilme.Location = new System.Drawing.Point(423, 242);
            this.btnTartımSilme.Name = "btnTartımSilme";
            this.btnTartımSilme.Size = new System.Drawing.Size(223, 55);
            this.btnTartımSilme.TabIndex = 4;
            this.btnTartımSilme.Text = "Tartımları Sil !";
            this.btnTartımSilme.UseVisualStyleBackColor = false;
            this.btnTartımSilme.Click += new System.EventHandler(this.btnTartımSilme_Click);
            // 
            // lbTartımEnd
            // 
            this.lbTartımEnd.AutoSize = true;
            this.lbTartımEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbTartımEnd.Location = new System.Drawing.Point(69, 230);
            this.lbTartımEnd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTartımEnd.Name = "lbTartımEnd";
            this.lbTartımEnd.Size = new System.Drawing.Size(95, 24);
            this.lbTartımEnd.TabIndex = 24;
            this.lbTartımEnd.Text = "Bitiş Tarihi";
            this.lbTartımEnd.Visible = false;
            // 
            // lbTartımStart
            // 
            this.lbTartımStart.AutoSize = true;
            this.lbTartımStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbTartımStart.Location = new System.Drawing.Point(24, 185);
            this.lbTartımStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTartımStart.Name = "lbTartımStart";
            this.lbTartımStart.Size = new System.Drawing.Size(143, 24);
            this.lbTartımStart.TabIndex = 23;
            this.lbTartımStart.Text = "Başlangıç Tarihi";
            this.lbTartımStart.Visible = false;
            // 
            // dtpTartımDateEnd
            // 
            this.dtpTartımDateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTartımDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTartımDateEnd.Location = new System.Drawing.Point(173, 230);
            this.dtpTartımDateEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTartımDateEnd.Name = "dtpTartımDateEnd";
            this.dtpTartımDateEnd.Size = new System.Drawing.Size(115, 29);
            this.dtpTartımDateEnd.TabIndex = 22;
            this.dtpTartımDateEnd.Value = new System.DateTime(2023, 7, 25, 23, 59, 59, 0);
            this.dtpTartımDateEnd.Visible = false;
            // 
            // rbTartımAllDelete
            // 
            this.rbTartımAllDelete.AutoSize = true;
            this.rbTartımAllDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbTartımAllDelete.Location = new System.Drawing.Point(123, 71);
            this.rbTartımAllDelete.Margin = new System.Windows.Forms.Padding(2);
            this.rbTartımAllDelete.Name = "rbTartımAllDelete";
            this.rbTartımAllDelete.Size = new System.Drawing.Size(206, 28);
            this.rbTartımAllDelete.TabIndex = 21;
            this.rbTartımAllDelete.Text = "Tüm Tarih aralığını sil";
            this.rbTartımAllDelete.UseVisualStyleBackColor = true;
            this.rbTartımAllDelete.Click += new System.EventHandler(this.rbTartımAllDelete_Click);
            // 
            // rbTartımPeriodDelete
            // 
            this.rbTartımPeriodDelete.AutoSize = true;
            this.rbTartımPeriodDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbTartımPeriodDelete.Location = new System.Drawing.Point(123, 98);
            this.rbTartımPeriodDelete.Margin = new System.Windows.Forms.Padding(2);
            this.rbTartımPeriodDelete.Name = "rbTartımPeriodDelete";
            this.rbTartımPeriodDelete.Size = new System.Drawing.Size(202, 28);
            this.rbTartımPeriodDelete.TabIndex = 20;
            this.rbTartımPeriodDelete.Text = "Belli Tarih aralığını sil";
            this.rbTartımPeriodDelete.UseVisualStyleBackColor = true;
            this.rbTartımPeriodDelete.Click += new System.EventHandler(this.rbTartımPeriodDelete_Click);
            // 
            // dtpTartımDateStart
            // 
            this.dtpTartımDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTartımDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTartımDateStart.Location = new System.Drawing.Point(171, 185);
            this.dtpTartımDateStart.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTartımDateStart.Name = "dtpTartımDateStart";
            this.dtpTartımDateStart.Size = new System.Drawing.Size(117, 29);
            this.dtpTartımDateStart.TabIndex = 19;
            this.dtpTartımDateStart.Value = new System.DateTime(2023, 7, 25, 0, 1, 0, 0);
            this.dtpTartımDateStart.Visible = false;
            // 
            // gbConnectionSettings
            // 
            this.gbConnectionSettings.Controls.Add(this.label5);
            this.gbConnectionSettings.Controls.Add(this.cbxUsername);
            this.gbConnectionSettings.Controls.Add(this.cbxDbName);
            this.gbConnectionSettings.Controls.Add(this.lblServer);
            this.gbConnectionSettings.Controls.Add(this.CbWindowsAuthentication);
            this.gbConnectionSettings.Controls.Add(this.lblPassword);
            this.gbConnectionSettings.Controls.Add(this.lblUser);
            this.gbConnectionSettings.Controls.Add(this.CBServers);
            this.gbConnectionSettings.Controls.Add(this.txtPassword);
            this.gbConnectionSettings.Location = new System.Drawing.Point(130, 32);
            this.gbConnectionSettings.Name = "gbConnectionSettings";
            this.gbConnectionSettings.Size = new System.Drawing.Size(420, 164);
            this.gbConnectionSettings.TabIndex = 4;
            this.gbConnectionSettings.TabStop = false;
            this.gbConnectionSettings.Text = "SQL Server Bağlantı Ayarları";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Veritabanı Adı :";
            // 
            // cbxUsername
            // 
            this.cbxUsername.Enabled = false;
            this.cbxUsername.FormattingEnabled = true;
            this.cbxUsername.Location = new System.Drawing.Point(87, 106);
            this.cbxUsername.Name = "cbxUsername";
            this.cbxUsername.Size = new System.Drawing.Size(212, 21);
            this.cbxUsername.TabIndex = 8;
            this.cbxUsername.DropDown += new System.EventHandler(this.cbxUsername_DropDown);
            this.cbxUsername.TextChanged += new System.EventHandler(this.cbxUsername_TextChanged);
            // 
            // cbxDbName
            // 
            this.cbxDbName.FormattingEnabled = true;
            this.cbxDbName.Location = new System.Drawing.Point(87, 80);
            this.cbxDbName.Name = "cbxDbName";
            this.cbxDbName.Size = new System.Drawing.Size(212, 21);
            this.cbxDbName.TabIndex = 7;
            this.cbxDbName.DropDown += new System.EventHandler(this.cbxDbName_DropDown);
            this.cbxDbName.TextChanged += new System.EventHandler(this.cbxDbName_TextChanged);
            // 
            // lblServer
            // 
            this.lblServer.AutoSize = true;
            this.lblServer.Location = new System.Drawing.Point(37, 33);
            this.lblServer.Name = "lblServer";
            this.lblServer.Size = new System.Drawing.Size(44, 13);
            this.lblServer.TabIndex = 5;
            this.lblServer.Text = "Server :";
            // 
            // CbWindowsAuthentication
            // 
            this.CbWindowsAuthentication.AutoSize = true;
            this.CbWindowsAuthentication.Checked = true;
            this.CbWindowsAuthentication.CheckState = System.Windows.Forms.CheckState.Checked;
            this.CbWindowsAuthentication.Location = new System.Drawing.Point(87, 57);
            this.CbWindowsAuthentication.Name = "CbWindowsAuthentication";
            this.CbWindowsAuthentication.Size = new System.Drawing.Size(141, 17);
            this.CbWindowsAuthentication.TabIndex = 4;
            this.CbWindowsAuthentication.Text = "Windows Authentication";
            this.CbWindowsAuthentication.UseVisualStyleBackColor = true;
            this.CbWindowsAuthentication.CheckedChanged += new System.EventHandler(this.CbWindowsAuthentication_CheckedChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Enabled = false;
            this.lblPassword.Location = new System.Drawing.Point(47, 139);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(34, 13);
            this.lblPassword.TabIndex = 2;
            this.lblPassword.Text = "Şifre :";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Enabled = false;
            this.lblUser.Location = new System.Drawing.Point(11, 110);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(70, 13);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Kullanıcı Adı :";
            // 
            // CBServers
            // 
            this.CBServers.FormattingEnabled = true;
            this.CBServers.Location = new System.Drawing.Point(87, 30);
            this.CBServers.Name = "CBServers";
            this.CBServers.Size = new System.Drawing.Size(214, 21);
            this.CBServers.TabIndex = 0;
            this.CBServers.DropDown += new System.EventHandler(this.CBServers_DropDown);
            this.CBServers.TextChanged += new System.EventHandler(this.CBServers_TextChanged);
            // 
            // txtPassword
            // 
            this.txtPassword.Enabled = false;
            this.txtPassword.Location = new System.Drawing.Point(87, 132);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(212, 20);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // btnConnectionTest
            // 
            this.btnConnectionTest.BackColor = System.Drawing.Color.Green;
            this.btnConnectionTest.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnConnectionTest.Location = new System.Drawing.Point(217, 202);
            this.btnConnectionTest.Name = "btnConnectionTest";
            this.btnConnectionTest.Size = new System.Drawing.Size(214, 30);
            this.btnConnectionTest.TabIndex = 3;
            this.btnConnectionTest.Text = "Bağlan";
            this.btnConnectionTest.UseVisualStyleBackColor = false;
            this.btnConnectionTest.Click += new System.EventHandler(this.BtnConnectionTest_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.Control;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(665, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.aboutToolStripMenuItem.Text = "Hakkında";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // dtpTartımSaatEnd
            // 
            this.dtpTartımSaatEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTartımSaatEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTartımSaatEnd.Location = new System.Drawing.Point(307, 230);
            this.dtpTartımSaatEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTartımSaatEnd.Name = "dtpTartımSaatEnd";
            this.dtpTartımSaatEnd.Size = new System.Drawing.Size(115, 29);
            this.dtpTartımSaatEnd.TabIndex = 28;
            this.dtpTartımSaatEnd.Value = new System.DateTime(2024, 7, 26, 23, 59, 0, 0);
            this.dtpTartımSaatEnd.Visible = false;
            // 
            // dtpTartımSaatStart
            // 
            this.dtpTartımSaatStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTartımSaatStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTartımSaatStart.Location = new System.Drawing.Point(305, 185);
            this.dtpTartımSaatStart.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTartımSaatStart.Name = "dtpTartımSaatStart";
            this.dtpTartımSaatStart.Size = new System.Drawing.Size(119, 29);
            this.dtpTartımSaatStart.TabIndex = 27;
            this.dtpTartımSaatStart.Value = new System.DateTime(2023, 7, 25, 0, 1, 0, 0);
            this.dtpTartımSaatStart.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 611);
            this.Controls.Add(this.gbConnectionSettings);
            this.Controls.Add(this.tabControlProcessHeaders);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnConnectionTest);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESİT SPWin Teknik Servis Programı";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlProcessHeaders.ResumeLayout(false);
            this.tpBackup.ResumeLayout(false);
            this.grpBoxPatch.ResumeLayout(false);
            this.grpBoxPatch.PerformLayout();
            this.tpRestore.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tpSQLFile.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tpSPWinDatabasePhotoDelete.ResumeLayout(false);
            this.tpSPWinDatabasePhotoDelete.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tpDatabaseRepair.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tpSPWinScaleAndDBAConsolidation.ResumeLayout(false);
            this.tpTablolar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV1)).EndInit();
            this.tpQuary.ResumeLayout(false);
            this.tpQuary.PerformLayout();
            this.tbSorgu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.esitUserEkle.ResumeLayout(false);
            this.esitUserEkle.PerformLayout();
            this.EsitScaleSil.ResumeLayout(false);
            this.tpCamPhotoLink.ResumeLayout(false);
            this.tpCamPhotoLink.PerformLayout();
            this.tpTartımSilme.ResumeLayout(false);
            this.tpTartımSilme.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.gbConnectionSettings.ResumeLayout(false);
            this.gbConnectionSettings.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlProcessHeaders;
        private System.Windows.Forms.TabPage tpBackup;
        private System.Windows.Forms.GroupBox grpBoxPatch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnBackupFileLocationSelect;
        private System.Windows.Forms.TextBox txtBackupPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tpRestore;
        private System.Windows.Forms.TabPage tpSQLFile;
        private System.Windows.Forms.TabPage tpSPWinDatabasePhotoDelete;
        private System.Windows.Forms.TabPage tpSPWinScaleAndDBAConsolidation;
        private System.Windows.Forms.GroupBox gbConnectionSettings;
        private System.Windows.Forms.Label lblServer;
        private System.Windows.Forms.CheckBox CbWindowsAuthentication;
        private System.Windows.Forms.Button btnConnectionTest;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.ComboBox CBServers;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.Button btnRestoreFile;
        private System.Windows.Forms.TextBox txtRestorePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnSQLRun;
        private System.Windows.Forms.Button btnSQLFileSelect;
        private System.Windows.Forms.TextBox txtSQLFile;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnWeighPhotoDelete;
        private System.Windows.Forms.RadioButton rbAllPhoto;
        private System.Windows.Forms.RadioButton rbInTheFolderPhoto;
        private System.Windows.Forms.RadioButton rbOneAndTwoPhoto;
        private System.Windows.Forms.TabPage tpDatabaseRepair;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnMoveDbaToScale;
        private System.Windows.Forms.ComboBox cbxDbName;
        private System.Windows.Forms.ComboBox cbxDbNameBackup;
        private System.Windows.Forms.ComboBox cbxDbNameRestore;
        private System.Windows.Forms.ComboBox cbxDbNameRepair;
        private System.Windows.Forms.ComboBox cbxUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabPage tpTablolar;
        private System.Windows.Forms.Button btngoster;
        public System.Windows.Forms.DataGridView dataGV1;
        private System.Windows.Forms.ComboBox CbxtableList;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.TabPage tpQuary;
        private System.Windows.Forms.RichTextBox tbxQuary;
        private System.Windows.Forms.Button btnQuarySave;
        private System.Windows.Forms.Button btnQuaryClear;
        private System.Windows.Forms.Button btnloc;
        private System.Windows.Forms.TextBox tbxQuarySaveLoc;
        private System.Windows.Forms.TextBox tbxQuaryName;
        private System.Windows.Forms.Label lblQuaryName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TabPage tbSorgu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtbSorgula;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnSorgula;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.RadioButton rdbPeriod;
        private System.Windows.Forms.RadioButton rdbAll;
        private System.Windows.Forms.DateTimePicker dtpFinish;
        private System.Windows.Forms.Label lblDateStart;
        private System.Windows.Forms.Label lblDateFinish;
        private System.Windows.Forms.TabPage esitUserEkle;
        private System.Windows.Forms.Button btnEsitUserEkle;
        private System.Windows.Forms.TabPage EsitScaleSil;
        private System.Windows.Forms.Button btnEsitScaleSil;
        private System.Windows.Forms.TabPage tpCamPhotoLink;
        private System.Windows.Forms.Label lblCamIpAddress;
        private System.Windows.Forms.TextBox tbCamPassword;
        private System.Windows.Forms.TextBox tbCamUser;
        private System.Windows.Forms.TextBox tbCamIpAddress;
        private System.Windows.Forms.Label lblCamPassword;
        private System.Windows.Forms.Label lblCamUser;
        private System.Windows.Forms.ComboBox cbCamType;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbCamLink;
        private System.Windows.Forms.Button btnCamLinkCreate;
        private System.Windows.Forms.Button btnLinkCopy;
        private System.Windows.Forms.TabPage tpTartımSilme;
        private System.Windows.Forms.Label lbTartımEnd;
        private System.Windows.Forms.Label lbTartımStart;
        private System.Windows.Forms.DateTimePicker dtpTartımDateEnd;
        private System.Windows.Forms.RadioButton rbTartımAllDelete;
        private System.Windows.Forms.RadioButton rbTartımPeriodDelete;
        private System.Windows.Forms.DateTimePicker dtpTartımDateStart;
        private System.Windows.Forms.RadioButton rbTartım2;
        private System.Windows.Forms.RadioButton rbTartım1;
        private System.Windows.Forms.Button btnTartımSilme;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbUserAddUserPassword;
        private System.Windows.Forms.Label lbUserAddUserName;
        private System.Windows.Forms.ComboBox cbUserAddUserRole;
        private System.Windows.Forms.Label lbUserAddUserRole;
        private System.Windows.Forms.TextBox tbUserAddUserPassword;
        private System.Windows.Forms.TextBox tbUserAddUserName;
        private System.Windows.Forms.DateTimePicker dtpTartımSaatEnd;
        private System.Windows.Forms.DateTimePicker dtpTartımSaatStart;
    }
}

