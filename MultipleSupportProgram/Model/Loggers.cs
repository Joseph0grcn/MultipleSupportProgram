namespace MultipleSupportProgram.Model
{
    public class Loggers
    {
        public void CreateSpwinlogsFile()
        {
            //Yok ise SPWINLOGS klasörünü oluşturur
            log4net.Config.XmlConfigurator.Configure();
            string filepath = "C:\\SPWINLOGS";
            if ((!System.IO.Directory.Exists(filepath))) System.IO.Directory.CreateDirectory(filepath);
        }

    }
}
