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
using Microsoft.SqlServer.Server;

namespace MultipleSupportProgram.Model
{
    public class SQLFileRun
    {
        public log4net.ILog logger = log4net.LogManager.GetLogger("SQLFileRun");
        

        
        public void EsitUserAdd(string getConString)
        {
            try
            {
                
                string userAddScriptText = @"CREATE LOGIN esit_user WITH PASSWORD=N'esit12345', 
                DEFAULT_DATABASE=[SPWIN_DB], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF,
                CHECK_POLICY=OFF EXEC master..sp_addsrvrolemember @loginame = N'esit_user', @rolename = N'sysadmin'";
                SqlConnection connect = new SqlConnection(getConString);
                bool result = false;
                string[] commandTextArray = userAddScriptText.Split(new string[] { "GO" }, StringSplitOptions.RemoveEmptyEntries);
                connect.Open();
                foreach (string commandText in commandTextArray)
                {
                    if (commandText.Trim() == string.Empty) continue;
                    SqlCommand command = new SqlCommand(commandText, connect);
                    command.CommandTimeout = 0;
                    result = Convert.ToBoolean(command.ExecuteNonQuery());
                }
                connect.Close();
                if (!result)
                {
                    Thread.Sleep(500);
                    MainForm.waitForm.Close();
                    Application.DoEvents();
                    logger.Error("Esit-User Ekleme işlemi başarısız!");
                    MessageBox.Show("Esit-User Ekleme işlemi başarısız!", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    Thread.Sleep(500);
                    MainForm.waitForm.Close();
                    Application.DoEvents();
                    logger.Debug("Esit-User Ekleme işlemi başarıyla gerçekleşti.");
                    MessageBox.Show("Esit-User Ekleme işlemi başarıyla gerçekleşti.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                Thread.Sleep(500);
                MainForm.waitForm.Close();
                Application.DoEvents();
                logger.Error("Esit-User Ekleme işlemi başarısız! : \n" + ex.Message);
                MessageBox.Show("Esit-User Ekleme işlemi başarısız! : \n" + ex.Message + "", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
