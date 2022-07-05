using ProjetoRedeHoteis.Lib.Data;
using Microsoft.EntityFrameworkCore;
using ProjetoRedeHoteis.Lib.Data.Repositorios;
using ProjetoRedeHoteis.Lib.Data.Repositorios.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<RedeHoteisContext>(
        conn => conn.UseNpgsql(builder.Configuration.GetConnectionString("RedeHoteis_DB"))
                    .UseSnakeCaseNamingConvention()
    );

builder.Services.AddControllers()
                .AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling =
Newtonsoft.Json.ReferenceLoopHandling.Ignore);
builder.Services.AddScoped<ICategoriaQuartoRepositorio, CategoriaQuartoRepositorio>();
builder.Services.AddScoped<IEstadiaHospedeRepositorio, EstadiaHospedeRepositorio>();
builder.Services.AddScoped<IEstadiaRepositorio, EstadiaRepositorio>();
builder.Services.AddScoped<IHospedeRepositorio, HospedeRepositorio>();
builder.Services.AddScoped<IHotelRepositorio, HotelRepositorio>();
builder.Services.AddScoped<IQuartoRepositorio, QuartoRepositorio>();
builder.Services.AddScoped<IServicoHotelRepositorio, ServicoHotelRepositorio>();
builder.Services.AddScoped<IServicoRepositorio, ServicoRepositorio>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
