using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication2.Models {
    interface ICountry {
        string LongName { get; set; }
        string ShortName { get; set; }
        string Continent { get; set; }
        string TwoLetterCode { get; set; }
    }
}
