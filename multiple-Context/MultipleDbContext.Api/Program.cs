using Autofac;
using Autofac.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using MultipleDbContext.Api.Data;
using MultipleDbContext.Api.Ioc;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddControllers();

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(x => x.RegisterModule(new AutoFacModule()));

builder.Services
        .AddDbContext<DbOneContext>(options => options
        .UseSqlServer(builder.Configuration.GetConnectionString("DbOneContext")));

builder.Services
        .AddDbContext<DbTwoContext>(options => options
        .UseSqlServer(builder.Configuration.GetConnectionString("DbTwoContext")));

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthorization();

app.MapControllers();

app.Run();