using CapitalPlacementTask.Api.Services.Implementation;
using CapitalPlacementTask.Api.Services.Interfaces;
using Microsoft.Azure.Cosmos;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register Services
builder.Services.AddScoped<IApplicationFormService, ApplicationFormService>();
builder.Services.AddScoped<IApplicationSubmissionService, ApplicationSubmissionService>();

// CosmosDb Setup
builder.Services.AddSingleton<CosmosClient>(sp =>
{
    var connectionString = builder.Configuration.GetConnectionString("CosmosDb");
    return new CosmosClient(connectionString);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
