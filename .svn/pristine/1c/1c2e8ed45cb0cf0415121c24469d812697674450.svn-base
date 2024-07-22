using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Remoting.Contexts;
using static System.Net.WebRequestMethods;
using System.Threading;

namespace MultipleSupportProgram.Model
{
    public class Backup
    {
        public log4net.ILog logger = log4net.LogManager.GetLogger("Backup");
        public string BackupFileLocation()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                return folderBrowserDialog.SelectedPath;
            }
            return null;
        }

        public void BackupDB(string databaseName, string backupFileLocation, string getConString)
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
                SqlCommand command = new SqlCommand();
                SqlConnection connect = new SqlConnection(getConString);
                command = new SqlCommand(@"backup database " + databaseName + " to disk = @directory with init,stats=10", connect);
                command.Parameters.AddWithValue("@directory", string.Concat("" + backupFileLocation + "", "" + databaseName + "_" + DateTime.Now.ToString("MM_dd_yyyy_HH_mm_ss") + ".bak"));
                connect.Open();
                bool result = Convert.ToBoolean(command.ExecuteNonQuery());
                connect.Close();
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
                //MessageBox.Show("HATA Backup işlemi başarısız! : " + ex.Message + "", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

    }
}
