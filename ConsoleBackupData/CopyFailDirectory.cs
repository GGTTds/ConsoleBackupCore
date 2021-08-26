using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleBackupData
{
     public class CopyFailDirectory : ICopyFailDirectory
    {
        Logger _log = new Logger();
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
                        await _log.logsDebugAsync($"Копирование файла {NameFail} в {CopyHere}");
                        if (GlobalData.lvlLogs == 2)
                        {
                             await _log.logsAsync($"Копирование файла {NameFail}");
                            Console.WriteLine("Логи записаны");
                        }
                        using (FileStream r = File.Create(CopyHere + NameFail.Substring(NameFail.LastIndexOf('\\'))))
                        {
                            await v.CopyToAsync(r);
                        }
                        await _log.logsDebugAsync("Копирование завершено");
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                if (GlobalData.lvlLogs == 1)
                    await _log.logsAsync(ex);
                return false;
            }
        }
    }
}
