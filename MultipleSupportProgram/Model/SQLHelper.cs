using log4net.Repository.Hierarchy;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Management;
using System.Security.Cryptography.X509Certificates;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

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


        public static bool ExecuteNonQueryScript(string sqlScript, int timeout = 30)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sqlScript, connection))
                {
                    try
                    {
                        command.CommandTimeout = timeout;
                        command.ExecuteNonQuery();

                        return true;

                    }
                    catch (Exception ex)
                    {
                        if (ex.Message.Contains("already exists.\r\nUser, group, or role") || ex.Message.Contains("already exists in the current database"))
                        {
                            MessageBox.Show("Kullanıcı ismi kullanılmaktadır.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }

                        MessageBox.Show(ex.Message + ex);
                        logger.Error(ex + " hatalı script :" + sqlScript);
                        return false;
                    }
                }
            }
        }
        public static object ExecuteScalarScript(string sqlScript, int timeout = 30)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sqlScript, connection))
                {
                    try
                    {
                        command.CommandTimeout = timeout;
                        var result = command.ExecuteScalar();
                        return result;
                    }
                    catch (Exception ex)
                    {

                        logger.Error(ex + " hatalı script :" + sqlScript);
                        return null;
                    }
                }
            }
        }
        public static DataTable ExecuteReaderScript(string sqlScript, int timeout = 30)
        {
            DataTable result = new DataTable();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(sqlScript, connection))
                {
                    try
                    {
                        command.CommandTimeout = timeout;
                        SqlDataReader reader = command.ExecuteReader();
                        result.Load(reader);
                        return result;
                    }
                    catch (Exception ex)
                    {
                        logger.Error(ex + " hatalı script :" + sqlScript);
                        return null;
                    }
                }
            }
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

                logger.Debug("backup file path :\n" + backupFilePath);
                logger.Debug(sqlScript);
                bool result = ExecuteNonQueryScript(sqlScript, 0);
                Thread.Sleep(500);
                MainForm.waitForm.Close();
                Application.DoEvents();
                if (!result)
                {
                    logger.Error("HATA Backup işlemi başarısız! ");
                    MessageBox.Show("HATA Backup işlemi başarısız! : ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    logger.Info("Yedekleme işlemi başarıyla gerçekleşti.");
                    MessageBox.Show("Yedekleme işlemi başarıyla gerçekleşti.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                logger.Error("HATA Backup işlemi başarısız!: " + ex.Message);
                throw new Exception("HATA Backup işlemi başarısız! : " + ex.Message + "");
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
                bool result = ExecuteNonQueryScript(sqlScript, 0);
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
        public static void EsitUserAdd(string user, string password, string role)
        {

            //kullanıcı kontrolü

            string userAddScriptText = "";
            if (role == "Admin") // admin
            {
                userAddScriptText = $@"
                        CREATE LOGIN [{user}] WITH PASSWORD=N'{password}', 
                        DEFAULT_DATABASE=[SPWIN_DB], DEFAULT_LANGUAGE=[us_english], 
                        CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF;

                        USE [SPWIN_DB];
                        CREATE USER [{user}] FOR LOGIN [{user}];

                        EXEC sp_addsrvrolemember @loginame = N'{user}', @rolename = N'sysadmin';
                    ";
            }
            else if (role == "Read-Only") //read-only
            {
                userAddScriptText = $@"
                        CREATE LOGIN [{user}] WITH PASSWORD=N'{password}', 
                        DEFAULT_DATABASE=[SPWIN_DB], DEFAULT_LANGUAGE=[us_english], 
                        CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF;

                        USE [SPWIN_DB];
                        CREATE USER [{user}] FOR LOGIN [{user}];

                        EXEC sp_addrolemember N'db_datareader', N'{user}';
                    ";
            }
            else
            {
                MessageBox.Show("Esit-User Ekleme işlemi için rol seçiniz!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            bool result = ExecuteNonQueryScript(userAddScriptText);
            if (result == true)
            {
                logger.Debug("Esit-User Ekleme işlemi başarıyla gerçekleşti.");
                MessageBox.Show("Esit-User Ekleme işlemi başarıyla gerçekleşti.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }

        public static void EsitUserDelete(string username)
        {
            string[] sqlScripts = { "USE SPWIN_DB;", "DROP USER " + username, "DROP LOGIN " + username };
            try
            {
                foreach (string sql in sqlScripts)
                {
                    if (!ExecuteNonQueryScript(sql))
                    {
                        throw new Exception("kullanıcı bulunamadı.");
                    }

                }
                MessageBox.Show("Kullanıcı silme işlemi tamamlandı", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Kullanıcı silme işlemi tamamlanamadı. " + ex.Message, "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);

                logger.Error(ex);
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
                connectionString = @"Server=" + serverName + ";Database=" + databaseName + ";User Id=" + _userName + ";Password=" + _password + ";";
            }
        }
        public static bool ConnectionTest()
        {
            try
            {
                if (serverName == "" || databaseName == "")
                {
                    MessageBox.Show("Server ismi ve Database ismi boş olamaz  \n", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                using (SqlConnection con = new SqlConnection(connectionString + " Connect Timeout=10"))
                {

                    con.Open();
                    logger.Debug("Bağlantı başarılı bir şekilde açıldı");

                    logger.Debug("Bağlantı başarılı bir şekilde kapatıldı");
                    con.Close();
                    return true;
                }
            }
            catch (Exception ex)
            {

                logger.Error("HATA Bağlantı kurulamadı! : " + ex.Message + "  \nConnection String = " + connectionString);
                MessageBox.Show("Bağlantı Oluşturulamadı.\n" + ex.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return false;
            }
        }
        public static void GetSQLServerList(ComboBox sqlServerList)
        {
            try
            {
                string machineName = Environment.MachineName;
                RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;

                using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
                {
                    RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);

                    if (instanceKey != null)
                    {
                        sqlServerList.Items.Clear();
                        sqlServerList.Items.Add(machineName);
                        foreach (var instanceName in instanceKey.GetValueNames())
                        {
                            sqlServerList.Items.Add(machineName + "\\" + instanceName); //22.07.2024
                            //sqlServerList.Items.Add(instanceName);
                        }
                    }
                }
                logger.Debug("SQL server listeleme işlemi başarılı!");
            }
            catch (Exception ex)
            {
                logger.Error("HATA SQL server listeleme işlemi başarısız! :" + ex.Message + "");
                throw new Exception("HATA SQL server listeleme işlemi başarısız! : " + ex.Message);
            }

        }
        public static void GetSQLDatabaseList(ComboBox cbxDatabase, string cbServerName)
        {
            try
            {
                cbxDatabase.Items.Clear();

                SqlConnection connect = new SqlConnection("Server= " + cbServerName + " ;Database= Master ;Trusted_Connection=True;");
                connect.Open();

                SqlCommand cmd = new SqlCommand("SELECT name FROM sys.databases where name NOT IN ('master','tempdb','model','msdb') ", connect);
                SqlDataReader DR = cmd.ExecuteReader();
                while (DR.Read())
                {
                    cbxDatabase.Items.Add(DR[0]);
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



        public static void PhotoDelete(string radioButtonTag, string time1, string time2, string picturePath)
        {
            string commandStr = "";
            try
            {
                // bütün veritabanında tüm tarihlerde işlem yapıyor
                if (time1 == "" && time2 == "")
                {

                    switch (radioButtonTag)
                    {
                        case "TagOneAndTwoPhoto":
                            OneAndTwoPhotoDelete();
                            break;

                        case "TagInTheFolderPhoto":
                            InTheFolderDelete();
                            break;

                        case "TagAllPhoto":
                            OneAndTwoPhotoDelete();
                            InTheFolderDelete();
                            break;
                    }
                }
                //Seçilen tarih aralığında işlem yapıyor
                else
                {
                    switch (radioButtonTag)
                    {
                        case "TagOneAndTwoPhoto":
                            OneAndTwoPhotoTimeDelete();
                            break;

                        case "TagInTheFolderPhoto":
                            InTheFolderTimeDelete();
                            break;

                        case "TagAllPhoto":
                            OneAndTwoPhotoTimeDelete();
                            InTheFolderTimeDelete();
                            break;
                    }
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

            void OneAndTwoPhotoDelete()
            {
                try
                {


                    // veritabanı seçildiğinde imagefile alanlarının hepsinin boş olduğu verileri silmektedir
                    //commandStr = "SELECT seq  FROM SPWIN_DB.dbo.WeighingImages \r\nWHERE \r\n((SPWIN_DB.dbo.WeighingImages.seqnum2 IN(SELECT seq FROM Weigh2)\r\nOR (SPWIN_DB.dbo.WeighingImages.seqnum1 IN (SELECT seqnum1 FROM Weigh2 )\r\nAND SPWIN_DB.dbo.WeighingImages.seqnum2 = 0  )) )AND (imageFile1 IS  NULL   AND imageFile2 IS  NULL   AND imageFile3 IS  NULL   AND imageFile4 IS  NULL)";
                    commandStr = @"
                    SELECT seq
                    FROM SPWIN_DB.dbo.WeighingImages
                    WHERE (
                        seqnum2 IN (
                            SELECT seq
                            FROM Weigh2
                        )
                        OR (
                            seqnum1 IN (
                                SELECT seqnum1
                                FROM Weigh2
                            )
                            AND WeighingImages.seqnum2 = 0
                        )
                    )
                    AND (
                        imageFile1 IS NULL
                        AND imageFile2 IS NULL
                        AND imageFile3 IS NULL
                        AND imageFile4 IS NULL
                    );";
                    DataTable dataTable = ExecuteReaderScript(commandStr, 0);
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string deleteCommand = "DELETE FROM SPWIN_DB.dbo.WeighingImages WHERE seq = " + row["seq"];
                        ExecuteNonQueryScript(deleteCommand, 10);
                    }
                    MessageBox.Show("Veritabanından fotoğrafları silme işlemi tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    logger.Error(ex.Message + " " + ex.Source);

                    throw;
                }
            }
            void OneAndTwoPhotoTimeDelete()
            {
                try
                {
                    //int count = 0;
                    // veritabanı seçildiğinde imagefile alanlarının hepsinin boş olduğu verileri silmektedir
                    //commandStr = $"SELECT seq  FROM SPWIN_DB.dbo.WeighingImages \r\nWHERE \r\n((SPWIN_DB.dbo.WeighingImages.seqnum2 IN(SELECT seq FROM Weigh2 WHERE WeighTime2 BETWEEN '{time1}' AND '{time2}' ) \r\nOR (SPWIN_DB.dbo.WeighingImages.seqnum1 IN (SELECT seqnum1 FROM Weigh2 WHERE WeighTime2 BETWEEN '{time1}' AND '{time2}'  )\r\nAND SPWIN_DB.dbo.WeighingImages.seqnum2 = 0  )) )AND (imageFile1 IS  NULL   AND imageFile2 IS  NULL   AND imageFile3 IS  NULL   AND imageFile4 IS  NULL)";
                    commandStr = $@"
                                        SELECT seq
                    FROM SPWIN_DB.dbo.WeighingImages
                    WHERE (
                        (
                            seqnum2 IN (
                                SELECT Weigh2.seq
                                FROM Weigh2
                                WHERE Weigh2.WeighTime2 BETWEEN '{time1}' AND '{time2}'
                            )
                            OR (
                                seqnum1 IN (
                                    SELECT Weigh2.seqnum1
                                    FROM Weigh2
                                    WHERE Weigh2.WeighTime2 BETWEEN '{time1}' AND '{time2}'
                                )
                                AND WeighingImages.seqnum2 = 0
                            )
                        )
                    )
                    AND (
                        imageFile1 IS NULL
                        AND imageFile2 IS NULL
                        AND imageFile3 IS NULL
                        AND imageFile4 IS NULL
                    )";
                    DataTable dataTable = ExecuteReaderScript(commandStr, 0);
                    foreach (DataRow row in dataTable.Rows)
                    {
                        string deleteCommand = "DELETE FROM SPWIN_DB.dbo.WeighingImages WHERE seq = " + row["seq"];
                        ExecuteNonQueryScript(deleteCommand, 10);
                        //count++;
                    }
                    MessageBox.Show("Veritabanından fotoğrafları silme işlemi tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //Console.Write("işlem gören satır sayısı: " +count +"\n");
                }
                catch (Exception ex)
                {
                    logger.Error(ex.Message + " " + ex.Source);

                    throw;
                }
            }

            void InTheFolderDelete()
            {
                try
                {
                    //commandStr = "SELECT seq , imageFile1 , imageFile2 , imageFile3 , imageFile4  FROM SPWIN_DB.dbo.WeighingImages \r\nWHERE \r\n((SPWIN_DB.dbo.WeighingImages.seqnum2 IN(SELECT seq FROM Weigh2)\r\nOR (SPWIN_DB.dbo.WeighingImages.seqnum1 IN (SELECT seqnum1 FROM Weigh2 )\r\nAND SPWIN_DB.dbo.WeighingImages.seqnum2 = 0  ))) AND (imageFile1 IS NOT NULL   OR imageFile2 IS NOT NULL   OR imageFile3 IS NOT NULL   OR imageFile4 IS NOT NULL)\r\norder by seq";
                    commandStr = $@"
                    SELECT seq, imageFile1, imageFile2, imageFile3, imageFile4
                    FROM SPWIN_DB.dbo.WeighingImages
                    WHERE (
                        seqnum2 IN (
                            SELECT seq
                            FROM Weigh2
                        )
                        OR (
                            seqnum1 IN (
                                SELECT seqnum1
                                FROM Weigh2
                            )
                            AND seqnum2 = 0
                        )
                    )
                    AND (
                        imageFile1 IS NOT NULL
                        OR imageFile2 IS NOT NULL
                        OR imageFile3 IS NOT NULL
                        OR imageFile4 IS NOT NULL
                    )
                    ORDER BY seq;";
                    DataTable pictureFileNames = ExecuteReaderScript(commandStr, 0);
                    FileHelper.DeletePictureFile(picturePath, pictureFileNames);
                    MessageBox.Show($"{picturePath} \nDosya konumundan fotoğrafları silme işlemi tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    logger.Error(ex.Message + " " + ex.Source);

                    throw;
                }
            }

            void InTheFolderTimeDelete()
            {
                try
                {
                    commandStr = $@"
                    SELECT seq, imageFile1, imageFile2, imageFile3, imageFile4
                    FROM SPWIN_DB.dbo.WeighingImages
                    WHERE (
                        (WeighingImages.seqnum2 IN (
                            SELECT seq
                            FROM Weigh2
                            WHERE WeighTime2 BETWEEN '{time1}' AND '{time2}'
                        )
                        OR (WeighingImages.seqnum1 IN (
                            SELECT seqnum1
                            FROM Weigh2
                            WHERE WeighTime2 BETWEEN '{time1}' AND '{time2}'
                        ) AND seqnum2 = 0))
                    )
                    AND (imageFile1 IS NOT NULL
                    OR imageFile2 IS NOT NULL
                    OR imageFile3 IS NOT NULL
                    OR imageFile4 IS NOT NULL)
                    ORDER BY seq";
                    DataTable pictureFileNames = ExecuteReaderScript(commandStr, 0);
                    FileHelper.DeletePictureFile(picturePath, pictureFileNames);
                    MessageBox.Show("Dosya konumundan fotoğrafları silme işlemi tamamlandı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    logger.Error(ex.Message + " " + ex.Source);

                    throw;
                }
            }
        }
        public static void WeighingDelete(string tartim, string time1, string time2)
        {
            string commandStr = "";
            string tabloName = "";
            if (tartim == "rbTartim1")
            {
                tabloName = "dbo.Weigh1";
            }
            else if (tartim == "rbTartim2")
            {
                tabloName = "dbo.Weigh2";
            }
            try
            {
                if (time1 == "" && time2 == "")
                {
                    //veritabanında tarih kısıtlaması olmadan çalışıyor
                    switch (tartim)
                    {
                        case "rbTartim1":
                            commandStr = "select seq from dbo.Weigh1 where WeighTime1 < GETDATE();";
                            break;

                        case "rbTartim2":
                            commandStr = "select seq from dbo.Weigh2 where WeighTime1 < GETDATE();";
                            break;
                    }
                }
                else
                {
                    //Seçilen tarih aralığında çalışıyor
                    switch (tartim)
                    {
                        case "rbTartim1":
                            commandStr = "select seq from Weigh1 where WeighTime1 between '" + time1 + "' and '" + time2 + "';";
                            break;

                        case "rbTartim2":
                            commandStr = "select seq from Weigh2 where WeighTime1 between '" + time1 + "' and '" + time2 + "';";
                            break;
                    }
                }


                DataTable datatable = ExecuteReaderScript(commandStr, 0);
                foreach (DataRow row in datatable.Rows)
                {

                    ExecuteNonQueryScript("delete from " + tabloName + " where seq = " + row["seq"] + ";");
                }



                MessageBox.Show("Tartım silme işlemi başarıyla gerçekleşti.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                logger.Info("tartım tablosu silme işlemi" + commandStr + "kodu ile gerçekleşti");
                logger.Debug("Tartım silme işlemi başarıyla gerçekleşti.");


            }
            catch (Exception ex)
            {
                Thread.Sleep(1000);
                MainForm.waitForm.Close();
                Application.DoEvents();
                logger.Error("Tartım silme işlemi başarısız. : " + ex.Message);
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
                else
                {
                    MessageBox.Show("Veri Taşıma işleminde Etkilenen satır bulunamadı ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Veri taşıma işlemi başarılı! - Liman Listesi taşındı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Veri Taşıma işleminde Etkilenen satır bulunamadı ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                else
                {
                    MessageBox.Show("Veri Taşıma işleminde Etkilenen satır bulunamadı ", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            try
            {
                string SQLScript = "select seq,seqnum1,CName4,CName5,CName6,CName9,CName10,Code4,Code9 from SPWIN_DB.dbo.Weigh2 where (CName4 IS NOT NULL and CName4 <> '') and (CName5 IS NOT NULL and CName5 <> '') and (CName9 IS NOT NULL and CName9 <> '') and (DbaWeigh2Id IS NULL or DbaWeigh2Id = '' or DbaWeigh2Id = 0)";

                DataTable dataTable = new DataTable();
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
                        "\n" + errorCount + " tane hatalı işlem gerçekleşti" +
                        "\n" + (dataTable.Rows.Count - errorCount).ToString() + " tane hatasız işlem gerçekleşti");
                    MessageBox.Show((dataTable.Rows.Count - errorCount).ToString() + " Adet veri taşıma işlemi başarılı! - DBA_Dataları taşındı", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                logger.Error("Veri taşıma işlemi başarısız: " + ex.Message);
                MessageBox.Show("HATA Veri taşıma işlemi başarısız : " + ex.Message + "", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static bool AuditStopedScriptRun(string serverInstance )
        {
            try
            {
                if (serverInstance == "")
                {
                    serverStart("SQLEXPRESS");
                }
                else
                {
                    serverStart(serverInstance);
                }
                
                string[] sqlCommands = new string[]
                {
                    "ALTER DATABASE AUDIT_SPWIN SET EMERGENCY;",
                    "DBCC CHECKDB('AUDIT_SPWIN');",
                    "ALTER DATABASE AUDIT_SPWIN SET SINGLE_USER WITH ROLLBACK IMMEDIATE;",
                    "DBCC CHECKDB('AUDIT_SPWIN', REPAIR_ALLOW_DATA_LOSS);",
                    "ALTER DATABASE AUDIT_SPWIN SET MULTI_USER;"
                };
                foreach (string sqlCommand in sqlCommands)
                {
                    if (!ExecuteNonQueryScript(sqlCommand, 0))
                    {
                        MessageBox.Show(sqlCommand + " \nçalıştırılamadı scripti tekrar çalıştırın", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                return false;
            }
        }
        public static bool SpwinStopedScriptRun(string serverInstance)
        {
            try
            {
                if (serverInstance == "")
                {
                    serverStart("SQLEXPRESS");
                }
                else
                {
                    serverStart(serverInstance);
                }
                string[] sqlCommands = new string[]
                {
                    "ALTER DATABASE SPWIN_DB SET EMERGENCY;",
                    "DBCC CHECKDB('SPWIN_DB');",
                    "ALTER DATABASE SPWIN_DB SET SINGLE_USER WITH ROLLBACK IMMEDIATE;",
                    "DBCC CHECKDB (SPWIN_DB, REPAIR_ALLOW_DATA_LOSS);",
                    "ALTER DATABASE SPWIN_DB SET MULTI_USER;"
                };

                foreach (string sqlCommand in sqlCommands)
                {
                    if (!ExecuteNonQueryScript(sqlCommand, 0))
                    {
                        MessageBox.Show(sqlCommand + " \nçalıştırılamadı scripti tekrar çalıştırın", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return false;
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                logger.Error(ex);
                return false;
            }
        }
        public static void serverStart(string instanceName = "SQLEXPRESS")
        {
            string batFileContent = $@"
            net start SQLBrowser
            net start MSSQL${instanceName}
            net start {instanceName}
            pause

            ";

            string tempBatFilePath = Path.Combine(Path.GetTempPath(), "tempServerStartScript.bat");
            try
            {
                // Geçici dosyaya içeriği yaz
                File.WriteAllText(tempBatFilePath, batFileContent);

                // ProcessStartInfo ile dosyayı çalıştır
                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = tempBatFilePath,
                    UseShellExecute = true,
                    Verb = "runas"
                };

                Process process = Process.Start(processStartInfo);
                process.WaitForExit();
                if (process.ExitCode != 0)
                {
                    throw new Exception("BAT dosyası çalıştırılırken hata oluştu.");
                }

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Server başlatımında hata oluştu. " + ex.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                logger.Error("Server başlatımında hata oluştu " + ex);
            }
            finally
            {
                // Geçici dosyayı temizle
                if (File.Exists(tempBatFilePath))
                {
                    try
                    {
                        File.Delete(tempBatFilePath);
                    }
                    catch (Exception deleteEx)
                    {
                        // Dosya silinirken hata oluştuysa, bunu loglayabilirsiniz.
                        logger.Error("Geçici BAT dosyası silinirken hata oluştu: " + deleteEx.Message);
                    }
                }
            }

        }
        public static void serverKontrol(string instanceName)
        {
            string batFileContent = $@"
            @echo off
            echo Checking SQL Server services status...
            
            wmic service where ""name='MSSQL${instanceName}'"" get name, state
            wmic service where ""name='{instanceName}'"" get name, state
            wmic service where ""name='SQLBrowser'"" get name, state
            pause
            exit /b 0
            ";

            string tempBatFilePath = Path.Combine(Path.GetTempPath(), "tempServerStartScript.bat");
            
            try
            {
                // Geçici dosyaya içeriği yaz
                File.WriteAllText(tempBatFilePath, batFileContent);

                // ProcessStartInfo ile dosyayı çalıştır
                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = tempBatFilePath,
                    UseShellExecute = true,
                    Verb = "runas"
                };

                Process process = Process.Start(processStartInfo);
                process.WaitForExit();
                


            }
            catch (Exception ex)
            {
                MessageBox.Show("Server kontrolünde hata oluştu. " + ex.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                logger.Error("Server kontrolünde hata oluştu " + ex);
            }
            finally
            {
                // Geçici dosyayı temizle
                if (File.Exists(tempBatFilePath))
                {
                    try
                    {
                        File.Delete(tempBatFilePath);
                    }
                    catch (Exception deleteEx)
                    {
                        // Dosya silinirken hata oluştuysa, bunu loglayabilirsiniz.
                        logger.Error("Geçici BAT dosyası silinirken hata oluştu: " + deleteEx.Message);
                    }
                }
            }
        }


        public static void ServerConfigSettingsSetter(string instanceName = "SQLEXPRESS")
        {
            // Çalıştırılacak .bat dosyasının adı
            string batFileContent = $@"
net start SQLBrowser

net start MSSQL${instanceName}





netsh advfirewall firewall add rule name=""Open Port 8080"" dir=in action=allow protocol=TCP localport=8080
netsh http add urlacl url=http://+:8080/ user=Everyone
netsh advfirewall firewall add rule name=""Open Port 80"" dir=in action=allow protocol=TCP localport=80

@echo =========  SQL Server Start Mode  ===================
sc config ""{instanceName}"" start= auto
sc config ""SQLBrowser"" start= auto




@echo =========  SQL Server Ports  ===================
@echo Enabling SQLServer default instance port 1433
netsh advfirewall firewall add rule name=""SQL Server"" dir=in action=allow protocol=TCP localport=1433
@echo Enabling Dedicated Admin Connection port 1434
netsh advfirewall firewall add rule name=""SQL Admin Connection"" dir=in action=allow protocol=TCP localport=1434
@echo Enabling Conventional SQL Server Service Broker port 4022
netsh advfirewall firewall add rule name=""SQL Service Broker"" dir=in action=allow protocol=TCP localport=4022
@echo Enabling Transact SQL/RPC port 135
netsh advfirewall firewall add rule name=""SQL Debugger/RPC"" dir=in action=allow protocol=TCP localport=135

@echo =========  Analysis Services Ports  ==============
@echo Enabling SSAS Default Instance port 2383
netsh advfirewall firewall add rule name=""Analysis Services"" dir=in action=allow protocol=TCP localport=2383
@echo Enabling SQL Server Browser Service port 2382
netsh advfirewall firewall add rule name=""SQL Browser"" dir=in action=allow protocol=TCP localport=2382

@echo =========  Misc Applications  ==============
@echo Enabling HTTP port 80
netsh advfirewall firewall add rule name=""HTTP"" dir=in action=allow protocol=TCP localport=80
@echo Enabling SSL port 443
netsh advfirewall firewall add rule name=""SSL"" dir=in action=allow protocol=TCP localport=443
@echo Enabling port for SQL Server Browser Service's 'Browse' Button
netsh advfirewall firewall add rule name=""SQL Browser"" dir=in action=allow protocol=UDP localport=1434
@echo Allowing multicast broadcast response on UDP (Browser Service Enumerations OK)
netsh firewall set multicastbroadcastresponse ENABLE

@echo =========  File Access Privileges  ==============
cd /d %~dp0
cmd.exe /c ""icacls ""%cd%"" /grant Everyone:(OI)(CI)M""

@echo =========  Server Restart  ==============


net stop SQLBrowser
net stop MSSQL${instanceName}

net start SQLBrowser
net start MSSQL${instanceName}

pause
";
            //sc start MSSQL${serverName}
            //sc start SQLBrowser
            string tempBatFilePath = Path.Combine(Path.GetTempPath(), "tempServerConfigScript.bat");
            try
            {
                // Geçici dosyaya içeriği yaz
                File.WriteAllText(tempBatFilePath, batFileContent);

                // ProcessStartInfo ile dosyayı çalıştır
                ProcessStartInfo processStartInfo = new ProcessStartInfo
                {
                    FileName = tempBatFilePath,
                    UseShellExecute = true,
                    Verb = "runas"
                };

                Process process = Process.Start(processStartInfo);
                process.WaitForExit();
                if (process.ExitCode != 0)
                {
                    throw new Exception("BAT dosyası çalıştırılırken hata oluştu.");
                }

                MessageBox.Show("Server Configuration Ayarları Düzenlendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Server Configuration Ayarları Düzenlenmesinde hata oluştu. " + ex.Message, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                logger.Error("Server Configuration Ayarları Düzenlenmesinde hata oluştu " + ex);
            }
            finally
            {
                // Geçici dosyayı temizle
                if (File.Exists(tempBatFilePath))
                {
                    try
                    {
                        File.Delete(tempBatFilePath);
                    }
                    catch (Exception deleteEx)
                    {
                        // Dosya silinirken hata oluştuysa, bunu loglayabilirsiniz.
                        logger.Error("Geçici BAT dosyası silinirken hata oluştu: " + deleteEx.Message);
                    }
                }
            }




        }

        public static void SQLConfigTcpIpAccessAndPortSetter(string serverName, bool enableFlag = true, bool listenAllFlag = true, int portNo = 1433)
        {

            try
            {

                RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;

                using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
                {
                    string[] possiblePaths = new string[]
                {
                @"SOFTWARE\Microsoft\Microsoft SQL Server",
                @"SOFTWARE\Wow6432Node\Microsoft\Microsoft SQL Server" // 32-bit uygulama yoldan
                };
                    // SQL Server sürümünü bulmak için kayıt defterini kontrol etme
                    string[] versionPaths = new string[]
                    {
                        "MSSQL16."+serverName, // SQL Server 2022 Express
                        "MSSQL15."+serverName, // SQL Server 2019 Express
                        "MSSQL14."+serverName, // SQL Server 2017 Express
                        "MSSQL13."+serverName, // SQL Server 2016 Express
                        "MSSQL12."+serverName, // SQL Server 2014 Express
                        "MSSQL11."+serverName, // SQL Server 2012 Express
                        "MSSQL10_50."+serverName, // SQL Server 2008 R2 Express
                        "MSSQL10."+serverName, // SQL Server 2008 Express
                        "MSSQL.1"  // SQL Server 2005 Express
                    };
                    // SQL Server'ın yüklü olduğu sürümü bulma
                    string keyPath = null;
                    foreach (var path in possiblePaths)
                    {
                        foreach (var versionPath in versionPaths)
                        {
                            string fullKeyPath = $"{path}\\{versionPath}\\MSSQLServer\\SuperSocketNetLib\\Tcp";
                            using (RegistryKey key = hklm.OpenSubKey(fullKeyPath))
                            {
                                if (key != null)
                                {
                                    keyPath = fullKeyPath;
                                    break;
                                }
                            }
                            Console.WriteLine(fullKeyPath);
                        }
                        if (keyPath != null)
                        {
                            break;
                        }
                    }
                    if (keyPath != null)
                    {

                        using (RegistryKey key = hklm.OpenSubKey(keyPath, true))
                        {
                            if (key != null)
                            {
                                //TCP / IP'yi etkinleştirme
                                key.SetValue("Enabled", Convert.ToInt32(enableFlag), RegistryValueKind.DWord);
                                key.SetValue("ListenOnAllIPs", Convert.ToInt32(listenAllFlag), RegistryValueKind.DWord);
                            }
                            else
                            {
                                MessageBox.Show("Kayıt defteri anahtarı yazma izniyle açılmadı.");
                            }
                        }
                        using (RegistryKey key = hklm.OpenSubKey(keyPath + "\\IPAll", true))
                        {
                            if (key != null)
                            {
                                //TCP / IP port numarasını ayarlama
                                // Değiştirmek istediğiniz port numarası port no olarak metoda geliyor
                                key.SetValue("TcpPort", portNo, RegistryValueKind.String);
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("SQL Server kayıt defteri anahtarı bulunamadı.");
                    }
                }
            }
            catch (System.Security.SecurityException ex)
            {
                MessageBox.Show("Uygulama yönetici olarak çalıştırılmadı.\n Bu işlem için lütfen uygulamayı Yönetici olarak başlatın.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Error);
                logger.Error("config düzenleyici hatası :", ex);
            }
        }

    }
}
