# Empleados-ASP.NET

Este proyecto es un crud de dos entidades mediante la tecnologia ASP .NET y razor pages.

## Requisitos Previos

Asegúrate de tener instalados los siguientes componentes antes de ejecutar la aplicación:

1. **Microsoft SQL Server**: Necesitarás una instancia de SQL Server para la base de datos de tu aplicación. Puedes descargar SQL Server desde [Microsoft SQL Server Downloads](https://www.microsoft.com/sql-server/sql-server-downloads).

2. **Microsoft SQL Server Management Studio (SSMS)**: SSMS es una herramienta gráfica para administrar y trabajar con SQL Server. Puedes descargar SSMS desde [SQL Server Management Studio (SSMS)](https://docs.microsoft.com/en-us/sql/ssms/download-sql-server-management-studio-ssms).

## Configuración de la Base de Datos

1. **Conexión a SQL Server**: Abre SSMS y conecta a tu instancia de SQL Server. Puedes usar la autenticación de Windows o SQL Server, según tu configuración.

2. **Ejecutar Scripts de Creación de Tablas**: En la carpeta `Scripts` de tu proyecto, encontrarás scripts SQL para crear las tablas necesarias en la base de datos. Ejecuta estos scripts en SSMS para configurar tu esquema de base de datos.

3. **Actualizar la Cadena de Conexión**: Abre el archivo `appsettings.json` en tu proyecto ASP.NET Core y actualiza la cadena de conexión en la sección `"ConnectionStrings"` con la información correcta para tu base de datos.

```json
"ConnectionStrings": {
    "DefaultConnection": "Server=TuServidor;Database=TuBaseDeDatos;User=TuUsuario;Password=TuContraseña;"
},

