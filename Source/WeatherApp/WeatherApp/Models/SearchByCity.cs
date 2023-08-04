using System.ComponentModel.DataAnnotations;

namespace WeatherApp.Models
{
    public class SearchByCity
    {
        [Required(ErrorMessage = "You must enter a city name!")]
        [RegularExpression("^[A-Za-z ]+$", ErrorMessage = "Only text allowed")]
        [StringLength(20, MinimumLength = 2, ErrorMessage = "Enter a city name between 2 and 20 characters!")]
        [Display(Name = "City Name")]
        public string CityName { get; set; }
        
    }
}
