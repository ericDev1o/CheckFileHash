using Microsoft.EntityFrameworkCore;
class PropertyTypeDb : DbContext
{
    public PropertyTypeDb (DbContextOptions<PropertyTypeDb> options)
    {}
    public DbSet<PropertyTypeDb> Types => Set<PropertyTypeDb>();
}