using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using JsonDemoWithHttpClient.Model;
using System.Collections.ObjectModel;

namespace JsonDemoWithHttpClient
{
    public class Program
    {
        private static string Uri = "http://sondepremler20160728065405.azurewebsites.net/last";
        public static void Main(string[] args)
        {
            Console.WriteLine("***** Datalar Getiriliyor *****");

            Task.Run(async () =>
            {
                await GetEarthquke();

            }).GetAwaiter().GetResult();
        }

        public static async Task<List<EarthquakeModelList>> GetEarthquke()
        {
            using (var client = new HttpClient())
            {
                var request = new HttpRequestMessage(HttpMethod.Get, Uri);
                client.DefaultRequestHeaders.Add("Accept", "appliction/json");
                var response = await client.SendAsync(request);
                var result = response.Content.ReadAsStringAsync().Result;
                var myreturn = JsonConvert.DeserializeObject<List<EarthquakeModelList>>(result);
                
                //Console.WriteLine(myreturn.Earthquakes.Count);
                Console.WriteLine(myreturn);
                Console.ReadKey();
                
                return myreturn;
            }
        }
    }
}
