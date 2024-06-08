using Microsoft.EntityFrameworkCore;

namespace kolokwium_v2.Context;

public class AppDbContext : DbContext
{
    public AppDbContext()
    {
        
    }

    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
    {
        
    }

}