using Financas.Repository;
using Financas.Repository.UsuarioRepository;
using Financas.UseCase.UsuarioUseCase.CriarUsuario;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json.Converters;

var builder = WebApplication.CreateBuilder(args);

builder.WebHost.UseUrls("https://localhost:7048;http://localhost:5288");

builder.Services.AddCors(opt =>
{
    opt.AddDefaultPolicy(policy =>
    {
        policy.AllowAnyOrigin();
        policy.AllowAnyHeader();
        policy.AllowAnyMethod();
    });
});

builder.Services.AddScoped<DataBaseContext, DataBaseContext>();

builder.Services.AddScoped<IUsuarioRepository, EFCoreUsuarioRepository>();
builder.Services.AddScoped<ICadastrarUsuarioUseCase, CadastrarUsuarioUseCase>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services
    .AddControllersWithViews()
    .AddNewtonsoftJson(options => 
        options.SerializerSettings.Converters.Add(new StringEnumConverter()));

builder.Services.AddLogging(config =>
{
    config.AddConsole();
    config.AddDebug();
});

var app = builder.Build();

app.UseCors();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();