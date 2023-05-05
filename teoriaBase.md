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

 ****************.NET es una colección de muchos elementos y personas que, de forma conjunta, crean un entorno eficaz para la compilación de aplicaciones.

Los desarrolladores de software usan lenguajes de .NET, como C# y F#, para escribir código fuente. Cada línea de código que escriben expresa una instrucción o un comando que el equipo debe ejecutar mientras el programa se está ejecutando.

Antes de que los desarrolladores de software puedan ejecutar su código, deben compilarlo primero. El compilador de .NET es un programa que convierte el código fuente en un lenguaje especial denominado lenguaje intermedio (IL). Al compilar el código en un formato "intermedio", se puede usar la misma base de código independientemente de dónde se ejecute el código, ya sea en Windows o Linux, o en hardware de equipo de 32 o 64 bits.

A veces, las personas piensan equivocadamente que el lenguaje de programación C# es .NET. Sin embargo, C# y .NET son distintos. C# es una sintaxis de lenguaje de programación. Como parte de la sintaxis, puede hacer referencia y llamar a métodos definidos en bibliotecas de código .NET, o ensamblados. Además, para crear un ensamblado a partir del código de C#, se usa el compilador de C# que se instala con el SDK de .NET. El entorno de ejecución de .NET ejecuta ensamblados de .NET. 

Todo el software se crea en capas, lo que significa que hay software que se ejecuta en distintos niveles de abstracción en un equipo:

En el nivel más bajo, el software se comunica directamente con el hardware del equipo. Controla el flujo de datos en la placa base, los procesadores, la memoria y las unidades de disco duro.
En el siguiente nivel, el software permite al usuario final proporcionar instrucciones a través de un sistema operativo.
En el siguiente nivel, el software como .NET proporciona una manera de desarrollar y ejecutar aplicaciones.
En el siguiente nivel, los marcos de trabajo de la aplicación y las bibliotecas de funcionalidad permiten crear rápidamente aplicaciones enriquecidas con menos esfuerzo que los métodos de desarrollo más antiguos permitidos.
Una biblioteca de código encapsula la funcionalidad para un fin específico en un único ensamblado. Para .NET, hay miles de bibliotecas disponibles. Estas bibliotecas pueden ser propias o de terceros, y pueden ser comerciales o de código abierto. Las bibliotecas proporcionan una amplia gama de funcionalidades que puede usar en sus aplicaciones. Simplemente debe hacer referencia a esos ensamblados y llamar a los métodos necesarios. De esta manera, como desarrollador, se basa en el trabajo de otros desarrolladores de software. Ahorra tiempo y esfuerzo, ya que no tiene que compilar y mantener todas las características.

Probablemente se preguntará qué modelos de aplicaciones admite cada marco de trabajo. Use la tabla siguiente para asignar un modelo de aplicación a un marco de trabajo de .NET.

Modelo de aplicación	  Marco                         Notas
Web	                    ASP.NET Core	                Marco para compilar lógica del lado servidor.

Web	                    ASP.NET Core MVC	            Marco para compilar lógica del lado servidor para páginas web o API web.

Web	                    ASP.NET Core, Razor Pages     Marco para compilar HTML generado por el servidor.

Cliente web           	Blazor	                      Blazor forma parte de ASP.NET Core. Sus dos modos permiten la manipulación
de Document Object Model (DOM) a través de sockets como un vehículo de comunicación para ejecutar código del lado servidor, o bien como una implementación WebAssembly para ejecutar C# compilado en un explorador.

Escritorio	            WinForms	                    Marco para compilar aplicaciones clásicas de estilo Windows.

Escritorio	    Windows Presentation Foundation (WPF)	Marco de trabajo para compilar aplicaciones de escritorio dinámicas 
que se ajustan a distintos factores de forma. WPF permite que los elementos de formulario realicen movimientos, atenuaciones, deslizamientos y otros efectos con la ayuda de una biblioteca completa de animaciones.

Móvil	                  Xamarin	                      Permite a los desarrolladores de .NET compilar aplicaciones para 
dispositivos iOS y Android.

Además, .NET habilita entornos conocidos de desarrollo de juegos de terceros y de código abierto y motores como Unity.

****************
Visual Studio 2022 es el entorno de desarrollo insignia de Microsoft. Millones de desarrolladores lo usan para compilar aplicaciones .NET. Una interfaz gráfica de usuario (que incluye menús, ventanas, diseñadores visuales, cuadros de diálogo y asistentes) guía a los desarrolladores por el proceso de desarrollo de aplicaciones. Visual Studio 2022 está disponible en tres ediciones: Community, Professional y Enterprise. Cada edición incluye herramientas distintas y tiene licencia para propósitos diferentes.

Los desarrolladores que prefieran un flujo de trabajo de línea de comandos pueden usar una combinación de Visual Studio Code, el editor de código más popular del mundo, y la interfaz de línea de comandos de .NET, también conocida como CLI de .NET.

Visual Studio y Visual Studio Code son dos herramientas diferentes que se utilizan para diferentes propósitos.

Visual Studio es un entorno de desarrollo integrado (IDE) completo para crear aplicaciones de Windows, aplicaciones móviles, juegos, sitios web y servicios en la nube. Es una herramienta poderosa para programadores profesionales que requieren una variedad de funciones avanzadas como depuración, diseño de interfaz de usuario, pruebas automatizadas y colaboración en equipo.
Para los desarrolladores que prefieren un entorno visual, Visual Studio 2022 es la mejor opción. Como puede imaginar, debido a la naturaleza exhaustiva y visual de Visual Studio 2022, se requiere más tiempo, ancho de banda y espacio en disco para descargar e instalar el programa. 


Por otro lado, Visual Studio Code es un editor de código ligero y gratuito que se utiliza principalmente para la edición de código en proyectos más pequeños o para desarrolladores que prefieren un entorno de trabajo más simplificado. Es una herramienta muy popular para desarrollar aplicaciones web, aplicaciones móviles y proyectos de inteligencia artificial y ciencia de datos.

En resumen, si estás trabajando en un proyecto complejo y necesitas una amplia gama de herramientas y funciones, entonces Visual Studio es una buena opción. Si estás trabajando en proyectos más pequeños o prefieres un editor de código más ligero y gratuito, entonces Visual Studio Code es una buena opción.

****************
Microsoft proporciona activamente un completo conjunto de documentación, tutoriales y aprendizaje. Encontrará materiales de aprendizaje en las modalidades populares que le ayudarán en cada paso del proceso de aprendizaje.

En la tabla siguiente se muestran algunos de los excelentes recursos que podrían convertirse en favoritos para volver a utilizarlos.

Resource	                 Propósito
*Microsoft Learn	         Proporciona tutoriales de inicio rápido y documentación de referencia definitiva.

*Patrones y prácticas	     Ayuda a los desarrolladores y arquitectos de software a encontrar soluciones que satisfagan necesidades comunes de desarrollo de aplicaciones. A menudo, los recursos superan los detalles de bajo nivel de escritura de código y profundizan en la elección de productos y servicios que permiten arquitecturas escalables aparentemente infinitas.

*Vídeos de .NET	           Proporciona tutoriales de vídeo del equipo de .NET. Estos vídeos guían a los desarrolladores en los escenarios de uso comunes.

*Microsoft Learn	         Proporciona laboratorios prácticos que le ayudarán a desarrollar sus habilidades mediante una combinación de instrucciones, ejercicios, elementos multimedia, pruebas de conocimientos y un método para llevar un seguimiento del progreso.

****************Cómo funciona .NET en tiempo de ejecución

*Compila el código intermedio en un formato binario la primera vez que se ejecuta el programa. El formato binario es específico de la plataforma y la arquitectura (por ejemplo, Windows de 64 bits) en el equipo en el que se ejecuta.
*Busca el punto de entrada del programa y empieza a ejecutar cada instrucción en el orden adecuado.
*Administra recursos del equipo, como la memoria y el acceso a la red. Cuando escucha que el entorno de ejecución de .NET "administra la memoria", significa que funciona con el sistema operativo para aprovisionar memoria para la aplicación. Cuando la aplicación ya no necesita los datos almacenados en memoria, una característica de recopilación de elementos no utilizados libera la memoria del sistema operativo sin instrucciones del desarrollador de software.
*Protege el equipo del usuario del software que puede tener intenciones malintencionadas. También proporciona un nivel de aislamiento entre las aplicaciones.

****************
Paso a Paso en la ejecución de un código:

Un comando para compilar el código nuevo invoca al compilador de C#. (dotnet build / run)

El compilador de C# garantiza que el código se pueda compilar y esté libre de errores de sintaxis. Si no puede compilar el código, el compilador se detiene y envía un mensaje de error al panel Salida.

Si el compilador de C# se ejecuta correctamente, el entorno de ejecución de .NET abre el ensamblado de .NET recién compilado. De forma predeterminada, busca en una clase denominada Program para buscar un método llamado Main() para empezar a ejecutar las instrucciones.

Instrucción por instrucción, el entorno de ejecución de .NET evalúa cada línea de código. Ejecuta la instrucción y se mueve a la siguiente línea de código.

En este caso, cuando finaliza la instrucción para imprimir las palabras "Hola mundo", la ruta de acceso en ejecución continúa hasta la línea siguiente, pero no encuentra nada. La ruta de acceso finaliza y el entorno de ejecución de .NET quita el programa de su memoria. Mientras tanto, la salida de la instrucción WriteLine() se devuelve al explorador web.

Esta secuencia de eventos, y la división básica de responsabilidades entre un lenguaje de programación, un compilador y un entorno de ejecución son los conceptos más importantes de entender para empezar.

****************
.NET es popular en las empresas por diversos motivos. Entre las ventajas se incluyen su ecosistema y su integración con otros productos de Microsoft, incluidos los servicios en la nube de Azure y los productos de servidor locales. Además, .NET es un sistema fuertemente tipado, por lo que evita muchos de los errores que pueden surgir en sistemas débilmente tipados. Los desarrolladores pueden optar por usar un paradigma basado en objetos en C# o un paradigma basado en la funcionalidad en F# . Usan el lenguaje que mejor se adapte a los tipos de problemas que necesitan resolver.

Elija .NET para aplicaciones de IA y en la nube
El SDK de Azure para .NET permite a los desarrolladores aprovisionar y administrar recursos de Azure. Como alternativa, Azure App Service y Azure Functions pueden hospedar aplicaciones compiladas con lenguajes .NET.

ML.NET es una biblioteca de aprendizaje automático gratuita para los lenguajes .NET. Habilita las funcionalidades de análisis y predicción de Machine Learning basadas en modelos.

Elija .NET para compilar aplicaciones de IoT
Puede usar .NET para compilar aplicaciones de IoT para escenarios y dispositivos IoT. Las aplicaciones de IoT suelen interactuar con sensores, pantallas y dispositivos de entrada que requieren el uso de pines de E/S de uso general (GPIO), puertos serie o hardware similar. Por ejemplo, puede encontrar bibliotecas que funcionan con paneles populares, como Raspberry Pi y Hummingboard.

****************
1. Imagine que usó código de C# para crear una aplicación. Después de ejecutar el código, detecta un error en la lógica. ¿Cómo se puede encontrar el error?

NO - El compilador de C# le ayudará a encontrar el error en la lógica.
El compilador identificará los errores de compilación de sintaxis de C#. Sin embargo, no detectará errores en la lógica.

NO - El entorno de ejecución de .NET le ayudará a encontrar el error en la lógica.

NO - Una clase de la biblioteca de .NET le ayudará a encontrar el error en la lógica.

SI - Las características de depuración de Visual Studio o la CLI de .NET pueden ayudarle a encontrar el error en la lógica.
Correcto. Puede usar las herramientas de depuración para establecer puntos de interrupción, recorrer el código y supervisar el valor de las variables para ayudarle a encontrar errores.

2. ¿Cuál de los siguientes términos describe un marco de trabajo de aplicación que combina varias bibliotecas relacionadas, junto con proyectos de inicio, plantillas de archivo, generadores de código y otras herramientas para que los desarrolladores puedan compilar una aplicación con un fin específico?

NO - Carga de trabajo

SI - Modelo de aplicación
Correcto. Un modelo de aplicación permite crear un tipo específico de aplicación, como una aplicación web o una aplicación móvil.

NO - Un ensamblado

NO - Entorno
En un contexto de desarrollo de software, el término entorno suele hacer referencia a la colección de herramientas que se usan para compilar aplicaciones.

3. ¿Cuál de los siguientes términos describe mejor el instalador necesario para crear proyectos, escribir código, llamar a métodos en bibliotecas, compilar código y compilar, depurar y ejecutar aplicaciones?

NO - Entorno de ejecución de .NET
El entorno de ejecución de .NET solo puede ejecutar ensamblados de .NET. Estamos buscando una respuesta que abarque más funcionalidades.


NO - Bibliotecas base de .NET

SI - SDK de .NET
Correcto.


NO - Ensamblado .NET
