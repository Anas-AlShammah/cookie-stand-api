using Microsoft.EntityFrameworkCore;
using Salmon.Data;
using Salmon.Dtos;
using Salmon.Interfaces;
using Salmon.Models;

namespace Salmon.Services
{
    public class CookiestandService : ICookiestand
    {
        private readonly AppDbContext _context;
        public CookiestandService(AppDbContext context)
        {
            _context=context;
        }
        public async Task Delete(int id)
        {
            var cooke = await _context.Cookiestands.FirstOrDefaultAsync(c => c.Id == id);
            _context.Cookiestands.Remove(cooke);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Cookiestand>> GetAll()
        {
            var cookies = await _context.Cookiestands.ToListAsync();
            return cookies;
        }

        public async Task<Cookiestand> GetById(int id)
        {
            var cooke = await _context.Cookiestands.FirstOrDefaultAsync(c => c.Id == id);
            return cooke;
        }

        public async Task Post(CookiestandDto cookiestandDto)
        {
            var Cookiestand = new Cookiestand()
            {
                Location = cookiestandDto.Location,
                Description = cookiestandDto.Description,
                minimum_customers_per_hour = cookiestandDto.minimum_customers_per_hour,
                maximum_customers_per_hour = cookiestandDto.maximum_customers_per_hour,
                average_cookies_per_sale = cookiestandDto.average_cookies_per_sale,
                Owner = cookiestandDto.Owner,
            };
            await _context.Cookiestands.AddAsync(Cookiestand);
            await _context.SaveChangesAsync();
         }

        public async Task Put(int id, CookiestandDto cookiestandDto)
        {
            var cooke = await _context.Cookiestands.FirstOrDefaultAsync(c => c.Id == id);
            cooke.Location = cookiestandDto.Location;
            cooke.Description = cookiestandDto.Description;
            cooke.minimum_customers_per_hour = cookiestandDto.minimum_customers_per_hour;
            cooke.maximum_customers_per_hour = cookiestandDto.maximum_customers_per_hour;
            cooke.average_cookies_per_sale = cookiestandDto.average_cookies_per_sale;
            cooke.Owner = cookiestandDto.Owner;
            await _context.SaveChangesAsync();
        }
    }
}
