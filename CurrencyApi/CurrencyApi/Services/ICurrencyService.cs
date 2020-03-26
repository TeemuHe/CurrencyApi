using CurrencyApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CurrencyApi.Services
{
    public interface ICurrencyService
    {
        RATE Create(RATE rate);
        List<RATE> Read();
        RATE Read(string country);
        RATE Update(RATE rate, string country);
    }
}
