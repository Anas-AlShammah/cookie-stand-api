namespace Salmon.Dtos
{
    public class CookiestandDto
    {
        public string Location { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;
        public int minimum_customers_per_hour { get; set; }
        public int maximum_customers_per_hour { get; set; }
        public double average_cookies_per_sale { get; set; }
        public string? Owner { get; set; }
    }
}
