
using System.Runtime.CompilerServices;
using Infrastructure;
using Infrastructure.Persistence;
using Infrastructure.Persistence.SeedData;
using Microsoft.EntityFrameworkCore;
using web;

var builder = WebApplication.CreateBuilder(args);

//configuration
builder.Services.AddInfrastructureServices(builder.Configuration);
builder.AddWebConfigureServices(); 
//build
var app = builder.Build();
await app.AddWebAppServiceAsync().ConfigureAwait(false);  
