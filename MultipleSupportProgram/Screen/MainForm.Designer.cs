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
            this.tableLayoutPanel18 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel19 = new System.Windows.Forms.TableLayoutPanel();
            this.btnBackupFileLocationSelect = new System.Windows.Forms.Button();
            this.btnBackup = new System.Windows.Forms.Button();
            this.cbxDbNameBackup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBackupPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tpRestore = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel16 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel17 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRestoreFile = new System.Windows.Forms.Button();
            this.cbxDbNameRestore = new System.Windows.Forms.ComboBox();
            this.txtRestorePath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRestore = new System.Windows.Forms.Button();
            this.tpSQLFile = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel14 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel15 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSQLFile = new System.Windows.Forms.TextBox();
            this.btnSQLFileSelect = new System.Windows.Forms.Button();
            this.btnSQLRun = new System.Windows.Forms.Button();
            this.tpSPWinDatabasePhotoDelete = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel9 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel11 = new System.Windows.Forms.TableLayoutPanel();
            this.rbAllPhoto = new System.Windows.Forms.RadioButton();
            this.rbOneAndTwoPhoto = new System.Windows.Forms.RadioButton();
            this.rbInTheFolderPhoto = new System.Windows.Forms.RadioButton();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel10 = new System.Windows.Forms.TableLayoutPanel();
            this.rdbPeriod = new System.Windows.Forms.RadioButton();
            this.rdbAll = new System.Windows.Forms.RadioButton();
            this.btnWeighPhotoDelete = new System.Windows.Forms.Button();
            this.dtpFinish = new System.Windows.Forms.DateTimePicker();
            this.lblDateFinish = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblDateStart = new System.Windows.Forms.Label();
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
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
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
            this.tpSorgu = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnSorgula = new System.Windows.Forms.Button();
            this.rtbSorgula = new System.Windows.Forms.RichTextBox();
            this.tpEsitUserEkle = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEsitUserSilHelp = new System.Windows.Forms.Button();
            this.btnKullanıcıSil = new System.Windows.Forms.Button();
            this.tbUserAddUserPasswordConfirm = new System.Windows.Forms.TextBox();
            this.btnKullanıcıEkle = new System.Windows.Forms.Button();
            this.cbUserAddUserRole = new System.Windows.Forms.ComboBox();
            this.lbUserAddUserName = new System.Windows.Forms.Label();
            this.lbUserAddUserPasswordConfirm = new System.Windows.Forms.Label();
            this.lbUserAddUserPassword = new System.Windows.Forms.Label();
            this.tbUserAddUserPassword = new System.Windows.Forms.TextBox();
            this.lbUserAddUserRole = new System.Windows.Forms.Label();
            this.tbUserAddUserName = new System.Windows.Forms.TextBox();
            this.tpCamPhotoLink = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCamLinkCreate = new System.Windows.Forms.Button();
            this.btnLinkCopy = new System.Windows.Forms.Button();
            this.lblCamUser = new System.Windows.Forms.Label();
            this.lblCamPassword = new System.Windows.Forms.Label();
            this.cbCamType = new System.Windows.Forms.ComboBox();
            this.tbCamUser = new System.Windows.Forms.TextBox();
            this.tbCamIpAddress = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tbCamPassword = new System.Windows.Forms.TextBox();
            this.lblCamIpAddress = new System.Windows.Forms.Label();
            this.tbCamLink = new System.Windows.Forms.TextBox();
            this.tpEsitScaleSil = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnEsitScaleSil = new System.Windows.Forms.Button();
            this.tpTartımSilme = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel13 = new System.Windows.Forms.TableLayoutPanel();
            this.rbTartim2 = new System.Windows.Forms.RadioButton();
            this.rbTartim1 = new System.Windows.Forms.RadioButton();
            this.btnTartimSilme = new System.Windows.Forms.Button();
            this.dtpTartimSaatEnd = new System.Windows.Forms.DateTimePicker();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tableLayoutPanel12 = new System.Windows.Forms.TableLayoutPanel();
            this.rbTartimPeriodDelete = new System.Windows.Forms.RadioButton();
            this.rbTartimAllDelete = new System.Windows.Forms.RadioButton();
            this.dtpTartimDateStart = new System.Windows.Forms.DateTimePicker();
            this.lbTartımStart = new System.Windows.Forms.Label();
            this.dtpTartimDateEnd = new System.Windows.Forms.DateTimePicker();
            this.lbTartımEnd = new System.Windows.Forms.Label();
            this.dtpTartimSaatStart = new System.Windows.Forms.DateTimePicker();
            this.tpDatabaseStop = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAuditDBScript = new System.Windows.Forms.Button();
            this.btnSpwinDBScript = new System.Windows.Forms.Button();
            this.tpServerConManager = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.btnServerConManager = new System.Windows.Forms.Button();
            this.tableLayoutPanel20 = new System.Windows.Forms.TableLayoutPanel();
            this.label12 = new System.Windows.Forms.Label();
            this.tbConfigServerName = new System.Windows.Forms.TextBox();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControlProcessHeaders.SuspendLayout();
            this.tpBackup.SuspendLayout();
            this.tableLayoutPanel18.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tableLayoutPanel19.SuspendLayout();
            this.tpRestore.SuspendLayout();
            this.tableLayoutPanel16.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tableLayoutPanel17.SuspendLayout();
            this.tpSQLFile.SuspendLayout();
            this.tableLayoutPanel14.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tableLayoutPanel15.SuspendLayout();
            this.tpSPWinDatabasePhotoDelete.SuspendLayout();
            this.tableLayoutPanel9.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.tableLayoutPanel11.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tableLayoutPanel10.SuspendLayout();
            this.tpDatabaseRepair.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tpSPWinScaleAndDBAConsolidation.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            this.tpTablolar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGV1)).BeginInit();
            this.tpQuary.SuspendLayout();
            this.tpSorgu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tpEsitUserEkle.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.tpCamPhotoLink.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tpEsitScaleSil.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tpTartımSilme.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tableLayoutPanel13.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tableLayoutPanel12.SuspendLayout();
            this.tpDatabaseStop.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tpServerConManager.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel20.SuspendLayout();
            this.gbConnectionSettings.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlProcessHeaders
            // 
            this.tabControlProcessHeaders.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.tabControlProcessHeaders.Controls.Add(this.tpBackup);
            this.tabControlProcessHeaders.Controls.Add(this.tpRestore);
            this.tabControlProcessHeaders.Controls.Add(this.tpSQLFile);
            this.tabControlProcessHeaders.Controls.Add(this.tpSPWinDatabasePhotoDelete);
            this.tabControlProcessHeaders.Controls.Add(this.tpDatabaseRepair);
            this.tabControlProcessHeaders.Controls.Add(this.tpSPWinScaleAndDBAConsolidation);
            this.tabControlProcessHeaders.Controls.Add(this.tpTablolar);
            this.tabControlProcessHeaders.Controls.Add(this.tpQuary);
            this.tabControlProcessHeaders.Controls.Add(this.tpSorgu);
            this.tabControlProcessHeaders.Controls.Add(this.tpEsitUserEkle);
            this.tabControlProcessHeaders.Controls.Add(this.tpCamPhotoLink);
            this.tabControlProcessHeaders.Controls.Add(this.tpEsitScaleSil);
            this.tabControlProcessHeaders.Controls.Add(this.tpTartımSilme);
            this.tabControlProcessHeaders.Controls.Add(this.tpDatabaseStop);
            this.tabControlProcessHeaders.Controls.Add(this.tpServerConManager);
            this.tabControlProcessHeaders.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabControlProcessHeaders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlProcessHeaders.Enabled = false;
            this.tabControlProcessHeaders.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControlProcessHeaders.Location = new System.Drawing.Point(3, 253);
            this.tabControlProcessHeaders.MinimumSize = new System.Drawing.Size(665, 413);
            this.tabControlProcessHeaders.Multiline = true;
            this.tabControlProcessHeaders.Name = "tabControlProcessHeaders";
            this.tabControlProcessHeaders.SelectedIndex = 0;
            this.tabControlProcessHeaders.Size = new System.Drawing.Size(665, 413);
            this.tabControlProcessHeaders.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlProcessHeaders.TabIndex = 0;
            // 
            // tpBackup
            // 
            this.tpBackup.BackColor = System.Drawing.SystemColors.Control;
            this.tpBackup.Controls.Add(this.tableLayoutPanel18);
            this.tpBackup.Location = new System.Drawing.Point(4, 82);
            this.tpBackup.Name = "tpBackup";
            this.tpBackup.Padding = new System.Windows.Forms.Padding(3);
            this.tpBackup.Size = new System.Drawing.Size(657, 327);
            this.tpBackup.TabIndex = 0;
            this.tpBackup.Text = "Yedekle";
            // 
            // tableLayoutPanel18
            // 
            this.tableLayoutPanel18.ColumnCount = 3;
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel18.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel18.Controls.Add(this.groupBox1, 1, 1);
            this.tableLayoutPanel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel18.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel18.Name = "tableLayoutPanel18";
            this.tableLayoutPanel18.RowCount = 3;
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel18.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel18.Size = new System.Drawing.Size(651, 321);
            this.tableLayoutPanel18.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tableLayoutPanel19);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(133, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 186);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Veritabanı Yedekle";
            // 
            // tableLayoutPanel19
            // 
            this.tableLayoutPanel19.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel19.ColumnCount = 3;
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel19.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel19.Controls.Add(this.btnBackupFileLocationSelect, 2, 1);
            this.tableLayoutPanel19.Controls.Add(this.btnBackup, 1, 2);
            this.tableLayoutPanel19.Controls.Add(this.cbxDbNameBackup, 1, 0);
            this.tableLayoutPanel19.Controls.Add(this.label1, 0, 1);
            this.tableLayoutPanel19.Controls.Add(this.txtBackupPath, 1, 1);
            this.tableLayoutPanel19.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel19.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel19.Name = "tableLayoutPanel19";
            this.tableLayoutPanel19.RowCount = 3;
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel19.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel19.Size = new System.Drawing.Size(378, 165);
            this.tableLayoutPanel19.TabIndex = 5;
            // 
            // btnBackupFileLocationSelect
            // 
            this.btnBackupFileLocationSelect.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnBackupFileLocationSelect.Location = new System.Drawing.Point(324, 71);
            this.btnBackupFileLocationSelect.Name = "btnBackupFileLocationSelect";
            this.btnBackupFileLocationSelect.Size = new System.Drawing.Size(51, 22);
            this.btnBackupFileLocationSelect.TabIndex = 3;
            this.btnBackupFileLocationSelect.Text = "- - -";
            this.btnBackupFileLocationSelect.UseVisualStyleBackColor = true;
            this.btnBackupFileLocationSelect.Click += new System.EventHandler(this.BtnBackupFileLocationSelect_Click);
            // 
            // btnBackup
            // 
            this.tableLayoutPanel19.SetColumnSpan(this.btnBackup, 2);
            this.btnBackup.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnBackup.Location = new System.Drawing.Point(135, 113);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(240, 49);
            this.btnBackup.TabIndex = 4;
            this.btnBackup.Text = "Yedekle";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.BtnBackup_Click);
            // 
            // cbxDbNameBackup
            // 
            this.cbxDbNameBackup.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxDbNameBackup.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbxDbNameBackup.Enabled = false;
            this.cbxDbNameBackup.FormattingEnabled = true;
            this.cbxDbNameBackup.Location = new System.Drawing.Point(135, 15);
            this.cbxDbNameBackup.Name = "cbxDbNameBackup";
            this.cbxDbNameBackup.Size = new System.Drawing.Size(183, 24);
            this.cbxDbNameBackup.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Veritabanı Dosya Konumu :";
            // 
            // txtBackupPath
            // 
            this.txtBackupPath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtBackupPath.Location = new System.Drawing.Point(135, 71);
            this.txtBackupPath.Name = "txtBackupPath";
            this.txtBackupPath.Size = new System.Drawing.Size(183, 22);
            this.txtBackupPath.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Veritabanı Adı :";
            // 
            // tpRestore
            // 
            this.tpRestore.BackColor = System.Drawing.SystemColors.Control;
            this.tpRestore.Controls.Add(this.tableLayoutPanel16);
            this.tpRestore.Location = new System.Drawing.Point(4, 82);
            this.tpRestore.Name = "tpRestore";
            this.tpRestore.Padding = new System.Windows.Forms.Padding(3);
            this.tpRestore.Size = new System.Drawing.Size(657, 327);
            this.tpRestore.TabIndex = 1;
            this.tpRestore.Text = "Geri Yükle";
            // 
            // tableLayoutPanel16
            // 
            this.tableLayoutPanel16.ColumnCount = 3;
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel16.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel16.Controls.Add(this.groupBox5, 1, 1);
            this.tableLayoutPanel16.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel16.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel16.Name = "tableLayoutPanel16";
            this.tableLayoutPanel16.RowCount = 3;
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel16.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel16.Size = new System.Drawing.Size(651, 321);
            this.tableLayoutPanel16.TabIndex = 9;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.tableLayoutPanel17);
            this.groupBox5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox5.Location = new System.Drawing.Point(133, 67);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(384, 186);
            this.groupBox5.TabIndex = 7;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "SQL Dosyası Çalıştırma";
            // 
            // tableLayoutPanel17
            // 
            this.tableLayoutPanel17.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel17.ColumnCount = 3;
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel17.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel17.Controls.Add(this.btnRestoreFile, 2, 1);
            this.tableLayoutPanel17.Controls.Add(this.cbxDbNameRestore, 1, 0);
            this.tableLayoutPanel17.Controls.Add(this.txtRestorePath, 1, 1);
            this.tableLayoutPanel17.Controls.Add(this.label3, 0, 0);
            this.tableLayoutPanel17.Controls.Add(this.label4, 0, 1);
            this.tableLayoutPanel17.Controls.Add(this.btnRestore, 1, 2);
            this.tableLayoutPanel17.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel17.Name = "tableLayoutPanel17";
            this.tableLayoutPanel17.RowCount = 3;
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel17.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel17.Size = new System.Drawing.Size(378, 165);
            this.tableLayoutPanel17.TabIndex = 5;
            // 
            // btnRestoreFile
            // 
            this.btnRestoreFile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnRestoreFile.Location = new System.Drawing.Point(324, 71);
            this.btnRestoreFile.Name = "btnRestoreFile";
            this.btnRestoreFile.Size = new System.Drawing.Size(51, 22);
            this.btnRestoreFile.TabIndex = 3;
            this.btnRestoreFile.Text = "- - -";
            this.btnRestoreFile.UseVisualStyleBackColor = true;
            this.btnRestoreFile.Click += new System.EventHandler(this.BtnRestoreFile_Click);
            // 
            // cbxDbNameRestore
            // 
            this.cbxDbNameRestore.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbxDbNameRestore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbxDbNameRestore.Enabled = false;
            this.cbxDbNameRestore.FormattingEnabled = true;
            this.cbxDbNameRestore.Location = new System.Drawing.Point(135, 15);
            this.cbxDbNameRestore.Name = "cbxDbNameRestore";
            this.cbxDbNameRestore.Size = new System.Drawing.Size(183, 24);
            this.cbxDbNameRestore.TabIndex = 9;
            // 
            // txtRestorePath
            // 
            this.txtRestorePath.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtRestorePath.Location = new System.Drawing.Point(135, 71);
            this.txtRestorePath.Name = "txtRestorePath";
            this.txtRestorePath.Size = new System.Drawing.Size(183, 22);
            this.txtRestorePath.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Veritabanı Adı :";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 32);
            this.label4.TabIndex = 0;
            this.label4.Text = "Veritabanı Dosyası :";
            // 
            // btnRestore
            // 
            this.tableLayoutPanel17.SetColumnSpan(this.btnRestore, 2);
            this.btnRestore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRestore.Location = new System.Drawing.Point(135, 113);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(240, 49);
            this.btnRestore.TabIndex = 4;
            this.btnRestore.Text = "Veritabanını Geri Yükle";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.BtnRestore_Click);
            // 
            // tpSQLFile
            // 
            this.tpSQLFile.BackColor = System.Drawing.SystemColors.Control;
            this.tpSQLFile.Controls.Add(this.tableLayoutPanel14);
            this.tpSQLFile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tpSQLFile.Location = new System.Drawing.Point(4, 82);
            this.tpSQLFile.Name = "tpSQLFile";
            this.tpSQLFile.Padding = new System.Windows.Forms.Padding(3);
            this.tpSQLFile.Size = new System.Drawing.Size(657, 327);
            this.tpSQLFile.TabIndex = 2;
            this.tpSQLFile.Text = "SQL Dosyası Çalıştırma";
            // 
            // tableLayoutPanel14
            // 
            this.tableLayoutPanel14.ColumnCount = 3;
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel14.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel14.Controls.Add(this.groupBox2, 1, 1);
            this.tableLayoutPanel14.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel14.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel14.Name = "tableLayoutPanel14";
            this.tableLayoutPanel14.RowCount = 3;
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel14.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel14.Size = new System.Drawing.Size(651, 321);
            this.tableLayoutPanel14.TabIndex = 8;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.tableLayoutPanel15);
            this.groupBox2.Location = new System.Drawing.Point(139, 117);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(371, 85);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "SQL Dosyası Çalıştırma";
            // 
            // tableLayoutPanel15
            // 
            this.tableLayoutPanel15.ColumnCount = 3;
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel15.Controls.Add(this.label6, 0, 0);
            this.tableLayoutPanel15.Controls.Add(this.txtSQLFile, 1, 0);
            this.tableLayoutPanel15.Controls.Add(this.btnSQLFileSelect, 2, 0);
            this.tableLayoutPanel15.Controls.Add(this.btnSQLRun, 1, 1);
            this.tableLayoutPanel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel15.Location = new System.Drawing.Point(3, 18);
            this.tableLayoutPanel15.Name = "tableLayoutPanel15";
            this.tableLayoutPanel15.RowCount = 2;
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel15.Size = new System.Drawing.Size(365, 64);
            this.tableLayoutPanel15.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 8);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 16);
            this.label6.TabIndex = 0;
            this.label6.Text = "SQL Dosyası :";
            // 
            // txtSQLFile
            // 
            this.txtSQLFile.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtSQLFile.Location = new System.Drawing.Point(130, 5);
            this.txtSQLFile.Name = "txtSQLFile";
            this.txtSQLFile.Size = new System.Drawing.Size(176, 22);
            this.txtSQLFile.TabIndex = 2;
            // 
            // btnSQLFileSelect
            // 
            this.btnSQLFileSelect.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.btnSQLFileSelect.Location = new System.Drawing.Point(312, 5);
            this.btnSQLFileSelect.Name = "btnSQLFileSelect";
            this.btnSQLFileSelect.Size = new System.Drawing.Size(50, 22);
            this.btnSQLFileSelect.TabIndex = 3;
            this.btnSQLFileSelect.Text = "- - -";
            this.btnSQLFileSelect.UseVisualStyleBackColor = true;
            this.btnSQLFileSelect.Click += new System.EventHandler(this.BtnSQLFileSelect_Click);
            // 
            // btnSQLRun
            // 
            this.tableLayoutPanel15.SetColumnSpan(this.btnSQLRun, 2);
            this.btnSQLRun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSQLRun.Location = new System.Drawing.Point(130, 35);
            this.btnSQLRun.Name = "btnSQLRun";
            this.btnSQLRun.Size = new System.Drawing.Size(232, 26);
            this.btnSQLRun.TabIndex = 4;
            this.btnSQLRun.Text = "SQL Dosyasını Çalıştır";
            this.btnSQLRun.UseVisualStyleBackColor = true;
            this.btnSQLRun.Click += new System.EventHandler(this.BtnSQLRun_Click);
            // 
            // tpSPWinDatabasePhotoDelete
            // 
            this.tpSPWinDatabasePhotoDelete.BackColor = System.Drawing.SystemColors.Control;
            this.tpSPWinDatabasePhotoDelete.Controls.Add(this.tableLayoutPanel9);
            this.tpSPWinDatabasePhotoDelete.Location = new System.Drawing.Point(4, 82);
            this.tpSPWinDatabasePhotoDelete.Name = "tpSPWinDatabasePhotoDelete";
            this.tpSPWinDatabasePhotoDelete.Padding = new System.Windows.Forms.Padding(3);
            this.tpSPWinDatabasePhotoDelete.Size = new System.Drawing.Size(657, 327);
            this.tpSPWinDatabasePhotoDelete.TabIndex = 3;
            this.tpSPWinDatabasePhotoDelete.Text = "Veritabanından Fotoğraf Silme";
            // 
            // tableLayoutPanel9
            // 
            this.tableLayoutPanel9.ColumnCount = 4;
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.tableLayoutPanel9.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 26F));
            this.tableLayoutPanel9.Controls.Add(this.groupBox7, 2, 0);
            this.tableLayoutPanel9.Controls.Add(this.groupBox8, 1, 0);
            this.tableLayoutPanel9.Controls.Add(this.btnWeighPhotoDelete, 3, 3);
            this.tableLayoutPanel9.Controls.Add(this.dtpFinish, 2, 2);
            this.tableLayoutPanel9.Controls.Add(this.lblDateFinish, 2, 1);
            this.tableLayoutPanel9.Controls.Add(this.dtpStart, 1, 2);
            this.tableLayoutPanel9.Controls.Add(this.lblDateStart, 1, 1);
            this.tableLayoutPanel9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel9.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel9.Name = "tableLayoutPanel9";
            this.tableLayoutPanel9.RowCount = 4;
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel9.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel9.Size = new System.Drawing.Size(651, 321);
            this.tableLayoutPanel9.TabIndex = 33;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.tableLayoutPanel11);
            this.groupBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox7.Location = new System.Drawing.Point(315, 3);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(163, 122);
            this.groupBox7.TabIndex = 31;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Tartım Seçiniz";
            // 
            // tableLayoutPanel11
            // 
            this.tableLayoutPanel11.ColumnCount = 1;
            this.tableLayoutPanel11.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel11.Controls.Add(this.rbAllPhoto, 0, 2);
            this.tableLayoutPanel11.Controls.Add(this.rbOneAndTwoPhoto, 0, 0);
            this.tableLayoutPanel11.Controls.Add(this.rbInTheFolderPhoto, 0, 1);
            this.tableLayoutPanel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel11.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanel11.Name = "tableLayoutPanel11";
            this.tableLayoutPanel11.RowCount = 3;
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel11.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel11.Size = new System.Drawing.Size(157, 94);
            this.tableLayoutPanel11.TabIndex = 32;
            // 
            // rbAllPhoto
            // 
            this.rbAllPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbAllPhoto.AutoSize = true;
            this.rbAllPhoto.Location = new System.Drawing.Point(3, 65);
            this.rbAllPhoto.Name = "rbAllPhoto";
            this.rbAllPhoto.Size = new System.Drawing.Size(151, 26);
            this.rbAllPhoto.TabIndex = 10;
            this.rbAllPhoto.Text = "Hepsi";
            this.rbAllPhoto.UseVisualStyleBackColor = true;
            // 
            // rbOneAndTwoPhoto
            // 
            this.rbOneAndTwoPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbOneAndTwoPhoto.AutoSize = true;
            this.rbOneAndTwoPhoto.Location = new System.Drawing.Point(3, 3);
            this.rbOneAndTwoPhoto.Name = "rbOneAndTwoPhoto";
            this.rbOneAndTwoPhoto.Size = new System.Drawing.Size(151, 25);
            this.rbOneAndTwoPhoto.TabIndex = 8;
            this.rbOneAndTwoPhoto.Text = "Veri tabanı";
            this.rbOneAndTwoPhoto.UseVisualStyleBackColor = true;
            // 
            // rbInTheFolderPhoto
            // 
            this.rbInTheFolderPhoto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rbInTheFolderPhoto.AutoSize = true;
            this.rbInTheFolderPhoto.Location = new System.Drawing.Point(3, 34);
            this.rbInTheFolderPhoto.Name = "rbInTheFolderPhoto";
            this.rbInTheFolderPhoto.Size = new System.Drawing.Size(151, 25);
            this.rbInTheFolderPhoto.TabIndex = 9;
            this.rbInTheFolderPhoto.Text = "Klasör";
            this.rbInTheFolderPhoto.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.tableLayoutPanel10);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox8.Location = new System.Drawing.Point(146, 3);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(163, 122);
            this.groupBox8.TabIndex = 30;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Tarih Seçiniz";
            // 
            // tableLayoutPanel10
            // 
            this.tableLayoutPanel10.ColumnCount = 1;
            this.tableLayoutPanel10.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Controls.Add(this.rdbPeriod, 0, 1);
            this.tableLayoutPanel10.Controls.Add(this.rdbAll, 0, 0);
            this.tableLayoutPanel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel10.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanel10.Name = "tableLayoutPanel10";
            this.tableLayoutPanel10.RowCount = 2;
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel10.Size = new System.Drawing.Size(157, 94);
            this.tableLayoutPanel10.TabIndex = 32;
            // 
            // rdbPeriod
            // 
            this.rdbPeriod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbPeriod.AutoSize = true;
            this.rdbPeriod.Location = new System.Drawing.Point(2, 49);
            this.rdbPeriod.Margin = new System.Windows.Forms.Padding(2);
            this.rdbPeriod.Name = "rdbPeriod";
            this.rdbPeriod.Size = new System.Drawing.Size(153, 28);
            this.rdbPeriod.TabIndex = 12;
            this.rdbPeriod.Text = "Tarih aralığını sil";
            this.rdbPeriod.UseVisualStyleBackColor = true;
            this.rdbPeriod.CheckedChanged += new System.EventHandler(this.rdbPeriod_CheckedChanged);
            // 
            // rdbAll
            // 
            this.rdbAll.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rdbAll.AutoSize = true;
            this.rdbAll.Location = new System.Drawing.Point(2, 17);
            this.rdbAll.Margin = new System.Windows.Forms.Padding(2);
            this.rdbAll.Name = "rdbAll";
            this.rdbAll.Size = new System.Drawing.Size(153, 28);
            this.rdbAll.TabIndex = 14;
            this.rdbAll.Text = "Tüm kayıtları sil";
            this.rdbAll.UseVisualStyleBackColor = true;
            this.rdbAll.CheckedChanged += new System.EventHandler(this.rdbAll_CheckedChanged);
            // 
            // btnWeighPhotoDelete
            // 
            this.btnWeighPhotoDelete.BackColor = System.Drawing.Color.Red;
            this.btnWeighPhotoDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnWeighPhotoDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnWeighPhotoDelete.Location = new System.Drawing.Point(484, 259);
            this.btnWeighPhotoDelete.Name = "btnWeighPhotoDelete";
            this.btnWeighPhotoDelete.Size = new System.Drawing.Size(164, 59);
            this.btnWeighPhotoDelete.TabIndex = 4;
            this.btnWeighPhotoDelete.Text = "Tartım Fotoğraflarını Sil";
            this.btnWeighPhotoDelete.UseVisualStyleBackColor = false;
            this.btnWeighPhotoDelete.Click += new System.EventHandler(this.BtnWeighPhotoDelete_Click);
            // 
            // dtpFinish
            // 
            this.dtpFinish.Location = new System.Drawing.Point(314, 194);
            this.dtpFinish.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFinish.Name = "dtpFinish";
            this.dtpFinish.Size = new System.Drawing.Size(128, 22);
            this.dtpFinish.TabIndex = 15;
            this.dtpFinish.Value = new System.DateTime(2023, 7, 25, 23, 59, 59, 0);
            this.dtpFinish.Visible = false;
            // 
            // lblDateFinish
            // 
            this.lblDateFinish.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDateFinish.AutoSize = true;
            this.lblDateFinish.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDateFinish.Location = new System.Drawing.Point(314, 148);
            this.lblDateFinish.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateFinish.Name = "lblDateFinish";
            this.lblDateFinish.Size = new System.Drawing.Size(95, 24);
            this.lblDateFinish.TabIndex = 24;
            this.lblDateFinish.Text = "Bitiş Tarihi";
            this.lblDateFinish.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDateFinish.Visible = false;
            // 
            // dtpStart
            // 
            this.dtpStart.Location = new System.Drawing.Point(145, 194);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(2);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(127, 22);
            this.dtpStart.TabIndex = 10;
            this.dtpStart.Value = new System.DateTime(2023, 7, 25, 0, 1, 0, 0);
            this.dtpStart.Visible = false;
            // 
            // lblDateStart
            // 
            this.lblDateStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDateStart.AutoSize = true;
            this.lblDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDateStart.Location = new System.Drawing.Point(145, 148);
            this.lblDateStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDateStart.Name = "lblDateStart";
            this.lblDateStart.Size = new System.Drawing.Size(143, 24);
            this.lblDateStart.TabIndex = 23;
            this.lblDateStart.Text = "Başlangıç Tarihi";
            this.lblDateStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblDateStart.Visible = false;
            // 
            // tpDatabaseRepair
            // 
            this.tpDatabaseRepair.BackColor = System.Drawing.SystemColors.Control;
            this.tpDatabaseRepair.Controls.Add(this.groupBox6);
            this.tpDatabaseRepair.Location = new System.Drawing.Point(4, 82);
            this.tpDatabaseRepair.Name = "tpDatabaseRepair";
            this.tpDatabaseRepair.Padding = new System.Windows.Forms.Padding(3);
            this.tpDatabaseRepair.Size = new System.Drawing.Size(657, 327);
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
            this.cbxDbNameRepair.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbxDbNameRepair.FormattingEnabled = true;
            this.cbxDbNameRepair.Location = new System.Drawing.Point(128, 28);
            this.cbxDbNameRepair.Name = "cbxDbNameRepair";
            this.cbxDbNameRepair.Size = new System.Drawing.Size(194, 24);
            this.cbxDbNameRepair.TabIndex = 10;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(128, 81);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(194, 22);
            this.textBox4.TabIndex = 8;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(72, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 16);
            this.label9.TabIndex = 7;
            this.label9.Text = "Boyut :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(34, 31);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 16);
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
            this.textBox6.Size = new System.Drawing.Size(194, 22);
            this.textBox6.TabIndex = 2;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(69, 58);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(50, 16);
            this.label11.TabIndex = 0;
            this.label11.Text = "Status :";
            // 
            // tpSPWinScaleAndDBAConsolidation
            // 
            this.tpSPWinScaleAndDBAConsolidation.BackColor = System.Drawing.SystemColors.Control;
            this.tpSPWinScaleAndDBAConsolidation.Controls.Add(this.tableLayoutPanel8);
            this.tpSPWinScaleAndDBAConsolidation.Location = new System.Drawing.Point(4, 82);
            this.tpSPWinScaleAndDBAConsolidation.Name = "tpSPWinScaleAndDBAConsolidation";
            this.tpSPWinScaleAndDBAConsolidation.Padding = new System.Windows.Forms.Padding(3);
            this.tpSPWinScaleAndDBAConsolidation.Size = new System.Drawing.Size(657, 327);
            this.tpSPWinScaleAndDBAConsolidation.TabIndex = 6;
            this.tpSPWinScaleAndDBAConsolidation.Text = "SPWin Scale ve DBA Birleştirme";
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 3;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel8.Controls.Add(this.btnMoveDbaToScale, 1, 1);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 3;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(651, 321);
            this.tableLayoutPanel8.TabIndex = 3;
            // 
            // btnMoveDbaToScale
            // 
            this.btnMoveDbaToScale.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnMoveDbaToScale.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnMoveDbaToScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnMoveDbaToScale.Location = new System.Drawing.Point(198, 99);
            this.btnMoveDbaToScale.Name = "btnMoveDbaToScale";
            this.btnMoveDbaToScale.Size = new System.Drawing.Size(254, 122);
            this.btnMoveDbaToScale.TabIndex = 0;
            this.btnMoveDbaToScale.Text = "Eski Versiyondaki DBA Verilerini Yeni Versiyona Taşı";
            this.btnMoveDbaToScale.UseVisualStyleBackColor = false;
            this.btnMoveDbaToScale.Click += new System.EventHandler(this.BtnMoveDbaToScale_Click);
            // 
            // tpTablolar
            // 
            this.tpTablolar.BackColor = System.Drawing.SystemColors.Control;
            this.tpTablolar.Controls.Add(this.checkedListBox1);
            this.tpTablolar.Controls.Add(this.CbxtableList);
            this.tpTablolar.Controls.Add(this.btngoster);
            this.tpTablolar.Controls.Add(this.dataGV1);
            this.tpTablolar.Location = new System.Drawing.Point(4, 82);
            this.tpTablolar.Margin = new System.Windows.Forms.Padding(2);
            this.tpTablolar.Name = "tpTablolar";
            this.tpTablolar.Padding = new System.Windows.Forms.Padding(2);
            this.tpTablolar.Size = new System.Drawing.Size(657, 327);
            this.tpTablolar.TabIndex = 8;
            this.tpTablolar.Text = "Tablolar";
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.CheckOnClick = true;
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Location = new System.Drawing.Point(4, 32);
            this.checkedListBox1.Margin = new System.Windows.Forms.Padding(2);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(111, 225);
            this.checkedListBox1.TabIndex = 20;
            // 
            // CbxtableList
            // 
            this.CbxtableList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbxtableList.FormattingEnabled = true;
            this.CbxtableList.Location = new System.Drawing.Point(4, 5);
            this.CbxtableList.Margin = new System.Windows.Forms.Padding(2);
            this.CbxtableList.Name = "CbxtableList";
            this.CbxtableList.Size = new System.Drawing.Size(111, 24);
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
            this.dataGV1.Location = new System.Drawing.Point(122, 2);
            this.dataGV1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGV1.Name = "dataGV1";
            this.dataGV1.ReadOnly = true;
            this.dataGV1.RowHeadersWidth = 51;
            this.dataGV1.RowTemplate.Height = 24;
            this.dataGV1.Size = new System.Drawing.Size(533, 323);
            this.dataGV1.TabIndex = 0;
            // 
            // tpQuary
            // 
            this.tpQuary.BackColor = System.Drawing.SystemColors.Control;
            this.tpQuary.Controls.Add(this.label7);
            this.tpQuary.Controls.Add(this.lblQuaryName);
            this.tpQuary.Controls.Add(this.tbxQuaryName);
            this.tpQuary.Controls.Add(this.tbxQuarySaveLoc);
            this.tpQuary.Controls.Add(this.btnloc);
            this.tpQuary.Controls.Add(this.btnQuaryClear);
            this.tpQuary.Controls.Add(this.btnQuarySave);
            this.tpQuary.Controls.Add(this.tbxQuary);
            this.tpQuary.Location = new System.Drawing.Point(4, 82);
            this.tpQuary.Margin = new System.Windows.Forms.Padding(2);
            this.tpQuary.Name = "tpQuary";
            this.tpQuary.Padding = new System.Windows.Forms.Padding(2);
            this.tpQuary.Size = new System.Drawing.Size(657, 327);
            this.tpQuary.TabIndex = 9;
            this.tpQuary.Text = "Quary.sql";
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
            this.tbxQuaryName.Size = new System.Drawing.Size(516, 22);
            this.tbxQuaryName.TabIndex = 6;
            // 
            // tbxQuarySaveLoc
            // 
            this.tbxQuarySaveLoc.Location = new System.Drawing.Point(235, 297);
            this.tbxQuarySaveLoc.Name = "tbxQuarySaveLoc";
            this.tbxQuarySaveLoc.Size = new System.Drawing.Size(225, 22);
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
            // tpSorgu
            // 
            this.tpSorgu.BackColor = System.Drawing.SystemColors.Control;
            this.tpSorgu.Controls.Add(this.panel1);
            this.tpSorgu.Location = new System.Drawing.Point(4, 82);
            this.tpSorgu.Margin = new System.Windows.Forms.Padding(2);
            this.tpSorgu.Name = "tpSorgu";
            this.tpSorgu.Padding = new System.Windows.Forms.Padding(2);
            this.tpSorgu.Size = new System.Drawing.Size(657, 327);
            this.tpSorgu.TabIndex = 10;
            this.tpSorgu.Text = "Sorgu";
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
            this.panel1.Size = new System.Drawing.Size(646, 339);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(2, 65);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(639, 272);
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
            // tpEsitUserEkle
            // 
            this.tpEsitUserEkle.BackColor = System.Drawing.SystemColors.Control;
            this.tpEsitUserEkle.Controls.Add(this.tableLayoutPanel7);
            this.tpEsitUserEkle.Location = new System.Drawing.Point(4, 82);
            this.tpEsitUserEkle.Name = "tpEsitUserEkle";
            this.tpEsitUserEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tpEsitUserEkle.Size = new System.Drawing.Size(657, 327);
            this.tpEsitUserEkle.TabIndex = 11;
            this.tpEsitUserEkle.Text = "Kullanıcı İşlemleri";
            // 
            // tableLayoutPanel7
            // 
            this.tableLayoutPanel7.ColumnCount = 4;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel7.Controls.Add(this.btnEsitUserSilHelp, 2, 6);
            this.tableLayoutPanel7.Controls.Add(this.btnKullanıcıSil, 3, 6);
            this.tableLayoutPanel7.Controls.Add(this.tbUserAddUserPasswordConfirm, 1, 3);
            this.tableLayoutPanel7.Controls.Add(this.btnKullanıcıEkle, 3, 5);
            this.tableLayoutPanel7.Controls.Add(this.cbUserAddUserRole, 1, 4);
            this.tableLayoutPanel7.Controls.Add(this.lbUserAddUserName, 0, 1);
            this.tableLayoutPanel7.Controls.Add(this.lbUserAddUserPasswordConfirm, 0, 3);
            this.tableLayoutPanel7.Controls.Add(this.lbUserAddUserPassword, 0, 2);
            this.tableLayoutPanel7.Controls.Add(this.tbUserAddUserPassword, 1, 2);
            this.tableLayoutPanel7.Controls.Add(this.lbUserAddUserRole, 0, 4);
            this.tableLayoutPanel7.Controls.Add(this.tbUserAddUserName, 1, 1);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tableLayoutPanel7.RowCount = 7;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28816F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28531F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(651, 321);
            this.tableLayoutPanel7.TabIndex = 11;
            // 
            // btnEsitUserSilHelp
            // 
            this.btnEsitUserSilHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEsitUserSilHelp.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnEsitUserSilHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEsitUserSilHelp.ForeColor = System.Drawing.SystemColors.Control;
            this.btnEsitUserSilHelp.Location = new System.Drawing.Point(422, 278);
            this.btnEsitUserSilHelp.Name = "btnEsitUserSilHelp";
            this.btnEsitUserSilHelp.Size = new System.Drawing.Size(30, 40);
            this.btnEsitUserSilHelp.TabIndex = 10;
            this.btnEsitUserSilHelp.Text = "?";
            this.btnEsitUserSilHelp.UseVisualStyleBackColor = false;
            this.btnEsitUserSilHelp.Click += new System.EventHandler(this.btnEsitUserSilHelp_Click);
            // 
            // btnKullanıcıSil
            // 
            this.btnKullanıcıSil.BackColor = System.Drawing.Color.Red;
            this.btnKullanıcıSil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKullanıcıSil.ForeColor = System.Drawing.Color.White;
            this.btnKullanıcıSil.Location = new System.Drawing.Point(458, 273);
            this.btnKullanıcıSil.Name = "btnKullanıcıSil";
            this.btnKullanıcıSil.Size = new System.Drawing.Size(190, 45);
            this.btnKullanıcıSil.TabIndex = 7;
            this.btnKullanıcıSil.Text = "Kullanıcı Sil";
            this.btnKullanıcıSil.UseVisualStyleBackColor = false;
            this.btnKullanıcıSil.Click += new System.EventHandler(this.btnKullanıcıSil_Click);
            // 
            // tbUserAddUserPasswordConfirm
            // 
            this.tbUserAddUserPasswordConfirm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUserAddUserPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbUserAddUserPasswordConfirm.Location = new System.Drawing.Point(198, 143);
            this.tbUserAddUserPasswordConfirm.Name = "tbUserAddUserPasswordConfirm";
            this.tbUserAddUserPasswordConfirm.PasswordChar = 'x';
            this.tbUserAddUserPasswordConfirm.Size = new System.Drawing.Size(189, 29);
            this.tbUserAddUserPasswordConfirm.TabIndex = 9;
            this.tbUserAddUserPasswordConfirm.Text = "esit12345";
            // 
            // btnKullanıcıEkle
            // 
            this.btnKullanıcıEkle.BackColor = System.Drawing.Color.ForestGreen;
            this.btnKullanıcıEkle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnKullanıcıEkle.ForeColor = System.Drawing.Color.White;
            this.btnKullanıcıEkle.Location = new System.Drawing.Point(458, 228);
            this.btnKullanıcıEkle.Name = "btnKullanıcıEkle";
            this.btnKullanıcıEkle.Size = new System.Drawing.Size(190, 39);
            this.btnKullanıcıEkle.TabIndex = 0;
            this.btnKullanıcıEkle.Text = "Kullanıcı Ekle";
            this.btnKullanıcıEkle.UseVisualStyleBackColor = false;
            this.btnKullanıcıEkle.Click += new System.EventHandler(this.btnKullanıcıEkle_Click);
            // 
            // cbUserAddUserRole
            // 
            this.cbUserAddUserRole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.cbUserAddUserRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbUserAddUserRole.FormattingEnabled = true;
            this.cbUserAddUserRole.Items.AddRange(new object[] {
            "Read-Only",
            "Admin"});
            this.cbUserAddUserRole.Location = new System.Drawing.Point(198, 190);
            this.cbUserAddUserRole.Name = "cbUserAddUserRole";
            this.cbUserAddUserRole.Size = new System.Drawing.Size(189, 24);
            this.cbUserAddUserRole.TabIndex = 6;
            // 
            // lbUserAddUserName
            // 
            this.lbUserAddUserName.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbUserAddUserName.AutoSize = true;
            this.lbUserAddUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbUserAddUserName.Location = new System.Drawing.Point(69, 55);
            this.lbUserAddUserName.Name = "lbUserAddUserName";
            this.lbUserAddUserName.Size = new System.Drawing.Size(123, 24);
            this.lbUserAddUserName.TabIndex = 1;
            this.lbUserAddUserName.Text = "Kullanıcı Adı :";
            // 
            // lbUserAddUserPasswordConfirm
            // 
            this.lbUserAddUserPasswordConfirm.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbUserAddUserPasswordConfirm.AutoSize = true;
            this.lbUserAddUserPasswordConfirm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbUserAddUserPasswordConfirm.Location = new System.Drawing.Point(38, 145);
            this.lbUserAddUserPasswordConfirm.Name = "lbUserAddUserPasswordConfirm";
            this.lbUserAddUserPasswordConfirm.Size = new System.Drawing.Size(154, 24);
            this.lbUserAddUserPasswordConfirm.TabIndex = 8;
            this.lbUserAddUserPasswordConfirm.Text = "Şifre Doğrulama :";
            // 
            // lbUserAddUserPassword
            // 
            this.lbUserAddUserPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbUserAddUserPassword.AutoSize = true;
            this.lbUserAddUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbUserAddUserPassword.Location = new System.Drawing.Point(60, 100);
            this.lbUserAddUserPassword.Name = "lbUserAddUserPassword";
            this.lbUserAddUserPassword.Size = new System.Drawing.Size(132, 24);
            this.lbUserAddUserPassword.TabIndex = 2;
            this.lbUserAddUserPassword.Text = "Kullanıcı Şifre :";
            // 
            // tbUserAddUserPassword
            // 
            this.tbUserAddUserPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUserAddUserPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbUserAddUserPassword.Location = new System.Drawing.Point(198, 98);
            this.tbUserAddUserPassword.Name = "tbUserAddUserPassword";
            this.tbUserAddUserPassword.PasswordChar = 'x';
            this.tbUserAddUserPassword.Size = new System.Drawing.Size(189, 29);
            this.tbUserAddUserPassword.TabIndex = 4;
            this.tbUserAddUserPassword.Text = "esit12345";
            // 
            // lbUserAddUserRole
            // 
            this.lbUserAddUserRole.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lbUserAddUserRole.AutoSize = true;
            this.lbUserAddUserRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbUserAddUserRole.Location = new System.Drawing.Point(70, 190);
            this.lbUserAddUserRole.Name = "lbUserAddUserRole";
            this.lbUserAddUserRole.Size = new System.Drawing.Size(122, 24);
            this.lbUserAddUserRole.TabIndex = 5;
            this.lbUserAddUserRole.Text = "Yetki Düzeyi :";
            // 
            // tbUserAddUserName
            // 
            this.tbUserAddUserName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbUserAddUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbUserAddUserName.Location = new System.Drawing.Point(198, 53);
            this.tbUserAddUserName.Name = "tbUserAddUserName";
            this.tbUserAddUserName.Size = new System.Drawing.Size(189, 29);
            this.tbUserAddUserName.TabIndex = 3;
            this.tbUserAddUserName.Text = "Esit_User";
            // 
            // tpCamPhotoLink
            // 
            this.tpCamPhotoLink.BackColor = System.Drawing.SystemColors.Control;
            this.tpCamPhotoLink.Controls.Add(this.tableLayoutPanel5);
            this.tpCamPhotoLink.Location = new System.Drawing.Point(4, 82);
            this.tpCamPhotoLink.Name = "tpCamPhotoLink";
            this.tpCamPhotoLink.Padding = new System.Windows.Forms.Padding(3);
            this.tpCamPhotoLink.Size = new System.Drawing.Size(657, 327);
            this.tpCamPhotoLink.TabIndex = 13;
            this.tpCamPhotoLink.Text = "kamera link";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 4;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.tableLayoutPanel5.Controls.Add(this.btnCamLinkCreate, 3, 2);
            this.tableLayoutPanel5.Controls.Add(this.btnLinkCopy, 3, 3);
            this.tableLayoutPanel5.Controls.Add(this.lblCamUser, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.lblCamPassword, 0, 1);
            this.tableLayoutPanel5.Controls.Add(this.cbCamType, 3, 1);
            this.tableLayoutPanel5.Controls.Add(this.tbCamUser, 1, 0);
            this.tableLayoutPanel5.Controls.Add(this.tbCamIpAddress, 3, 0);
            this.tableLayoutPanel5.Controls.Add(this.label8, 2, 1);
            this.tableLayoutPanel5.Controls.Add(this.tbCamPassword, 1, 1);
            this.tableLayoutPanel5.Controls.Add(this.lblCamIpAddress, 2, 0);
            this.tableLayoutPanel5.Controls.Add(this.tbCamLink, 1, 3);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 4;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(651, 321);
            this.tableLayoutPanel5.TabIndex = 7;
            // 
            // btnCamLinkCreate
            // 
            this.btnCamLinkCreate.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnCamLinkCreate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCamLinkCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCamLinkCreate.Location = new System.Drawing.Point(424, 163);
            this.btnCamLinkCreate.Name = "btnCamLinkCreate";
            this.btnCamLinkCreate.Size = new System.Drawing.Size(224, 74);
            this.btnCamLinkCreate.TabIndex = 4;
            this.btnCamLinkCreate.Text = "Kamera Linki Oluştur";
            this.btnCamLinkCreate.UseVisualStyleBackColor = false;
            this.btnCamLinkCreate.Click += new System.EventHandler(this.btnCamLinkCreate_Click);
            // 
            // btnLinkCopy
            // 
            this.btnLinkCopy.BackColor = System.Drawing.Color.GreenYellow;
            this.btnLinkCopy.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnLinkCopy.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnLinkCopy.Location = new System.Drawing.Point(424, 243);
            this.btnLinkCopy.Name = "btnLinkCopy";
            this.btnLinkCopy.Size = new System.Drawing.Size(224, 75);
            this.btnLinkCopy.TabIndex = 6;
            this.btnLinkCopy.Text = "Linki kopyala";
            this.btnLinkCopy.UseVisualStyleBackColor = false;
            this.btnLinkCopy.Click += new System.EventHandler(this.btnLinkCopy_Click);
            // 
            // lblCamUser
            // 
            this.lblCamUser.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCamUser.AutoSize = true;
            this.lblCamUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCamUser.Location = new System.Drawing.Point(9, 16);
            this.lblCamUser.Name = "lblCamUser";
            this.lblCamUser.Size = new System.Drawing.Size(85, 48);
            this.lblCamUser.TabIndex = 1;
            this.lblCamUser.Text = "Kullanıcı Adı :";
            // 
            // lblCamPassword
            // 
            this.lblCamPassword.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCamPassword.AutoSize = true;
            this.lblCamPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCamPassword.Location = new System.Drawing.Point(37, 108);
            this.lblCamPassword.Name = "lblCamPassword";
            this.lblCamPassword.Size = new System.Drawing.Size(57, 24);
            this.lblCamPassword.TabIndex = 2;
            this.lblCamPassword.Text = "Şifre :";
            // 
            // cbCamType
            // 
            this.cbCamType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbCamType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCamType.FormattingEnabled = true;
            this.cbCamType.Items.AddRange(new object[] {
            "Aver",
            "Dahua",
            "Hikvision"});
            this.cbCamType.Location = new System.Drawing.Point(424, 108);
            this.cbCamType.Name = "cbCamType";
            this.cbCamType.Size = new System.Drawing.Size(224, 24);
            this.cbCamType.TabIndex = 3;
            // 
            // tbCamUser
            // 
            this.tbCamUser.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbCamUser.Location = new System.Drawing.Point(100, 29);
            this.tbCamUser.Name = "tbCamUser";
            this.tbCamUser.Size = new System.Drawing.Size(221, 22);
            this.tbCamUser.TabIndex = 0;
            // 
            // tbCamIpAddress
            // 
            this.tbCamIpAddress.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbCamIpAddress.Location = new System.Drawing.Point(424, 29);
            this.tbCamIpAddress.Name = "tbCamIpAddress";
            this.tbCamIpAddress.Size = new System.Drawing.Size(224, 22);
            this.tbCamIpAddress.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(338, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 48);
            this.label8.TabIndex = 6;
            this.label8.Text = "Kamera Model :";
            // 
            // tbCamPassword
            // 
            this.tbCamPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tbCamPassword.Location = new System.Drawing.Point(100, 109);
            this.tbCamPassword.Name = "tbCamPassword";
            this.tbCamPassword.Size = new System.Drawing.Size(221, 22);
            this.tbCamPassword.TabIndex = 1;
            // 
            // lblCamIpAddress
            // 
            this.lblCamIpAddress.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.lblCamIpAddress.AutoSize = true;
            this.lblCamIpAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCamIpAddress.Location = new System.Drawing.Point(382, 28);
            this.lblCamIpAddress.Name = "lblCamIpAddress";
            this.lblCamIpAddress.Size = new System.Drawing.Size(36, 24);
            this.lblCamIpAddress.TabIndex = 0;
            this.lblCamIpAddress.Text = "IP :";
            // 
            // tbCamLink
            // 
            this.tbCamLink.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbCamLink.BackColor = System.Drawing.Color.GreenYellow;
            this.tableLayoutPanel5.SetColumnSpan(this.tbCamLink, 2);
            this.tbCamLink.Location = new System.Drawing.Point(100, 269);
            this.tbCamLink.Name = "tbCamLink";
            this.tbCamLink.ReadOnly = true;
            this.tbCamLink.Size = new System.Drawing.Size(318, 22);
            this.tbCamLink.TabIndex = 5;
            // 
            // tpEsitScaleSil
            // 
            this.tpEsitScaleSil.BackColor = System.Drawing.SystemColors.Control;
            this.tpEsitScaleSil.Controls.Add(this.tableLayoutPanel3);
            this.tpEsitScaleSil.Location = new System.Drawing.Point(4, 82);
            this.tpEsitScaleSil.Name = "tpEsitScaleSil";
            this.tpEsitScaleSil.Padding = new System.Windows.Forms.Padding(3);
            this.tpEsitScaleSil.Size = new System.Drawing.Size(657, 327);
            this.tpEsitScaleSil.TabIndex = 12;
            this.tpEsitScaleSil.Text = "www.EsitScale.com Sil";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Controls.Add(this.btnEsitScaleSil, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(651, 321);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // btnEsitScaleSil
            // 
            this.btnEsitScaleSil.BackColor = System.Drawing.Color.Red;
            this.btnEsitScaleSil.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEsitScaleSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEsitScaleSil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEsitScaleSil.Location = new System.Drawing.Point(198, 99);
            this.btnEsitScaleSil.Name = "btnEsitScaleSil";
            this.btnEsitScaleSil.Size = new System.Drawing.Size(254, 122);
            this.btnEsitScaleSil.TabIndex = 0;
            this.btnEsitScaleSil.Text = "www.EsitScale.com dosyalarını  Sil";
            this.btnEsitScaleSil.UseVisualStyleBackColor = false;
            this.btnEsitScaleSil.Click += new System.EventHandler(this.btnEsitScaleSil_Click);
            // 
            // tpTartımSilme
            // 
            this.tpTartımSilme.BackColor = System.Drawing.SystemColors.Control;
            this.tpTartımSilme.Controls.Add(this.tableLayoutPanel6);
            this.tpTartımSilme.Location = new System.Drawing.Point(4, 82);
            this.tpTartımSilme.Name = "tpTartımSilme";
            this.tpTartımSilme.Padding = new System.Windows.Forms.Padding(3);
            this.tpTartımSilme.Size = new System.Drawing.Size(657, 327);
            this.tpTartımSilme.TabIndex = 14;
            this.tpTartımSilme.Text = "Tartım Silme";
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 4;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel6.Controls.Add(this.groupBox4, 2, 0);
            this.tableLayoutPanel6.Controls.Add(this.btnTartimSilme, 3, 4);
            this.tableLayoutPanel6.Controls.Add(this.dtpTartimSaatEnd, 2, 3);
            this.tableLayoutPanel6.Controls.Add(this.groupBox3, 1, 0);
            this.tableLayoutPanel6.Controls.Add(this.dtpTartimDateStart, 1, 2);
            this.tableLayoutPanel6.Controls.Add(this.lbTartımStart, 1, 1);
            this.tableLayoutPanel6.Controls.Add(this.dtpTartimDateEnd, 2, 2);
            this.tableLayoutPanel6.Controls.Add(this.lbTartımEnd, 2, 1);
            this.tableLayoutPanel6.Controls.Add(this.dtpTartimSaatStart, 1, 3);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 5;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(651, 321);
            this.tableLayoutPanel6.TabIndex = 32;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tableLayoutPanel13);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox4.Location = new System.Drawing.Point(295, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(189, 122);
            this.groupBox4.TabIndex = 31;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tartım Seçiniz";
            // 
            // tableLayoutPanel13
            // 
            this.tableLayoutPanel13.ColumnCount = 1;
            this.tableLayoutPanel13.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Controls.Add(this.rbTartim2, 0, 1);
            this.tableLayoutPanel13.Controls.Add(this.rbTartim1, 0, 0);
            this.tableLayoutPanel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel13.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanel13.Name = "tableLayoutPanel13";
            this.tableLayoutPanel13.RowCount = 2;
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel13.Size = new System.Drawing.Size(183, 94);
            this.tableLayoutPanel13.TabIndex = 32;
            // 
            // rbTartim2
            // 
            this.rbTartim2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbTartim2.AutoSize = true;
            this.rbTartim2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbTartim2.Location = new System.Drawing.Point(3, 56);
            this.rbTartim2.Name = "rbTartim2";
            this.rbTartim2.Size = new System.Drawing.Size(177, 28);
            this.rbTartim2.TabIndex = 9;
            this.rbTartim2.Text = "2. Tartım";
            this.rbTartim2.UseVisualStyleBackColor = true;
            // 
            // rbTartim1
            // 
            this.rbTartim1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbTartim1.AutoSize = true;
            this.rbTartim1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbTartim1.Location = new System.Drawing.Point(3, 9);
            this.rbTartim1.Name = "rbTartim1";
            this.rbTartim1.Size = new System.Drawing.Size(177, 28);
            this.rbTartim1.TabIndex = 8;
            this.rbTartim1.Text = "1. Tartım";
            this.rbTartim1.UseVisualStyleBackColor = true;
            // 
            // btnTartimSilme
            // 
            this.btnTartimSilme.BackColor = System.Drawing.Color.Red;
            this.btnTartimSilme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTartimSilme.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTartimSilme.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnTartimSilme.Location = new System.Drawing.Point(490, 275);
            this.btnTartimSilme.Name = "btnTartimSilme";
            this.btnTartimSilme.Size = new System.Drawing.Size(158, 43);
            this.btnTartimSilme.TabIndex = 4;
            this.btnTartimSilme.Text = "Tartımları Sil !";
            this.btnTartimSilme.UseVisualStyleBackColor = false;
            this.btnTartimSilme.Click += new System.EventHandler(this.btnTartımSilme_Click);
            // 
            // dtpTartimSaatEnd
            // 
            this.dtpTartimSaatEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTartimSaatEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTartimSaatEnd.Location = new System.Drawing.Point(294, 226);
            this.dtpTartimSaatEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTartimSaatEnd.Name = "dtpTartimSaatEnd";
            this.dtpTartimSaatEnd.Size = new System.Drawing.Size(95, 29);
            this.dtpTartimSaatEnd.TabIndex = 28;
            this.dtpTartimSaatEnd.Value = new System.DateTime(2024, 7, 26, 23, 59, 0, 0);
            this.dtpTartimSaatEnd.Visible = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tableLayoutPanel12);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.groupBox3.Location = new System.Drawing.Point(100, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(189, 122);
            this.groupBox3.TabIndex = 30;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tarih Seçiniz";
            // 
            // tableLayoutPanel12
            // 
            this.tableLayoutPanel12.ColumnCount = 1;
            this.tableLayoutPanel12.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Controls.Add(this.rbTartimPeriodDelete, 0, 1);
            this.tableLayoutPanel12.Controls.Add(this.rbTartimAllDelete, 0, 0);
            this.tableLayoutPanel12.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel12.Location = new System.Drawing.Point(3, 25);
            this.tableLayoutPanel12.Name = "tableLayoutPanel12";
            this.tableLayoutPanel12.RowCount = 2;
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel12.Size = new System.Drawing.Size(183, 94);
            this.tableLayoutPanel12.TabIndex = 32;
            // 
            // rbTartimPeriodDelete
            // 
            this.rbTartimPeriodDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbTartimPeriodDelete.AutoSize = true;
            this.rbTartimPeriodDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbTartimPeriodDelete.Location = new System.Drawing.Point(2, 56);
            this.rbTartimPeriodDelete.Margin = new System.Windows.Forms.Padding(2);
            this.rbTartimPeriodDelete.Name = "rbTartimPeriodDelete";
            this.rbTartimPeriodDelete.Size = new System.Drawing.Size(179, 28);
            this.rbTartimPeriodDelete.TabIndex = 20;
            this.rbTartimPeriodDelete.Text = "Tarih aralığını sil";
            this.rbTartimPeriodDelete.UseVisualStyleBackColor = true;
            this.rbTartimPeriodDelete.Click += new System.EventHandler(this.rbTartımPeriodDelete_Click);
            // 
            // rbTartimAllDelete
            // 
            this.rbTartimAllDelete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.rbTartimAllDelete.AutoSize = true;
            this.rbTartimAllDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.rbTartimAllDelete.Location = new System.Drawing.Point(2, 9);
            this.rbTartimAllDelete.Margin = new System.Windows.Forms.Padding(2);
            this.rbTartimAllDelete.Name = "rbTartimAllDelete";
            this.rbTartimAllDelete.Size = new System.Drawing.Size(179, 28);
            this.rbTartimAllDelete.TabIndex = 21;
            this.rbTartimAllDelete.Text = "Tüm kayıtları sil";
            this.rbTartimAllDelete.UseVisualStyleBackColor = true;
            this.rbTartimAllDelete.Click += new System.EventHandler(this.rbTartımAllDelete_Click);
            // 
            // dtpTartimDateStart
            // 
            this.dtpTartimDateStart.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpTartimDateStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTartimDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTartimDateStart.Location = new System.Drawing.Point(99, 193);
            this.dtpTartimDateStart.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTartimDateStart.Name = "dtpTartimDateStart";
            this.dtpTartimDateStart.Size = new System.Drawing.Size(118, 29);
            this.dtpTartimDateStart.TabIndex = 19;
            this.dtpTartimDateStart.Value = new System.DateTime(2024, 7, 29, 0, 0, 0, 0);
            this.dtpTartimDateStart.Visible = false;
            // 
            // lbTartımStart
            // 
            this.lbTartımStart.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTartımStart.AutoSize = true;
            this.lbTartımStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbTartımStart.Location = new System.Drawing.Point(99, 140);
            this.lbTartımStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTartımStart.Name = "lbTartımStart";
            this.lbTartımStart.Size = new System.Drawing.Size(143, 24);
            this.lbTartımStart.TabIndex = 23;
            this.lbTartımStart.Text = "Başlangıç Tarihi";
            this.lbTartımStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbTartımStart.Visible = false;
            // 
            // dtpTartimDateEnd
            // 
            this.dtpTartimDateEnd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.dtpTartimDateEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTartimDateEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTartimDateEnd.Location = new System.Drawing.Point(294, 193);
            this.dtpTartimDateEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTartimDateEnd.Name = "dtpTartimDateEnd";
            this.dtpTartimDateEnd.Size = new System.Drawing.Size(118, 29);
            this.dtpTartimDateEnd.TabIndex = 22;
            this.dtpTartimDateEnd.Value = new System.DateTime(2024, 7, 29, 0, 0, 0, 0);
            this.dtpTartimDateEnd.Visible = false;
            // 
            // lbTartımEnd
            // 
            this.lbTartımEnd.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbTartımEnd.AutoSize = true;
            this.lbTartımEnd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbTartımEnd.Location = new System.Drawing.Point(294, 140);
            this.lbTartımEnd.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTartımEnd.Name = "lbTartımEnd";
            this.lbTartımEnd.Size = new System.Drawing.Size(95, 24);
            this.lbTartımEnd.TabIndex = 24;
            this.lbTartımEnd.Text = "Bitiş Tarihi";
            this.lbTartımEnd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbTartımEnd.Visible = false;
            // 
            // dtpTartimSaatStart
            // 
            this.dtpTartimSaatStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTartimSaatStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpTartimSaatStart.Location = new System.Drawing.Point(99, 226);
            this.dtpTartimSaatStart.Margin = new System.Windows.Forms.Padding(2);
            this.dtpTartimSaatStart.Name = "dtpTartimSaatStart";
            this.dtpTartimSaatStart.Size = new System.Drawing.Size(99, 29);
            this.dtpTartimSaatStart.TabIndex = 27;
            this.dtpTartimSaatStart.Value = new System.DateTime(2023, 7, 25, 0, 1, 0, 0);
            this.dtpTartimSaatStart.Visible = false;
            // 
            // tpDatabaseStop
            // 
            this.tpDatabaseStop.BackColor = System.Drawing.SystemColors.Control;
            this.tpDatabaseStop.Controls.Add(this.tableLayoutPanel2);
            this.tpDatabaseStop.Location = new System.Drawing.Point(4, 82);
            this.tpDatabaseStop.Name = "tpDatabaseStop";
            this.tpDatabaseStop.Padding = new System.Windows.Forms.Padding(3);
            this.tpDatabaseStop.Size = new System.Drawing.Size(657, 327);
            this.tpDatabaseStop.TabIndex = 15;
            this.tpDatabaseStop.Text = "Veri Tabanı Durdu";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 4;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.btnAuditDBScript, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnSpwinDBScript, 2, 1);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(651, 321);
            this.tableLayoutPanel2.TabIndex = 2;
            // 
            // btnAuditDBScript
            // 
            this.btnAuditDBScript.BackColor = System.Drawing.Color.GreenYellow;
            this.btnAuditDBScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAuditDBScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAuditDBScript.Location = new System.Drawing.Point(133, 99);
            this.btnAuditDBScript.Name = "btnAuditDBScript";
            this.btnAuditDBScript.Size = new System.Drawing.Size(189, 122);
            this.btnAuditDBScript.TabIndex = 0;
            this.btnAuditDBScript.Text = "Audit script çalıştır";
            this.btnAuditDBScript.UseVisualStyleBackColor = false;
            this.btnAuditDBScript.Click += new System.EventHandler(this.BtnAuditDBScript_Click);
            // 
            // btnSpwinDBScript
            // 
            this.btnSpwinDBScript.BackColor = System.Drawing.Color.GreenYellow;
            this.btnSpwinDBScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnSpwinDBScript.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSpwinDBScript.Location = new System.Drawing.Point(328, 99);
            this.btnSpwinDBScript.Name = "btnSpwinDBScript";
            this.btnSpwinDBScript.Size = new System.Drawing.Size(189, 122);
            this.btnSpwinDBScript.TabIndex = 1;
            this.btnSpwinDBScript.Text = "Spwin Script çalıştır";
            this.btnSpwinDBScript.UseVisualStyleBackColor = false;
            this.btnSpwinDBScript.Click += new System.EventHandler(this.btnSpwinDBScript_Click);
            // 
            // tpServerConManager
            // 
            this.tpServerConManager.Controls.Add(this.tableLayoutPanel4);
            this.tpServerConManager.Location = new System.Drawing.Point(4, 82);
            this.tpServerConManager.Name = "tpServerConManager";
            this.tpServerConManager.Padding = new System.Windows.Forms.Padding(3);
            this.tpServerConManager.Size = new System.Drawing.Size(657, 327);
            this.tpServerConManager.TabIndex = 16;
            this.tpServerConManager.Text = "Server Configuration Manager";
            this.tpServerConManager.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 3;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.Controls.Add(this.btnServerConManager, 1, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel20, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(651, 321);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // btnServerConManager
            // 
            this.btnServerConManager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnServerConManager.Location = new System.Drawing.Point(198, 99);
            this.btnServerConManager.Name = "btnServerConManager";
            this.btnServerConManager.Size = new System.Drawing.Size(254, 122);
            this.btnServerConManager.TabIndex = 0;
            this.btnServerConManager.Text = "Server Configuration Manager Ayarlarını Yap";
            this.btnServerConManager.UseVisualStyleBackColor = true;
            this.btnServerConManager.Click += new System.EventHandler(this.btnServerConManager_Click);
            // 
            // tableLayoutPanel20
            // 
            this.tableLayoutPanel20.ColumnCount = 1;
            this.tableLayoutPanel20.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel20.Controls.Add(this.label12, 0, 0);
            this.tableLayoutPanel20.Controls.Add(this.tbConfigServerName, 0, 1);
            this.tableLayoutPanel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel20.Location = new System.Drawing.Point(198, 3);
            this.tableLayoutPanel20.Name = "tableLayoutPanel20";
            this.tableLayoutPanel20.RowCount = 2;
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel20.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel20.Size = new System.Drawing.Size(254, 90);
            this.tableLayoutPanel20.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(248, 45);
            this.label12.TabIndex = 0;
            this.label12.Text = "Server İsmi";
            this.label12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // tbConfigServerName
            // 
            this.tbConfigServerName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.tbConfigServerName.Location = new System.Drawing.Point(3, 56);
            this.tbConfigServerName.Name = "tbConfigServerName";
            this.tbConfigServerName.Size = new System.Drawing.Size(248, 22);
            this.tbConfigServerName.TabIndex = 1;
            // 
            // gbConnectionSettings
            // 
            this.gbConnectionSettings.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.gbConnectionSettings.Controls.Add(this.label5);
            this.gbConnectionSettings.Controls.Add(this.cbxUsername);
            this.gbConnectionSettings.Controls.Add(this.cbxDbName);
            this.gbConnectionSettings.Controls.Add(this.lblServer);
            this.gbConnectionSettings.Controls.Add(this.CbWindowsAuthentication);
            this.gbConnectionSettings.Controls.Add(this.lblPassword);
            this.gbConnectionSettings.Controls.Add(this.lblUser);
            this.gbConnectionSettings.Controls.Add(this.CBServers);
            this.gbConnectionSettings.Controls.Add(this.txtPassword);
            this.gbConnectionSettings.Location = new System.Drawing.Point(150, 3);
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
            this.cbxDbName.Text = "SPWIN_DB";
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
            this.CBServers.Text = ".\\SQLEXPRESS";
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
            this.btnConnectionTest.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnConnectionTest.BackColor = System.Drawing.Color.GreenYellow;
            this.btnConnectionTest.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnConnectionTest.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConnectionTest.Location = new System.Drawing.Point(237, 183);
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
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.panel3.Controls.Add(this.gbConnectionSettings);
            this.panel3.Controls.Add(this.btnConnectionTest);
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.MinimumSize = new System.Drawing.Size(665, 214);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(665, 233);
            this.panel3.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.panel3, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabControlProcessHeaders, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 250F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(665, 666);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(665, 690);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(681, 729);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ESİT SPWin Teknik Servis Programı";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlProcessHeaders.ResumeLayout(false);
            this.tpBackup.ResumeLayout(false);
            this.tableLayoutPanel18.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.tableLayoutPanel19.ResumeLayout(false);
            this.tableLayoutPanel19.PerformLayout();
            this.tpRestore.ResumeLayout(false);
            this.tableLayoutPanel16.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.tableLayoutPanel17.ResumeLayout(false);
            this.tableLayoutPanel17.PerformLayout();
            this.tpSQLFile.ResumeLayout(false);
            this.tableLayoutPanel14.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tableLayoutPanel15.ResumeLayout(false);
            this.tableLayoutPanel15.PerformLayout();
            this.tpSPWinDatabasePhotoDelete.ResumeLayout(false);
            this.tableLayoutPanel9.ResumeLayout(false);
            this.tableLayoutPanel9.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.tableLayoutPanel11.ResumeLayout(false);
            this.tableLayoutPanel11.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.tableLayoutPanel10.ResumeLayout(false);
            this.tableLayoutPanel10.PerformLayout();
            this.tpDatabaseRepair.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tpSPWinScaleAndDBAConsolidation.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            this.tpTablolar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGV1)).EndInit();
            this.tpQuary.ResumeLayout(false);
            this.tpQuary.PerformLayout();
            this.tpSorgu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.tpEsitUserEkle.ResumeLayout(false);
            this.tableLayoutPanel7.ResumeLayout(false);
            this.tableLayoutPanel7.PerformLayout();
            this.tpCamPhotoLink.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tpEsitScaleSil.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tpTartımSilme.ResumeLayout(false);
            this.tableLayoutPanel6.ResumeLayout(false);
            this.tableLayoutPanel6.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.tableLayoutPanel13.ResumeLayout(false);
            this.tableLayoutPanel13.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tableLayoutPanel12.ResumeLayout(false);
            this.tableLayoutPanel12.PerformLayout();
            this.tpDatabaseStop.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tpServerConManager.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel20.ResumeLayout(false);
            this.tableLayoutPanel20.PerformLayout();
            this.gbConnectionSettings.ResumeLayout(false);
            this.gbConnectionSettings.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlProcessHeaders;
        private System.Windows.Forms.TabPage tpBackup;
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
        private System.Windows.Forms.TabPage tpSorgu;
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
        private System.Windows.Forms.TabPage tpEsitUserEkle;
        private System.Windows.Forms.Button btnKullanıcıEkle;
        private System.Windows.Forms.TabPage tpEsitScaleSil;
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
        private System.Windows.Forms.DateTimePicker dtpTartimDateEnd;
        private System.Windows.Forms.RadioButton rbTartimAllDelete;
        private System.Windows.Forms.RadioButton rbTartimPeriodDelete;
        private System.Windows.Forms.DateTimePicker dtpTartimDateStart;
        private System.Windows.Forms.RadioButton rbTartim2;
        private System.Windows.Forms.RadioButton rbTartim1;
        private System.Windows.Forms.Button btnTartimSilme;
        private System.Windows.Forms.Label lbUserAddUserPassword;
        private System.Windows.Forms.Label lbUserAddUserName;
        private System.Windows.Forms.ComboBox cbUserAddUserRole;
        private System.Windows.Forms.Label lbUserAddUserRole;
        private System.Windows.Forms.TextBox tbUserAddUserPassword;
        private System.Windows.Forms.TextBox tbUserAddUserName;
        private System.Windows.Forms.DateTimePicker dtpTartimSaatEnd;
        private System.Windows.Forms.DateTimePicker dtpTartimSaatStart;
        private System.Windows.Forms.TabPage tpDatabaseStop;
        private System.Windows.Forms.Button btnSpwinDBScript;
        private System.Windows.Forms.Button btnAuditDBScript;
        private System.Windows.Forms.Button btnKullanıcıSil;
        private System.Windows.Forms.TabPage tpServerConManager;
        private System.Windows.Forms.Button btnServerConManager;
        private System.Windows.Forms.TextBox tbUserAddUserPasswordConfirm;
        private System.Windows.Forms.Label lbUserAddUserPasswordConfirm;
        private System.Windows.Forms.Button btnEsitUserSilHelp;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel9;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Label lblDateStart;
        private System.Windows.Forms.Label lblDateFinish;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel10;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel11;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel13;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel12;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel14;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel15;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel16;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel17;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel18;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel19;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel20;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox tbConfigServerName;
    }
}

