using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace WeatherApp.Models
{
    public class City
    {
        [Display(Name = "City Name")]
        public string Name { get; set; }

        [Display(Name = "Temp.")]
        public float Tempature { get; set; }

        [Display(Name = "Humidity.")]
        public int Humidity { get; set; }

        [Display(Name = "Pressure:")]
        public int Pressure { get; set; }

        [Display(Name = "Wind Speed:")]
        public float Wind { get; set; }

        [Display(Name = "Weather Conditions:")]
        public string Weather { get; set; }
		[Display(Name = "Longtitutde:")]
		public float Lon { get; set; }
		[Display(Name = "Latitude:")]
		public float Lat { get; set; }
	}
}
