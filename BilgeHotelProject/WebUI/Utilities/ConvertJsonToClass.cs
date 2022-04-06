using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace WebUI.Utilities
{
    public class ConvertJsonToClass<T> where T: class
    {
        public static List<T> ConvertJsonFrom(string url)
        {
            //herhangi bir web sitesine istekte bulunmak için aşağıdaki nesneyi kullanmamız gerekmektedir.
            WebClient client = new WebClient();

            //parametreden alınan url'i yukarıda almış olduğumuz instance ile istekte bulunup bütün veriyi string oalrak yakalıyoruz.
            string jsonFormat = client.DownloadString(url);

            //string olarak aldığımız verileri (jsonFormat) Covid19 isimli class içerisinde bulunan property'lere taşıyoruz. (Deserialize)
            var jsonClass = JsonConvert.DeserializeObject<List<T>>(jsonFormat);

            return jsonClass.ToList();
        }
    }
}
