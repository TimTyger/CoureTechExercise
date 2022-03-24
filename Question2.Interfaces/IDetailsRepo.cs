using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Question2.Interfaces
{
    public interface IDetailsRepo
    {
        Task<IEnumerable<ICountryDetails>> GetCountryDetailsByCountryId(int? Id);
        Task<ICountry> GetCountryByCode(string Code);
    }
}
