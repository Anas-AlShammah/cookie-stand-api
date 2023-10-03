using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Salmon.Dtos;
using Salmon.Interfaces;
using Salmon.Models;

namespace Salmon.Controllers
{
    [Route("api")]
    [ApiController]
    public class CookiestandController : ControllerBase
    {
        private readonly ICookiestand _cookiestand;
        public CookiestandController(ICookiestand cookiestand)
        {
            _cookiestand = cookiestand;
        }
        [HttpPost("Cookiestand")]
        public async Task<ActionResult> Post(CookiestandDto cookiestandDto)
        {
            await _cookiestand.Post(cookiestandDto);
            return Ok();
        }
        [HttpPut("Cookiestand/{id}")]
        public async Task<ActionResult> Put(int id,CookiestandDto cookiestandDto)
        {
            await _cookiestand.Put(id,cookiestandDto);
            return Ok();
        }
        [HttpGet("Cookiestands")]
        public async Task<List<Cookiestand>> GetAll()
        {
            return await _cookiestand.GetAll();
        }
        [HttpGet("Cookiestand/{id}")]
        public async Task<Cookiestand> GetById(int id)
        {
            return await _cookiestand.GetById(id);
        }
        [HttpDelete("Cookiestand/{id}")]
        public async Task<ActionResult> Delete(int id)
        {
             await _cookiestand.Delete(id);
            return NoContent();
        }
    }
}
