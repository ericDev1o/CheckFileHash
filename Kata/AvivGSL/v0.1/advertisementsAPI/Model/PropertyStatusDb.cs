class PropertyStatusDb : DbContext
{
    public PropertyStatusDb(DbContextOptions<PropertyStatusDb> options) : base(options)
    {
    }
    public DbSet<PropertyStatusDb> Statuses => Set<PropertyStatusDb>();
}