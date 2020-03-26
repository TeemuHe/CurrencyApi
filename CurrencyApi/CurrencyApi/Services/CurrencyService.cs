using CurrencyApi.Models;
using CurrencyApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CurrencyApi.Services
{
    public class CurrencyService : ICurrencyService
    {
        private readonly ICurrencyRepository _currencyRepository;

        public CurrencyService(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository;
        }
        public RATE Create(RATE rate)
        {
            return _currencyRepository.Create(rate);
        }

        public List<RATE> Read()
        {
            return _currencyRepository.Read();
        }

        public RATE Read(string country)
        {
            return _currencyRepository.Read(country);
        }

        public RATE Update(RATE rate, string country)
        {
            return _currencyRepository.Update(rate, country);
        }
    }
}
