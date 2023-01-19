using Microsoft.EntityFrameworkCore;
class PropertyAdDb : DbContext
{
    public PropertyAdDb(DbContextOptions<PropertyAdDb> options)
    {}
    public DbSet<PropertyAdDb> Ads => Set<PropertyAdDb>();
}