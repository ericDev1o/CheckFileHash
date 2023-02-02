public class PropertyAdDb : DbContext
{
    public PropertyAdDb(DbContextOptions<PropertyAdDb> options) : base(options)
    {}
    public DbSet<PropertyAd> Ads => Set<PropertyAd>();

    //error
    /*public async Task<IResult> GetAd(int i)
    {
        return await Ads.Where(Ad => Ad.Id == i).First();
    }*/
    public IResult GetAd(int i)
    {
        return (IResult) Ads.Where(Ad => Ad.Id == i)
        .First();
        /*.FirstOrDefault(..., new PropertyAd
        {
            Id=1,
            Description="test flat",
            Localization=new PropertyAddress
            {
                Id=1,
                Country="FR",
                PostalCode=0,
                City="test city",
                Street="test street",
                Number=0
            },
            Type=new PropertyType
            {
                Type=PropertyTypesEnum.Flat
            },
            Published= new PropertyStatus
            {
                Status = PropertyStatusesEnum.Pending
            }
        }
        );*/
    }
}