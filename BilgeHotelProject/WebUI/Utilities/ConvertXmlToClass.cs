using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WebUI.Utilities
{
    public class ConvertXmlToClass<T> where T : class
    {
        public static T ConvertXmlFrom(string url)
        {
            WebClient client1 = new WebClient();
            var xmlFormat = client1.DownloadString(url);


            XmlSerializer serializer = new XmlSerializer(typeof(T));
            using (StringReader reader = new StringReader(xmlFormat))
            {
                var xmlClass = (T)serializer.Deserialize(reader);

                return xmlClass;
            }

            
        }
    }
}
