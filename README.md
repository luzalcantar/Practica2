# Practica 2
Formulario en Visual Studio C# para agregar y consultar Distribuidores

## Montar codigo
1. Clonar repositorio  o descargar y descomprimir archivo .zip 
```
git clone https://github.com/luzalcantar/Practica2.git
```

2. Montar base de datos backup.sql que se encuentra en la carpeta raiz del proyecto

3. Cambiar conexiones en archivo ```Practica2/conexionbd.cs```

```
string servidor = "localhost";
string port = "3306";
string usuario = "root";
string password = "root";
string database = "practica2"; 
```
