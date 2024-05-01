using SGE.Aplicacion;
using SGE.Repositorios;

// Configuro los repositorios
ITramiteRepositorio repoTramite = new RepositorioTramite();
IExpedienteRepositorio repoExp = new RepositorioExpediente(repoTramite);
// Configuro la especificacion de actualizacion de estado
IEspecificacionCambioEstado espec = new EspecificacionCambioEstado();
// Configuro los servicios
IServicioAutorizacion auth = new ServicioAutorizacionProvisiorio();
IServicioActualizacionEstado act = new ServicioActualizacionEstado(repoExp, espec);
// Configuros los validadores
ExpedienteValidador valExp = new();
TramiteValidador valTramite = new();
RepositorioExpValidador repoValExp = new(repoExp);
RepositorioTramiteValidador repoValTramite = new(repoExp, repoTramite);

// Creo los casos de uso de expedientes
var altaExp = new CasoDeUsoExpedienteAlta(repoExp, auth, valExp);
var bajaExp = new CasoDeUsoExpedienteBaja(repoExp, auth, repoValExp);
var modifExp = new CasoDeUsoExpedienteModificacion(repoExp, auth, repoValExp);
var consultaIdExp = new CasoDeUsoExpedienteConsultaPorId(repoExp);
var consultaTodosExp = new CasoDeUsoExpedienteConsultaTodos(repoExp);
// Creo los casos de uso de tramites
var altaTramite = new CasoDeUsoTramiteAlta(repoTramite, auth, act, valTramite);
var bajaTramite = new CasoDeUsoTramiteBaja(repoTramite, auth, act, repoValTramite);
var modifTramite = new CasoDeUsoTramiteModificacion(repoTramite, auth, act, repoValTramite);
var consultaEtiqueta = new CasoDeUsoTramiteConsultaPorEtiqueta(repoTramite);
