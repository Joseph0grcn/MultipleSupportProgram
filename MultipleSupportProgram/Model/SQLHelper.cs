using log4net.Repository.Hierarchy;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleSupportProgram.Model
{

    internal class SQLHelper
    {
        public static log4net.ILog logger = log4net.LogManager.GetLogger("SQLHelper");

        public static string serverName;
        public static string databaseName;
        public static string userName;
        public static string password;
        public static string connectionString;

        public static bool windowsAuthentication = false;


        public static bool ExecuteNonQueryScript(string sqlScript)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sqlScript, connection))
                {
                    try
                    {
                        command.ExecuteNonQuery();
                        logger.Debug("SQL script başarıyla çalıştırıldı.");
                        return true;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Hata: " + ex.Message);
                        return false;
                    }
                }
            }
        }
        public static object ExecuteScalarScript(string sqlScript)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sqlScript, connection))
                {
                    try
                    {
                        var result = command.ExecuteScalar();
                        
                        return result;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Hata: " + ex.Message);
                        return null;
                    }
                }
            }
        }
        public static DataTable ExecuteReaderScript(string sqlScript)
        {
            DataTable result = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sqlScript, connection))
                {
                    try
                    {

                        SqlDataReader reader = command.ExecuteReader();
                        result.Load(reader);

                        return result;
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("Hata: " + ex.Message);
                        return null;
                    }
                }
            }
        }

        public static string BackupFileLocation()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                return folderBrowserDialog.SelectedPath;
            }
            return null;
        }
        public static void BackupDB(string databaseName, string backupFileLocation)
        {

            if (databaseName.Replace(" ", "").Length == 0)
            {
                Thread.Sleep(500);
                MainForm.waitForm.Close();
                Application.DoEvents();
                MessageBox.Show("Lütfen Database adını giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (backupFileLocation.Replace(" ", "").Length == 0)
            {
                Thread.Sleep(500);
                MainForm.waitForm.Close();
                Application.DoEvents();
                MessageBox.Show("Lütfen Backup dosyasını seçiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string backupFilePath = $"{backupFileLocation}{databaseName}_{DateTime.Now:MM_dd_yyyy_HH_mm_ss}.bak";
                string sqlScript = $@"BACKUP DATABASE [{databaseName}] TO DISK = '{backupFilePath}' WITH INIT, STATS = 10";
                bool result = ExecuteNonQueryScript(sqlScript);
                Thread.Sleep(500);
                MainForm.waitForm.Close();
                Application.DoEvents();
                if (!result)
                {
                    logger.Error("HATA Backup işlemi başarısız!");
                    MessageBox.Show("HATA Backup işlemi başarısız! : ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    logger.Debug("Yedekleme işlemi başarıyla gerçekleşti.");
                    MessageBox.Show("Yedekleme işlemi başarıyla gerçekleşti.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                logger.Error("HATA Backup işlemi başarısız!: " + ex.Message);
                throw new Exception("HATA Backup işlemi başarısız! : " + ex.Message + "");
            }

        }
        
        public static string RestoreFileLocation()
        {
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Veritabanı Dosyası |*.bak";
            if (file.ShowDialog() == DialogResult.OK)
            {
                return file.FileName;
            }
            else
            {
                return null;
            }
        }
        public static void RestoreDB(string databaseName, string restoreFilePath)
        {
            if (databaseName.Replace(" ", "").Length == 0)
            {
                Thread.Sleep(500);
                MainForm.waitForm.Close();
                Application.DoEvents();
                MessageBox.Show("Lütfen Database adını giriniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (restoreFilePath.Replace(" ", "").Length == 0)
            {
                Thread.Sleep(500);
                MainForm.waitForm.Close();
                Application.DoEvents();
                MessageBox.Show("Lütfen Backup dosyasını seçiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                string sqlScript = $"USE [master] ALTER DATABASE [{databaseName}] SET SINGLE_USER WITH ROLLBACK IMMEDIATE RESTORE DATABASE [{databaseName}] FROM  DISK =  '{restoreFilePath}' WITH  FILE = 1,  NOUNLOAD,  REPLACE,  STATS = 5 ALTER DATABASE [{databaseName}] SET MULTI_USER";
                bool result = ExecuteNonQueryScript(sqlScript);
                if (!result)
                {
                    Thread.Sleep(500);
                    MainForm.waitForm.Close();
                    Application.DoEvents();
                    logger.Error("Restore işlemi başarısız! :");
                    MessageBox.Show("Restore işlemi başarısız! :", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Thread.Sleep(500);
                    MainForm.waitForm.Close();
                    Application.DoEvents();
                    logger.Debug("Geri yükleme işlemi başarıyla gerçekleşti.");
                    MessageBox.Show("Geri yükleme işlemi başarıyla gerçekleşti.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }
            catch (Exception ex)
            {
                Thread.Sleep(500);
                MainForm.waitForm.Close();
                Application.DoEvents();
                logger.Error("HATA Restore işlemi başarısız!: " + ex.Message);
                MessageBox.Show("HATA Restore işlemi başarısız! : " + ex.Message + "", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static string SQLFileSelect()
        {
            using (OpenFileDialog file = new OpenFileDialog())
            {
                file.Filter = "SQL Dosyası |*.sql";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    return file.FileName;
                }
                else
                {
                    return null;
                }
            }
        }
        public static void RunSQLFile(string sqlFile)
        {
            if (sqlFile.Replace(" ", "").Length == 0)
            {
                Thread.Sleep(500);
                MainForm.waitForm.Close();
                Application.DoEvents();
                MessageBox.Show("Lütfen SQL dosyasını seçiniz.", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                FileInfo file = new FileInfo(sqlFile);
                string scriptText = file.OpenText().ReadToEnd();
                bool result = false;
                string[] commandTextArray = scriptText.Split(new string[] { "GO" }, StringSplitOptions.RemoveEmptyEntries);
                
                foreach (string commandText in commandTextArray)
                {
                    if (commandText.Trim() == string.Empty) continue;
                    result = ExecuteNonQueryScript(commandText);
                }
                if (result == false)
                {
                    Thread.Sleep(500);
                    MainForm.waitForm.Close();
                    Application.DoEvents();
                    logger.Error("SQL dosyası çalıştırma işlemi başarısız!");
                    MessageBox.Show("SQL dosyası çalıştırma işlemi başarısız!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Thread.Sleep(500);
                    MainForm.waitForm.Close();
                    Application.DoEvents();
                    logger.Debug("SQL Dosya Çalıştırma işlemi başarıyla gerçekleşti.");
                    MessageBox.Show("SQL Dosya Çalıştırma işlemi başarıyla gerçekleşti.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Thread.Sleep(500);
                MainForm.waitForm.Close();
                Application.DoEvents();
                logger.Error("SQL dosyası çalıştırma işlemi başarısız! : " + ex.Message);
                MessageBox.Show("SQL dosyası çalıştırma işlemi başarısız! : " + ex.Message + "", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void EsitUserAdd()
        {
            try
            {
                string userAddScriptText = @"CREATE LOGIN esit_user WITH PASSWORD=N'esit12345', 
                DEFAULT_DATABASE=[SPWIN_DB], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF,
                CHECK_POLICY=OFF EXEC master..sp_addsrvrolemember @loginame = N'esit_user', @rolename = N'sysadmin'";

                bool result = ExecuteNonQueryScript(userAddScriptText);
                if (result == false)
                {
                    logger.Error("Esit-User Ekleme işlemi başarısız!");
                    MessageBox.Show("Esit-User Ekleme işlemi başarısız!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    logger.Debug("Esit-User Ekleme işlemi başarıyla gerçekleşti.");
                    MessageBox.Show("Esit-User Ekleme işlemi başarıyla gerçekleşti.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                logger.Error("Esit-User Ekleme işlemi başarısız! : \n" + ex.Message);
                MessageBox.Show("Esit-User Ekleme işlemi başarısız! : \n" + ex.Message + "", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        public static string GetConnectionString()
        {
            return connectionString;
        }
        public static void LoadConnectionString(bool _windowsAuthentication, string _serverName, string _databaseName, string _userName, string _password)
        {
            serverName = _serverName;
            databaseName = _databaseName;
            userName = _userName;
            password = _password;
            windowsAuthentication = _windowsAuthentication;

            if (_windowsAuthentication == true)
            {
                connectionString = "Server=" + serverName + ";Database=" + databaseName + ";Trusted_Connection=True;";
            }
            else
            {
                connectionString = @"Server="+serverName+";Database="+databaseName+";User Id="+_userName+";Password="+_password+";";
            }
        }
        public static void ConnectionTest()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    logger.Debug("Bağlantı başarılı bir şekilde açıldı");
                    con.Close();
                    logger.Debug("Bağlantı başarılı bir şekilde kapatıldı");
                }
            }
            catch (Exception ex)
            {
                logger.Error("HATA Bağlantı kurulamadı! : " + ex.Message + "");
                throw new Exception("HATA Bağlantı kurulamadı : " + ex.Message);
            }
        }
        public static void GetSQLServerList(ComboBox sqlServerList)
        {   try
            {
                serverName = Environment.MachineName;
                RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;

                using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
                {
                    RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);

                    if (instanceKey != null)
                    {
                        sqlServerList.Items.Clear();
                        foreach (var instanceName in instanceKey.GetValueNames())
                        {
                            sqlServerList.Items.Add(serverName);
                        }
                    }
                }
                logger.Debug("SQL server listeleme işlemi başarılı!");
            }
            catch (Exception ex )
            {
                logger.Error("HATA SQL server listeleme işlemi başarısız! :" + ex.Message + "");
                throw new Exception("HATA SQL server listeleme işlemi başarısız! : " + ex.Message);
            }
        }
        public static void GetSQLDatabaseList(ComboBox[] comboBoxDatabase, string serverName)
        {
            try
            {
                foreach (ComboBox cbxDatabase in comboBoxDatabase) { cbxDatabase.Items.Clear(); }

                SqlConnection connect = new SqlConnection("Server=" + serverName + ";Database= Master ;Trusted_Connection=True;");
                connect.Open();

                SqlCommand cmd = new SqlCommand("SELECT name FROM sys.databases where name NOT IN ('master','tempdb','model','msdb') ", connect);
                SqlDataReader DR = cmd.ExecuteReader();
                while (DR.Read())
                {
                    foreach (var cbxItem in comboBoxDatabase)
                    {
                        cbxItem.Items.Add(DR[0]);
                    }
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                logger.Error("HATA SQL database listeleme işlemi başarısız! : " + ex.Message + "");
                throw new Exception("HATA SQL database listeleme işlemi başarısız! : " + ex.Message, ex);
            }
        }
        public static void FindDbUsers(ComboBox cbxDbUsers, string databaseName, string serverName)
        {
            try
            {
                cbxDbUsers.Items.Clear();
                SqlConnection connect = new SqlConnection("Server=" + serverName + ";Database= Master ;Trusted_Connection=True;");
                connect.Open();
                
                SqlCommand cmd = new SqlCommand("USE " + databaseName + "; SELECT name, type_desc FROM sys.sql_logins WHERE type IN('S','U','G') AND is_disabled IN('0')  ;", connect);
                SqlDataReader DR = cmd.ExecuteReader();
                while (DR.Read())
                {
                    cbxDbUsers.Items.Add(DR[0]);
                }
                connect.Close();
            }
            catch (Exception ex)
            {
                logger.Error("HATA SQL database user listeleme işlemi başarısız! : " + ex.Message + "");
                throw new Exception("HATA SQL database user listeleme işlemi başarısız! : " + ex.Message);

            }

        }
        public static void FindTableColums(string databaseName, string tableName, CheckedListBox checkedListBox)
        {
            try
            {
                checkedListBox.Items.Clear();
                
                String SQLScript = "USE " + databaseName + "; SELECT column_name FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '" + tableName + "';";
                DataTable DR = ExecuteReaderScript(SQLScript);
                
                foreach (DataRow row in DR.Rows)
                {
                    checkedListBox.Items.Add(row[0].ToString());
                }

            }
            catch (Exception ex)
            {
                logger.Error("HATA SQL table column listeleme işlemi başarısız! : " + ex.Message + "");
                throw new Exception("HATA SQL table column listeleme işlemi başarısız! : " + ex.Message);
            }
        }


        //id tut öyle devam et
        public static void PhotoDelete(string radioButtonName, string time1, string time2)
        {
            string commandStr = "";
            try
            {
                if (time1 == "" && time2 == "")
                {
                    // bütün veritabanında tüm tarihlerde işlem yapıyor
                    switch (radioButtonName)
                    {
                        case "rbOneAndTwoPhoto":
                            commandStr = "UPDATE SPWIN_DB.dbo.WeighingImages SET image1 = NULL,image2 = NULL, image3 = NULL, image4 = NULL " +
                                "where seqnum2 in(select seq from Weigh2)";
                            break;

                        case "rbInTheFolderPhoto":
                            commandStr = "UPDATE SPWIN_DB.dbo.WeighingImages SET imageFile1 = NULL, imageFile2 = NULL, imageFile3 = NULL, imageFile4 = NULL " +
                                "where seqnum2 in(select seq from Weigh2)";
                            break;

                        case "rbAllPhoto":
                            commandStr = "UPDATE SPWIN_DB.dbo.WeighingImages SET image1 = NULL,image2 = NULL, image3 = NULL, image4 = NULL, imageFile1 = NULL, imageFile2 = NULL, imageFile3 = NULL, imageFile4 = NULL " +
                                "where seqnum2 in(select seq from Weigh2)";
                            break;
                    }
                }
                else
                {
                    //Seçilen tarih aralığında işlem yapıyor
                    switch (radioButtonName)
                    {
                        case "rbOneAndTwoPhoto":
                            commandStr = "UPDATE SPWIN_DB.dbo.WeighingImages SET image1 = NULL,image2 = NULL, image3 = NULL, image4 = NULL " +
                                "where seqnum2 in(select seq from Weigh2 where WeighTime2 between '" + time1 + "' and '" + time2 + "')";
                            break;

                        case "rbInTheFolderPhoto":
                            commandStr = "UPDATE SPWIN_DB.dbo.WeighingImages SET imageFile1 = NULL, imageFile2 = NULL, imageFile3 = NULL, imageFile4 = NULL " +
                                "where seqnum2 in(select seq from Weigh2 where WeighTime2 between '" + time1 + "' and '" + time2 + "')";
                            break;

                        case "rbAllPhoto":
                            commandStr = "UPDATE SPWIN_DB.dbo.WeighingImages SET image1 = NULL,image2 = NULL, image3 = NULL, image4 = NULL, imageFile1 = NULL, imageFile2 = NULL, imageFile3 = NULL, imageFile4 = NULL " +
                                "where seqnum2 in(select seq from Weigh2 where WeighTime2 between '" + time1 + "' and '" + time2 + "')";
                            break;
                    }
                }

                    
                bool result = Convert.ToBoolean(ExecuteNonQueryScript(commandStr));
                    
                if (result)
                {
                    Thread.Sleep(100);
                    Application.DoEvents();
                    MainForm.waitForm.Close();
                    Thread.Sleep(100);
                    Application.DoEvents();

                    MessageBox.Show("Tartım fotoğrafı silme işlemi başarıyla gerçekleşti.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Debug("Tartım fotoğrafı silme işlemi başarıyla gerçekleşti.");

                }
                
            }
            catch (Exception ex)
            {
                Thread.Sleep(1000);
                MainForm.waitForm.Close();
                Application.DoEvents();
                logger.Error("Tartım fotoğrafı silme işlemi başarısız. : " + ex.Message);
                MessageBox.Show("HATAsss : " + ex.Message + "", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        //updateDbaToScale
        public static void MoveCarrierCompany()
        { /* Taşıyıcı Firma'alanına taşınacak */
            
            try
            {
                
                    string SQLScript = "INSERT INTO SPWIN_DB.dbo.Firm(FirmCode, FirmName) SELECT TOP 100 SPWIN_DB.dbo.Code_4.Code, SPWIN_DB.dbo.Code_4.Name FROM SPWIN_DB.dbo.Code_4 LEFT JOIN SPWIN_DB.dbo.Firm on (SPWIN_DB.dbo.Code_4.Code = SPWIN_DB.dbo.Firm.FirmCode and SPWIN_DB.dbo.Firm.FirmName = SPWIN_DB.dbo.Code_4.Name) where SPWIN_DB.dbo.Firm.FirmCode is null and SPWIN_DB.dbo.Firm.FirmName is null";
                    bool result = ExecuteNonQueryScript(SQLScript);
                    if (result)
                    {
                        logger.Debug("Veri taşıma işlemi başarılı! - Taşıyıcı Firma --> Firma listesine eklendi");
                        MessageBox.Show("Veri taşıma işlemi başarılı! - Taşıyıcı Firma --> Firma listesine eklendi", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                
            }
            catch (Exception ex)
            {

                logger.Error("Veri taşıma işlemi başarısız: " + ex.Message);
                MessageBox.Show("HATA : " + ex.Message + "", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void MovePortList()
        { /* Liman Listesi'alanına taşınacak */
            try
            {
                string SQLScript = "INSERT INTO SPWIN_DB.dbo.Code_DBA(Code, Name, Definition, FieldNo) SELECT TOP 50 SPWIN_DB.dbo.Code_9.Code, SPWIN_DB.dbo.Code_9.Name, SPWIN_DB.dbo.Code_9.Definition,6 FROM SPWIN_DB.dbo.Code_9 LEFT JOIN SPWIN_DB.dbo.Code_DBA on (SPWIN_DB.dbo.Code_9.Code = SPWIN_DB.dbo.Code_DBA.Code and SPWIN_DB.dbo.Code_DBA.Name = SPWIN_DB.dbo.Code_9.Name) where SPWIN_DB.dbo.Code_DBA.Code is null and SPWIN_DB.dbo.Code_DBA.Name is null";
                bool result = ExecuteNonQueryScript(SQLScript);
                if (result)
                {
                    logger.Debug("Veri taşıma işlemi başarılı! - Liman Listesi taşındı");
                    //MessageBox.Show("Veri taşıma işlemi başarılı! - Liman Listesi taşındı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                logger.Error("Veri taşıma işlemi başarısız : " + ex.Message);
                MessageBox.Show("HATA Veri taşıma işlemi başarısız : " + ex.Message + "", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void MoveDbaService()
        {
            try
            {
                    string SQLScript = "UPDATE SPWIN_DB.dbo.Parameters SET DbaIsActive = 'False', DbaUserName = ds.username, DbaPassword = ds.password, DbaOrtam = 'False' FROM SPWIN_DB.dbo.Parameters p INNER JOIN SPWIN_DB.dbo.DbaServis ds ON p.seq = ds.ID";
                    bool result = ExecuteNonQueryScript(SQLScript);
                    if (result)
                    {
                        logger.Debug("Veri taşıma işlemi başarılı!");
                        MessageBox.Show("Veri taşıma işlemi başarılı! - DBA_Servis bilgileri taşındı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
            }
            catch (Exception ex)
            {
                logger.Error("Veri taşıma işlemi başarısız : " + ex.Message);
                MessageBox.Show("HATA Veri taşıma işlemi başarısız : " + ex.Message + "", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void SelectDbaDataAndAddDatatable()
        {

            DataTable dataTable = new DataTable();
            try
            {
                string SQLScript = "select seq,seqnum1,CName4,CName5,CName6,CName9,CName10,Code4,Code9 from SPWIN_DB.dbo.Weigh2 where (CName4 IS NOT NULL and CName4 <> '') and (CName5 IS NOT NULL and CName5 <> '') and (CName9 IS NOT NULL and CName9 <> '') and (DbaWeigh2Id IS NULL or DbaWeigh2Id = '' or DbaWeigh2Id = 0)";
                dataTable = ExecuteReaderScript(SQLScript);    
                MoveDba_Data(dataTable);
            }
            catch (Exception ex)
            {
                logger.Error("Weight2 DBA veri listeleme işlemi başarısız : " + ex.Message);
                MessageBox.Show("HATA Weight2 DBA veri listeleme işlemi başarısız : " + ex.Message + "", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void MoveDba_Data(DataTable dataTable)
        {
            int errorCount = 0;
            string carrierCompany, containerNo, portList, portListCode, carrierCompanyCode;
            int containerMaxWeight, attractiveWeight, trailerWeight;
            try
            {
                bool result = true;
                foreach (DataRow row in dataTable.Rows)
                {
                    result = true;
                    carrierCompany = row["CName4"].ToString();
                    containerNo = row["CName5"].ToString();
                    int.TryParse(row["CName6"].ToString(), out containerMaxWeight);
                    attractiveWeight = 0;
                    trailerWeight = 0;
                    portList = row["CName9"].ToString();
                    portListCode = row["Code9"].ToString();
                    carrierCompanyCode = row["Code4"].ToString();

                    string SQLScript = "INSERT INTO SPWIN_DB.dbo.DBA_Data(" +
                                    "CarrierCompany,ContainerNo,ContainerMaxWeight,AttractiveWeight,TrailerWeight,PortList,PortListCode,CarrierCompanyCode) " +
                                    "VALUES ('" + carrierCompany + "','" + containerNo + "'," + containerMaxWeight + 
                                    "," + attractiveWeight + "," + trailerWeight + ",'" + portList + "','" + portListCode + "','" + carrierCompanyCode + "'); " +
                                    "UPDATE SPWIN_DB.dbo.Weigh2 set DbaWeigh2Id =IDENT_CURRENT('SPWIN_DB.dbo.DBA_Data') where seq =" + row["seq"].ToString() + " ;" +
                                    "UPDATE SPWIN_DB.dbo.Weigh1 set DbaWeigh1Id =IDENT_CURRENT('SPWIN_DB.dbo.DBA_Data') where seq =" + row["seqnum1"].ToString();
                    result = ExecuteNonQueryScript(SQLScript);
                    if (result == false)
                    {
                        errorCount++;
                    }    
                }
                if (errorCount == 0)
                {
                    logger.Debug("Veri taşıma işlemi başarılı! - DBA_Dataları taşındı");
                    MessageBox.Show(dataTable.Rows.Count.ToString() + " Adet veri taşıma işlemi başarılı! - DBA_Dataları taşındı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    logger.Error("Veri taşıma işlemi sonlandı - DBA_Dataları eksik şekilde taşındı " +
                        "\n"+errorCount + " tane hatalı işlem gerçekleşti" +
                        "\n"+(dataTable.Rows.Count-errorCount).ToString() + " tane hatasız işlem gerçekleşti");
                    MessageBox.Show((dataTable.Rows.Count - errorCount).ToString() + " Adet veri taşıma işlemi başarılı! - DBA_Dataları taşındı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                logger.Error("Veri taşıma işlemi başarısız: " + ex.Message);
                MessageBox.Show("HATA Veri taşıma işlemi başarısız : " + ex.Message + "", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }







































    }
}
