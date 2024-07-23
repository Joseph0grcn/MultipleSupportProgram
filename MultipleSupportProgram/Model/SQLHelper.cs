using log4net.Repository.Hierarchy;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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

        public static SqlCommand SqlCmd(string quary, SqlConnection connection)
        {
            //
            return null;
        }
        public static SqlConnection ConnectionOpenClose(String action)
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                if (action == "open" || action == "Open")
                {
                    con.Open();
                    logger.Debug("Bağlantı başarılı bir şekilde açıldı");
                }
                else if (action == "close" || action == "Close")
                {
                    con.Close();
                    logger.Debug("Bağlantı başarılı bir şekilde kapatıldı");
                }
                return con;
            }
        }

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
                        Console.WriteLine("SQL script başarıyla çalıştırıldı.");
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
        public object ExecuteScalarScript(string sqlScript)
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

        public static void BackupDB(string databaseName, string backupFileLocation, string getConString)
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

            if (windowsAuthentication == true)
            {
                connectionString = "Server=" + serverName + ";Database=" + databaseName + ";Trusted_Connection=True;";
            }
            else
            {
                connectionString = @"Server=" + serverName + "; Database=" + databaseName + "; User Id= " + userName + " ; Password=" + password + ";";
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
                    logger.Debug("Bağlantı Başarılı.");
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
                            //sqlServerList.Items.Add(ServerName + "\\" + instanceName); //22.07.2024
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














































    }
}
