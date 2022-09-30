using OData;

var builder = WebApplication.CreateBuilder(args);

var startUp = new Startup(builder.Configuration);

startUp.ConfigurationServices(builder.Services);

var app = builder.Build();

startUp.Configure(app, app.Environment);

app.Run();