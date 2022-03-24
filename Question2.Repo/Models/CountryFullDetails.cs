using Question2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Question2.Repo.Models
{
    public class CountryFullDetails : ICountryDetailsDto
    {
        public string countryCode { get; set; }
        public string name { get; set; }
        public string countryIso { get; set; }
        public List<ICountryDetails> countryDetails { get; set; }
        
    }
}
