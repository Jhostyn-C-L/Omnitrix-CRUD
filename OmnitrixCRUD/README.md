Esta es una API REST sencilla para administrar alienígenas, tomando de inspiracion la serie de Ben 10.

Hice uso de las siguientes tecnologías:
- C#
- ASP.NET Core 8
- Swagger

Las funcionalidades de este CRUD son las siguientes:
- Registrar alienígenas.
- Consultar todos los alienígenas.
- Buscar por ID.
- Actualizar alienígenas.
- Eliminar alienígenas.

Este es el Endpoints:

| Método | Endpoint | Función |
|---|---|---|
| GET | /api/Aliens | Listar |
| GET | /api/Aliens/{id} | Buscar por ID |
| POST | /api/Aliens | Registrar |
| PUT | /api/Aliens/{id} | Actualizar |
| DELETE | /api/Aliens/{id} | Eliminar |

Funcionamiento de la ejecución:

1. Abrir la solución en Visual Studio.
2. Ejecutar el proyecto.
3. Abrir Swagger para probar los endpoints.

No utilice SQLServer, por ello los datos se almacenan temporalmente en memoria.