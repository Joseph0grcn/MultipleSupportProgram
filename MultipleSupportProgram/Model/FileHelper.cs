using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Runtime;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleSupportProgram.Model
{
    internal class FileHelper
    {
        public static log4net.ILog logger = log4net.LogManager.GetLogger("FileHelper");
        public static string RestoreFileLocation()
        {
            using (OpenFileDialog file = new OpenFileDialog())
            {
                file.Filter = "Veritabanı Dosyası |*.bak";
                if (file.ShowDialog() == DialogResult.OK)
                {
                    logger.Info(file.FileName + " yedeği seçildi");
                    return file.FileName;
                }
                else
                {
                    return null;
                }
            }
        }
        public static string BackupFileLocation()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                logger.Info(folderBrowserDialog.SelectedPath + "  dosya yolu seçildi");
                return folderBrowserDialog.SelectedPath;
            }
            return null;
        }

        public static string SQLFileSelect()
        {
            using (OpenFileDialog file = new OpenFileDialog())
            {
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
        }
        public static void DeleteDirectoryIfExists(string path)
        {
            try
            {
                if (Directory.Exists(path))
                {
                    DirectorySecurity dirSecurity = Directory.GetAccessControl(path);
                    dirSecurity.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.FullControl, AccessControlType.Allow));
                    Directory.SetAccessControl(path, dirSecurity);
                    Directory.Delete(path, true);
                    MessageBox.Show($"'{path}' başarıyla silindi.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Info($"'{path}' başarıyla silindi.");
                }
                else
                {
                    MessageBox.Show($"'{path}' bulunamadı.", "BİLGİ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    logger.Warn($"'{path}' bulunamadı.");
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                logger.Error($"Erişim hatası: {ex.Message}");
            }
            catch (Exception ex)
            {
                logger.Error($"Bir hata oluştu: {ex.Message}");
            }
        }

        public static string GetPictureFileLocation()
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                logger.Info(folderBrowserDialog.SelectedPath + "  dosya yolu seçildi");
                return folderBrowserDialog.SelectedPath;
            }
            return null;
        }

        public static void DeletePictureFile(string pictureFilePath, DataTable pictureFileNames)
        {
            string[] fileNames =
                {
                    "imageFile1",
                    "imageFile2",
                    "imageFile3",
                    "imageFile4",
                };
            foreach (DataRow row in pictureFileNames.Rows)
            {

                foreach (string file in fileNames)
                {
                    try
                    {
                        if (row[file] != DBNull.Value)
                        {
                            string combinedPath = Path.Combine(pictureFilePath, row[file].ToString());
                            if (File.Exists(combinedPath))
                            {
                                File.Delete(combinedPath);
                            }
                            else
                            {
                                logger.Error($"Failed to delete picture file {combinedPath}");
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        logger.Error($"Dosya silinirken bir hata oluştu: {ex.Message}");
                        throw;
                    }
                    
                    
                }
                string commandstring = "DELETE FROM SPWIN_DB.dbo.WeighingImages WHERE seq = " + row["seq"];
                SQLHelper.ExecuteNonQueryScript( commandstring );
            }
        }
    }
}
