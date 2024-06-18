using SGE.UI.Components;
using SGE.Repositorios;
using SGE.Aplicacion;

BaseSqlite.Inicializar();

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddTransient<CasoDeUsoExpedienteAlta>()
    .AddTransient<CasoDeUsoSignup>()
    .AddTransient<CasoDeUsoLogin>()
    .AddTransient<CasoDeUsoConsultaUsuarioId>()
    .AddScoped<IUsuarioRepositorio, RepositorioUsuarios>()
    .AddScoped<IExpedienteRepositorio, RepositorioExpediente>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
}

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
