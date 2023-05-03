**************** C# - Lenguaje de programación orientado a objetos que permite crear aplicaciones que se ejecutan en el entorno .NET Framework. 

**************** Compilador - Código ejecutable que traduce un código escrito en un lenguaje de alto nivel como C# a lenguaje máquina. 

**************** Framework - Es un ambiente o entorno de trabajo. 

**************** API (Interfaz de programación de aplicaciones): biblioteca formada por subrutinas, procedimientos y funciones que se puede utilizar para desarrollar otros programas

**************** Arreglo: conjunto de direcciones - de espacios de memoria contiguos -, agrupadas bajo un mismo nombre e indexadas desde 0. Pueden ser unidimensionales, bidimensionales o multidimensionales. 

**************** ASP.NET: framework comercializado por Microsoft para programar sitios web dinámicos, aplicaciones web y servicios web. 

**************** Función: bloque de código que realiza una determinada operación. Al llamar a una función, se le pueden pasar parámetros de entrada. Puede devolver un valor de salida.

**************** GUI (Interfaz gráfica de usuario): son las pantallas mediante las que el usuario puede
interactuar con el sistema.

**************** Implementación: instalación y puesta en marcha de un software.

**************** Inicialización: asignación de un valor inicial a una variable.

**************** Iteración: ejecución repetitiva de instrucciones hasta que se cumple una condición (ejecución de un bucle). 

**************** Microsoft Visual Studio: es un entorno de desarrollo integrado (IDE) que tiene un editor de texto donde se puede escribir el código de un programa. También permite depurar y compilar el código para luego publicar una aplicación.

**************** Operador: símbolo que determina el tipo de cálculo que se realizará en una expresión. Hay operadores lógicos, aritméticos, de
concatenación, de comparación y especiales. 

**************** Procedimiento: grupo de instrucciones agrupadas bajo un mismo nombre. El procedimiento recibe datos y devuelve resultados.

**************** Tipo de dato: atributo de los datos que indica sobre qué clase de dato va a trabajar el código (procedimiento, función, método,
instancia, clase, proceso iterativo, etc). El tipo de dato determina qué valores puede tomar la variable y qué operaciones se podrán realizar con esos valores. Algunos tipos de datos son: expresiones booleanas, caracteres
de texto, números enteros, decimales y otros.

**************** Variable: espacio en memoria a la que se le asocia un nombre para almacenar un valor. El nombre permite referenciar la variable para realizar operaciones lógicas, matemáticas y otras (según el tipo de dato que almacenen). El valor puede ser asignado, modificado y también reasignado. 

**************** .NET es un marco de trabajo (framework) desarrollado por Microsoft que permite crear aplicaciones y servicios para diferentes plataformas y dispositivos, como computadoras, teléfonos inteligentes y tabletas.

.NET proporciona un conjunto de herramientas, bibliotecas y lenguajes de programación para simplificar el desarrollo de software y aumentar la productividad de los desarrolladores. Además, también ofrece características de seguridad y escalabilidad para aplicaciones empresariales y críticas.

**************** El CLR (Common Language Runtime) es una parte importante de la plataforma .NET que se encarga de ejecutar y gestionar las aplicaciones escritas en los diferentes lenguajes de programación que soporta .NET. Básicamente, el CLR es el "motor" que se encarga de traducir el código escrito en lenguajes como C# o VB.NET al lenguaje de la máquina para poder ser ejecutado.

**************** MSIL (Microsoft Intermediate Language) es un lenguaje de programación intermedio utilizado por el CLR para representar el código escrito en cualquier lenguaje de programación .NET. En otras palabras, cuando se compila el código fuente de un programa en .NET, el compilador produce código MSIL en lugar de código de máquina.

**************** La biblioteca de clases .NET Framework es un conjunto de bibliotecas de software que proporcionan una amplia gama de funcionalidades para el desarrollo de aplicaciones en la plataforma .NET. Estas bibliotecas contienen código predefinido que los desarrolladores pueden utilizar para realizar tareas comunes como la gestión de archivos, la conexión a bases de datos, el trabajo con gráficos, entre muchas otras cosas.

**************** El IDE (Integrated Development Environment) es un software que ayuda a los desarrolladores a escribir, depurar y desplegar aplicaciones. Visual Studio es el IDE más popular para el desarrollo de aplicaciones en .NET. Ofrece una serie de herramientas y características que hacen que el proceso de desarrollo sea más fácil y productivo, como un editor de código, depurador, herramientas de diseño visual y integración con el CLR para la compilación y ejecución de código.

**************** una aplicación de .NET se desarrolla y se ejecuta en uno o varios de sus softwares instalados, como: .NET Framework,.NET Core y Mono.
Hay una especificación de API (un conjunto de librerías de código), común a todas las implementaciones de .NET, denominada .NET Standard. 
.NET Standard es también una plataforma de destino. Si el código tiene como destino una versión de .NET Standard, se puede ejecutar en cualquier implementación de .NET que sea compatible con esa versión de .NET Standard.
.NET Standard es un conjunto de APIs que se implementa mediante la biblioteca de clases base de una implementación de .NET.
Más formalmente, es una especificación de APIs de .NET que constituye un conjunto uniforme de contratos contra los que se compila
el código. Estos contratos se implementan en cada implementación de .NET. Esto permite la portabilidad entre diferentes implementaciones de .NET, de forma que el código se puede ejecutar en cualquier parte; por ejemplo, esto logra que la
implementación .NET Core sea multiplataforma.

**************** Cada implementación de .NET incluye los siguientes componentes:
Uno o varios entornos de ejecución, por ejemplo:
● CLR para .NET Framework (Common Language Runtime)
● CoreCLR y CoreRT para .NET Core (.NET Core Common Language Runtime y .NET Core Runtime)

Una biblioteca de clases que implementa .NET Standard y puede implementar API adicionales, por ejemplo:
● Biblioteca de clases base de .NET Framework
● Biblioteca de clases base de .NET Core (.NET Core Base ClassLlibrary)

Opcionalmente, uno o varios marcos de trabajo de la aplicación, por ejemplo:
● ASP.NET para .NET Framework y para .NET Core.
● Windows Forms para .NET Framework.
● Windows Presentation Foundation (WPF) para .NET Framework.

Opcionalmente, herramientas de desarrollo. Algunas herramientas de desarrollo se comparten entre varias
implementaciones.
Hay cuatro implementaciones principales de .NET que Microsoft desarrolla y mantiene activamente:
.NET Core, .NET Framework, Mono y UWP.

NET Core

.NET Core es una implementación multiplataforma de .NET diseñada para aplicaciones instaladas tanto en servidores
propios como servidores en la nube a gran escala.
.NET Core puede ejecutarse en entornos Windows, macOS y Linux. Implementa .NET Standard, de forma que cualquier código que
tenga como destino .NET Standard se pueda ejecutar en .NET Core. ASP.NET Core se ejecuta en .NET Core.

.NET Framework

.NET Framework es la implementación original de .NET que existe desde 2002. Es el mismo entorno que los desarrolladores de .NET han usado siempre. Las versiones 4.5 y posteriores implementan .NET Standard, de forma que el código que tiene como destino .NET Standard se puede ejecutar en esas versiones de .NET Framework.
Contiene APIs específicas de Windows adicionales, como la API para el desarrollo de aplicaciones de escritorio con Windows Forms
y WPF. .NET Framework está optimizado para crear aplicaciones de escritorio de Windows.

**************** ¿Qué es C# (Sharp)?

C# (se pronuncia “se sharp”) es un lenguaje que pretende reunir lo mejor de los diversos lenguajes que compilan a nativo (C / C++, Object Pascal, ADA, etc.) y de los interpretados (Java, Perl, etc.) en uno solo, y que, además, pueda correr sobre diversos sistemas operativos.
Al respecto, existe un proyecto paralelo al desarrollo de .NET de Microsoft, que se denomina “Mono” que transportó el lenguaje C# y gran parte del framework .NET a Unix / Linux / Solaris.
C# toma gran parte de la sintaxis de C / C++ y muchas de las características de Eiffel (un lenguaje de laboratorio que ideó Bertrand Meyer), ofreciendo al desarrollador un potente lenguaje 100% orientado a objetos.
Si bien el CLR acepta muchos otros lenguajes, el framework .NET está 100% escrito en C#; por lo tanto, es el lenguaje base para .Net.

**************** Entorno de Desarrollo
El compilador
Cuando se instala en cada computadora el SDK de Microsoft .NET, se crea el directorio C:\WINDOWS\Microsoft.NET\Framework\v2.0.5
0727\.. , dentro del cual se alojan los compiladores de línea.
El compilador para C# es “csc.exe” y puede ser invocado desde la línea de comandos, es decir: Inicio | Ejecutar | cmd.
Cuando se invoca al compilador pasándole como parámetro un nombre de archivo cualquiera con la extensión “.cs”, convierte a este en un archivo *.exe (ejecutable), pero este NO es un ejecutable NATIVO (es decir, autónomo), sino que necesita del framework .NET con el CLR instalado en la misma máquina para poder correr.

Los archivos fuente (“*.cs”)
Los archivos de “código fuente” no son más que archivos de texto plano, que contienen las líneas del programa en C# con las instrucciones que cada programador quiere que la aplicación lleve a cabo. Deben cumplir con las normas sintácticas del lenguaje, caso contrario, el compilador detecta los errores y no genera el ejecutable.
Veamos un primer ejemplo de aplicación de consola:

/*
 Nombre del archivo: Saludo.cs
 Autor: ...
 Objetivo del programa: Mostrar por consola un mensaje de bienvenida
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

// Nombre del archivo ejecutable (mismo nombre que el Proyecto) .exe que se generará
namespace Bienvenida
{
// Clase inicial del programa Saludo.cs
class Saludo
 {
// Punto de entrada a la aplicación (el código dentro de Main es lo primero en ejecutarse)
static void Main()
 {
// Muestra por pantalla el contenido entre "" dentro del paréntesis
Console.WriteLine("Hola a todos !!!Bienvenidos a .Net !!!");
// Espera que el usuario presione una tecla para continuar la ejecución del programa
Console.ReadKey();
 }
 }
}

En la imagen anterior codificamos el programa en el IDE de Visual Studio, y con click derecho sobre el nombre del archivo, también podríamos compilarlo.

**************** Cómo está formado el framework .NET
La arquitectura del framework .NET, es la implementación del CLI (Common Language Runtime) por parte de Microsoft para los
lenguajes C#, Visual Basic, J#, ASP, y JavaScript, más varios paquetes que dan soporte a interfaces de usuario, acceso a datos, XML y WEB agrupadas en una Librería de Clase Base (BCL) que está formada por cientos de tipos de datos.

Esta librería está escrita en MSIL, por lo que puede usarse desde cualquier lenguaje cuyo compilador genere MSIL.
A través de las clases suministradas en ella es posible desarrollar cualquier tipo de aplicación, desde las tradicionales aplicaciones de ventanas, consola o servicio de Windows NT hasta los novedosos servicios Web y páginas ASP.NET.
Dada su amplitud, ha sido necesario organizar las clases, incluidas en ella, en espacios de nombres que agrupan clases con funcionalidades similares. Esto es una clasificación. Veamos los espacios de nombres más usados en la tabla:

Espacio de nombres          Utilidad de los tipos de dato que contiene

System                      Tipos muy frecuentemente usados, como los tipos básicos, tablas, excepciones, fechas,
                            números aleatorios, recolector de basura, entrada/salida en consola, etc.
System.Collections          Colecciones de datos de uso común como pilas, colas, listas, diccionarios, etc.
System.Data                 Manipulación de bases de datos. Forman la denominada arquitectura ADO.NET.
System.IO                   Manipulación de archivos y otros flujos de datos.
System.Net                  Realización de comunicaciones en red.
System.Reflection           Acceso a los metadatos que acompañan a los módulos de código.
System.Runtime.Remoting     Acceso a objetos remotos.
System.Security             Acceso a la política de seguridad en que se basa el CLR.
System.Threading            Manipulación de hilos de ejecución.
System.Web.UI.WebControls   Creación de interfaces de usuario basadas en ventanas para aplicaciones Web.
System.Windows.Forms        Creación de interfaces de usuario basadas en ventanas para aplicaciones estándar.
System.XML                  Acceso a datos en formato XML.


