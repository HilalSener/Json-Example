using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDemoWithHttpClient.Model
{
    public class EarthquakeModel
    {
        public string Date { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public double Deepth { get; set; }
        public double MD { get; set; }
        public double ML { get; set; }
        public double MW { get; set; }
        public string Location { get; set; }
        public string Result { get; set; }
    }

    public class EarthquakeModelList
    {
        public List<EarthquakeModel> Earthquakes { get; set; }
    }
}
