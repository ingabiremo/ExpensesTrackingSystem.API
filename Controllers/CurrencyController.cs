using ExpensesTrackingSystem.API.Entities;
using ExpensesTrackingSystem.API.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpensesTrackingSystem.API.Controllers
{
    [ApiController]
    public class CurrencyController : ControllerBase
    {

        private readonly ICurrencyRepository _currencyRepository;
        public CurrencyController(ICurrencyRepository currencyRepository)
        {
            _currencyRepository = currencyRepository ?? 
                throw new ArgumentNullException(nameof(currencyRepository));
        }

        [HttpGet("api/currency")]
        public IActionResult GetCurrencies()
        {
            var currencyList  = _currencyRepository.GetCurrencies();
            return new JsonResult(currencyList);
           
        }
    }
}
