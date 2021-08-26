using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleBackupData
{
    interface ILogger
    {
        public Task<bool> logs(Exception ex);
        public Task<bool> logs(string infoLog);
        public Task<bool> logsDebug(string log);
    }
}
