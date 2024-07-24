﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultipleSupportProgram.Model
{
    internal class FileOperations
    {
        public static log4net.ILog logger = log4net.LogManager.GetLogger("FileOperations");
        public static string RestoreFileLocation()
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
        private void DeleteDirectoryIfExists(string path)
        {
            try
            {
                if (Directory.Exists(path))
                {
                    DirectorySecurity dirSecurity = Directory.GetAccessControl(path);
                    dirSecurity.AddAccessRule(new FileSystemAccessRule("Everyone", FileSystemRights.FullControl, AccessControlType.Allow));
                    Directory.SetAccessControl(path, dirSecurity);
                    Directory.Delete(path, true);
                    logger.Info($"'{path}' başarıyla silindi.");
                }
                else
                {
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

    }
}
