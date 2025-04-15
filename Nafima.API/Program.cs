using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Nafima.API.Middlewares;
using Nafima.Core.Entities;
using Nafima.Data;
using Nafima.Data.Repositories.Implementatitons;
using Nafima.Data.Repositories.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddIdentity<AppUser, IdentityRole>(opt =>
{
    opt.Password.RequireNonAlphanumeric = false;
    opt.Password.RequiredLength = 6;

}).AddDefaultTokenProviders().AddEntityFrameworkStores<AppDbContext>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});



builder.Services.AddScoped<IDonationRepository, DonationRepository>();

builder.Services.AddScoped<IFAQRepository,FAQRepository>();

builder.Services.AddScoped<IPartnershipRepository, PartnershipRepository>();

builder.Services.AddScoped<IReviewRepository, ReviewRepository>();

builder.Services.AddScoped<IServiceRepository, ServiceRepository>();

builder.Services.AddScoped<ISettingRepository, SettingRepository>();

builder.Services.AddScoped<ISliderRepository, SliderRepository>();

builder.Services.AddScoped<IStatisticRepository, StatisticRepository>();







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
app.UseMiddleware<ExceptionHandlerMiddleware>();


app.Run();
