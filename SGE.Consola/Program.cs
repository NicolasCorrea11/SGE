using SGE.Aplicacion;
using SGE.Repositorios;

// Configuro las dependencias
IExpedienteRepositorio repoExp = new RepositorioExpediente();
ITramiteRepositorio repoTramite = new RepositorioTramite();

// Creo los casos de uso de expedientes
var altaExp = new CasoDeUsoExpedienteAlta(repoExp);
var bajaExp = new CasoDeUsoExpedienteBaja(repoExp);
var modifExp = new CasoDeUsoExpedienteModificacion(repoExp);
var consultaIdExp = new CasoDeUsoExpedienteConsultaPorId(repoExp);
var consultaTodosExp = new CasoDeUsoExpedienteConsultaTodos(repoExp);

// Creo los casos de uso de tramites
var altaTramite = new CasoDeUsoTramiteAlta(repoTramite);
var bajaTramite = new CasoDeUsoTramiteBaja(repoTramite);
var modifTramite = new CasoDeUsoTramiteModificacion(repoTramite);
var consultaEtiqueta = new CasoDeUsoTramiteConsultaPorEtiqueta(repoTramite);

try
{
  /*
  altaExp.Ejecutar(new Expediente() { Caratula = "Prueba", Estado = EstadoExpediente.RecienIniciado }, 1);
  altaExp.Ejecutar(new Expediente() { Caratula = "Prueba 2", Estado = EstadoExpediente.RecienIniciado }, 1);
  altaExp.Ejecutar(new Expediente() { Caratula = "Prueba 3", Estado = EstadoExpediente.RecienIniciado }, 1);

  bajaExp.Ejecutar(2, 1);
  
  modifExp.Ejecutar(new Expediente() { Id = 1, Caratula = "Modificacion2", Estado = EstadoExpediente.RecienIniciado }, 1);
  
  Console.WriteLine(consultaIdExp.Ejecutar(3));
  
  foreach (object o in consultaTodosExp.Ejecutar(3))
  {
    Console.WriteLine(o);
  }
  */
  // altaTramite.Ejecutar(new Tramite() { Id = 1, ExpedienteId = 3, Etiqueta = EtiquetaTramite.Resolucion }, 1);
  // altaTramite.Ejecutar(new Tramite() { Id = 2, ExpedienteId = 3, Etiqueta = EtiquetaTramite.PaseAEstudio }, 1);

  foreach (object o in consultaTodosExp.Ejecutar(3))
  {
    Console.WriteLine(o);
  }
}
catch (Exception ex)
{
  Console.WriteLine(ex);
}
