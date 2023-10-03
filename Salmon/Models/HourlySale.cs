using Salmon.Interfaces;

namespace Salmon.Models
{
    public class HourlySale
    {
        public int Id { get; set; } // Primary key
        public int CookieStandId { get; set; } // Foreign key
        public int SalesValue { get; set; }

        
        public Cookiestand CookieStand { get; set; }
    }
}
