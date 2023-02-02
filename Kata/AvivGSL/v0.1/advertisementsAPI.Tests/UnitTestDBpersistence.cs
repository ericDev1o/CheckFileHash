namespace advertisementsAPI.Tests;
/*
<summary>
This class tests the database persistency of a posted advertisement.
</summary>
*/
public class UnitTestDBpersistence
{
    /*
    <summary>
    The advertisement is persisted in DB.
    It should either be embedded in an uncommited transaction
    or rollbacked after the insertion and success response.
    </summary>
    */
    [Fact]
    public async Task TestAdvertisementIdReturned_OK()
    {
        //Arrange
        await using var context = new MockDb().CreateDbContext();
        //Act
        context.Ads.Add(new PropertyAd
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
        });
        var written = await context.SaveChangesAsync();
        //Assert
        Assert.Equal(4, written);
    }
    /*
    <summary>
    The advertisement isn't created nor persisted in DB.
    </summary>
    */
    [Fact]
    public async Task TestAdvertisementIdReturned_KO()
    {
        //Arrange
        await using var context = new MockDb().CreateDbContext();
        //Act
        var notFound = context.GetAd(0);
        //Assert
        Assert.Equal(Results.NotFound(), notFound);
    }
}