using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Currency/5
        [HttpGet("{id}", Name = "Get")]
        public ActionResult Get(string country)
        {
            var result = _currencyService.Read(country);
            return new JsonResult(result);
        }

        // POST: api/Currency
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Currency/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
