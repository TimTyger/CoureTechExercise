using System;
using System.Collections.Generic;
using System.Text;

namespace Question2.Interfaces
{
    public interface ICountry
    {
         int Id { get; set; }
         string CountryCode { get; set; }
         string Name { get; set; }
         string CountryIso { get; set; }
    }
}
