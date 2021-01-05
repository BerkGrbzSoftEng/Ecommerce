﻿using System;
using System.Collections.Generic;
using System.Text;
using Core.CrossCutting.Logging.Log4Net;
using log4net;
using log4net.Repository.Hierarchy;

namespace Core.CrossCutting.Logging.Log4Net.Loggers
{
    public class FileLogger:LoggerService
    {
        public FileLogger() : base(LogManager.GetLogger("JsonFileLogger"))
        {
        }

    }
}
