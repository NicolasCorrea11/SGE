# Sistema de Gestión de Expedientes
## Características del sistema
- Posibilita la organización y administración efectiva de expedientes y trámites. Ambos elementos serán gestionados y persistidos de forma independiente.
- Se establece una relación mediante la propiedad ExpedienteId en la clase Trámite, destinada a asociar un trámite a un expediente específico.
- Gestiona usuarios y sus respectivos permisos. Todos los usuarios tendrán acceso de lectura sobre ambas entidades.
- Para realizar altas, bajas o modificaciones será necesario contar con permisos explícitos.
- Realiza validaciones para evitar el ingreso de elementos que no cumplan con ciertos requisitos.
- Gestiona ciertos desencadenantes que se activan al manipular los trámites de los expedientes, lo que ocasionará un cambio automático en el estado del expediente.
## Instrucciones de uso
- Configurar repositorios, servicios y validadores.
- Crear casos de uso de las entidades con sus respectivas dependencias.
- Ejecutar los casos de uso creados anteriormente, con el método Ejecutar() dentro de un bloque try-catch.

### Proyecto realizado por Nicolás Correa y Lautaro Bertarelli.
