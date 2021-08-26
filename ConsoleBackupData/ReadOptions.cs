using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleBackupData
{
    public class ReadOptions : IReadOptions
    {
        public async Task<bool> ReadOptionsAsync()
        {
            try
            {
                int i = 0;
                string s;
                using (StreamReader v = new StreamReader("options.txt"))
                {
                    while ((s = await v.ReadLineAsync()) != null)
                    {
                        GlobalData.OptionData[i] = s.ToString();
                        i++;
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
