using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBackupData
{
    interface ILogger
    {
        public Task<bool> logsAsync(Exception ex);
        public Task<bool> logsAsync(string infoLog);
        public Task<bool> logsDebugAsync(string log);
    }
}
