using log4net.Repository.Hierarchy;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace MultipleSupportProgram.Model
{
    public class UpdateDbaToScale
    {
        public log4net.ILog logger = log4net.LogManager.GetLogger("UpdateDbaToScale");
        string commandStr;
        bool result=false;
        


        public void MoveDba_Data(DataTable dataTable, string getConString)
        {
            commandStr = "";
            string carrierCompany, containerNo,  portList, portListCode, carrierCompanyCode;
            int containerMaxWeight, attractiveWeight, trailerWeight;
            try
            {
                using (SqlConnection con = new SqlConnection(getConString))
                {
                    con.Open();
                    foreach (DataRow row in dataTable.Rows)
                    {
                        carrierCompany = row["CName4"].ToString();
                        containerNo = row["CName5"].ToString();
                       int.TryParse(row["CName6"].ToString(), out containerMaxWeight);
                        attractiveWeight = 0;
                        trailerWeight = 0;
                        portList = row["CName9"].ToString();
                        portListCode = row["Code9"].ToString();
                        carrierCompanyCode = row["Code4"].ToString();

                        commandStr = "INSERT INTO SPWIN_DB.dbo.DBA_Data(" +
                                     "CarrierCompany,ContainerNo,ContainerMaxWeight,AttractiveWeight,TrailerWeight,PortList,PortListCode,CarrierCompanyCode) " +
                                     "VALUES ('" + carrierCompany + "','" + containerNo + "'," + containerMaxWeight + "," + attractiveWeight + "," + trailerWeight + ",'" + portList + "','" + portListCode + "','" + carrierCompanyCode + "'); " +
                                     "UPDATE SPWIN_DB.dbo.Weigh2 set DbaWeigh2Id =IDENT_CURRENT('SPWIN_DB.dbo.DBA_Data') where seq =" + row["seq"].ToString() + " ;" +
                                     "UPDATE SPWIN_DB.dbo.Weigh1 set DbaWeigh1Id =IDENT_CURRENT('SPWIN_DB.dbo.DBA_Data') where seq =" + row["seqnum1"].ToString();
                        SqlCommand command = new SqlCommand(commandStr, con);
                        result = Convert.ToBoolean(command.ExecuteNonQuery());
                    }

                    con.Close();
                    if (result)
                    {
                        logger.Debug("Veri taşıma işlemi başarılı! - DBA_Dataları taşındı");
                        MessageBox.Show (dataTable.Rows.Count.ToString() + " Adet veri taşıma işlemi başarılı! - DBA_Dataları taşındı");
                    }
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
