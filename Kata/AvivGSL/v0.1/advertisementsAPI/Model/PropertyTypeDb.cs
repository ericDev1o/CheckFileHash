class PropertyTypeDb : DbContext
{
    public PropertyTypeDb (DbContextOptions<PropertyTypeDb> options) : base(options)
    {}
    public DbSet<PropertyTypeDb> Types => Set<PropertyTypeDb>();
}