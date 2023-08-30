using System;

namespace ConsoleLoggers
{
    internal class DataService
    {
        //MyCompanyLogger logger = new MyCompanyLogger();

        public void Valiation()
        {
            int i = 6;
            int j = 0;
            try
            {
                Console.WriteLine(i / j);
            }
            catch (Exception ex)
            {
                //logger.SaveToLog(ex.Message);
                //MyCompanyLogger.SaveToLog(ex.Message);
                //MyCompanyLogger.SaveToLog("OK");

                //ex.Message.SaveToLog();
                //"OK".SaveToLog();

                ex.SaveToLog();
            }
        }
    }
}
