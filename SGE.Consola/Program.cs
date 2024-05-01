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

/*
altaExp.Ejecutar(new Expediente() { Caratula = "Expediente 1", Estado = EstadoExpediente.RecienIniciado }, 1);
altaExp.Ejecutar(new Expediente() { Caratula = "Expediente 2", Estado = EstadoExpediente.RecienIniciado }, 1);
altaExp.Ejecutar(new Expediente() { Caratula = "Expediente 3", Estado = EstadoExpediente.RecienIniciado }, 1);

altaTramite.Ejecutar(new Tramite() { ExpedienteId = 1, Contenido = "Tramite 1, Expediente 1", Etiqueta = EtiquetaTramite.Resolucion }, 1);
altaTramite.Ejecutar(new Tramite() { ExpedienteId = 1, Contenido = "Tramite 2, Expediente 1", Etiqueta = EtiquetaTramite.PaseAEstudio }, 1);
altaTramite.Ejecutar(new Tramite() { ExpedienteId = 3, Contenido = "Tramite 3, Expediente 3", Etiqueta = EtiquetaTramite.PaseAlArchivo }, 1);
/*
Console.WriteLine(consultaIdExp.Ejecutar(1));

foreach (object o in consultaTodosExp.Ejecutar(1))
{
  Console.WriteLine(o);
}

foreach (Tramite t in consultaEtiqueta.Ejecutar(EtiquetaTramite.PaseAEstudio))
{
  Console.WriteLine(t);
}

foreach (Expediente e in repoExp.ListarExpedientes())
{
  Console.WriteLine(e);
}

bajaExp.Ejecutar(3, 1);
bajaTramite.Ejecutar(2, 1);

modifExp.Ejecutar(new Expediente() { Id = 3, Caratula = "Prueba 3 mod", Estado = EstadoExpediente.ParaResolver }, 1);
modifTramite.Ejecutar(new Tramite() { Id = 1, ExpedienteId = 1, Contenido = "Tramite 1", Etiqueta = EtiquetaTramite.PaseAlArchivo }, 1);
*/


try
{
  /*
  altaExp.Ejecutar(new Expediente() { Caratula = "Expediente 1", Estado = EstadoExpediente.RecienIniciado }, 1);
  altaExp.Ejecutar(new Expediente() { Caratula = "Expediente 2", Estado = EstadoExpediente.RecienIniciado }, 1);
  altaExp.Ejecutar(new Expediente() { Caratula = "Expediente 3", Estado = EstadoExpediente.RecienIniciado }, 1);
  
  
  modifExp.Ejecutar(new Expediente() { Id = 5, Caratula = "Modificacion2", Estado = EstadoExpediente.RecienIniciado }, 1);
  
  Console.WriteLine(consultaIdExp.Ejecutar(3));
  
  foreach (object o in consultaTodosExp.Ejecutar(3))
  {
    Console.WriteLine(o);
  }
  

  altaTramite.Ejecutar(new Tramite() { Id = 1, ExpedienteId = 3, Contenido = "Tramite 1", Etiqueta = EtiquetaTramite.Resolucion }, 1);
  Console.WriteLine(consultaIdExp.Ejecutar(3)?.Estado);
  altaTramite.Ejecutar(new Tramite() { Id = 2, ExpedienteId = 3, Contenido = "Tramite 2", Etiqueta = EtiquetaTramite.PaseAEstudio }, 1);
  Console.WriteLine(consultaIdExp.Ejecutar(3)?.Estado);
  altaTramite.Ejecutar(new Tramite() { Id = 3, ExpedienteId = 3, Contenido = "Tramite 3", Etiqueta = EtiquetaTramite.PaseAlArchivo }, 1);
  Console.WriteLine(consultaIdExp.Ejecutar(3)?.Estado);
  
  Tramite tramite = new() { Id = 5, ExpedienteId = 3, Etiqueta = EtiquetaTramite.Resolucion };
  modifTramite.Ejecutar(tramite, 1);
  
  bajaTramite.Ejecutar(5, 1);
  
  Console.WriteLine(consultaIdExp.Ejecutar(3)?.Estado);
  
  foreach (Tramite t in consultaEtiqueta.Ejecutar(EtiquetaTramite.Resolucion))
  {
    Console.WriteLine(t);
  }
  */
}

catch (Exception ex)
{
  Console.WriteLine(ex);
}