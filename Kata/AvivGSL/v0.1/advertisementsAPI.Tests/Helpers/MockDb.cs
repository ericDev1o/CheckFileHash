namespace advertisementsAPI.Tests.Helpers;
public class MockDb : IDbContextFactory<PropertyAdDb>
{
    public PropertyAdDb CreateDbContext()
    {
        var options = new DbContextOptionsBuilder<PropertyAdDb>()
        .UseInMemoryDatabase($"InMemoryTestDb-{DateTime.Now.ToFileTimeUtc()}")
        .Options;
        return new PropertyAdDb(options);
    }
}