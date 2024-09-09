using Microsoft.EntityFrameworkCore;

namespace Products_Web_API.Models
{
    public class APIdbContext:DbContext
    {
        public APIdbContext(DbContextOptions options): base(options) 
        { 

        }

        public DbSet<Products> Products { get; set; }
    }
}
