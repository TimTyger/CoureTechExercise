using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Question2.Interfaces
{
    public interface IDetailsService
    {
        Task<ICountryDetailsDto> GetDetailsByPhoneNumber(string phoneNumber);
    }
}
