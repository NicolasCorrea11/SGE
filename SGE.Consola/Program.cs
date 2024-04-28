using SGE.Aplicacion;
using SGE.Repositorios;

IExpedienteRepositorio repo = new RepositorioExpediente();
var altaex = new CasoDeUsoAltaExpediente(repo);
altaex.Ejecutar(new Expediente() {Caratula = "prueba dos??", Estado = EstadoExpediente.RecienIniciado, IdUltMod = 24});
