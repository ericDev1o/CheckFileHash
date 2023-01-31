class PropertyAddressDb : DbContext
{
    public PropertyAddressDb(DbContextOptions<PropertyAddressDb> options)
    : base(options)
    {
    }
    public DbSet<PropertyAddressDb> Addresses => Set<PropertyAddressDb>();
}