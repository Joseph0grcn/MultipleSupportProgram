using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MultipleSupportProgram.Model
{
    public class WeighPhotoDelete
    {
        public log4net.ILog logger = log4net.LogManager.GetLogger("WeighPhotoDelete");
        public void PhotoDelete(string getConString,string radioButtonName,string time1 ,string time2
            ) 
        {
            string commandStr = "";
            try
            {
                using (SqlConnection con = new SqlConnection(getConString))
                {
                    con.Open();

                    if (time1 == "" && time2 == "")
                    {
                        // bütün veritabanında işlem yapıyor
                        switch (radioButtonName)
                        {
                            case "rbOneAndTwoPhoto":
                                commandStr = "UPDATE SPWIN_DB.dbo.WeighingImages SET image1 = NULL,image2 = NULL, image3 = NULL, image4 = NULL " +
                                    "where seqnum2 in(select seq from Weigh2')";                           
                                break;

                            case "rbInTheFolderPhoto":
                                commandStr = "UPDATE SPWIN_DB.dbo.WeighingImages SET imageFile1 = NULL, imageFile2 = NULL, imageFile3 = NULL, imageFile4 = NULL " +
                                    "where seqnum2 in(select seq from Weigh2')";
                                break;

                            case "rbAllPhoto":
                                commandStr = "UPDATE SPWIN_DB.dbo.WeighingImages SET image1 = NULL,image2 = NULL, image3 = NULL, image4 = NULL, imageFile1 = NULL, imageFile2 = NULL, imageFile3 = NULL, imageFile4 = NULL " +
                                    "where seqnum2 in(select seq from Weigh2')";
                                break;
                        }
                    }
                    else
                    {
                        //Seçilen tarih aralığında işlem yapıyor
                        switch (radioButtonName)
                        {
                            case "rbOneAndTwoPhoto":
                                commandStr = "UPDATE SPWIN_DB.dbo.WeighingImages SET image1 = NULL,image2 = NULL, image3 = NULL, image4 = NULL " +
                                    "where seqnum2 in(select seq from Weigh2 where WeighTime2 between '" + time1 + "' and '" + time2 + "')";
                                break;

                            case "rbInTheFolderPhoto":
                                commandStr = "UPDATE SPWIN_DB.dbo.WeighingImages SET imageFile1 = NULL, imageFile2 = NULL, imageFile3 = NULL, imageFile4 = NULL "+
                                    "where seqnum2 in(select seq from Weigh2 where WeighTime2 between '" + time1 + "' and '" + time2 + "')"; 
                                break;

                            case "rbAllPhoto":
                                commandStr = "UPDATE SPWIN_DB.dbo.WeighingImages SET image1 = NULL,image2 = NULL, image3 = NULL, image4 = NULL, imageFile1 = NULL, imageFile2 = NULL, imageFile3 = NULL, imageFile4 = NULL "+
                                    "where seqnum2 in(select seq from Weigh2 where WeighTime2 between '" + time1 + "' and '" + time2 + "')"; 
                                break;
                        }
                    }

                    
                    SqlCommand command = new SqlCommand(commandStr, con);
                    bool result = Convert.ToBoolean(command.ExecuteNonQuery());
                    con.Close();
                    if (result)
                    {   Thread.Sleep(100);
                        Application.DoEvents();
                        MainForm.waitForm.Close();
                        Thread.Sleep(100);
                        Application.DoEvents();

                        MessageBox.Show("Tartım fotoğrafı silme işlemi başarıyla gerçekleşti.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        logger.Debug("Tartım fotoğrafı silme işlemi başarıyla gerçekleşti.");
                        
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

        }

    }
}
