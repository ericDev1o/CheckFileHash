using Microsoft.EntityFrameworkCore;
class PropertyStatusDb : DbContext
{
    public PropertyStatusDb(DbContextOptions<PropertyStatusDb> options)
    {
    }
    public DbSet<PropertyStatusDb> Statuses => Set<PropertyStatusDb>();
}