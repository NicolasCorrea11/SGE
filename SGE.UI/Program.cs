using SGE.UI.Components;
using SGE.Repositorios;
using SGE.Aplicacion;

BaseSqlite.Inicializar();

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services
    .AddTransient<CasoDeUsoExpedienteAlta>()
    .AddTransient<CasoDeUsoExpedienteBaja>()
    .AddTransient<CasoDeUsoExpedienteModificacion>()
    .AddTransient<CasoDeUsoListarExpedientes>()
    .AddTransient<CasoDeUsoExpedienteConsultaId>()
    .AddTransient<CasoDeUsoExpedienteConsultaTodos>()
    .AddTransient<CasoDeUsoSignup>()
    .AddTransient<CasoDeUsoLogin>()
    .AddTransient<CasoDeUsoUsuarioModificacion>()
    .AddTransient<CasoDeUsoConsultaUsuarioId>()
    .AddTransient<CasoDeUsoTramiteAlta>()
    .AddTransient<CasoDeUsoTramiteBaja>()
    .AddTransient<CasoDeUsoTramiteModificacion>()
    .AddTransient<CasoDeUsoTramiteConsultaEtiqueta>()
    .AddTransient<CasoDeUsoTramiteConsultaId>()
    .AddTransient<CasoDeUsoTramiteConsultaExpId>()
    .AddScoped<ExpedienteValidador>()
    .AddScoped<TramiteValidador>()
    .AddScoped<IUsuarioRepositorio, RepositorioUsuarios>()
    .AddScoped<IExpedienteRepositorio, RepositorioExpediente>()
    .AddScoped<ITramiteRepositorio, RepositorioTramite>()
    .AddScoped<IServicioAutorizacion, ServicioAutorizacion>();

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
