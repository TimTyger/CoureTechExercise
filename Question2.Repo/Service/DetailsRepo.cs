using Question2.Interfaces;
using Question2.Repo.Data;
using Question2.Repo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question2.Repo.Service
{
    public class DetailsRepo :IDetailsRepo
    {
        private readonly Question2Context _context;
        public DetailsRepo(Question2Context context)
        {
            _context = context;
        }

        public async Task<ICountry> GetCountryByCode(string code)
        {
            if (string.IsNullOrWhiteSpace(code))
            {
                throw new ArgumentNullException(nameof(code));
            }
            return  _context.Country.Local.Where(x => x.CountryCode == code).First();
        }
        public async Task<IEnumerable<ICountryDetails>> GetCountryDetailsByCountryId(int? Id)
        {
            if (Id==null)
            {
                throw new ArgumentNullException(nameof(Id));
            }
            return _context.CountryDetails.Local.Where(x => x.CountryId == Id);
        }
    }
}
