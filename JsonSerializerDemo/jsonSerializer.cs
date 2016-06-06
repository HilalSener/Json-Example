using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace JsonSerializerDemo
{
    class jsonSerializer
    {
        static void Main(string[] args)
        {
            using (WebClient wc = new WebClient())
            {
                Console.Clear();
                var uri = ("http://api.openweathermap.org/data/2.5/forecast/city?id=745044&APPID={APIKEY}");
                var json = wc.DownloadString(uri);
                var djson = JsonConvert.DeserializeObject(json);

                Console.WriteLine(djson);

                JsonSerializer serializer;

                Console.WriteLine(" ***Indent*** ");
                serializer = new JsonSerializer();
                serializer.Formatting = Formatting.Indented;
                using (StreamWriter sw = new StreamWriter(@"..\..\weather.json"))
                {
                    using (JsonWriter writer = new JsonTextWriter(sw))
                    {
                        serializer.Serialize(writer, djson);
                    }
                }
            }
        }
    }
}
