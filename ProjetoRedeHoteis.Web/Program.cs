using ProjetoRedeHoteis.Lib.Data;
using Microsoft.EntityFrameworkCore;
using ProjetoRedeHoteis.Lib.Data.Repositorios;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<RedeHoteisContext>(
        conn => conn.UseNpgsql(builder.Configuration.GetConnectionString("RedeHoteis_DB"))
                    .UseSnakeCaseNamingConvention()
    );

builder.Services.AddControllers()
                .AddNewtonsoftJson(x => x.SerializerSettings.ReferenceLoopHandling =
Newtonsoft.Json.ReferenceLoopHandling.Ignore);
builder.Services.AddScoped<CategoriaQuartoRepositorio>();
builder.Services.AddScoped<EstadiaHospedeRepositorio>();
builder.Services.AddScoped<EstadiaRepositorio>();
builder.Services.AddScoped<HospedeRepositorio>();
builder.Services.AddScoped<HotelRepositorio>();
builder.Services.AddScoped<QuartoRepositorio>();
builder.Services.AddScoped<ServicoHotelRepositorio>();
builder.Services.AddScoped<ServicoRepositorio>();

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
