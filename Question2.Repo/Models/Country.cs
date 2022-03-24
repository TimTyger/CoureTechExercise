using Question2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Question2.Repo.Models
{
    public class Country : ICountry
    {
        public int Id { get; set; }
        public string CountryCode { get; set; }
        public string Name { get; set; }
        public string CountryIso { get; set; }
    }
}
