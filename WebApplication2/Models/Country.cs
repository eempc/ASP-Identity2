using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models {
    public class Country : ICountry {
        public int Id { get; set; }
        [Required, Display(Name = "Long country name")]
        public string LongName { get; set; }
        [Required, Display(Name = "Short country name")]
        public string ShortName { get; set; }
        [Required, Display(Name = "Continent")]
        public string Continent { get; set; }
        [Required, Display(Name = "Country two letter code")]
        public string TwoLetterCode { get; set; }
    }
}
