using Salmon.Dtos;
using Salmon.Models;

namespace Salmon.Interfaces
{
    public interface ICookiestand
    {
        Task Post(CookiestandDto cookiestandDto);
        Task<List<Cookiestand>> GetAll();
        Task <Cookiestand> GetById(int id);
        Task Delete (int id);
        Task Put(int id, CookiestandDto cookiestandDto);
    }
}
