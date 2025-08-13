Requisitos 
.NET Core SDK 3.1 (Para compilar y ejecutar la API. https://dotnet.microsoft.com/es-es/download/dotnet/3.1)
Visual Studio 2019/2022 (compatible con .NET Core 3.1)
SQL Server
Entity Framework Core Tools (si usarás migraciones) Install-Package Microsoft.EntityFrameworkCore.Tools 3.1

Paso 1:
Ejecutar el comando  "Update-Database" en la consola del administrador de paquetes (se utiliza para aplicar 
las migraciones pendientes a la base de datos), esto creara la base de datos.


Paso 2:
Establecer como poryecto principal "ServCliente"

Paso 3:Ejecutar el boton "IIS Express" para empezar a ejecutar.