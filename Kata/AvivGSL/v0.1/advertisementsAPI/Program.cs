var builder = WebApplication.CreateBuilder(args);
/*builder.Services.AddDbContext<PropertyTypeDb>();
builder.Services.AddDbContext<PropertyStatusDb>();
builder.Services.AddDbContext<PropertyAddressDb>();
builder.Services.AddDbContext<PropertyAdDb>();*/
// development environment
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
builder.Services.AddProblemDetails();
var app = builder.Build();
if(app.Environment.IsDevelopment())
{    
    app.UseStatusCodePages();
}
app.MapGet("/", () => "This is a data persistency API POC")
//app.MapGet("/annonce", async (PropertyAdDb propertyAdDb) => await propertyAdDb.Ads.ToListAsync());
.WithOpenApi();
/*app.MapPost(
    "/annonce/{id}", 
    async(int id, PropertyAd ad, PropertyAdDb adDb)
    =>
    {
        ad.Id = id;
        adDb.Ads.Add(ad);
        await adDb.SaveChangesAsync();
        return Results.Created($"/annonce/{ad.Id}",ad);
    }
)
.WithOpenApi();*/
app.Run();