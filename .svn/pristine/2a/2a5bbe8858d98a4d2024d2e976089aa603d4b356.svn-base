using System;
using System.Collections.Generic;
using System.Data.Sql;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using ComboBox = System.Windows.Forms.ComboBox;
using System.Threading;

namespace MultipleSupportProgram.Model
{
    public class SQLFileRun
    {
        public log4net.ILog logger = log4net.LogManager.GetLogger("SQLFileRun");
        public string SQLFileSelect()
        {
            OpenFileDialog file = new OpenFileDialog();
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

        public void SQLRun(string sqlFile, string getConString)
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
                SqlConnection connect = new SqlConnection(getConString);
                bool result = false;
                string[] commandTextArray = scriptText.Split(new string[] { "GO" }, StringSplitOptions.RemoveEmptyEntries);
                connect.Open();
                foreach (string commandText in commandTextArray)
                {
                    if (commandText.Trim() == string.Empty) continue;
                    SqlCommand command = new SqlCommand(commandText, connect);
                    result = Convert.ToBoolean(command.ExecuteNonQuery());
                }
                connect.Close();
                if (!result)
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

    }
}
