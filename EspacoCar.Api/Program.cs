using System.Text.Json.Serialization;
using EspacoCar.Api.Data;
using EspacoCar.Api.Repositories;
using EspacoCar.Api.Repositories.Contratos;
using EspacoCar.Api.Services;
using EspacoCar.Api.Services.contratos;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddControllers()
            .AddJsonOptions(options =>
            {
                options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
            });

builder.Services.AddDbContext<DataContext>(
    options => options.UseSqlServer(builder.Configuration.GetConnectionString("connectionStings")));

builder.Services.AddTransient<IProdutoService, ProdutoService>();
builder.Services.AddTransient<ICategoriaDeProdutoService, CategoriaDeProdutoService>();
builder.Services.AddTransient<IEntradaDeProdutoServcie, EntradaDeProdutoService>();
builder.Services.AddTransient<ISaidaDeProdutoServcie, SaidaDeProdutoService>();

builder.Services.AddTransient<IProdutoRepositorio, ProdutoRepositorio>();
builder.Services.AddTransient<IProdutoCategoriaRepositorio, ProdutoCategoriaRepositorio>();
builder.Services.AddTransient<IProdutoEntradaRepositorio, ProdutoEntradaRepositorio>();
builder.Services.AddTransient<IProdutoSaidaRepositorio, ProdutoSaidaRepositorio>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.MapControllers();

app.Run();
