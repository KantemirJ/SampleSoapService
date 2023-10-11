using SoapCore;
using SampleSoapService.Services;
using SampleSoapService.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SampleSoapServiceContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("Postgres")));

builder.Services.AddSoapCore();
builder.Services.AddScoped<IDatabaseManager, DatabaseManager>();
builder.Services.AddSoapCore();
builder.Services.AddScoped<ISoapService, SoapService>();

var app = builder.Build();

app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.UseSoapEndpoint<IDatabaseManager>("/DbService.asmx", new SoapEncoderOptions(), SoapSerializer.XmlSerializer);
    endpoints.UseSoapEndpoint<ISoapService>("/Service.asmx", new SoapEncoderOptions(), SoapSerializer.XmlSerializer);
});

app.Run();
