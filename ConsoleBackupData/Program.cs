using System;
using System.Threading.Tasks;

namespace ConsoleBackupData
{
    class Program
    {
       public static ReadOptions v = new ReadOptions();
       public static CopyFailDirectory t = new CopyFailDirectory();
        public static Logger L = new Logger();
        static async Task Main(string[] args)
        {
            await Task.Run(() => Start());
        }

        public static async Task Start()
        {
            await Task.Run(() => L.logsDebugAsync("Старт приложения"));
            await Task.Run(() => v.ReadOptionsAsync());
            await Task.Run(() => t.CopyFailAsync());
            await Task.Run(() => L.logsDebugAsync("завершение приложения"));
            if(GlobalData.lvlLogs != 0)
                Console.WriteLine("Логи созданы");
            Console.WriteLine("Копирвание завершено.Для завершение нажмите на любую кнопку");
            Console.ReadKey();
        }
    }
}
