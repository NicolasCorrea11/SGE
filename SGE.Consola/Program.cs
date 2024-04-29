using SGE.Aplicacion;
using SGE.Repositorios;

// Configuro las dependencias
IExpedienteRepositorio repoExp = new RepositorioExpediente();
ITramiteRepositorio repoTramite = new RepositorioTramite();
// Configuro los servicios
ServicioAutorizacionProvisiorio auth = new();
ServicioActualizacionEstado act = new(repoExp);


// Creo los casos de uso de expedientes
var altaExp = new CasoDeUsoExpedienteAlta(repoExp, auth);
var bajaExp = new CasoDeUsoExpedienteBaja(repoExp, auth);
var modifExp = new CasoDeUsoExpedienteModificacion(repoExp, auth);
var consultaIdExp = new CasoDeUsoExpedienteConsultaPorId(repoExp);
var consultaTodosExp = new CasoDeUsoExpedienteConsultaTodos(repoExp);
// Creo los casos de uso de tramites
var altaTramite = new CasoDeUsoTramiteAlta(repoTramite, auth, act);
var bajaTramite = new CasoDeUsoTramiteBaja(repoTramite, auth, act);
var modifTramite = new CasoDeUsoTramiteModificacion(repoTramite, auth, act);
var consultaEtiqueta = new CasoDeUsoTramiteConsultaPorEtiqueta(repoTramite);


//altaExp.Ejecutar(new Expediente() { Caratula = "Prueba 1", Estado = EstadoExpediente.RecienIniciado }, 1);
//altaExp.Ejecutar(new Expediente() { Caratula = "Prueba 2", Estado = EstadoExpediente.RecienIniciado }, 1);
//altaExp.Ejecutar(new Expediente() { Caratula = "Prueba 3", Estado = EstadoExpediente.RecienIniciado }, 1);

//altaTramite.Ejecutar(new Tramite() { Id = 1, ExpedienteId = 1, Contenido = "Tramite 1", Etiqueta = EtiquetaTramite.Despacho }, 1);
//altaTramite.Ejecutar(new Tramite() { Id = 2, ExpedienteId = 2, Contenido = "Tramite 2", Etiqueta = EtiquetaTramite.Despacho }, 1);
//altaTramite.Ejecutar(new Tramite() { Id = 3, ExpedienteId = 3, Contenido = "Tramite 3", Etiqueta = EtiquetaTramite.Despacho }, 1);

//Console.WriteLine(consultaIdExp.Ejecutar(1));

/*
List<object> lis = consultaTodosExp.Ejecutar(1);
foreach (object o in lis)
{
  if (o is Expediente e)
  {
    Console.WriteLine(e.ToString());
  }
  if (o is Tramite t)
  {
    Console.WriteLine(t.ToString());
  }
}
*/

/*
List<Tramite> listram = repoTramite.ConsultaPorEtiqueta(EtiquetaTramite.Despacho);
foreach (Tramite t in listram)
{
  Console.WriteLine(t);
}
*/

List<Expediente> listexp = repoExp.ListarExpedientes();
foreach (Expediente ex in listexp)
{
  Console.WriteLine(ex);
}

//bajaExp.Ejecutar(2, 1);
//bajaTramite.Ejecutar(3, 1);

//modifExp.Ejecutar(new Expediente() {Id = 3, Caratula = "Prueba 3 mod", Estado = EstadoExpediente.ParaResolver }, 1);
//modifTramite.Ejecutar(new Tramite() { Id = 1, ExpedienteId = 1, Contenido = "Tramite 1", Etiqueta = EtiquetaTramite.PaseAlArchivo}, 1);

























/*
try
{
  altaExp.Ejecutar(new Expediente() { Caratula = "Prueba 1", Estado = EstadoExpediente.RecienIniciado }, 1);
  altaExp.Ejecutar(new Expediente() { Caratula = "Prueba 2", Estado = EstadoExpediente.RecienIniciado }, 1);
  altaExp.Ejecutar(new Expediente() { Caratula = "Prueba 3", Estado = EstadoExpediente.RecienIniciado }, 1);

  bajaExp.Ejecutar(2, 1);
  
  modifExp.Ejecutar(new Expediente() { Id = 1, Caratula = "Modificacion2", Estado = EstadoExpediente.RecienIniciado }, 1);
  
  Console.WriteLine(consultaIdExp.Ejecutar(3));
  
  foreach (object o in consultaTodosExp.Ejecutar(3))
  {
    Console.WriteLine(o);
  }
  

  altaTramite.Ejecutar(new Tramite() { Id = 1, ExpedienteId = 3, Contenido = "Tramite 1", Etiqueta = EtiquetaTramite.Resolucion }, 1);
  Console.WriteLine(consultaIdExp.Ejecutar(3)?.Estado);
  altaTramite.Ejecutar(new Tramite() { Id = 2, ExpedienteId = 3, Contenido = "Tramite 2", Etiqueta = EtiquetaTramite.PaseAEstudio }, 1);
  Console.WriteLine(consultaIdExp.Ejecutar(3)?.Estado);
  altaTramite.Ejecutar(new Tramite() { Id = 3, ExpedienteId = 3, Etiqueta = EtiquetaTramite.PaseAlArchivo }, 1);
  Console.WriteLine(consultaIdExp.Ejecutar(3)?.Estado);
  
  Tramite tramite = new() { Id = 3, ExpedienteId = 3, Etiqueta = EtiquetaTramite.Resolucion };
  modifTramite.Ejecutar(tramite, 1);
  Console.WriteLine(consultaIdExp.Ejecutar(3)?.Estado);
  
  foreach (Tramite t in consultaEtiqueta.Ejecutar(EtiquetaTramite.Resolucion))
  {
    Console.WriteLine(t);
  }
  
}

catch (Exception ex)
{
  Console.WriteLine(ex);
}
*/