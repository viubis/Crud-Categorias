using Categorias.Domain.Interfaces.Repositorios;
using Categorias.Infra.Data.Contexto;
using Categorias.Infra.Data.Repositorios;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Adicione servi�os ao cont�iner.
builder.Services.AddControllers();
// Saiba mais sobre a configura��o do Swagger/OpenAPI em https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<CategoriaContexto>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("CategoriaConnection"));
});

builder.Services.AddTransient<IRepositorioCategoria, RepositorioCategoria>();

var assemblyDomain = AppDomain.CurrentDomain.Load("Categorias.Domain");
builder.Services.AddMediatR(assemblyDomain);

var app = builder.Build();

// Configure o pipeline de solicita��o HTTP.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// UseAuthorization deve ser colocado entre UseRouting e UseEndpoints
app.UseRouting();

app.UseAuthorization();

app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});

app.Run();
