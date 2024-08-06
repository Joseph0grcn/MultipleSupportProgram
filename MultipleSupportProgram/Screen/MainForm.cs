using log4net.Repository.Hierarchy;
using MultipleSupportProgram.Model;
using MultipleSupportProgram.Screen;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.PeerToPeer;
using System.Security.AccessControl;
using System.Security.Cryptography.X509Certificates;
using System.Security.Permissions;
using System.Security.Principal;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;
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

        public void MainForm_Load(object sender, EventArgs e)
        {
            //conString = SQLHelper.GetConnectionString();
            loggers.CreateSpwinlogsFile();
            
            tabControlProcessHeaders.TabPages.Remove(tpDatabaseRepair);
            tabControlProcessHeaders.TabPages.Remove(tpQuary);
            tabControlProcessHeaders.TabPages.Remove(tpTablolar);
            tabControlProcessHeaders.TabPages.Remove(tpSorgu);
            tabControlProcessHeaders.TabPages.Remove(tpSQLFile);



        }


        public string conString;
        public Loggers loggers = new Loggers();
        public static WaitScreenFunc waitForm = new WaitScreenFunc();
        public enum photoDeleteEnum { 


            }


        private void BtnConnectionTest_Click(object sender, EventArgs e)
        {
            try
            {
                SQLHelper.LoadConnectionString(CbWindowsAuthentication.Checked, CBServers.Text, cbxDbName.Text, cbxUsername.Text, txtPassword.Text);
                if (btnConnectionTest.Text == "Bağlantı Kes")
                {
                    gbConnectionSettings.Enabled = true;
                    tabControlProcessHeaders.Enabled = false;
                    btnConnectionTest.Text = "Bağlan";
                    btnConnectionTest.BackColor = Color.GreenYellow;
                    MessageBox.Show("Bağlantı Kesildi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    btnConnectionTest.Text = "Bağlanıyor...";
                    btnConnectionTest.BackColor = Color.DarkGoldenrod;
                    Application.DoEvents();

                    if (SQLHelper.ConnectionTest() == true)
                    {
                        cbxDbNameBackup.Text = cbxDbName.Text;
                        cbxDbNameRepair.Text = cbxDbName.Text;
                        cbxDbNameRestore.Text = cbxDbName.Text;
                        gbConnectionSettings.Enabled = false;
                        tabControlProcessHeaders.Enabled = true;
                        btnConnectionTest.Text = "Bağlantı Kes";
                        btnConnectionTest.BackColor = Color.OrangeRed;
                    }
                    else
                    {
                        btnConnectionTest.Text = "Bağlan";
                        btnConnectionTest.BackColor = Color.GreenYellow;
                        

                    }
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message + "connection string " + conString , "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
        }

        private void BtnRestore_Click(object sender, EventArgs e)
        {
            try
            {
                btnRestore.Enabled = false;
                waitForm.Show(this);
                Application.DoEvents();
                SQLHelper.RestoreDB(cbxDbNameRestore.Text, txtRestorePath.Text);
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
            txtRestorePath.Text = FileHelper.RestoreFileLocation();
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
            txtBackupPath.Text = (FileHelper.BackupFileLocation() + "\\");
        }

        private void BtnBackup_Click(object sender, EventArgs e)
        {
            btnBackup.Enabled = false;
            waitForm.Show(this);
            Thread.Sleep(100);
            try
            {

                SQLHelper.BackupDB(cbxDbNameBackup.Text, txtBackupPath.Text);
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
            txtSQLFile.Text = FileHelper.SQLFileSelect();
        }

        

        private void BtnSQLRun_Click(object sender, EventArgs e)
        {
            btnSQLRun.Enabled = false;
            waitForm.Show(this);
            Thread.Sleep(100);
            

            SQLHelper.RunSQLFile(txtSQLFile.Text);
            btnSQLRun.Enabled = true;

        }
        private ComboBox[] DatabaseComboboxList(ComboBox cbxDbName, ComboBox cbxDbNameBackup, ComboBox cbxDbNameRepair, ComboBox cbxDbNameRestore)
        {
            ComboBox[] comboBoxDatabase = { cbxDbName, cbxDbNameBackup, cbxDbNameRepair, cbxDbNameRestore };
            return comboBoxDatabase;
        }
       
        private void BtnWeighPhotoDelete_Click(object sender, EventArgs e)
        {
            btnWeighPhotoDelete.Enabled = false;
           
            

            btnWeighPhotoDelete.Text = "Bekleyiniz...";
            

            
            
            conString = SQLHelper.GetConnectionString();

            if (rbOneAndTwoPhoto.Checked == true || rbInTheFolderPhoto.Checked == true || rbAllPhoto.Checked == true)
            {
                string rbName = "";
                string time1 = "";
                string time2 = "";
                if (rdbPeriod.Checked == true)
                {
                   
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
                    if (result==DialogResult.No)
                    {
                        MessageBox.Show("İşlem iptal edildi.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnWeighPhotoDelete.Enabled = true;
                        btnWeighPhotoDelete.Text = "Tartım Fotoğraflarını Sil";
                        return;
                    }
                    
                }
                else
                {
                    MessageBox.Show("Bu işlemi yapabilmek için zaman ayarlarından birini seçmek zorundasınız.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnWeighPhotoDelete.Enabled = true;
                    btnWeighPhotoDelete.Text = "Tartım Fotoğraflarını Sil";
                    return;
                }

                 if (rbOneAndTwoPhoto.Checked == true)
                {
                    rbName = rbOneAndTwoPhoto.Tag.ToString();
                }
                else if (rbInTheFolderPhoto.Checked == true)
                {
                    rbName = rbInTheFolderPhoto.Tag.ToString();
                }
                else if (rbAllPhoto.Checked == true)
                {
                    rbName = rbAllPhoto.Tag.ToString();
                }

                // silme fonksiyonuna gidiş
                //************************
                SQLHelper.PhotoDelete(rbName,time1,time2,tbPicturePath.Text);


                
            }
            else
            {
                
                MessageBox.Show("Bu işlemi yapabilmek için tartım fotoğraflarını silme seçeneklerinden birini seçmelisiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
            }
            btnWeighPhotoDelete.Enabled = true;
            btnWeighPhotoDelete.Text = "Tartım Fotoğraflarını Sil";

        }

        

        private void BtnMoveDbaToScale_Click(object sender, EventArgs e)
        {
            btnMoveDbaToScale.Enabled = false;

            SQLHelper.MoveDbaService();
            SQLHelper.MoveCarrierCompany();
            SQLHelper.MovePortList();
            SQLHelper.SelectDbaDataAndAddDatatable();

            btnMoveDbaToScale.Enabled = true;
            
        }
        

        private void Button2_Click(object sender, EventArgs e)
        {

        }

        private void Goster_Click(object sender, EventArgs e)
        {
            conString = SQLHelper.GetConnectionString();
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
            

            DataTable dataTable = new DataTable();
            dataTable = SQLHelper.ExecuteReaderScript("USE " + cbxDbName.Text + "; SELECT " + quary + " FROM " + CbxtableList.Text);

            dataGV1.DataSource = null;
            
            dataGV1.DataSource = dataTable;
            connect.Close();
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
                conString = SQLHelper.GetConnectionString();
                SqlConnection connect = new SqlConnection(conString);
                connect.Open();

                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand(rtbSorgula.Text.Replace('\n', ' '), connect);
                var adapter = new SqlDataAdapter(cmd);
                adapter.Fill(ds);
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
                
            }

        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1();
            about.Show();
        }

        private void CbxtableList_Click(object sender, EventArgs e)// son kalınan nokta
        {
            try
            {
                CbxtableList.Items.Clear();
                DataTable DR = SQLHelper.ExecuteReaderScript("USE " + cbxDbName.Text + "; SELECT * FROM SYS.TABLES  ;");
                
                
                foreach (DataRow row in DR.Rows)
                {
                    CbxtableList.Items.Add(row[0].ToString());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        

        private void CBServers_DropDown(object sender, EventArgs e)
        {
            if (CBServers.Items.Count == 0)
            {
                try
                {
                    SQLHelper.GetSQLServerList(CBServers); //dataçekilir
                }
                catch (Exception ex)
                {
                    Application.DoEvents();
                    MessageBox.Show(ex.Message + "", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            
        }
        private void cbxDbName_DropDown(object sender, EventArgs e)
        {
            
                try
                {
                    SQLHelper.GetSQLDatabaseList(cbxDbName, CBServers.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            
        }
        private void cbxUsername_DropDown(object sender, EventArgs e)
        {
            if (cbxUsername.Items.Count == 0)
            {
                try
                {
                    SQLHelper.FindDbUsers(cbxUsername, cbxDbName.Text, CBServers.Text);
                    MessageBox.Show("Kullanıcı listeleme başarılı.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message + "", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void CbxtableList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (btngoster.Enabled == false)
            {
                btngoster.Enabled = true;
            }
            try
            {

                conString = SQLHelper.GetConnectionString();
                waitForm.Show(this);
                Thread.Sleep(500);
                SQLHelper.FindTableColums(cbxDbName.Text, CbxtableList.Text, checkedListBox1);
                Application.DoEvents();
                waitForm.Close();

            }
            catch (Exception ex)
            {
                Thread.Sleep(500);
                waitForm.Close();
                Application.DoEvents();
                MessageBox.Show(ex.Message + "", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
        }

        private void btnEsitScaleSil_Click(object sender, EventArgs e)
        {
            try
            {
                string appDataRoaming = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
                string appDataLocal = appDataRoaming.Replace("Roaming", "Local");
                string dosyaIsmi = "www.esitscale.com";
                string localPath = Path.Combine(appDataLocal, dosyaIsmi);
                string roamingPath = Path.Combine(appDataRoaming, dosyaIsmi);



                string message = "Bu işlem www.esitscale.com dosyalarını silecektir \ndevam etmek istiyor musunuz?";
                string title = "UYARI";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);

                if (result == DialogResult.Yes)
                {
                    FileHelper.DeleteDirectoryIfExists(localPath);
                    FileHelper.DeleteDirectoryIfExists(roamingPath);
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Hata Meydana geldi : " + ex, "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
                
            
            
        }

        private void btnCamLinkCreate_Click(object sender, EventArgs e)
        {
            string camLink = "";
            string camType = cbCamType.Text;
            string camUser = tbCamUser.Text;
            string camPassword = tbCamPassword.Text;
            string camIpAddress = tbCamIpAddress.Text;
            if (camUser =="" && camPassword =="")
            {
                switch (camType)
                {
                    case "Aver":
                        camLink = @"http://" +camIpAddress + "/GetImage.cgi?CH=1";
                        break;
                    case "Dahua":
                        camLink = @"http://" +camIpAddress + "/cgi-bin/snapshot.cgi?";
                        break;
                    case "Hikvision":
                        camLink = @"http://" +camIpAddress + "/ISAPI/Streaming/channels/1/picture";
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (camType)
                {
                    case "Aver":
                        camLink = @"http://" + camUser + ":" + camPassword + "@" + camIpAddress + "/GetImage.cgi?CH=1";
                        break;
                    case "Dahua":
                        camLink = @"http://" + camUser + ":" + camPassword + "@" + camIpAddress + "/cgi-bin/snapshot.cgi?";
                        break;
                    case "Hikvision":
                        camLink = @"http://" + camUser + ":" + camPassword + "@" + camIpAddress + "/ISAPI/Streaming/channels/1/picture";
                        break;
                    default:
                        break;
                }
            }


            
            tbCamLink.Text = camLink;
        }

        private void btnLinkCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbCamLink.Text);
        }

        private void rbTartımAllDelete_Click(object sender, EventArgs e)
        {
            
            

            lbTartımStart.Visible = false;
            lbTartımEnd.Visible = false;
            dtpTartimDateStart.Visible = false;
            dtpTartimDateEnd.Visible = false;
            dtpTartimSaatStart.Visible = false;
            dtpTartimSaatEnd.Visible = false;
        }

        private void rbTartımPeriodDelete_Click(object sender, EventArgs e)
        {
            lbTartımStart.Visible = true;
            lbTartımEnd.Visible = true;
            dtpTartimDateStart.Visible = true;
            dtpTartimDateEnd.Visible = true;
            dtpTartimSaatStart.Visible = true;
            dtpTartimSaatEnd.Visible = true;
        }

        private void btnTartımSilme_Click(object sender, EventArgs e)
        {
            string message = "Bu işlem veri tabanında geri alınamayan SİLME işlemleri gerçekleştirecektir \nDevam edilsin mi?";
            string title = "UYARI";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon messageBoxIcon = MessageBoxIcon.Warning;
            DialogResult result = MessageBox.Show(message, title, buttons, messageBoxIcon);

            

            if (result == DialogResult.Yes)
            {
                string rbName = "";
                string time1 = "";
                string time2 = "";


                if (rbTartim1.Checked == true || rbTartim2.Checked == true )
                {
                    if (rbTartim1.Checked == true)
                    {
                        rbName = rbTartim1.Name.ToString();
                    }
                    else if (rbTartim2.Checked == true)
                    {
                        rbName = rbTartim2.Name.ToString();
                    }
                    

                    if (rbTartimPeriodDelete.Checked == true)
                    {
                        time1 = dtpTartimDateStart.Value.Date.ToString("yyyy-MM-dd") + " " + dtpTartimSaatStart.Value.TimeOfDay.ToString("t");
                        time2 = dtpTartimDateEnd.Value.Date.ToString("yyyy-MM-dd") + " " + dtpTartimSaatEnd.Value.TimeOfDay.ToString("t");
                        
                        SQLHelper.WeighingDelete(rbName, time1, time2);
                        
                    }
                    else if (rbTartimAllDelete.Checked == true)
                    {
                        SQLHelper.WeighingDelete(rbName,time1,time2);
                    }
                    else
                    {
                        message = "Bu işlem için tarih seçeneklerinden birini seçmeniz gerekmektedir";
                        title = "UYARI";
                        buttons = MessageBoxButtons.OK;
                        messageBoxIcon = MessageBoxIcon.Warning;
                        MessageBox.Show(message, title, buttons, messageBoxIcon);
                    }
                }
                else
                {
                    message = "Bu işlem için tartımlardan birini seçmeniz gerekmektedir";
                    title = "UYARI";
                    buttons = MessageBoxButtons.OK;
                    messageBoxIcon = MessageBoxIcon.Warning;
                    MessageBox.Show(message, title, buttons, messageBoxIcon);
                }
            }
            else
            {
                message = "Silme işlemi iptal edildi";
                title = "UYARI";
                buttons = MessageBoxButtons.OK;
                messageBoxIcon = MessageBoxIcon.Information;
                MessageBox.Show(message, title, buttons, messageBoxIcon);
            }
        }

        private void BtnAuditDBScript_Click(object sender, EventArgs e)
        {
            string message = "Bu işlem veritabanına bağlanmayı geçici süre engelleyecektir \n işleme devam etmek istiyor musunuz?";
            string title = "UYARI";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon messageBoxIcon = MessageBoxIcon.Warning;
            DialogResult result = MessageBox.Show(message, title, buttons, messageBoxIcon);

            if (result == DialogResult.Yes)
            {
                if (SQLHelper.AuditStopedScriptRun())
                {
                    message = "AUDIT_DB Hata giderme işlemi başarılı bir şekilde sonuçlandı";
                    title = "UYARI";
                    buttons = MessageBoxButtons.OK;
                    messageBoxIcon = MessageBoxIcon.Information;
                    MessageBox.Show(message, title, buttons, messageBoxIcon);
                }
               
            }
            else
            {
                message = "İşlem iptal edildi";
                title = "UYARI";
                buttons = MessageBoxButtons.OK;
                messageBoxIcon = MessageBoxIcon.Information;
                MessageBox.Show(message, title, buttons, messageBoxIcon);
            }
            
        }

        private void btnSpwinDBScript_Click(object sender, EventArgs e)
        {
            string message = "Bu işlem veritabanına bağlanmayı geçici süre engelleyecektir \n işleme devam etmek istiyor musunuz?";
            string title = "UYARI";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            MessageBoxIcon messageBoxIcon = MessageBoxIcon.Warning;
            DialogResult result = MessageBox.Show(message, title, buttons, messageBoxIcon);
            if (result == DialogResult.Yes)
            {
                if (SQLHelper.SpwinStopedScriptRun()){
                    message = "SPWIN_DB Hata giderme işlem başarılı bir şekilde sonuçlandı";
                    title = "UYARI";
                    buttons = MessageBoxButtons.OK;
                    messageBoxIcon = MessageBoxIcon.Information;
                    MessageBox.Show(message, title, buttons, messageBoxIcon);
                }
                
            }
            else
            {
                message = "İşlem iptal edildi";
                title = "UYARI";
                buttons = MessageBoxButtons.OK;
                messageBoxIcon = MessageBoxIcon.Information;
                MessageBox.Show(message, title, buttons, messageBoxIcon);
            }
            
        }

        private void btnKullanıcıEkle_Click(object sender, EventArgs e)
        {
            if (tbUserAddUserPassword.Text == tbUserAddUserPasswordConfirm.Text)
            {
                SQLHelper.EsitUserAdd(tbUserAddUserName.Text, tbUserAddUserPassword.Text, cbUserAddUserRole.Text);
            }
            else
            {
                MessageBox.Show("Şifre ve şifre doğrulama aynı olmalıdır. Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        private void btnKullanıcıSil_Click(object sender, EventArgs e)
        {
            string selectedUserName =  tbUserAddUserName.Text;
            // Silinmemesi gereken kullanıcıların listesi
            List<string> protectedUsers = new List<string>
            {
                "sa",
                "NT AUTHORITY\\SYSTEM",
                "NT SERVICE\\MSSQLSERVER",
                "NT SERVICE\\SQLWriter",
                "NT AUTHORITY\\NETWORK SERVICE",
                "BUILTIN\\Administrators",
                ""
            };

            if (!protectedUsers.Contains(selectedUserName) && tbUserAddUserPassword.Text == "KULLANICISIL" )
            {
                
                SQLHelper.EsitUserDelete(tbUserAddUserName.Text);
            }else if (selectedUserName == "")
            {
                MessageBox.Show("Kullanıcı silme işlemi için bir kullanıcı adı girilmedi!"
                                , "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (protectedUsers.Contains(selectedUserName))
            {
                MessageBox.Show("Kullanıcı silme işlemi için sistem kullanıcılarından biri seçilemez!"
                                , "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Kullanıcı silme işlemi için \n silmek istediğiniz kullanıcı adını ve kullanıcı şifresi olarakta 'KULLANICISIL' bilgilerini giriniz"
                                , "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btnServerConManager_Click(object sender, EventArgs e)
        {
            if (IsAdministrator())
            {


                if (rbConfigSQLExpress.Checked)
                {
                    SQLHelper.SQLExpressConfigTcpIpAccessAndPortSetter(true, true, 1433);
                }
                else if (rbConfigSQLServer.Checked)
                {
                    SQLHelper.SQLServerConfigTcpIpAccessAndPortSetter(true, true, 1433);
                }


                if (tbConfigServerName.Text == "")
                {
                    SQLHelper.ServerConfigSettingsSetter("SQLEXPRESS");
                }
                else
                {
                    SQLHelper.ServerConfigSettingsSetter(tbConfigServerName.Text);
                }
            }
            else
            {
                MessageBox.Show("İşlem gerçekleştirilemedi bu işlemin gerçekleştirilebilmesi için uygulamanın yönetici olarak açılması gerekmektedir. \nLütfen uygulamayı yönetici olarak tekrar başlatın", "Yetkisiz Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        static bool IsAdministrator()
        {
            using (WindowsIdentity identity = WindowsIdentity.GetCurrent()) {
                WindowsPrincipal principal = new WindowsPrincipal(identity);
                return principal.IsInRole(WindowsBuiltInRole.Administrator);
            }
        }
        private void btnEsitUserSilHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Kullanıcı silme işlemi için \n silmek istediğiniz kullanıcı adını ve kullanıcı şifresi olarakta 'KULLANICISIL' bilgilerini giriniz"
                                , "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnPicturePath_Click(object sender, EventArgs e)
        {
            tbPicturePath.Text = FileHelper.GetPictureFileLocation();
        }

        private void rbOneAndTwoPhoto_CheckedChanged(object sender, EventArgs e)
        {
            rtbPicture.Visible = false;
            tbPicturePath.Visible = false;
            btnPicturePath.Visible = false;
        }

        private void rbInTheFolderPhoto_CheckedChanged(object sender, EventArgs e)
        {
            rtbPicture.Visible = true;
            tbPicturePath.Visible = true;
            btnPicturePath.Visible = true;
        }

        private void rbAllPhoto_CheckedChanged(object sender, EventArgs e)
        {
            rtbPicture.Visible = true;
            tbPicturePath.Visible = true;
            btnPicturePath.Visible = true;
        }
    }
}
