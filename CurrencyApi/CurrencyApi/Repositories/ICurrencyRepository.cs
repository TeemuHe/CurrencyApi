using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CurrencyApi.Models;

namespace CurrencyApi.Repositories
{
    public interface ICurrencyRepository
    {
        RATE Create(RATE rate);
        List<RATE> Read();
        RATE Read(string country);
        RATE ReadCurrencyAmount(decimal amount, string country1, string country2);
        RATE ReadCurrencyAmount2(decimal amount, string country1, string country2);
        RATE Update(RATE rate, string country);
    }
}
