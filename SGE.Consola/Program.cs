using SGE.Aplicacion;
using SGE.Repositorios;

IExpedienteRepositorio repo = new RepositorioExpediente();
var altaex = new CasoDeUsoExpedienteAlta(repo);
var bajaex = new CasoDeUsoExpedienteBaja(repo);
var modex = new CasoDeUsoExpedienteModificacion(repo);

//altaex.Ejecutar(new Expediente() {Caratula = "prueba uno", Estado = EstadoExpediente.RecienIniciado, IdUltMod = 1}, 1);
//altaex.Ejecutar(new Expediente() {Caratula = "prueba dos", Estado = EstadoExpediente.RecienIniciado, IdUltMod = 1}, 1);
//altaex.Ejecutar(new Expediente() {Caratula = "prueba tres", Estado = EstadoExpediente.RecienIniciado, IdUltMod = 1}, 1);

//modex.Ejecutar(new Expediente() {Id = 2, Caratula = "modifica2", Estado = EstadoExpediente.EnNotificacion, IdUltMod = 1},1);

bajaex.Ejecutar(2, 1);

ITramiteRepositorio repot = new RepositorioTramite();
var altatr = new CasoDeUsoTramiteAlta(repot);
var bajatr = new CasoDeUsoTramiteBaja(repot);
var modtr = new CasoDeUsoTramiteModificacion(repot);


//altatr.Ejecutar(new Tramite() {Contenido = "prueba uno", Etiqueta = EtiquetaTramite.Despacho, ExpedienteId = 1, IdUltMod = 1}, 1);
//altatr.Ejecutar(new Tramite() {Contenido = "prueba dos", Etiqueta = EtiquetaTramite.Despacho, ExpedienteId = 2, IdUltMod = 1}, 1);
//altatr.Ejecutar(new Tramite() {Contenido = "prueba tres", Etiqueta = EtiquetaTramite.Despacho, ExpedienteId = 3, IdUltMod = 1}, 1);


//modtr.Ejecutar(new Tramite() {Id = 3, Contenido = "modifica3", Etiqueta = EtiquetaTramite.EscritoPresentado, ExpedienteId = 3}, 1);

//bajatr.Ejecutar(2, 1);