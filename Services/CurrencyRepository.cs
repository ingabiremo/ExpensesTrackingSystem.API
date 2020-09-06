using ExpensesTrackingSystem.API.DbContexts;
using ExpensesTrackingSystem.API.Entities;
using Microsoft.AspNetCore.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExpensesTrackingSystem.API.Services
{
    public class CurrencyRepository: ICurrencyRepository
    {
        private readonly ExpensesTrackingContext _context;

        public CurrencyRepository(ExpensesTrackingContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IEnumerable<Currency> GetCurrencies()
        {
              return _context.Currency.ToList<Currency>();
        }

       
    }
}
