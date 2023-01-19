//using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
/*builder.Services.AddDbContext<PropertyTypeDb>();
builder.Services.AddDbContext<PropertyStatusDb>();
builder.Services.AddDbContext<PropertyAddressDb>();
builder.Services.AddDbContext<PropertyAdDb>();*/
builder.Services.AddDatabaseDeveloperPageExceptionFilter();
var app = builder.Build();

app.MapGet("/", () => "This is a data persistency POC aiming to be a more complete clean API");
//app.MapGet("/annonce", async (PropertyAdDb propertyAdDb) => await propertyAdDb.Ads.ToListAsync());

app.Run();