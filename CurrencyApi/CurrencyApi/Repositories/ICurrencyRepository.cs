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
        RATE Update(RATE rate, string country);
    }
}
