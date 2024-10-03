# Proyecto .NET con Entity Framework y MySQL

Este es un proyecto desarrollado en C# utilizando el framework .NET, con Entity Framework para la interacción con la base de datos MySQL.

## Requisitos previos

Asegúrate de tener instalados los siguientes requisitos antes de empezar:

- **.NET SDK**: Versión `>=6.0`
- **MySQL Server**: Versión `>=8.0`
- **MySQL Workbench** (opcional): Herramienta GUI para gestionar bases de datos MySQL.
- **Visual Studio** o **VS Code** (con extensión de C# instalada)

## Configuración de la Base de Datos

1. Instala MySQL Server si no lo tienes ya instalado. Puedes descargarlo desde [MySQL](https://dev.mysql.com/downloads/mysql/).
2. Crea una base de datos nueva en MySQL para el proyecto:
   ```sql
   CREATE DATABASE tiendaenlinea;
   ```
3. Actualiza la cadena de conexión en el archivo appsettings.json para conectar tu aplicación a la base de datos MySQL:
   ```json
       "ConnectionStrings": {
    "DefaultConnection": "Server=localhost;Database=tiendaenlinea;User=root;Password=1234567890;"
  }
   ```
