var builder = WebApplication.CreateBuilder(args);

//Register your Api
RegisterServices(builder.Services);

var app = builder.Build();

// Configure the Milddleware 
var apis = app.Services.GetServices<IApi>();
foreach (var api in apis )
{
    if(api is null) throw new InvalidProgramException("Apis not Found");

    api.Register(app);
}

app.Run();

void RegisterServices(IServiceCollection services)
{
    // Add framework services.
    services.AddDbContext<AppDbContext>();
    services.AddScoped<IReserva, ReservaRepository>();
    services.AddTransient<IApi, ClienteApi>();
}