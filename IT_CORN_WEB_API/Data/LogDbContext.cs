using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using IT_CORN_WEB_API.Data.Entity;

namespace IT_CORN_WEB_API.Data;

public class LogDbContext : DbContext
{
    public DbSet<RequestLog> RequestLogs { get; set; }
    public DbSet<GeoData?> GeoDatas { get; set; }

    public LogDbContext(DbContextOptions<LogDbContext> options) : base(options)
    {
    }
}