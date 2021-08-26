using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleBackupData
{
     public class Logger : ILogger
    {
        public async Task<bool> logsAsync(Exception ex)
        {
            try
            {
                using (StreamWriter v = new StreamWriter(GlobalData.OptionData[0] + "logsError.txt", true))
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
        public async Task<bool> logsAsync(string InfoLog)
        {
            try
            {
                using (StreamWriter v = new StreamWriter(@$"{GlobalData.OptionData[0]}{DateTime.Now.ToLongDateString()}\" + "logsInfo.txt", false))
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
        public async Task<bool> logsDebugAsync(string log)
        {
            try
            {
                StringBuilder BilderInfo = new StringBuilder();
                BilderInfo.Append(log);
                if(GlobalData.lvlLogs == 3)
                {
                    using (StreamWriter v = new StreamWriter(@$"{GlobalData.OptionData[0]}{DateTime.Now.ToLongDateString()}\" + "logsDebug.txt", true))
                    {
                        await v.WriteLineAsync(BilderInfo.ToString());
                    }
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
