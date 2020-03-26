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
            return _context.RATE.FirstOrDefault(c => c.Country == country);
        }

        public RATE Update(RATE rate, string country)
        {
            _context.Update(rate);
            _context.SaveChanges();
            return rate;
        }
    }
}
