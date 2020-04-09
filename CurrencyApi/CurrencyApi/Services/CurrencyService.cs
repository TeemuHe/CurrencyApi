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

        public RATE ReadCurrencyAmount(decimal amount, string country1, string country2)
        {
            return _currencyRepository.ReadCurrencyAmount(amount, country1, country2);
        }

        public RATE ReadCurrencyAmount2(decimal amount, string country1, string country2)
        {
            return _currencyRepository.ReadCurrencyAmount2(amount, country1, country2);
        }

        public RATE Update(RATE rate, string country)
        {
            var updatedRate = _currencyRepository.Read(country);
            if(updatedRate != null)
            {
                return _currencyRepository.Update(rate, country);
            }
            else
            {
                throw new Exception("Rate not found!");
            }
            
        }
    }
}
