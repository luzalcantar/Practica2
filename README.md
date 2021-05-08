# Practica 2
Formulario en Visual Studio C# para agregar y consultar Distribuidores

## Montar codigo
1. Clonar repositorio  o descargar y descomprimir archivo .zip 
```
git clone https://github.com/luzalcantar/Practica2.git
```

2. Montar base de datos ```backup.sql``` que se encuentra en la carpeta raiz del proyecto

3. Cambiar conexiones en archivo ```Practica2/conexionbd.cs```

```
string servidor = "localhost"; //Servidor en el que se monto la base de datos
string port = "3306"; //Puerto
string usuario = "root"; //Usuario para acceder a la base de datos
string password = "root"; //Contraseña para acceder a la base de datos
string database = "practica2";  //Nombre de la base de datos
```
