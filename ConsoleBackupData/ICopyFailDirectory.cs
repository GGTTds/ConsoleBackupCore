using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBackupData
{
    interface ICopyFailDirectory
    {
        public Task<bool> CopyFailAsync();
    }
}
