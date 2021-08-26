using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Linq;

namespace ConsoleBackupData
{
    public class ReadOptions : IReadOptions
    {
        Logger _log = new Logger();
        public async Task<bool> ReadOptionsAsync()
        {
            try
            {
                int i = 0;
                string s = "";
                using (StreamReader v = new StreamReader("options.txt", true))
                {
                    while ((s = await v.ReadLineAsync()) != null)
                    {
                        GlobalData.OptionData[i] = s.ToString();
                        i++;
                    }
                }
                await Task.Run(() => GoLogs());
                return true;
            }
            catch (Exception ex)
            {
                if(GlobalData.lvlLogs == 1)
                await _log.logs(ex);
                return false;
            }

        }

        public void GoLogs()
        {
            if (GlobalData.OptionData.Contains("Error") == true)
            {
                GlobalData.lvlLogs = 1;
                Console.WriteLine("Логи: Error");
            }
            if (GlobalData.OptionData.Contains("Info") == true)
            {
                GlobalData.lvlLogs = 2;
                Console.WriteLine("Логи: Info");
            }
            if (GlobalData.OptionData.Equals("Debug"))
                GlobalData.lvlLogs = 3;
        }
    }
}
