using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBackupData
{
    interface IReadOptions
    {
        public Task<bool> ReadOptionsAsync();
    }
}
