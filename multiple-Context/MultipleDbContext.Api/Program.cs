using Microsoft.EntityFrameworkCore;
using MultipleDbContext.Api.Data;
using MultipleDbContext.Api.Repository;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services
        .AddDbContext<DbOneContext>(options => options
        .UseSqlServer(builder.Configuration.GetConnectionString("DbOneContext")));

builder.Services
        .AddDbContext<DbTwoContext>(options => options
        .UseSqlServer(builder.Configuration.GetConnectionString("DbTwoContext")));

builder.Services.AddScoped<IPeopleRepository, PeopleRepository>();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.Run();