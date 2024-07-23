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
        


        


        

        // ekleme 
        public void FindTableColums(string getConString, string databaseName ,string tableName,CheckedListBox checkedListBox)
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
