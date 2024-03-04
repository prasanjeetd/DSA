using WebApi.Middlewares;
using WebApi.MultipleImpInterfaces;
using WebApi.OptionPattern;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var services = builder.Services;
services.AddTransient<ServiceA>();
services.AddTransient<ServiceB>();
services.AddTransient<ServiceC>();

services.AddTransient<ServiceResolver>(serviceProvider => key =>
{
    switch (key)
    {
        case "A":
            return serviceProvider.GetService<ServiceA>();
        case "B":
            return serviceProvider.GetService<ServiceB>();
        case "C":
            return serviceProvider.GetService<ServiceC>();
        default:
            throw new KeyNotFoundException(); // or maybe return null, up to you
    }
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<FactoryActivatedMiddleware>();

builder.Services.Configure<PositionOptions>(
    builder.Configuration.GetSection(PositionOptions.Position));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseMiddleware<ConventionalMiddleware>();
app.UseMiddleware<FactoryActivatedMiddleware>();

app.UseAuthorization();

app.MapControllers();

app.Run();


/*
 * 
 * • Create a Web API that will result in JSON response for locations with
 * availability between 10 am and 1 pm.
•    You will have to create your own list of at least 10 locations with 
different time availabilities. For the locations think about different businesses 
such as a Pharmacy, a Bakery, a barber shop, a supermarket, a candy store, a cinema complex, etc. 
You can also use any other location you want. Feel free to be creative.

Keep your code and solutions as simple as possible
• The goal of this challenge is to check if you can code up a GET endpoint and properly formatted responses.
• Our team will do a Code review (code style, organization, naming conventions, declarations, commenting). Keep this in mind when writing code.
• Try to implement source control. Our team will review commit messages.
• Our team will review how you managed locations and times. Slurped up via c#, imported to database, copy-paste, etc.
• Our team will review if the API does return proper HTTP codes
• Our team will review how is the response object formatted.
• Our team will review what would be the JSON response if nothing is available.
• Try to perform unit testing and leave evidence.
 * 
 */