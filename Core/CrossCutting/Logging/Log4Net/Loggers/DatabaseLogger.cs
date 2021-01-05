using System;
using System.Collections.Generic;
using System.Text;
using Core.CrossCutting.Logging.Log4Net;
using log4net;

namespace Core.CrossCutting.Logging.Log4Net.Loggers
{
    public class DatabaseLogger:LoggerService
    {
        public DatabaseLogger() : base(LogManager.GetLogger("DatabaseLogger"))
        {
        }
    }
}
