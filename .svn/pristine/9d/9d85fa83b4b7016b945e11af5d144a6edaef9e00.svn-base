using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MultipleSupportProgram.Model
{
    public class Restore
    {
        public log4net.ILog logger = log4net.LogManager.GetLogger("Restore");

        public string RestoreFile() 
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

        public void RestoreDB(string databaseName, string restoreFilePath, string getConString) {
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
                using (SqlConnection con = new SqlConnection(getConString))
                {
                    string command = "use master RESTORE DATABASE @DatabaseName FROM DISK = @BackUpPath WITH REPLACE";
                    using (SqlCommand sqlcommand = new SqlCommand(command, con))
                    {
                        sqlcommand.Parameters.Add("@DatabaseName", SqlDbType.VarChar);
                        sqlcommand.Parameters["@DatabaseName"].Value = databaseName;

                        sqlcommand.Parameters.AddWithValue("@BackUpPath", restoreFilePath);
                        con.Open();
                        bool result = Convert.ToBoolean(sqlcommand.ExecuteNonQuery());
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
    }
}
