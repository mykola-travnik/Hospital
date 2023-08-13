using App.Middleware;
using Business;
using Business.DataSeedService;
using Business.Services;
using Data.Repositories;
using Infrastructure.Contexts;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAuthorization();
builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            // указывает, будет ли валидироваться издатель при валидации токена
            ValidateIssuer = true,
            // строка, представляющая издателя
            ValidIssuer = AuthOptions.ISSUER,
            // будет ли валидироваться потребитель токена
            ValidateAudience = true,
            // установка потребителя токена
            ValidAudience = AuthOptions.AUDIENCE,
            // будет ли валидироваться время существования
            ValidateLifetime = true,
            // установка ключа безопасности
            IssuerSigningKey = AuthOptions.GetSymmetricSecurityKey(),
            // валидация ключа безопасности
            ValidateIssuerSigningKey = true
        };
    });

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<MainContext>();
builder.Services.AddAutoMapper(typeof(MapperConfig));


builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(
        policy =>
        {
            policy.AllowAnyOrigin()
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
});

// Add repository
builder.Services.AddScoped<ICountryRepository, CountryRepository>();
builder.Services.AddScoped<ICityRepository, CityRepository>();
builder.Services.AddScoped<IDoctorRepository, DoctorRepository>();
builder.Services.AddScoped<IHospitalRepository, HospitalRepository>();
builder.Services.AddScoped<ISpecialisationRepository, SpecialisationRepository>();
builder.Services.AddScoped<ISpecialisationDoctorRepository, SpecialisationDoctorRepository>();
builder.Services.AddScoped<IHospitalDoctorRepository, HospitalDoctorRepository>();
builder.Services.AddScoped<IRoleRepository, RoleRepository>();
builder.Services.AddScoped<IUserRepository, UserRepository>();

// Services
builder.Services.AddScoped<ICityService, CityService>();
builder.Services.AddScoped<ICountryService, CountryService>();
builder.Services.AddScoped<IDoctorService, DoctorService>();
builder.Services.AddScoped<IHospitalDoctorService, HospitalDoctorService>();
builder.Services.AddScoped<IHospitalService, HospitalService>();
builder.Services.AddScoped<ISpecialisationDoctorService, SpecialisationDoctorService>();
builder.Services.AddScoped<ISpecialisationService, SpecialisationService>();
builder.Services.AddScoped<IRoleService, RoleService>();
builder.Services.AddScoped<IUserService, UserService>();
builder.Services.AddScoped<IAuthService, AuthService>();

// Data seeding services
builder.Services.AddTransient<ICountryDataSeedService, CountryDataSeedService>();
builder.Services.AddTransient<ICityDataSeedService, CityDataSeedService>();
builder.Services.AddTransient<IDoctorDataSeedService, DoctorDataSeedService>();
builder.Services.AddTransient<IHospitalDataSeedService, HospitalDataSeedService>();
builder.Services.AddTransient<ISpecialisationDataSeedService, SpecialisationDataSeedService>();
builder.Services.AddTransient<ISpecialisationDoctorDataSeedService, SpecialisationDoctorDataSeedService>();
builder.Services.AddTransient<IHospitalDoctorDataSeedService, HospitalDoctorDataSeedService>();
builder.Services.AddTransient<IUserDataSeedService, UserDataSeedService>();
builder.Services.AddTransient<IRoleDataSeedService, RoleDataSeedService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthentication();
app.UseAuthorization();

app.UseMiddleware<JwtMiddleware>();

app.MapControllers();
app.UseCors();

app.Run();