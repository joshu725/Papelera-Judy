# PapeleraJudy

## Descripción

Papelera Judy es una aplicación de punto de venta en Windows Forms desarrollada en C#, esta permite gestionar empleados, proveedores, productos, clientes, y realizar/consultar ventas y compras. Además, incluye funcionalidad para consultar y agregar IVA, y utiliza PostgreSQL para el almacenamiento de datos.

## Requisitos

- .NET Framework (versión requerida: 4.x)
- PostgreSQL (versión recomendada: 16 o superior)

## Instalación

### 1. Clona el repositorio

```bash
git clone https://github.com/joshu725/Papelera-Judy
```

### 2. Restaura los paquetes NuGet

```bash
cd Papelera-Judy
dotnet restore
```

O si estás utilizando Visual Studio, abre la solución (`Papelera-Judy.sln`) y Visual Studio restaurará los paquetes automáticamente.

### 3. Configura la base de datos PostgreSQL
1. Instala PostgreSQL.
2. Crea una base de datos para la aplicación.
3. Configura la conexión en el archivo de configuración (al inicio de `Data\PostgreSQL.cs`) para conectar la aplicación con tu base de datos.
4. Restaura las tablas en el schema publico de la base de datos que acabas de crear (deberás utilizar el archivo `pgsql_schema.sql` de la carpeta principal del proyecto)

### 4. Compila y ejecuta
Puedes compilar y ejecutar la aplicación en Visual Studio o desde la línea de comandos
```bash
dotnet build
dotnet run
```

## Ejecución
Las siguientes capturas de pantalla permiten demostrar el funcionamiento del programa

![1](https://github.com/user-attachments/assets/f7a42f1f-8c6f-43bd-bca8-836485154290)

![2](https://github.com/user-attachments/assets/40407f1e-b34d-4652-b1db-cf746da0ffd7)

![3](https://github.com/user-attachments/assets/33e02586-b3a1-4e80-b1aa-3737082f4e36)

![4](https://github.com/user-attachments/assets/4ee80895-b89d-4bfd-bf0d-89878617b288)

![5](https://github.com/user-attachments/assets/d7b05e8c-064e-4d47-86f6-bd05a0abdfa7)

![6](https://github.com/user-attachments/assets/2cadf7cb-e3ac-423a-afab-9f8b36691d57)

## Licencia
Este proyecto está licenciado bajo la licencia MIT.
