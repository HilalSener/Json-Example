using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace jsonExample
{
    class firstExample
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("*** Open Weather json Data ***");

            using (WebClient wc = new WebClient())
            {
                var uri = ("http://api.openweathermap.org/data/2.5/forecast/city?id=745044&APPID={APIKEY}");
                var json = wc.DownloadString(uri);

                var djson = JsonConvert.DeserializeObject(json);

                Console.WriteLine(djson);
            }
    }
    }
}
