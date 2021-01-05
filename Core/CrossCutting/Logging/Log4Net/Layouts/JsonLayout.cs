﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using System.Xml.Resolvers;
using log4net.Core;
using log4net.Layout;
using Newtonsoft.Json;
using Formatting = Newtonsoft.Json.Formatting;

namespace Core.CrossCutting.Logging.Log4Net.Layouts
{
    public class JsonLayout:LayoutSkeleton
    {
        public override void ActivateOptions()
        {
             
        }

        public override void Format(TextWriter writer, LoggingEvent loggingEvent)
        {
            var logEvent=new SerializableLogEvent(loggingEvent);
            var json = JsonConvert.SerializeObject(logEvent, Formatting.Indented);
            writer.WriteLine(json);

        }
    }
}