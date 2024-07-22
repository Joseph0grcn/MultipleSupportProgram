using System;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Common;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;
using log4net.Repository.Hierarchy;
using Microsoft.Win32;
using System.Threading;

namespace MultipleSupportProgram.Model
{
    public class DatabaseProcess
    {
        public log4net.ILog logger = log4net.LogManager.GetLogger("DatabaseProcess");
        public string GetConString(Boolean windowsAuthentication, string server, string username, string password, string database)
        {
            string ConString ;
            if (windowsAuthentication==true)
            {
                ConString = "Server=" + server + ";Database=" + database + ";Trusted_Connection=True;";
            }
            else
            {
                ConString = @"Server=" + server + "; Database=" + database + "; User Id= " + username + " ; Password=" + password + ";";
                //ConString = "Data Source=" + server + ";Initial Catalog=" + database + ";User Id=" + username + ";Password=" + password + ";";
            }
            return ConString;
        }


        public void ConnectionTest(Boolean windowsAuthentication, string server, string username, string password, string database)
        {
            
            try
            {
                SqlConnection con = new SqlConnection(GetConString(windowsAuthentication, server, username, password, database));
                
                    
                    con.Open();
                    Thread.Sleep(1000);
                    MainForm.waitForm.Close();
                    Application.DoEvents();
                    logger.Debug("Bağlantı Başarılı.");
                    MessageBox.Show("Bağlantı Başarılı.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                
            }
            catch (Exception ex)
            {

                
                logger.Error("HATA Bağlantı kurulamadı! : " + ex.Message + "");
               throw new Exception("HATA Bağlantı kurulamadı : " + ex.Message);
                
            }
        }

        public void GetSQLServerList(ComboBox sqlServerList)
        {
            try
            {
                //System.Data.Sql.SqlDataSourceEnumerator instance =  System.Data.Sql.SqlDataSourceEnumerator.Instance;
                //DataTable dt = SqlDataSourceEnumerator.Instance.GetDataSources();
                //DataTable dt = System.Data.Sql.Smo.SmoApplication.EnumAvailableSqlServers();
                //DataTable dt = SmoApplication.EnumAvailableSqlServers(true);
                string ServerName = Environment.MachineName;

                RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;

                using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))

                {

                    RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);

                    if (instanceKey != null)

                    {

                        sqlServerList.Items.Clear();

                        foreach (var instanceName in instanceKey.GetValueNames())
                        {
                            sqlServerList.Items.Add(ServerName + "\\" + instanceName);
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

        //public void GetSQLDatabaseList(string getConString, ComboBox[] comboBoxDatabase, string serverName = "master")
        public void GetSQLDatabaseList(string getConString, ComboBox[] comboBoxDatabase)
        {
            try
            {
                foreach (ComboBox cbxDatabase in comboBoxDatabase) { cbxDatabase.Items.Clear(); }

                SqlConnection connect = new SqlConnection(getConString);
                connect.Open();

                SqlCommand cmd = new SqlCommand("SELECT name FROM sys.databases where name NOT IN ('master','tempdb','model','msdb') ", connect);
                //SqlCommand cmd = new SqlCommand("SELECT name FROM sys.databases where name NOT IN ('master','tempdb','model','msdb') AND SERVERPROPERTY('MachineName') = '"+serverName+"'", connect);


                SqlDataReader DR = cmd.ExecuteReader();

                while (DR.Read())
                {
                    foreach (var cbxItem in comboBoxDatabase)
                    {
                        cbxItem.Items.Add(DR[0]);
                    }
                }
                connect.Close();
                //MessageBox.Show("SQL database listeleme işlemi başarıyla gerçekleşti.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                logger.Error("HATA SQL database listeleme işlemi başarısız! : " + ex.Message + "");

                throw new Exception("HATA SQL database listeleme işlemi başarısız! : " + ex.Message, ex);
            }



        }
        public void FindDbUsers(ComboBox cbxDbUsers, string getConString, string databaseName)
        {
            try
            {   cbxDbUsers.Items.Clear();
                SqlConnection connect = new SqlConnection(getConString);
                connect.Open();
                //SqlCommand cmd = new SqlCommand("SELECT suser_sname(owner_sid) as 'Owner', state_desc, * from sys.databases", connect);//eski
                SqlCommand cmd = new SqlCommand("USE " + databaseName + "; SELECT name, type_desc FROM sys.sql_logins WHERE type IN('S','U','G') AND is_disabled IN('0')  ;", connect);
                SqlDataReader DR = cmd.ExecuteReader();
                while (DR.Read())
                {
                    cbxDbUsers.Items.Add(DR[0]);
                }
                //for (int i = 0; i < cbxDbUsers.Items.Count; i++)
                //{
                //    for (int y = 0; y < cbxDbUsers.Items.Count; y++)
                //    {
                //        if (y != i && cbxDbUsers.Items[i].ToString() == cbxDbUsers.Items[y].ToString())
                //        {
                //            cbxDbUsers.Items.RemoveAt(i);
                //            break;
                //        }
                //    }
                //}
                connect.Close();
            }
            catch (Exception ex)
            {
                logger.Error("HATA SQL database user listeleme işlemi başarısız! : " + ex.Message + "");
                throw new Exception("HATA SQL database user listeleme işlemi başarısız! : " + ex.Message );
                
            }

        }

        // ekleme 
        public void FindTbColum(string getConString, string databaseName ,string tableName,CheckedListBox checkedListBox)
        {
            try
            {
                checkedListBox.Items.Clear();
                SqlConnection connect = new SqlConnection(getConString);
                connect.Open();
                SqlCommand cmd = new SqlCommand("USE " + databaseName + "; SELECT column_name FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '"+tableName+"';", connect);
                SqlDataReader DR = cmd.ExecuteReader();
                while(DR.Read())
                {
                    checkedListBox.Items.Add(DR[0]);
                }
                connect.Close();
            }
            catch (Exception ex )
            {
                logger.Error("HATA SQL table column listeleme işlemi başarısız! : " + ex.Message + "");
                throw new Exception("HATA SQL table column listeleme işlemi başarısız! : " + ex.Message);
            }
        }



        

        



    }
}
