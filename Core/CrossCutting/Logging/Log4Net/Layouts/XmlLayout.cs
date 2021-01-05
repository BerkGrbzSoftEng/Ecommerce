using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using Core.CrossCutting.Logging.Log4Net;
using log4net.Core;
using log4net.Layout;

namespace Core.CrossCutting.Logging.Log4Net.Layouts
{
    public class XmlLayout:LayoutSkeleton
    {
        public override void ActivateOptions()
        {
            throw new NotImplementedException();
        }

        public override void Format(TextWriter writer, LoggingEvent loggingEvent)
        {
            var logEvent =new SerializableLogEvent(loggingEvent);
            var xml = XmlConvert.EncodeName(logEvent.UserName+" = "+logEvent.MessageObject.ToString());
            writer.WriteLine(xml);

        }
    }
}
