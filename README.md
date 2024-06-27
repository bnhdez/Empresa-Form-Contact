# Empresa Form Contact

Este proyecto es una aplicación ASP.NET Core MVC para manejar formularios de contacto.

## Repositorio

[Repositorio en GitHub](https://github.com/bnhdez/Empresa-Form-Contact.git)

## Requisitos

- Visual Studio 2022
- .NET 6.0 SDK o superior
- SQL Server (o SQL Server Express)

## Instrucciones para Ejecutar el Proyecto Localmente

### Clonar el Proyecto

1. Clona el repositorio desde GitHub a tu máquina local:

    ```bash
    git clone https://github.com/bnhdez/Empresa-Form-Contact.git
    ```

2. Navega a la carpeta del proyecto:

    ```bash
    cd Empresa-Form-Contact
    ```

### Configurar la Base de Datos

1. Abre SQL Server Management Studio (SSMS) o cualquier herramienta de administración de SQL Server.
2. Ejecuta el siguiente script SQL para crear la base de datos y la tabla necesaria:

    ```sql
    -- Crear base de datos
    CREATE DATABASE MUEBLESCORP;
    GO

    -- Usar la base de datos
    USE MUEBLESCORP;
    GO

    -- Crear tabla Contacts
    CREATE TABLE Contacts (
        Id INT IDENTITY(1,1) PRIMARY KEY,
        Nombre VARCHAR(50) NOT NULL,
        Correo VARCHAR(100) NOT NULL,
        Mensaje VARCHAR(250) NOT NULL
    );
    GO

    -- Verificar la tabla
    SELECT * FROM Contacts;
    ```

### Configurar la Cadena de Conexión

1. Abre el archivo `appsettings.json` en el proyecto.
2. Modifica la sección `ConnectionStrings` para apuntar a tu instancia de SQL Server. Por ejemplo:

    ```json
    {
        "ConnectionStrings": {
            "conexion": "Server=TU_SERVIDOR;Database=MUEBLESCORP;Trusted_Connection=True;TrustServerCertificate=True;"
    },
    "Logging": {
        "LogLevel": {
            "Default": "Information",
            "Microsoft": "Warning",
            "Microsoft.Hosting.Lifetime": "Information"
        }
    },
        "AllowedHosts": "*"
    }
    ```

### Restaurar Paquetes NuGet

1. Abre la solución (`.sln`) en Visual Studio 2022.
2. Restaura los paquetes NuGet. Esto se puede hacer automáticamente al abrir la solución, o manualmente seleccionando `Tools > NuGet Package Manager > Manage NuGet Packages for Solution...` y luego clic en `Restore`.

### Ejecutar el Proyecto

- Ejecuta el proyecto presionando `F5` o seleccionando `IIS Express` y clic en `Run`.

### Notas Adicionales

- **Error de conexión a la base de datos**: Verifica que tu cadena de conexión en `appsettings.json` esté configurada correctamente.
- **Problemas con las dependencias**: Asegúrate de que todos los paquetes NuGet están restaurados.
- **Migraciones**: Si necesitas realizar migraciones adicionales, puedes usar `Add-Migration` y `Update-Database` desde la Consola del Administrador de Paquetes.
- **Contexto y Modelo de Datos**: El contexto y los modelos de datos fueron creados mediante el comando:

    ```powershell
    Scaffold-DbContext "Server=BRS-PC\SQLEXPRESS01;Database=MUEBLESCORP;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models -Verbose
    ```

---

Siguiendo estos pasos, deberías poder configurar y ejecutar el proyecto localmente sin problemas. Si encuentras algún problema, revisa las configuraciones de la base de datos y asegúrate de que todos los paquetes NuGet estén restaurados correctamente.