using eCommerceInfrastructure.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

//Inject infrastructure services.
builder.Services.AddInfrastructure();
builder.Services.AddCoreLayer();

//Add Controllers
builder.Services.AddControllers();
var app = builder.Build();

app.UseRouting();
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();


app.Run();
