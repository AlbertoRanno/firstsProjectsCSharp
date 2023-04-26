DENTRO DEL ARCHIVO:

//Para hacer el código más facil de leer, implementar al comienzo del proyecto, "using System;", implica que luego lo puedo omitir de comandos como "System.Console.WriteLine();"

using System;

//Para pausar la app, y que el usuario pueda apreciar la salida en consola. (Luego con Enter, se detendrá la app)

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();

//Para darle formato al documento, click derecho, "dar formato al documento..."

Mayus + Alt + F.

//Para buscar en el código:

Control + F

//Para buscar y reemplazar en el código:

Control + H



COMANDOS DE CONSOLA:

//Para crear un nuevo proyecto, con ubicación relativa (OJO donde estás parado):

dotnet new console -o ./NombreProyecto

//Para compilar la app, y ver posibles errores y advertencias:

dotnet build

//Para correr la app:

dotnet run

//Creación de archivo gitignore para proyectos en C#:

dotnet new gitignore

//Si subí archivos a un repo, que No deberían de estar ahí, pero, quiero mantenerlos en la pc:

git rm -r --cached nombre_directorio    //   git rm --cached nombre_archivo

//Chequear que ahora sí estén incluidos en el gitignore, y hacer el commit - push... 
