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
			this.groupBox5 = new System.Windows.Forms.GroupBox();
			this.rbAllPhoto = new System.Windows.Forms.RadioButton();
			this.rbInTheFolderPhoto = new System.Windows.Forms.RadioButton();
			this.rbOneAndTwoPhoto = new System.Windows.Forms.RadioButton();
			this.rbJustOnePhoto = new System.Windows.Forms.RadioButton();
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
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.lbxResultInfo = new System.Windows.Forms.ListBox();
			this.btnMoveDbaToScale = new System.Windows.Forms.Button();
			this.groupBox4 = new System.Windows.Forms.GroupBox();
			this.label5 = new System.Windows.Forms.Label();
			this.btnFindDbUsers = new System.Windows.Forms.Button();
			this.cbxUsername = new System.Windows.Forms.ComboBox();
			this.btnDatabaseList = new System.Windows.Forms.Button();
			this.cbxDbName = new System.Windows.Forms.ComboBox();
			this.btnSQLServerList = new System.Windows.Forms.Button();
			this.lblServer = new System.Windows.Forms.Label();
			this.CbWindowsAuthentication = new System.Windows.Forms.CheckBox();
			this.btnConnectionTest = new System.Windows.Forms.Button();
			this.lblPassword = new System.Windows.Forms.Label();
			this.lblUser = new System.Windows.Forms.Label();
			this.CBServers = new System.Windows.Forms.ComboBox();
			this.txtPassword = new System.Windows.Forms.TextBox();
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
			this.groupBox4.SuspendLayout();
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
			this.tabControlProcessHeaders.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.tabControlProcessHeaders.Location = new System.Drawing.Point(3, 262);
			this.tabControlProcessHeaders.Name = "tabControlProcessHeaders";
			this.tabControlProcessHeaders.SelectedIndex = 0;
			this.tabControlProcessHeaders.Size = new System.Drawing.Size(746, 350);
			this.tabControlProcessHeaders.TabIndex = 0;
			// 
			// tpBackup
			// 
			this.tpBackup.BackColor = System.Drawing.SystemColors.Control;
			this.tpBackup.Controls.Add(this.grpBoxPatch);
			this.tpBackup.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.tpBackup.Location = new System.Drawing.Point(4, 23);
			this.tpBackup.Name = "tpBackup";
			this.tpBackup.Padding = new System.Windows.Forms.Padding(3);
			this.tpBackup.Size = new System.Drawing.Size(738, 323);
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
			this.grpBoxPatch.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.grpBoxPatch.Location = new System.Drawing.Point(105, 97);
			this.grpBoxPatch.Name = "grpBoxPatch";
			this.grpBoxPatch.Size = new System.Drawing.Size(432, 130);
			this.grpBoxPatch.TabIndex = 5;
			this.grpBoxPatch.TabStop = false;
			this.grpBoxPatch.Text = "Veritabanı Yedekleme";
			// 
			// cbxDbNameBackup
			// 
			this.cbxDbNameBackup.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cbxDbNameBackup.FormattingEnabled = true;
			this.cbxDbNameBackup.Location = new System.Drawing.Point(160, 28);
			this.cbxDbNameBackup.Name = "cbxDbNameBackup";
			this.cbxDbNameBackup.Size = new System.Drawing.Size(264, 22);
			this.cbxDbNameBackup.TabIndex = 8;
			this.cbxDbNameBackup.Text = "SPWIN_DB";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(66, 31);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(89, 14);
			this.label2.TabIndex = 6;
			this.label2.Text = "Veritabanı Adı :";
			// 
			// btnBackup
			// 
			this.btnBackup.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnBackup.Location = new System.Drawing.Point(160, 82);
			this.btnBackup.Name = "btnBackup";
			this.btnBackup.Size = new System.Drawing.Size(264, 31);
			this.btnBackup.TabIndex = 4;
			this.btnBackup.Text = "Yedekle";
			this.btnBackup.UseVisualStyleBackColor = true;
			this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
			// 
			// btnBackupFileLocationSelect
			// 
			this.btnBackupFileLocationSelect.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnBackupFileLocationSelect.Location = new System.Drawing.Point(360, 54);
			this.btnBackupFileLocationSelect.Name = "btnBackupFileLocationSelect";
			this.btnBackupFileLocationSelect.Size = new System.Drawing.Size(64, 22);
			this.btnBackupFileLocationSelect.TabIndex = 3;
			this.btnBackupFileLocationSelect.Text = "- - -";
			this.btnBackupFileLocationSelect.UseVisualStyleBackColor = true;
			this.btnBackupFileLocationSelect.Click += new System.EventHandler(this.btnBackupFileLocationSelect_Click);
			// 
			// txtBackupPath
			// 
			this.txtBackupPath.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtBackupPath.Location = new System.Drawing.Point(160, 55);
			this.txtBackupPath.Name = "txtBackupPath";
			this.txtBackupPath.Size = new System.Drawing.Size(194, 20);
			this.txtBackupPath.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(9, 58);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(153, 14);
			this.label1.TabIndex = 0;
			this.label1.Text = "Veritabanı Dosya Konumu :";
			// 
			// tpRestore
			// 
			this.tpRestore.BackColor = System.Drawing.SystemColors.Control;
			this.tpRestore.Controls.Add(this.groupBox1);
			this.tpRestore.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.tpRestore.Location = new System.Drawing.Point(4, 23);
			this.tpRestore.Name = "tpRestore";
			this.tpRestore.Padding = new System.Windows.Forms.Padding(3);
			this.tpRestore.Size = new System.Drawing.Size(738, 323);
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
			this.groupBox1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox1.Location = new System.Drawing.Point(105, 97);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(432, 130);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Veritabanı Geri Yükleme";
			// 
			// cbxDbNameRestore
			// 
			this.cbxDbNameRestore.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cbxDbNameRestore.FormattingEnabled = true;
			this.cbxDbNameRestore.Location = new System.Drawing.Point(160, 28);
			this.cbxDbNameRestore.Name = "cbxDbNameRestore";
			this.cbxDbNameRestore.Size = new System.Drawing.Size(264, 22);
			this.cbxDbNameRestore.TabIndex = 9;
			this.cbxDbNameRestore.Text = "SPWIN_DB";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(66, 31);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 14);
			this.label3.TabIndex = 6;
			this.label3.Text = "Veritabanı Adı :";
			// 
			// btnRestore
			// 
			this.btnRestore.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnRestore.Location = new System.Drawing.Point(160, 82);
			this.btnRestore.Name = "btnRestore";
			this.btnRestore.Size = new System.Drawing.Size(264, 31);
			this.btnRestore.TabIndex = 4;
			this.btnRestore.Text = "Veritabanını Geri Yükle";
			this.btnRestore.UseVisualStyleBackColor = true;
			this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
			// 
			// btnRestoreFile
			// 
			this.btnRestoreFile.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnRestoreFile.Location = new System.Drawing.Point(360, 54);
			this.btnRestoreFile.Name = "btnRestoreFile";
			this.btnRestoreFile.Size = new System.Drawing.Size(64, 22);
			this.btnRestoreFile.TabIndex = 3;
			this.btnRestoreFile.Text = "- - -";
			this.btnRestoreFile.UseVisualStyleBackColor = true;
			this.btnRestoreFile.Click += new System.EventHandler(this.btnRestoreFile_Click);
			// 
			// txtRestorePath
			// 
			this.txtRestorePath.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtRestorePath.Location = new System.Drawing.Point(160, 55);
			this.txtRestorePath.Name = "txtRestorePath";
			this.txtRestorePath.Size = new System.Drawing.Size(194, 20);
			this.txtRestorePath.TabIndex = 2;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label4.Location = new System.Drawing.Point(44, 58);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(114, 14);
			this.label4.TabIndex = 0;
			this.label4.Text = "Veritabanı Dosyası :";
			// 
			// tpSQLFile
			// 
			this.tpSQLFile.BackColor = System.Drawing.SystemColors.Control;
			this.tpSQLFile.Controls.Add(this.groupBox2);
			this.tpSQLFile.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.tpSQLFile.ForeColor = System.Drawing.SystemColors.ControlText;
			this.tpSQLFile.Location = new System.Drawing.Point(4, 23);
			this.tpSQLFile.Name = "tpSQLFile";
			this.tpSQLFile.Padding = new System.Windows.Forms.Padding(3);
			this.tpSQLFile.Size = new System.Drawing.Size(738, 323);
			this.tpSQLFile.TabIndex = 2;
			this.tpSQLFile.Text = "SQL Dosyası Çalıştırma";
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.btnSQLRun);
			this.groupBox2.Controls.Add(this.btnSQLFileSelect);
			this.groupBox2.Controls.Add(this.txtSQLFile);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox2.Location = new System.Drawing.Point(105, 97);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(432, 130);
			this.groupBox2.TabIndex = 7;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "SQL Dosyası Çalıştırma";
			// 
			// btnSQLRun
			// 
			this.btnSQLRun.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSQLRun.Location = new System.Drawing.Point(160, 66);
			this.btnSQLRun.Name = "btnSQLRun";
			this.btnSQLRun.Size = new System.Drawing.Size(264, 31);
			this.btnSQLRun.TabIndex = 4;
			this.btnSQLRun.Text = "SQL Dosyasını Çalıştır";
			this.btnSQLRun.UseVisualStyleBackColor = true;
			this.btnSQLRun.Click += new System.EventHandler(this.btnSQLRun_Click);
			// 
			// btnSQLFileSelect
			// 
			this.btnSQLFileSelect.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSQLFileSelect.Location = new System.Drawing.Point(360, 38);
			this.btnSQLFileSelect.Name = "btnSQLFileSelect";
			this.btnSQLFileSelect.Size = new System.Drawing.Size(64, 22);
			this.btnSQLFileSelect.TabIndex = 3;
			this.btnSQLFileSelect.Text = "- - -";
			this.btnSQLFileSelect.UseVisualStyleBackColor = true;
			this.btnSQLFileSelect.Click += new System.EventHandler(this.btnSQLFileSelect_Click);
			// 
			// txtSQLFile
			// 
			this.txtSQLFile.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtSQLFile.Location = new System.Drawing.Point(160, 39);
			this.txtSQLFile.Name = "txtSQLFile";
			this.txtSQLFile.Size = new System.Drawing.Size(194, 20);
			this.txtSQLFile.TabIndex = 2;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(70, 42);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(81, 14);
			this.label6.TabIndex = 0;
			this.label6.Text = "SQL Dosyası :";
			// 
			// tpSPWinDatabasePhotoDelete
			// 
			this.tpSPWinDatabasePhotoDelete.BackColor = System.Drawing.SystemColors.Control;
			this.tpSPWinDatabasePhotoDelete.Controls.Add(this.groupBox5);
			this.tpSPWinDatabasePhotoDelete.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.tpSPWinDatabasePhotoDelete.Location = new System.Drawing.Point(4, 23);
			this.tpSPWinDatabasePhotoDelete.Name = "tpSPWinDatabasePhotoDelete";
			this.tpSPWinDatabasePhotoDelete.Padding = new System.Windows.Forms.Padding(3);
			this.tpSPWinDatabasePhotoDelete.Size = new System.Drawing.Size(738, 323);
			this.tpSPWinDatabasePhotoDelete.TabIndex = 3;
			this.tpSPWinDatabasePhotoDelete.Text = "Veritabanından Fotoğraf Silme";
			// 
			// groupBox5
			// 
			this.groupBox5.Controls.Add(this.rbAllPhoto);
			this.groupBox5.Controls.Add(this.rbInTheFolderPhoto);
			this.groupBox5.Controls.Add(this.rbOneAndTwoPhoto);
			this.groupBox5.Controls.Add(this.rbJustOnePhoto);
			this.groupBox5.Controls.Add(this.btnWeighPhotoDelete);
			this.groupBox5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox5.Location = new System.Drawing.Point(147, 72);
			this.groupBox5.Name = "groupBox5";
			this.groupBox5.Size = new System.Drawing.Size(371, 152);
			this.groupBox5.TabIndex = 9;
			this.groupBox5.TabStop = false;
			this.groupBox5.Text = "Tartım Fotoğraflarını Silme";
			// 
			// rbAllPhoto
			// 
			this.rbAllPhoto.AutoSize = true;
			this.rbAllPhoto.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.rbAllPhoto.Location = new System.Drawing.Point(37, 102);
			this.rbAllPhoto.Name = "rbAllPhoto";
			this.rbAllPhoto.Size = new System.Drawing.Size(56, 18);
			this.rbAllPhoto.TabIndex = 10;
			this.rbAllPhoto.TabStop = true;
			this.rbAllPhoto.Text = "Hepsi";
			this.rbAllPhoto.UseVisualStyleBackColor = true;
			// 
			// rbInTheFolderPhoto
			// 
			this.rbInTheFolderPhoto.AutoSize = true;
			this.rbInTheFolderPhoto.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.rbInTheFolderPhoto.Location = new System.Drawing.Point(37, 79);
			this.rbInTheFolderPhoto.Name = "rbInTheFolderPhoto";
			this.rbInTheFolderPhoto.Size = new System.Drawing.Size(333, 18);
			this.rbInTheFolderPhoto.TabIndex = 9;
			this.rbInTheFolderPhoto.TabStop = true;
			this.rbInTheFolderPhoto.Text = "Klasöre Kaydedilen Fotoğrafların Veritabanı Kayıtlarını Sil";
			this.rbInTheFolderPhoto.UseVisualStyleBackColor = true;
			// 
			// rbOneAndTwoPhoto
			// 
			this.rbOneAndTwoPhoto.AutoSize = true;
			this.rbOneAndTwoPhoto.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.rbOneAndTwoPhoto.Location = new System.Drawing.Point(37, 57);
			this.rbOneAndTwoPhoto.Name = "rbOneAndTwoPhoto";
			this.rbOneAndTwoPhoto.Size = new System.Drawing.Size(97, 18);
			this.rbOneAndTwoPhoto.TabIndex = 8;
			this.rbOneAndTwoPhoto.TabStop = true;
			this.rbOneAndTwoPhoto.Text = "1. ve 2.Tartım";
			this.rbOneAndTwoPhoto.UseVisualStyleBackColor = true;
			// 
			// rbJustOnePhoto
			// 
			this.rbJustOnePhoto.AutoSize = true;
			this.rbJustOnePhoto.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.rbJustOnePhoto.Location = new System.Drawing.Point(37, 31);
			this.rbJustOnePhoto.Name = "rbJustOnePhoto";
			this.rbJustOnePhoto.Size = new System.Drawing.Size(103, 18);
			this.rbJustOnePhoto.TabIndex = 7;
			this.rbJustOnePhoto.TabStop = true;
			this.rbJustOnePhoto.Text = "Yalnız 1.Tartım";
			this.rbJustOnePhoto.UseVisualStyleBackColor = true;
			// 
			// btnWeighPhotoDelete
			// 
			this.btnWeighPhotoDelete.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnWeighPhotoDelete.Location = new System.Drawing.Point(128, 115);
			this.btnWeighPhotoDelete.Name = "btnWeighPhotoDelete";
			this.btnWeighPhotoDelete.Size = new System.Drawing.Size(194, 31);
			this.btnWeighPhotoDelete.TabIndex = 4;
			this.btnWeighPhotoDelete.Text = "Tartım Fotoğraflarını Sil";
			this.btnWeighPhotoDelete.UseVisualStyleBackColor = true;
			this.btnWeighPhotoDelete.Click += new System.EventHandler(this.btnWeighPhotoDelete_Click);
			// 
			// tpDatabaseRepair
			// 
			this.tpDatabaseRepair.BackColor = System.Drawing.SystemColors.Control;
			this.tpDatabaseRepair.Controls.Add(this.groupBox6);
			this.tpDatabaseRepair.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.tpDatabaseRepair.Location = new System.Drawing.Point(4, 23);
			this.tpDatabaseRepair.Name = "tpDatabaseRepair";
			this.tpDatabaseRepair.Padding = new System.Windows.Forms.Padding(3);
			this.tpDatabaseRepair.Size = new System.Drawing.Size(738, 323);
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
			this.groupBox6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
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
			this.cbxDbNameRepair.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cbxDbNameRepair.FormattingEnabled = true;
			this.cbxDbNameRepair.Location = new System.Drawing.Point(128, 28);
			this.cbxDbNameRepair.Name = "cbxDbNameRepair";
			this.cbxDbNameRepair.Size = new System.Drawing.Size(194, 22);
			this.cbxDbNameRepair.TabIndex = 10;
			this.cbxDbNameRepair.Text = "SPWIN_DB";
			// 
			// textBox4
			// 
			this.textBox4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.textBox4.Location = new System.Drawing.Point(128, 81);
			this.textBox4.Name = "textBox4";
			this.textBox4.ReadOnly = true;
			this.textBox4.Size = new System.Drawing.Size(194, 20);
			this.textBox4.TabIndex = 8;
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label9.Location = new System.Drawing.Point(72, 84);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(44, 14);
			this.label9.TabIndex = 7;
			this.label9.Text = "Boyut :";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label10.Location = new System.Drawing.Point(34, 31);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(89, 14);
			this.label10.TabIndex = 6;
			this.label10.Text = "Veritabanı Adı :";
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button2.Location = new System.Drawing.Point(128, 107);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(194, 31);
			this.button2.TabIndex = 4;
			this.button2.Text = "Dosya Boyutunu Küçült";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox6
			// 
			this.textBox6.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.textBox6.Location = new System.Drawing.Point(128, 55);
			this.textBox6.Name = "textBox6";
			this.textBox6.ReadOnly = true;
			this.textBox6.Size = new System.Drawing.Size(194, 20);
			this.textBox6.TabIndex = 2;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label11.Location = new System.Drawing.Point(69, 58);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(48, 14);
			this.label11.TabIndex = 0;
			this.label11.Text = "Status :";
			// 
			// tpSPWinScaleAndDBAConsolidation
			// 
			this.tpSPWinScaleAndDBAConsolidation.BackColor = System.Drawing.SystemColors.Control;
			this.tpSPWinScaleAndDBAConsolidation.Controls.Add(this.progressBar1);
			this.tpSPWinScaleAndDBAConsolidation.Controls.Add(this.lbxResultInfo);
			this.tpSPWinScaleAndDBAConsolidation.Controls.Add(this.btnMoveDbaToScale);
			this.tpSPWinScaleAndDBAConsolidation.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.tpSPWinScaleAndDBAConsolidation.Location = new System.Drawing.Point(4, 23);
			this.tpSPWinScaleAndDBAConsolidation.Name = "tpSPWinScaleAndDBAConsolidation";
			this.tpSPWinScaleAndDBAConsolidation.Padding = new System.Windows.Forms.Padding(3);
			this.tpSPWinScaleAndDBAConsolidation.Size = new System.Drawing.Size(738, 323);
			this.tpSPWinScaleAndDBAConsolidation.TabIndex = 6;
			this.tpSPWinScaleAndDBAConsolidation.Text = "SPWin Scale ve DBA Birleştirme";
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(77, 88);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(593, 48);
			this.progressBar1.TabIndex = 2;
			// 
			// lbxResultInfo
			// 
			this.lbxResultInfo.FormattingEnabled = true;
			this.lbxResultInfo.ItemHeight = 14;
			this.lbxResultInfo.Location = new System.Drawing.Point(77, 159);
			this.lbxResultInfo.Name = "lbxResultInfo";
			this.lbxResultInfo.Size = new System.Drawing.Size(593, 144);
			this.lbxResultInfo.TabIndex = 1;
			// 
			// btnMoveDbaToScale
			// 
			this.btnMoveDbaToScale.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnMoveDbaToScale.Location = new System.Drawing.Point(77, 34);
			this.btnMoveDbaToScale.Name = "btnMoveDbaToScale";
			this.btnMoveDbaToScale.Size = new System.Drawing.Size(593, 48);
			this.btnMoveDbaToScale.TabIndex = 0;
			this.btnMoveDbaToScale.Text = "Eski Versiyondaki DBA Verilerini Yeni Versiyona Taşı";
			this.btnMoveDbaToScale.UseVisualStyleBackColor = true;
			this.btnMoveDbaToScale.Click += new System.EventHandler(this.btnMoveDbaToScale_Click);
			// 
			// groupBox4
			// 
			this.groupBox4.Controls.Add(this.label5);
			this.groupBox4.Controls.Add(this.btnFindDbUsers);
			this.groupBox4.Controls.Add(this.cbxUsername);
			this.groupBox4.Controls.Add(this.btnDatabaseList);
			this.groupBox4.Controls.Add(this.cbxDbName);
			this.groupBox4.Controls.Add(this.btnSQLServerList);
			this.groupBox4.Controls.Add(this.lblServer);
			this.groupBox4.Controls.Add(this.CbWindowsAuthentication);
			this.groupBox4.Controls.Add(this.btnConnectionTest);
			this.groupBox4.Controls.Add(this.lblPassword);
			this.groupBox4.Controls.Add(this.lblUser);
			this.groupBox4.Controls.Add(this.CBServers);
			this.groupBox4.Controls.Add(this.txtPassword);
			this.groupBox4.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.groupBox4.Location = new System.Drawing.Point(176, 26);
			this.groupBox4.Name = "groupBox4";
			this.groupBox4.Size = new System.Drawing.Size(444, 216);
			this.groupBox4.TabIndex = 4;
			this.groupBox4.TabStop = false;
			this.groupBox4.Text = "SQL Server Bağlantı Ayarları";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label5.Location = new System.Drawing.Point(3, 84);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(89, 14);
			this.label5.TabIndex = 11;
			this.label5.Text = "Veritabanı Adı :";
			// 
			// btnFindDbUsers
			// 
			this.btnFindDbUsers.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnFindDbUsers.Location = new System.Drawing.Point(305, 107);
			this.btnFindDbUsers.Name = "btnFindDbUsers";
			this.btnFindDbUsers.Size = new System.Drawing.Size(124, 21);
			this.btnFindDbUsers.TabIndex = 10;
			this.btnFindDbUsers.Text = "Kullanıcıları Listele";
			this.btnFindDbUsers.UseVisualStyleBackColor = true;
			this.btnFindDbUsers.Click += new System.EventHandler(this.btnFindDbUsers_Click);
			// 
			// cbxUsername
			// 
			this.cbxUsername.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cbxUsername.FormattingEnabled = true;
			this.cbxUsername.Location = new System.Drawing.Point(92, 106);
			this.cbxUsername.Name = "cbxUsername";
			this.cbxUsername.Size = new System.Drawing.Size(212, 22);
			this.cbxUsername.TabIndex = 8;
			this.cbxUsername.Text = "esit_user";
			// 
			// btnDatabaseList
			// 
			this.btnDatabaseList.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnDatabaseList.Location = new System.Drawing.Point(305, 80);
			this.btnDatabaseList.Name = "btnDatabaseList";
			this.btnDatabaseList.Size = new System.Drawing.Size(124, 21);
			this.btnDatabaseList.TabIndex = 8;
			this.btnDatabaseList.Text = "Veritabanı Listele";
			this.btnDatabaseList.UseVisualStyleBackColor = true;
			this.btnDatabaseList.Click += new System.EventHandler(this.btnDatabaseList_Click);
			// 
			// cbxDbName
			// 
			this.cbxDbName.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.cbxDbName.FormattingEnabled = true;
			this.cbxDbName.Location = new System.Drawing.Point(92, 80);
			this.cbxDbName.Name = "cbxDbName";
			this.cbxDbName.Size = new System.Drawing.Size(212, 22);
			this.cbxDbName.TabIndex = 7;
			this.cbxDbName.Text = "SPWIN_DB";
			// 
			// btnSQLServerList
			// 
			this.btnSQLServerList.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSQLServerList.Location = new System.Drawing.Point(307, 30);
			this.btnSQLServerList.Name = "btnSQLServerList";
			this.btnSQLServerList.Size = new System.Drawing.Size(122, 21);
			this.btnSQLServerList.TabIndex = 6;
			this.btnSQLServerList.Text = "SQL Server Listele";
			this.btnSQLServerList.UseVisualStyleBackColor = true;
			this.btnSQLServerList.Click += new System.EventHandler(this.btnSQLServerList_Click);
			// 
			// lblServer
			// 
			this.lblServer.AutoSize = true;
			this.lblServer.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblServer.Location = new System.Drawing.Point(37, 33);
			this.lblServer.Name = "lblServer";
			this.lblServer.Size = new System.Drawing.Size(50, 14);
			this.lblServer.TabIndex = 5;
			this.lblServer.Text = "Server :";
			// 
			// CbWindowsAuthentication
			// 
			this.CbWindowsAuthentication.AutoSize = true;
			this.CbWindowsAuthentication.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.CbWindowsAuthentication.Location = new System.Drawing.Point(92, 57);
			this.CbWindowsAuthentication.Name = "CbWindowsAuthentication";
			this.CbWindowsAuthentication.Size = new System.Drawing.Size(160, 18);
			this.CbWindowsAuthentication.TabIndex = 4;
			this.CbWindowsAuthentication.Text = "Windows Authentication";
			this.CbWindowsAuthentication.UseVisualStyleBackColor = true;
			this.CbWindowsAuthentication.CheckedChanged += new System.EventHandler(this.CbWindowsAuthentication_CheckedChanged);
			// 
			// btnConnectionTest
			// 
			this.btnConnectionTest.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnConnectionTest.Location = new System.Drawing.Point(92, 158);
			this.btnConnectionTest.Name = "btnConnectionTest";
			this.btnConnectionTest.Size = new System.Drawing.Size(214, 30);
			this.btnConnectionTest.TabIndex = 3;
			this.btnConnectionTest.Text = "Bağlantı Testi";
			this.btnConnectionTest.UseVisualStyleBackColor = true;
			this.btnConnectionTest.Click += new System.EventHandler(this.btnConnectionTest_Click);
			// 
			// lblPassword
			// 
			this.lblPassword.AutoSize = true;
			this.lblPassword.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblPassword.Location = new System.Drawing.Point(47, 139);
			this.lblPassword.Name = "lblPassword";
			this.lblPassword.Size = new System.Drawing.Size(39, 14);
			this.lblPassword.TabIndex = 2;
			this.lblPassword.Text = "Şifre :";
			// 
			// lblUser
			// 
			this.lblUser.AutoSize = true;
			this.lblUser.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.lblUser.Location = new System.Drawing.Point(11, 110);
			this.lblUser.Name = "lblUser";
			this.lblUser.Size = new System.Drawing.Size(79, 14);
			this.lblUser.TabIndex = 1;
			this.lblUser.Text = "Kullanıcı Adı :";
			// 
			// CBServers
			// 
			this.CBServers.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.CBServers.FormattingEnabled = true;
			this.CBServers.Location = new System.Drawing.Point(92, 30);
			this.CBServers.Name = "CBServers";
			this.CBServers.Size = new System.Drawing.Size(214, 22);
			this.CBServers.TabIndex = 0;
			this.CBServers.Text = ".\\SQLEXPRESS";
			// 
			// txtPassword
			// 
			this.txtPassword.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtPassword.Location = new System.Drawing.Point(92, 132);
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			this.txtPassword.Size = new System.Drawing.Size(212, 20);
			this.txtPassword.TabIndex = 1;
			this.txtPassword.Text = "esit12345";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(756, 611);
			this.Controls.Add(this.groupBox4);
			this.Controls.Add(this.tabControlProcessHeaders);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
			this.groupBox5.ResumeLayout(false);
			this.groupBox5.PerformLayout();
			this.tpDatabaseRepair.ResumeLayout(false);
			this.groupBox6.ResumeLayout(false);
			this.groupBox6.PerformLayout();
			this.tpSPWinScaleAndDBAConsolidation.ResumeLayout(false);
			this.groupBox4.ResumeLayout(false);
			this.groupBox4.PerformLayout();
			this.ResumeLayout(false);

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
        private System.Windows.Forms.GroupBox groupBox4;
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
        private System.Windows.Forms.Button btnSQLServerList;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnWeighPhotoDelete;
        private System.Windows.Forms.RadioButton rbAllPhoto;
        private System.Windows.Forms.RadioButton rbInTheFolderPhoto;
        private System.Windows.Forms.RadioButton rbOneAndTwoPhoto;
        private System.Windows.Forms.RadioButton rbJustOnePhoto;
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
        private System.Windows.Forms.Button btnDatabaseList;
        private System.Windows.Forms.ComboBox cbxDbNameBackup;
        private System.Windows.Forms.ComboBox cbxDbNameRestore;
        private System.Windows.Forms.ComboBox cbxDbNameRepair;
        private System.Windows.Forms.ComboBox cbxUsername;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFindDbUsers;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ListBox lbxResultInfo;
    }
}

