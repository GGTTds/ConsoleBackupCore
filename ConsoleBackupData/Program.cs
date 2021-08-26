using System;
using System.Threading.Tasks;

namespace ConsoleBackupData
{
    class Program
    {
        static async Task Main(string[] args)
        {
            ReadOptions v = new ReadOptions();
            await Task.Run(() => v.ReadOptionsAsync());
            
        }
    }
}
