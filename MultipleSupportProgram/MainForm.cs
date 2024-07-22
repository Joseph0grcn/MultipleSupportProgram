using log4net.Repository.Hierarchy;
using MultipleSupportProgram.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;
using RadioButton = System.Windows.Forms.RadioButton;


namespace MultipleSupportProgram
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false; //kanalları açar çapraz iş parçacığını kapatır
        }
        public DatabaseProcess databaseProcess = new DatabaseProcess();
        public Restore restoreDb = new Restore();
        public Backup backupDb = new Backup();
        public SQLFileRun sqlFileRun = new SQLFileRun();
        public WeighPhotoDelete weighPhotoDelete = new WeighPhotoDelete();
        public UpdateDbaToScale updateDbaToScale = new UpdateDbaToScale();
        public string conString;
        public Loggers loggers = new Loggers();

        private void btnConnectionTest_Click(object sender, EventArgs e)
        {
            databaseProcess.ConnectionTest(CbWindowsAuthentication.Checked, CBServers.Text, cbxUsername.Text, txtPassword.Text, cbxDbName.Text);
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            restoreDb.RestoreDB(cbxDbNameRestore.Text, txtRestorePath.Text, databaseProcess.GetConString(CbWindowsAuthentication.Checked, CBServers.Text, cbxUsername.Text, txtPassword.Text, "master"));
        }

        private void btnRestoreFile_Click(object sender, EventArgs e)
        {
            txtRestorePath.Text = restoreDb.RestoreFile();
        }

        private void CbWindowsAuthentication_CheckedChanged(object sender, EventArgs e)
        {
            if (CbWindowsAuthentication.Checked)
            {
                txtPassword.Enabled = false; cbxUsername.Enabled = false; lblPassword.Enabled = false; lblUser.Enabled = false;
            }
            else
            {
                txtPassword.Enabled = true; cbxUsername.Enabled = true; lblPassword.Enabled = true; lblUser.Enabled = true;
            }
        }

        private void btnBackupFileLocationSelect_Click(object sender, EventArgs e)
        {
            txtBackupPath.Text = (backupDb.BackupFileLocation() + "\\");
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            backupDb.BackupDB(cbxDbNameBackup.Text, txtBackupPath.Text, conString);
        }

        private void btnSQLFileSelect_Click(object sender, EventArgs e)
        {
            txtSQLFile.Text = sqlFileRun.SQLFileSelect();
        }

        public void MainForm_Load(object sender, EventArgs e)
        {
            conString = databaseProcess.GetConString(CbWindowsAuthentication.Checked, CBServers.Text, cbxUsername.Text, txtPassword.Text, cbxDbName.Text);
            loggers.CreateSpwinlogsFile();
            tabControlProcessHeaders.TabPages.Remove(tpDatabaseRepair);
        }

        private void btnSQLRun_Click(object sender, EventArgs e)
        {
            sqlFileRun.SQLRun(txtSQLFile.Text, conString);
        }
        private ComboBox[] DatabaseComboboxList(ComboBox cbxDbName, ComboBox cbxDbNameBackup, ComboBox cbxDbNameRepair, ComboBox cbxDbNameRestore) 
        {
            ComboBox[] comboBoxDatabase = { cbxDbName, cbxDbNameBackup, cbxDbNameRepair, cbxDbNameRestore };
            return comboBoxDatabase;
        }
        private void btnSQLServerList_Click(object sender, EventArgs e)
        {
            btnSQLServerList.Enabled = false;
            if (CBServers.Items.Count == 0){ databaseProcess.GetSQLServerList(CBServers); }
            btnSQLServerList.Enabled = true;
        }
        private void btnDatabaseList_Click(object sender, EventArgs e)
        {
            btnDatabaseList.Enabled = false;
            if (cbxDbName.Items.Count == 0) { databaseProcess.GetSQLDatabaseList(conString, DatabaseComboboxList(cbxDbName, cbxDbNameBackup, cbxDbNameRepair, cbxDbNameRestore)); }
            btnDatabaseList.Enabled = true;
        }
        private void btnWeighPhotoDelete_Click(object sender, EventArgs e)
        {
            if (rbJustOnePhoto.Checked == true || rbOneAndTwoPhoto.Checked == true || rbInTheFolderPhoto.Checked == true || rbAllPhoto.Checked == true)
            {
                RadioButton radioButton = new RadioButton();

                if (rbJustOnePhoto.Checked == true)
                {
                    radioButton.Name = rbJustOnePhoto.Name;
                }
                else if (rbOneAndTwoPhoto.Checked == true)
                {
                    radioButton.Name = rbOneAndTwoPhoto.Name;
                }
                else if (rbInTheFolderPhoto.Checked == true)
                {
                    radioButton.Name = rbInTheFolderPhoto.Name;
                }
                else if (rbAllPhoto.Checked == true)
                {
                    radioButton.Name = rbAllPhoto.Name;
                }
                weighPhotoDelete.PhotoDelete(conString, radioButton);
            }
            else
            {
                MessageBox.Show("Bu işlemi yapabilmek için tartım fotoğraflarını silme seçeneklerinden birini seçmelisiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        private void btnMoveDbaToScale_Click(object sender, EventArgs e)
        {
            updateDbaToScale.MoveDbaService(conString);
            updateDbaToScale.MoveCarrierCompany(conString);
            //updateDbaToScale.MovePortList(conString);
            btnMoveDbaToScale.Enabled = false;
            updateDbaToScale.SelectDbaDataAndAddDatatable(conString);
            btnMoveDbaToScale.Enabled = true;
        }
        private void btnFindDbUsers_Click(object sender, EventArgs e)
        {
            if (cbxUsername.Items.Count == 0) { databaseProcess.FindDbUsers(cbxUsername, conString); }
        }

		private void button2_Click(object sender, EventArgs e)
		{

		}
	}
}
