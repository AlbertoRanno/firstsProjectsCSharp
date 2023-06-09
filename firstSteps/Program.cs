﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello \"C#\"!");
Console.Write("Congratulations!");
Console.Write(" ");
Console.Write("You wrote your first lines of code!\n");

/*el énfasis en los tipos de datos es una de las características distintivas de C# en comparación con otros lenguajes como Python y JavaScript. Los diseñadores de C# creían poder ayudar a los desarrolladores a evitar errores comunes de software mediante la aplicación de tipos de datos.*/

/*
Un literal es literalmente un valor codificado de forma rígida.
Cuando se necesita trabajar con datos de fuera del código propio, se declara una variable.
Que son valores temporales que se almacenan en la memoria del equipo.
Para poder usar una variable, hay que declararla.
Primero se selecciona un tipo de datos correspondiente al tipo de datos que se quiere almacenar y, luego, se asigna a la variable un nombre (camelCase - No usar contracciones)
El compilador de C# debe comprender primero el valor del lado derecho del operador de asignación para poder realizar después la asignación a la variable en el lado izquierdo del operador de asignación. Si el orden se revierte, se confunde al compilador de C#
*/

string firstName = "Bob";
//string para palabras, frases o cualquier dato alfanumérico para presentación, no cálculo
Console.Write("Concatenacion: " + firstName + " es alto\t\\");
char lastChar = 'b';
//char para un solo carácter alfanumérico
Console.Write($"Interpolacion: {lastChar} es el ultimo caracter\n\\");
int age = 27;
//int para un número entero
Console.Write($@" El @ respeta lo que ponga dentro //\\\ ---       65{age}\t\n\\"+"\n\\");
bool legal = true;
//bool para un valor true o false
Console.Write(legal+"\n");
decimal weight = 2.35m;
//decimal para un número con un decimal
int quotient = 7/5; // Dará por resultado un nro entero
Console.Write(weight+"\t\t"+quotient);
/* 
Para que esto funcione, el cociente (a la izquierda del operador de asignación) debe ser de tipo decimaly el dividendo o el divisor deben ser de tipo decimal (o ambos):
decimal decimalQuotient = 7.0m / 5;
decimal decimalQuotient = 7 / 5.0m;
decimal decimalQuotient = 7.0m / 5.0m;
Console.WriteLine("Decimal quotient: " + decimalQuotient); //1.4
*/

/*
Una variable local con tipo implícito se crea mediante la palabra clave var, que indica al compilador de C# que deduzca el tipo. Una vez que se ha inferido el tipo, es igual que si hubiera usado el tipo de datos real para declarar la variable.
var message = "Hello world!";
De hecho, la variable message se escribe como una cadena y nunca se puede cambiar. 

var message = "Hello World!";
message = 10.0m;
Si se ejecuta este código, aparece un mensaje de error:  No se puede convertir implícitamente el tipo 'decimal' en 'string'

var tiene un uso importante en C#. Por motivos que pueden no quedarle claros hasta que escriba código avanzado, hay situaciones en las que el tipo de datos puede no ser obvio en el momento de inicializar la variable. De hecho, en algunos casos, C# puede inventar un nuevo tipo de datos solo para el código y puede no ser capaz de darle un nombre predecible por adelantado.
*/

/*
orden de las operaciones.
En matemáticas, PEMDAS es un acrónimo que ayuda a los alumnos a recordar el orden en el que se realizan varias operaciones. El orden es:
Paréntesis (lo que se encuentra dentro del paréntesis se realiza primero)
Exponents (exponentes)
Multiplication (multiplicación) y Division (división) (de izquierda a derecha)
Addition (suma) y Subtraction (resta) (de izquierda a derecha)
C# sigue el mismo orden que PEMDAS, excepto en el caso de los exponentes. Aunque no hay ningún operador exponencial en C#, puede utilizar el método System.Math.Pow()
*/

//+=, -=, *=, ++ y -- Son operadores de asignación compuesta porque realizan alguna operación además de asignar el resultado a la variable. 

int value = 1;
value = value + 1;
Console.WriteLine("\n\nFirst increment: " + value);//2
value += 1;
Console.WriteLine("Second increment: " + value);//3
value++;
Console.WriteLine("Third increment: " + value);//4
value = value - 1;
Console.WriteLine("First decrement: " + value);//3
value -= 1;
Console.WriteLine("Second decrement: " + value);//2
value--;
Console.WriteLine("Third decrement: " + value);//1

/*Los operadores de incremento y decremento tienen una cualidad interesante: según su posición, llevan a cabo la operación antes o después de recuperar el valor. En otras palabras, si usa el operador delante del valor (como en ++value), el incremento se producirá antes de recuperar el valor. Del mismo modo, value++ incrementará el valor una vez recuperado.*/
int value2 = 1;
value2++;
Console.WriteLine("First: " + value2); // 2 - muestra el valor acumulado de value
Console.WriteLine("Second: " + value2++); //2 -muestra el valor acum. y luego le suma 1
Console.WriteLine("Third: " + value2); //3 confirma, que luego de mostrar en la linea anterior, se acumuló uno más
Console.WriteLine("Fourth: " + (++value2)); //4 se acumula primero, y luego muestra. Los paréntesis se agregan para mejorar la legibilidad, pero no son necesarios.

//Pasar de Fahrenheit a Celsius:
int fahrenheit = 94;
decimal celsius = (fahrenheit-32) * (5.0m/9);
Console.WriteLine($"The temperatura is {celsius} Celsius");

// ARRANCANDO CON C# EN VS:
/*
To help with this process, developers use a specialized tool known as an integrated development environment (IDE).
An IDE is a suite of tools that supports the full software development lifecycle.

In the filtered list of available extensions, select C# for Visual Studio Code (powered by OmniSharp).

Install the .NET SDK
.NET is a cross-platform, open-source developer platform that can be used to develop different types of applications. It includes the software languages and code libraries used to develop .NET applications. You can write .NET applications in C#, F#, or Visual Basic.

The .NET runtime is the code library that's required to run your C# applications. You may also see the .NET runtime referred to as the Common Language Runtime, or CLR. The .NET runtime isn't required to write your code, but it's required to actually run your applications.

Check to see if .NET is already installed
At the Terminal command prompt, type: dotnet --version and then press the Enter key.
Si no está… descargarlo: 
https://dotnet.microsoft.com/es-es/download

to create a new console application in a specified folder, type dotnet new console -o ./CsharpProjects/TestProject and then press Enter.

o si ya estoy en la carpeta deseada, simplemente: 
 dotnet new console

To compile a build of your application, enter the following command at the Terminal command prompt: dotnet build
The dotnet build command builds the project and its dependencies into a set of binaries. The binaries include the project's code in Intermediate Language (IL) files with a .dll extension. Depending on the project type and settings, other files may also be included.

To run your application, enter the following command at the Terminal command prompt:
dotnet run

The dotnet run command runs source code without any explicit compile or launch commands. It provides a convenient option to run your application from the source code with one command. It's useful for fast iterative development from the command line. The command depends on the dotnet build command to build the code.
oBS! The .NET SDK is required in order to run .NET command line interface commands such as dotnet run.
*/

/*
Subí a Git, antes de colocar el gitignore… SOLUCIÓN:

Una vez confirmados los cambios, es decir, una vez has hecho commit a esos archivos por primera vez, los archivos ya forman parte del repositorio
El primer paso sería eliminar esos archivos del repositorio. Para eso está el comando "rm". Sin embargo, ese comando tal cual, sin los parámetros adecuados, borrará el archivo también de nuestro directorio de trabajo, lo que es posible que no desees.

Si quieres que el archivo permanezca en tu ordenador pero simplemente que se borre del repostorio tienes que hacerlo así.

git rm --cached nombre_archivo
Si lo que deseas es borrar un directorio y todos sus contenidos, tendrás que hacer algo así:

git rm -r --cached nombre_directorio
El parámetro "--cached" es el que nos permite mantener los archivos en nuestro directorio de trabajo.

Asegurarse que estamos ignorando los archivos con
.gitignore
Hacer el commit para confirmar los cambios
git commit -m 'Eliminados archivos no deseados'
Enviar esos cambios al repositorio remoto
git push origin main
*/

