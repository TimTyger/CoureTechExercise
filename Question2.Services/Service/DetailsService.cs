using Question2.Interfaces;
using Question2.Repo.Models;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Question2.Services.Service
{
    public class DetailsService :IDetailsService
    {
        private readonly IDetailsRepo _repo;
        public DetailsService(IDetailsRepo repo)
        {
            _repo=repo;
        }

        public async Task<ICountryDetailsDto> GetDetailsByPhoneNumber(string phoneNumber)
        {
            try
            {
                var country = await _repo.GetCountryByCode(phoneNumber.Substring(0, 3));
                
                var countryDetails = await _repo.GetCountryDetailsByCountryId(country?.Id);
                return new CountryFullDetails
                {
                    countryCode = country.CountryCode,
                    name = country.Name,
                    countryIso =country.CountryIso,
                    countryDetails = countryDetails.ToList()
                };
               
            }
            catch (System.Exception)
            {
                throw;
            }
            
        }
    }
}
