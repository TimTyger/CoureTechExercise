using Microsoft.EntityFrameworkCore;
using Question2.Repo.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Question2.Repo.Data
{
    public class Question2Context : DbContext
    {
        public DbSet<Country> Country { get; set; }
        public DbSet<CountryDetails> CountryDetails { get; set; }

        public Question2Context(DbContextOptions<Question2Context> options) : base(options)
        {
            AddData();
        }

        public void AddData()
        {
            List<Country> countries = new List<Country>()
            {
            new Country{CountryCode="234",Name="Nigeria",CountryIso="NG"},
            new Country{CountryCode="233",Name="Ghana",CountryIso="GH"},
            new Country{CountryCode="229",Name="Benin Republic",CountryIso="BN"},
            new Country{CountryCode="225",Name="Côte d'Ivoire",CountryIso="CIV"}
            };
            Country.AddRange(countries);
            List<CountryDetails> details = new List<CountryDetails>()
            {
            new CountryDetails{CountryId=1,Operator="MTN Nigeria",OperatorCode="MTN NG"},
            new CountryDetails{CountryId=1,Operator="Airtel Nigeria",OperatorCode="ANG"},
            new CountryDetails{CountryId=1,Operator="9 Mobile Nigeria",OperatorCode="ETN"},
            new CountryDetails{CountryId=1,Operator="Globacom Nigeria",OperatorCode="GLO NG"},
            new CountryDetails{CountryId=2,Operator="Vodafone Ghana",OperatorCode="Vodafone GH"},
            new CountryDetails{CountryId=2,Operator="MTN Ghana",OperatorCode="MTN Ghana" },
            new CountryDetails{CountryId=2,Operator="Tigo Ghana",OperatorCode="Tigo Ghana"},
            new CountryDetails{CountryId=3,Operator="MTN Benin",OperatorCode="MTN Benin"},
            new CountryDetails{CountryId=3,Operator="Moov Benin",OperatorCode="Moov Benin"},
            new CountryDetails{CountryId=4,Operator="MTN Côte d'Ivoire",OperatorCode="MTN CIV"},
            };
            CountryDetails.AddRange(details);
        }

    }
}
