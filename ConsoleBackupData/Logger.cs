using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleBackupData
{
     public class Logger : ILogger
    {
        public async Task<bool> logs(Exception ex)
        {
            try
            {
                using (StreamWriter v = new StreamWriter(GlobalData.OptionData[0] + "logs.txt", true))
                {
                     await v.WriteLineAsync(ex.Message);
                }
                        return true;
            }
            catch
            {
                return false;
            }
        }
        public async Task<bool> logs(string InfoLog)
        {
            try
            {
                using (StreamWriter v = new StreamWriter(@$"{GlobalData.OptionData[0]}{DateTime.Now.ToLongDateString()}\" + "logs.txt", true))
                {
                    await v.WriteLineAsync(InfoLog);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
