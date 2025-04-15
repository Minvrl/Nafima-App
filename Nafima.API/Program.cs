using AutoMapper;
using MicroElements.Swashbuckle.FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Nafima.API.Middlewares;
using Nafima.Core.Entities;
using Nafima.Data;
using Nafima.Data.Repositories.Implementatitons;
using Nafima.Data.Repositories.Interfaces;
using Nafima.Service.Exceptions;
using Nafima.Service.Implementations;
using Nafima.Service.Interfaces;
using Nafima.Service.Profiles;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().ConfigureApiBehaviorOptions(options =>
{
    options.InvalidModelStateResponseFactory = context =>
    {

        var errors = context.ModelState.Where(x => x.Value.Errors.Count > 0)
        .Select(x => new RestExceptionError(x.Key, x.Value.Errors.First().ErrorMessage)).ToList();

        return new BadRequestObjectResult(new { message = "", errors });
    };
});

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddIdentity<AppUser, IdentityRole>(opt =>
{
    opt.Password.RequireNonAlphanumeric = false;
    opt.Password.RequiredLength = 6;

}).AddDefaultTokenProviders().AddEntityFrameworkStores<AppDbContext>();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHttpContextAccessor();
builder.Services.AddSingleton(provider => new MapperConfiguration(cfg =>
{
    cfg.AddProfile(new MapProfile(provider.GetService<IHttpContextAccessor>()));
}).CreateMapper());
builder.Services.AddDbContext<AppDbContext>(opt =>
{
    opt.UseSqlServer(builder.Configuration.GetConnectionString("Default"));
});



builder.Services.AddScoped<IDonationRepository, DonationRepository>();

builder.Services.AddScoped<IFAQRepository,FAQRepository>();
builder.Services.AddScoped<IFAQService, FAQService>();
builder.Services.AddScoped<IPartnershipRepository, PartnershipRepository>();

builder.Services.AddScoped<IReviewRepository, ReviewRepository>();

builder.Services.AddScoped<IServiceRepository, ServiceRepository>();

builder.Services.AddScoped<ISettingRepository, SettingRepository>();

builder.Services.AddScoped<ISliderRepository, SliderRepository>();

builder.Services.AddScoped<IStatisticRepository, StatisticRepository>();


builder.Services.AddFluentValidationRulesToSwagger();







var app = builder.Build();


app.UseAuthentication();
app.UseAuthorization();
app.UseStaticFiles();
app.UseHttpsRedirection();
// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}



app.MapControllers();
app.UseMiddleware<ExceptionHandlerMiddleware>();


app.Run();
