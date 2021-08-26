using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleBackupData
{
     public class CopyFailDirectory : ICopyFailDirectory
    {
        public async Task<bool> CopyFailAsync()
        {
            try
            {
                string CopyHere = GlobalData.OptionData[0] + DateTime.Now.ToLongDateString(); // Сюда копируем
                string FileHere = GlobalData.OptionData[1]; // Отсюда копируем
                Directory.CreateDirectory(CopyHere);
                foreach(var NameFail in Directory.EnumerateFiles(FileHere))
                {
                   using (FileStream v = new FileStream(NameFail, FileMode.Open))
                    {
                        Console.WriteLine($"Копирование файла {NameFail}");
                        using (FileStream r = File.Create(CopyHere + NameFail.Substring(NameFail.LastIndexOf('\\'))))
                        {
                            await v.CopyToAsync(r);
                        }
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
