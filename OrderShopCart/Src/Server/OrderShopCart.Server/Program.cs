using OrderShopCart.Application;
using OrderShopCart.Server;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle

builder.Services.ConfigureApplicationLayer();
builder.Services.ConfigureMapster();
builder.Services.ConfigureValidator();
builder.Services.ConfigureCors();

builder.Services.AddEndpoints();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseCors("AllowOrigin");

app.MapEndpoints();

await app.RunAsync();