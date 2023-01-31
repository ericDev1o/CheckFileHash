class PropertyAdDb : DbContext
{
    public PropertyAdDb(DbContextOptions<PropertyAdDb> options)
    {}
    public DbSet<PropertyAd> Ads => Set<PropertyAd>();

    //error
    /*public async Task<IResult> GetAd(int i)
    {
        return await Ads.Where(Ad => Ad.Id == i).First();
    }*/
    public IResult GetAd(int i)
    {
        return (IResult)Ads.Where(Ad => Ad.Id == i).First();
    }
}