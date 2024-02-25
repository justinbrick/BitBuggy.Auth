using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BitBuggy.Auth.Database;


public class UserContext : DbContext
{

    private readonly IConfiguration _configuration;
    public UserContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseNpgsql(_configuration.GetConnectionString("AuthDatabase"));
    }
}