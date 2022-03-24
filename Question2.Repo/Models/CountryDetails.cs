using Question2.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Question2.Repo.Models
{
    public class CountryDetails :ICountryDetails
    {
        public int Id { get; set; }
        public int CountryId { get; set; }
        public string Operator { get; set; }
        public string OperatorCode { get; set; }
    }
}
