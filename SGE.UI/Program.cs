using SGE.UI.Components;
using SGE.Repositorios;
using SGE.Aplicacion;


BaseSqlite.Inicializar();

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services
    // CASOS DE EXPEDIENTE
    .AddTransient<CasoDeUsoExpedienteAlta>()
    .AddTransient<CasoDeUsoExpedienteBaja>()
    .AddTransient<CasoDeUsoExpedienteModificacion>()
    .AddTransient<CasoDeUsoExpedienteListar>()
    .AddTransient<CasoDeUsoExpedienteConsultaId>()
    .AddTransient<CasoDeUsoExpedienteConsultaTodos>()
    // CASOS DE TRAMITE
    .AddTransient<CasoDeUsoTramiteAlta>()
    .AddTransient<CasoDeUsoTramiteBaja>()
    .AddTransient<CasoDeUsoTramiteModificacion>()
    .AddTransient<CasoDeUsoTramiteListar>()
    .AddTransient<CasoDeUsoTramiteConsultaEtiqueta>()
    .AddTransient<CasoDeUsoTramiteConsultaId>()
    .AddTransient<CasoDeUsoTramiteConsultaExpId>()
    // CASOS DE USUARIO
    .AddTransient<CasoDeUsoUsuarioSignup>()
    .AddTransient<CasoDeUsoUsuarioLogin>()
    .AddTransient<CasoDeUsoUsuarioEliminar>()
    .AddTransient<CasoDeUsoUsuarioModificacion>()
    .AddTransient<CasoDeUsoUsuarioConsultaId>()
    .AddTransient<CasoDeUsoUsuarioListar>()
    .AddTransient<CasoDeUsoUsuarioOtorgarPermiso>()
    .AddTransient<CasoDeUsoUsuarioQuitarPermiso>()
    // VALIDADORES
    .AddScoped<ExpedienteValidador>()
    .AddScoped<TramiteValidador>()
    .AddScoped<UsuarioValidador>()
    // REPOSITORIOS
    .AddScoped<IUsuarioRepositorio, RepositorioUsuarios>()
    .AddScoped<IExpedienteRepositorio, RepositorioExpediente>()
    .AddScoped<ITramiteRepositorio, RepositorioTramite>()
    // SERVICIOS
    .AddScoped<IServicioAutorizacion, ServicioAutorizacion>()
    .AddScoped<IServicioActualizacionEstado, ServicioActualizacionEstado>()
    .AddScoped<IServicioHash, ServicioHash>()
    .AddScoped<IEspecificacionCambioEstado, EspecificacionCambioEstado>();

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
