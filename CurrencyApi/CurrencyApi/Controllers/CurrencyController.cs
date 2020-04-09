using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CurrencyApi.Models;
using CurrencyApi.Repositories;
using CurrencyApi.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CurrencyApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CurrencyController : ControllerBase
    {
        private readonly ICurrencyRepository _currencyRepository;
        
        private readonly ICurrencyService _currencyService;

        public CurrencyController(ICurrencyRepository currencyRepository, ICurrencyService currencyService)
        {
            _currencyRepository = currencyRepository;
            _currencyService = currencyService;
        }
        // GET: api/Currency
        [HttpGet]
        public ActionResult<string> Get()
        {
            var result = _currencyService.Read();
            return new JsonResult(result);
        }

        // GET: api/Currency/5
        [HttpGet("{country}", Name = "Get")]
        public ActionResult Get(string country)
        {
            var result = _currencyService.Read(country);
            return new JsonResult(result);
        }

        // GET: api/Currency/5/CAD/THB
        [HttpGet("{amount}/{country1}/{country2}")]
        public ActionResult Get(decimal amount, string country1, string country2)
        {
            var result = _currencyService.ReadCurrencyAmount(amount, country1, country2);
            var result2 = _currencyService.ReadCurrencyAmount2(amount, country1, country2);
            var resultRate = result.Rate1;
            var resultRate2 = result2.Rate1;
            var answer = amount * resultRate2 / resultRate;
            return new JsonResult(answer);
        }

        // POST: api/Currency
        [HttpPost]
        public ActionResult Post([FromBody] RATE rate)
        {
            var result = _currencyService.Create(rate);
            return new JsonResult(result);
        }

        // PUT: api/Currency/5
        [HttpPut("{country}")]
        public ActionResult Put(string country, [FromBody] RATE rate)
        {
            var result = _currencyService.Update(rate, country);
            return new JsonResult(result);
        }
    }
}
