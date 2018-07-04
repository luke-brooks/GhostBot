using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GhostBotApp
{
    public class UserConfigOptionsModel
    {
        public string CurrentWorkingDirectory { get; set; }
        public string ResourceLocation { get; set; }
        public string SingleScreenLocation { get; set; }
        public string MultiScreenLocation { get; set; }
        public string MenuLocation { get; set; }
        public string SlackBaseUrl { get; set; }
        public string SlackChannel { get; set; }
        public string GhostBotMessage { get; set; }
        public int PauseTimeBetweenScansSec { get; set; }
        public int IdleThresholdSec { get; set; }
        public string TestingFlag { get; set; }

        public string ToXML()
        {
            var stringwriter = new System.IO.StringWriter();
            var serializer = new XmlSerializer(this.GetType());
            serializer.Serialize(stringwriter, this);
            return stringwriter.ToString();
        }

        public static UserConfigOptionsModel LoadFromXMLString(string xmlText)
        {
            var stringReader = new System.IO.StringReader(xmlText);
            var serializer = new XmlSerializer(typeof(UserConfigOptionsModel));
            return serializer.Deserialize(stringReader) as UserConfigOptionsModel;
        }
    }
}
