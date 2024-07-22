using log4net.Repository.Hierarchy;
using MultipleSupportProgram.Model;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Text;
using System.Threading;
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
        public static WaitScreenFunc waitForm = new WaitScreenFunc();
        


        public static void WaitClose()
        {
            Application.DoEvents();
            waitForm.Close();
        }

        private void BtnConnectionTest_Click(object sender, EventArgs e)
        {
            try
            {
                btnConnectionTest.Enabled = false;
                Application.DoEvents();
                waitForm.Show(this);
                Thread.Sleep(1000);
                databaseProcess.ConnectionTest(CbWindowsAuthentication.Checked, CBServers.Text, cbxUsername.Text, txtPassword.Text, cbxDbName.Text);
                Application.DoEvents();
                btnConnectionTest.Enabled = true;
                Application.DoEvents();
                tabControlProcessHeaders.Enabled = true;
                Application.DoEvents();
            }
            catch (Exception ex)
            {
                waitForm.Close();
                Application.DoEvents();
                MessageBox.Show(ex.Message + "", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnConnectionTest.Enabled = true;
            }
            //Console.WriteLine(CbWindowsAuthentication.Checked);
            //databaseProcess.ConnectionTest(CbWindowsAuthentication., CBServers.Text, cbxUsername.Text, txtPassword.Text, cbxDbName.Text);
        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            
            
            try
            {
                btnRestore.Enabled = false;
                waitForm.Show(this);
                Application.DoEvents();
                restoreDb.RestoreDB(cbxDbNameRestore.Text, txtRestorePath.Text, conString);

                btnRestore.Enabled = true;
            }
            catch (Exception ex)
            {
                waitForm.Close();
                Application.DoEvents();
                MessageBox.Show(ex.Message + "", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRestore.Enabled = true;
            }

        }

        private void BtnRestoreFile_Click(object sender, EventArgs e)
        {
            txtRestorePath.Text = restoreDb.RestoreFile();
        }

        private void CbWindowsAuthentication_CheckedChanged(object sender, EventArgs e)
        {
            if (!CbWindowsAuthentication.Checked)
            {
                txtPassword.Enabled = true; cbxUsername.Enabled = true; lblPassword.Enabled = true; lblUser.Enabled = true;
            }
            else
            {
                txtPassword.Enabled = false; cbxUsername.Enabled = false; lblPassword.Enabled = false; lblUser.Enabled = false;
            }
        }

        private void BtnBackupFileLocationSelect_Click(object sender, EventArgs e)
        {
            txtBackupPath.Text = (backupDb.BackupFileLocation() + "\\");
        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            btnBackup.Enabled = false;
            waitForm.Show(this);
            Thread.Sleep(100);
            try
            {

                backupDb.BackupDB(cbxDbNameBackup.Text, txtBackupPath.Text, conString);
                btnBackup.Enabled = true;
            }
            catch (Exception ex) {
                waitForm.Close();
                Application.DoEvents();
                MessageBox.Show(ex.Message + "", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnBackup.Enabled = true;
            }

        }

        private void BtnSQLFileSelect_Click(object sender, EventArgs e)
        {
            txtSQLFile.Text = sqlFileRun.SQLFileSelect();
        }

        public void MainForm_Load(object sender, EventArgs e)
        {
            //conString = databaseProcess.GetConString(CbWindowsAuthentication.Checked, CBServers.Text, cbxUsername.Text, txtPassword.Text, cbxDbName.Text);
            loggers.CreateSpwinlogsFile();
            tabControlProcessHeaders.TabPages.Remove(tpDatabaseRepair);
            tabControlProcessHeaders.TabPages.Remove(tpQuary);
            
        }

        private void BtnSQLRun_Click(object sender, EventArgs e)
        {
            btnSQLRun.Enabled = false;
            waitForm.Show(this);
            Thread.Sleep(100);
            conString = databaseProcess.GetConString(CbWindowsAuthentication.Checked, CBServers.Text, cbxUsername.Text, txtPassword.Text, cbxDbName.Text);

            sqlFileRun.SQLRun(txtSQLFile.Text, conString);
            btnSQLRun.Enabled = true;

        }
        private ComboBox[] DatabaseComboboxList(ComboBox cbxDbName, ComboBox cbxDbNameBackup, ComboBox cbxDbNameRepair, ComboBox cbxDbNameRestore)
        {
            ComboBox[] comboBoxDatabase = { cbxDbName, cbxDbNameBackup, cbxDbNameRepair, cbxDbNameRestore };
            return comboBoxDatabase;
        }
        private void BtnSQLServerList_Click(object sender, EventArgs e)
        {
            btnSQLServerList.Enabled = false;
            //if (CBServers.Items.Count == 0){ databaseProcess.GetSQLServerList(CBServers); }//değişmeyen
            waitForm.Show(this);

            Thread.Sleep(500);
            //thread başlat 

            try
            {
                databaseProcess.GetSQLServerList(CBServers); //dataçekilir

                waitForm.Close();
                Application.DoEvents();
                MessageBox.Show("SQL Server Listeleme Başarılı.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Thread.Sleep(500);

            }
            catch (Exception ex)
            {
                waitForm.Close();
                Thread.Sleep(500);
                Application.DoEvents();
                MessageBox.Show(ex.Message + "", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                btnSQLServerList.Enabled = true;
            }
        }
        private void BtnDatabaseList_Click(object sender, EventArgs e)
        {
            btnDatabaseList.Enabled = false;
            conString = databaseProcess.GetConString(CbWindowsAuthentication.Checked, CBServers.Text, cbxUsername.Text, txtPassword.Text, cbxDbName.Text);

            //if (cbxDbName.Items.Count == 0) { databaseProcess.GetSQLDatabaseList(conString, DatabaseComboboxList(cbxDbName, cbxDbNameBackup, cbxDbNameRepair, cbxDbNameRestore)); }
            waitForm.Show(this);
            Thread.Sleep(500);
            try
            {
                //databaseProcess.GetSQLDatabaseList(conString, DatabaseComboboxList(cbxDbName, cbxDbNameBackup, cbxDbNameRepair, cbxDbNameRestore), CBServers.Text);
                databaseProcess.GetSQLDatabaseList(conString, DatabaseComboboxList(cbxDbName, cbxDbNameBackup, cbxDbNameRepair, cbxDbNameRestore));


                waitForm.Close();
                Application.DoEvents();
                MessageBox.Show("Database Listeleme Başarılı.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Thread.Sleep(500);
            }
            catch (Exception ex)
            {
                Thread.Sleep(500);
                waitForm.Close();
                Application.DoEvents();

                MessageBox.Show(ex.Message + "", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Thread.Sleep(500);
            }
            finally
            {
                btnDatabaseList.Enabled = true;
            }
        }
        private void BtnWeighPhotoDelete_Click(object sender, EventArgs e)
        {
            btnWeighPhotoDelete.Enabled = false;
            
            

            //MainForm.waitForm.Show(MainForm.ActiveForm);
            conString = databaseProcess.GetConString(CbWindowsAuthentication.Checked, CBServers.Text, cbxUsername.Text, txtPassword.Text, cbxDbName.Text);

            if (rbOneAndTwoPhoto.Checked == true || rbInTheFolderPhoto.Checked == true || rbAllPhoto.Checked == true)
            {
                string rbName = "";
                string time1 = "";
                string time2 = "";
                if (rdbPeriod.Checked == true)
                {
                    MainForm.waitForm.Show(MainForm.ActiveForm);
                    time1 = dtpStart.Value.Date.ToString("u").Replace("Z", "");

                    var temp = dtpFinish.Value.Date;
                    temp = temp.AddHours(24.0);
                    time2 = temp.ToString("u").Replace("Z", "");
                }
                else if (rdbAll.Checked == true)
                {
                    string message = "Bu işlem Bütün veritabanı üzerinde silme işlemi yapacaktır \n işleme devam etmek istiyor musunuz?";
                    string title = "UYARI";

                    MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                    DialogResult result = MessageBox.Show(message, title, buttons);
                    if (result==DialogResult.Yes)
                    {
                        
                        MainForm.waitForm.Show(MainForm.ActiveForm);
                    }
                    else
                    {
                        
                        
                        MessageBox.Show("İşlem iptal edildi.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnWeighPhotoDelete.Enabled = true;
                        return;

                    }

                    
                }
                else
                {
                    
                    MessageBox.Show("Bu işlemi yapabilmek için zaman ayarlarından birini seçmek zorundasınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnWeighPhotoDelete.Enabled = true;
                    return;
                }

                 if (rbOneAndTwoPhoto.Checked == true)
                {
                    rbName = rbOneAndTwoPhoto.Name.ToString();
                }
                else if (rbInTheFolderPhoto.Checked == true)
                {
                    rbName = rbInTheFolderPhoto.Name.ToString();
                }
                else if (rbAllPhoto.Checked == true)
                {
                    rbName = rbAllPhoto.Name.ToString();
                }

                // silme fonksiyonuna gidiş
                //************************
                weighPhotoDelete.PhotoDelete(conString, rbName,time1,time2);


                btnWeighPhotoDelete.Enabled = true;
            }
            else
            {
                
                MessageBox.Show("Bu işlemi yapabilmek için tartım fotoğraflarını silme seçeneklerinden birini seçmelisiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnWeighPhotoDelete.Enabled = true;
            }

        }

        

        private void BtnMoveDbaToScale_Click(object sender, EventArgs e)
        {
            btnMoveDbaToScale.Enabled = false;
            waitForm.Show(this);

            Thread.Sleep(1000);
            conString = databaseProcess.GetConString(CbWindowsAuthentication.Checked, CBServers.Text, cbxUsername.Text, txtPassword.Text, cbxDbName.Text);
            updateDbaToScale.MoveDbaService(conString);
            updateDbaToScale.MoveCarrierCompany(conString);
            updateDbaToScale.MovePortList(conString);
            updateDbaToScale.SelectDbaDataAndAddDatatable(conString);

            btnMoveDbaToScale.Enabled = true;
            Application.DoEvents();
            MainForm.waitForm.Close();
        }
        private void BtnFindDbUsers_Click(object sender, EventArgs e)
        {
            btnFindDbUsers.Enabled = false;
            if (CbWindowsAuthentication.Checked == false) { CbWindowsAuthentication.Checked = true; }


            try
            {
                conString = databaseProcess.GetConString(CbWindowsAuthentication.Checked, CBServers.Text, cbxUsername.Text, txtPassword.Text, cbxDbName.Text);
                waitForm.Show(this);
                Thread.Sleep(500);
                databaseProcess.FindDbUsers(cbxUsername, conString, cbxDbName.Text); Application.DoEvents();
                Application.DoEvents();
                
                waitForm.Close();
                Thread.Sleep(500);
                Application.DoEvents();
                MessageBox.Show("Kullanıcı listeleme başarılı.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.DoEvents();
                btnFindDbUsers.Enabled = true;
                CbWindowsAuthentication.Checked = false;

                Thread.Sleep(500);
            }
            catch (Exception ex)
            {
                Thread.Sleep(500);
                waitForm.Close();
                Application.DoEvents();
                MessageBox.Show(ex.Message + "", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnFindDbUsers.Enabled = true;
                //CbWindowsAuthentication.Checked = false;

            }
            
            //if (cbxUsername.Items.Count == 0) { databaseProcess.FindDbUsers(cbxUsername, conString); }
        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Goster_Click(object sender, EventArgs e)
        {
            conString = databaseProcess.GetConString(CbWindowsAuthentication.Checked, CBServers.Text, cbxUsername.Text, txtPassword.Text, cbxDbName.Text);
            SqlConnection connect = new SqlConnection(conString);
            connect.Open();
            string quary = "";

            if (checkedListBox1.CheckedItems.Count != 0)
            {
                List<string> seciliVeriler = new List<string>();
                foreach (string item in checkedListBox1.CheckedItems)
                {
                    seciliVeriler.Add(item.ToString());
                }
                foreach (var veri in seciliVeriler)
                {
                    quary += veri + ",";
                }
                quary = quary.Remove(quary.Length - 1);
            }
            else
            {
                quary = "*";
            }
            SqlCommand cmd = new SqlCommand("USE " + cbxDbName.Text + "; SELECT " + quary + " FROM " + addCbxtable.Text, connect);
            SqlDataReader dr = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dataGV1.DataSource = null;
            dt.Load(dr);
            dataGV1.DataSource = dt;
            connect.Close();
        }

        private void AddCbxtable_SelectedValueChanged(object sender, EventArgs e)
        {
            if (btngoster.Enabled == false)
            {
                btngoster.Enabled = true;
            }
            try
            {

                conString = databaseProcess.GetConString(CbWindowsAuthentication.Checked, CBServers.Text, cbxUsername.Text, txtPassword.Text, cbxDbName.Text);
                waitForm.Show(this);
                Thread.Sleep(500);
                databaseProcess.FindTbColum(conString, cbxDbName.Text, addCbxtable.Text, checkedListBox1);
                Application.DoEvents();
                waitForm.Close();

            }
            catch (Exception ex)
            {
                Thread.Sleep(500);
                waitForm.Close();
                Application.DoEvents();
                MessageBox.Show(ex.Message + "", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnFindDbUsers.Enabled = true;

            }

        }

        

        private void btnQuaryClear_Click(object sender, EventArgs e)
        {
            tbxQuary.Clear();
            tbxQuaryName.Clear();
        }
        private void btnloc_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbxQuarySaveLoc.Text = folderBrowserDialog.SelectedPath + "\\";
            }
        }
        private void btnQuarySave_Click(object sender, EventArgs e)
        {
            if (tbxQuaryName.Text.Replace(" ", "").Length == 0)
            {
                Thread.Sleep(500);
                MainForm.waitForm.Close();
                Application.DoEvents();
                MessageBox.Show("Lütfen Quary adını giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (tbxQuarySaveLoc.Text.Replace(" ", "").Length == 0)
            {
                Thread.Sleep(500);
                MainForm.waitForm.Close();
                Application.DoEvents();
                MessageBox.Show("Lütfen Quary kayıt konumunu seçiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            tbxQuaryName.Text.Replace(" ", "_");
            String textToSave = tbxQuary.Text;

            File.AppendAllText(tbxQuarySaveLoc.Text + @"\" + tbxQuaryName.Text + ".sql", tbxQuary.Text);



        }
    
        private void btnTemizle_Click(object sender, EventArgs e)
        {
            
            rtbSorgula.Clear();
        }

        private void btnSorgula_Click(object sender, EventArgs e)
        {
            panel2.Controls.Clear();
            try
            {
                
                waitForm.Show(this);
                Thread.Sleep(500);
                conString = databaseProcess.GetConString(CbWindowsAuthentication.Checked, CBServers.Text, cbxUsername.Text, txtPassword.Text, cbxDbName.Text);
                SqlConnection connect = new SqlConnection(conString);
                connect.Open();

                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand(rtbSorgula.Text.Replace('\n', ' '), connect);
                var adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
                //SqlDataReader dtemp = cmd.ExecuteReader();



                //int tablecount = 0;
                //while (dtemp.HasRows)
                //{
                //    tablecount++;
                //    dtemp.NextResult();
                //}
                //dtemp.Close();

                //SqlDataReader dr = cmd.ExecuteReader();
                //DataSet dataset = dr.;
                //int height =panel2.Height/tablecount;

                //for (int i = 0; i < tablecount; i++)
                //{
                //    DataGridView dataGridView = new DataGridView();
                //    dataGridView.Location = new Point(1, 0 + (i * height));
                //    dataGridView.Height = height;
                //    dataGridView.Width = 850;
                //    panel2.Controls.Add(dataGridView);
                //    ds.Load(dr);
                //    dataGridView.DataSource = ds;
                //    dr.NextResult();
                //    panel2.Refresh();
                //}
                int tablecount = ds.Tables.Count ;
                int height = panel2.Height / tablecount;
                int weidth = panel2.Width;
                int i = 0;
                foreach (var table in ds.Tables)
                {
                    DataGridView dataGridView = new DataGridView();
                    dataGridView.Location = new Point(1,(i * height));
                    dataGridView.Height = height;
                    dataGridView.Width = weidth; 
                    
                    panel2.Controls.Add(dataGridView);
                    
                    dataGridView.DataSource = table;
                    i++;
                }

                
                connect.Close();
                waitForm.Close();

            }
            catch (Exception ex)
            {

                Thread.Sleep(500);
                waitForm.Close();
                Application.DoEvents();
                MessageBox.Show(ex.Message + "", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnFindDbUsers.Enabled = true;
            }

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();
        }

        

        

        private void addCbxtable_Click(object sender, EventArgs e)
        {
            
            try
            {
                addCbxtable.Items.Clear();
                conString = databaseProcess.GetConString(CbWindowsAuthentication.Checked, CBServers.Text, cbxUsername.Text, txtPassword.Text, cbxDbName.Text);
                SqlConnection connect = new SqlConnection(conString);
                connect.Open();
                SqlCommand cmd = new SqlCommand("USE " + cbxDbName.Text + "; SELECT * FROM SYS.TABLES  ;", connect);
                SqlDataReader DR = cmd.ExecuteReader();
                while (DR.Read())
                {
                    addCbxtable.Items.Add(DR[0]);
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnFindDbUsers.Enabled = true;
            }
        }

        

        private void CBServers_TextChanged(object sender, EventArgs e)
        {
            if (tabControlProcessHeaders.Enabled == true)
            {
                tabControlProcessHeaders.Enabled = false;
            }
            
        }

        private void cbxDbName_TextChanged(object sender, EventArgs e)
        {
            if (tabControlProcessHeaders.Enabled == true)
            {
                tabControlProcessHeaders.Enabled = false;
            }
        }

        private void cbxUsername_TextChanged(object sender, EventArgs e)
        {
            if (tabControlProcessHeaders.Enabled == true)
            {
                tabControlProcessHeaders.Enabled = false;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            if (tabControlProcessHeaders.Enabled == true)
            {
                tabControlProcessHeaders.Enabled = false;
            }
        }


        private void rdbPeriod_CheckedChanged(object sender, EventArgs e)
        {
            lblDateStart.Visible = true;
            lblDateFinish.Visible=true;
            dtpStart.Visible = true;
            dtpFinish.Visible = true;
        }

        private void rdbAll_CheckedChanged(object sender, EventArgs e)
        {
            lblDateStart.Visible = false;
            lblDateFinish.Visible = false;
            dtpStart.Visible = false;
            dtpFinish.Visible = false;
        }
    }
}
