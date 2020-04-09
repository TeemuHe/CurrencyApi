using CurrencyApi.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyApi.Repositories
{
    public class CurrencyRepository : ICurrencyRepository
    {
        private readonly DtbankdbContext _context;

        public CurrencyRepository(DtbankdbContext context)
        {
            _context = context;
        }

        public RATE Create(RATE rate)
        {
            _context.Add(rate);
            _context.SaveChanges();
            return rate;
        }

        public List<RATE> Read()
        {
            return _context.RATE
                .AsNoTracking()
                .ToList();
        }

        public RATE Read(string country)
        {
            return _context.RATE.AsNoTracking().FirstOrDefault(c => c.Country == country);
        }

        public RATE ReadCurrencyAmount(decimal amount, string country1, string country2)
        {
            // EI TOIMI VIELÄ   
            var cCoun1 = Read(country1);
            var cCoun2 = Read(country2);

            return _context.RATE.AsNoTracking().FirstOrDefault(c => c.Country == country1);
            /*var cAmount1 = cCoun1.Rate1;
            var cCoun2 = Read(country2);
            var cAmount2 = cCoun2.Rate1;
            var finalResult = amount * cAmount2 / cAmount1;
            return _context.RATE.AsNoTracking().FirstOrDefault(c => c.finalResult == finalResult);*/
        }

        public RATE ReadCurrencyAmount2(decimal amount, string country1, string country2)
        {
            return _context.RATE.AsNoTracking().FirstOrDefault(c => c.Country == country2);
        }

        public RATE Update(RATE rate, string country)
        {
            _context.Update(rate);
            _context.SaveChanges();
            return rate;
        }
    }
}
