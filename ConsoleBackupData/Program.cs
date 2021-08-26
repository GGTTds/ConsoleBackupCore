using System;
using System.Threading.Tasks;

namespace ConsoleBackupData
{
    class Program
    {
        static async Task Main(string[] args)
        {
            ReadOptions v = new ReadOptions();
            CopyFailDirectory t = new CopyFailDirectory();
            await Task.Run(() => v.ReadOptionsAsync());
            await Task.Run(() => t.CopyFailAsync());
            
        }
    }
}
