using Question2.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Question2.Response
{
    public class DetailsResponse
    {
        public string number { get; set; }
        public ICountryDetailsDto country { get; set; }
    }

}
