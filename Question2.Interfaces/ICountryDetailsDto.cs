using System;
using System.Collections.Generic;
using System.Text;

namespace Question2.Interfaces
{
    public interface ICountryDetailsDto
    {
         string countryCode { get; set; }
         string name { get; set; }
         string countryIso { get; set; }
         List<ICountryDetails> countryDetails { get; set; }
    }
}
