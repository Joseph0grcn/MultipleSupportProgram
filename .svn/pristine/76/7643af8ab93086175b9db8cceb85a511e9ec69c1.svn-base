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
        public void MoveCarrierCompany(string getConString) { /* Taşıyıcı Firma'alanına taşınacak */
            commandStr = "";
            try
            {
                using (SqlConnection con = new SqlConnection(getConString))
                {
                    con.Open();
                    commandStr = "INSERT INTO SPWIN_DB.dbo.Firm(FirmCode, FirmName) SELECT TOP 100 SPWIN_DB.dbo.Code_4.Code, SPWIN_DB.dbo.Code_4.Name FROM SPWIN_DB.dbo.Code_4 LEFT JOIN SPWIN_DB.dbo.Firm on (SPWIN_DB.dbo.Code_4.Code = SPWIN_DB.dbo.Firm.FirmCode and SPWIN_DB.dbo.Firm.FirmName = SPWIN_DB.dbo.Code_4.Name) where SPWIN_DB.dbo.Firm.FirmCode is null and SPWIN_DB.dbo.Firm.FirmName is null";
                    SqlCommand command = new SqlCommand(commandStr, con);
                    result = Convert.ToBoolean(command.ExecuteNonQuery());
                    con.Close();
                    if (result)
                    {
                        MainForm.waitForm.Close();
                        logger.Debug("Veri taşıma işlemi başarılı! - Taşıyıcı Firma --> Firma listesine eklendi");
                        MessageBox.Show("Veri taşıma işlemi başarılı! - Taşıyıcı Firma --> Firma listesine eklendi", "BİLGİ",MessageBoxButtons.OK,MessageBoxIcon.Information);

                    }
                }
            }
            catch (Exception ex)
            {
                
                MainForm.waitForm.Close();
                logger.Error("Veri taşıma işlemi başarısız: " + ex.Message);
                MessageBox.Show("HATA : " + ex.Message + "", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void MovePortList(string getConString)
        { /* Liman Listesi'alanına taşınacak */
            commandStr = "";
            try
            {
                using (SqlConnection con = new SqlConnection(getConString))
                {
                    con.Open();
                    commandStr = "INSERT INTO SPWIN_DB.dbo.Code_DBA(Code, Name, Definition, FieldNo) SELECT TOP 50 SPWIN_DB.dbo.Code_9.Code, SPWIN_DB.dbo.Code_9.Name, SPWIN_DB.dbo.Code_9.Definition,6 FROM SPWIN_DB.dbo.Code_9 LEFT JOIN SPWIN_DB.dbo.Code_DBA on (SPWIN_DB.dbo.Code_9.Code = SPWIN_DB.dbo.Code_DBA.Code and SPWIN_DB.dbo.Code_DBA.Name = SPWIN_DB.dbo.Code_9.Name) where SPWIN_DB.dbo.Code_DBA.Code is null and SPWIN_DB.dbo.Code_DBA.Name is null";
                    SqlCommand command = new SqlCommand(commandStr, con);
                     result = Convert.ToBoolean(command.ExecuteNonQuery());
                    con.Close();
                    if (result)
                    {
                        MainForm.waitForm.Close();
                        logger.Debug("Veri taşıma işlemi başarılı! - Liman Listesi taşındı");
                        MessageBox.Show("Veri taşıma işlemi başarılı! - Liman Listesi taşındı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MainForm.waitForm.Close();
                logger.Error("Veri taşıma işlemi başarısız : " + ex.Message);
                MessageBox.Show("HATA Veri taşıma işlemi başarısız : " + ex.Message + "", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void MoveDbaService(string getConString) {
            commandStr = "";
            try
            {
                using (SqlConnection con = new SqlConnection(getConString))
                {
                    con.Open();
                    commandStr = "UPDATE SPWIN_DB.dbo.Parameters SET DbaIsActive = 'False', DbaUserName = ds.username, DbaPassword = ds.password, DbaOrtam = 'False' FROM SPWIN_DB.dbo.Parameters p INNER JOIN SPWIN_DB.dbo.DbaServis ds ON p.seq = ds.ID";

                    SqlCommand command = new SqlCommand(commandStr, con);
                    bool result = Convert.ToBoolean(command.ExecuteNonQuery());
                    con.Close();
                    if (result)
                    {
                        
                        MainForm.waitForm.Close();
                        logger.Debug("Veri taşıma işlemi başarılı!");
                        MessageBox.Show("Veri taşıma işlemi başarılı! - DBA_Servis bilgileri taşındı", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
               
                
                MainForm.waitForm.Close();
                logger.Error("Veri taşıma işlemi başarısız : " + ex.Message);
                MessageBox.Show("HATA Veri taşıma işlemi başarısız : " + ex.Message + "", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SelectDbaDataAndAddDatatable(string getConString)
        {

            DataTable dataTable = new DataTable();
            commandStr = "";
            try
            {
                using (SqlConnection con = new SqlConnection(getConString))
                {
                    con.Open();
                    commandStr = "select seq,seqnum1,CName4,CName5,CName6,CName9,CName10,Code4,Code9 from SPWIN_DB.dbo.Weigh2 where (CName4 IS NOT NULL and CName4 <> '') and (CName5 IS NOT NULL and CName5 <> '') and (CName9 IS NOT NULL and CName9 <> '') and (DbaWeigh2Id IS NULL or DbaWeigh2Id = '' or DbaWeigh2Id = 0)";
                    SqlCommand command = new SqlCommand(commandStr, con);
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(command);
                    dataAdapter.Fill(dataTable);
                    con.Close();
                    dataAdapter.Dispose();
                    MoveDba_Data(dataTable, getConString);
                    MainForm.waitForm.Close();
                }
 
            }
            catch (Exception ex)
            {
                MainForm.waitForm.Close();
                logger.Error("Weight2 DBA veri listeleme işlemi başarısız : " + ex.Message);
                MessageBox.Show("HATA Weight2 DBA veri listeleme işlemi başarısız : " + ex.Message + "", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

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
