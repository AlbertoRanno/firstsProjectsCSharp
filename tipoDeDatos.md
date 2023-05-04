El sistema de tipos de datos suele ser la parte más importante de cualquier lenguaje de programación.
 
Para que una aplicación sea eficiente con el menor consumo posible de recursos, es esencial el uso correcto de los distintos tipos de datos. 

Muchos de los lenguajes orientados a objetos proporcionan los tipos agrupándolos de dos formas: los tipos primitivos del lenguaje, como números o cadenas, y el resto de tipos creados a partir de clases que instanciados serán objetos. 
Esto genera muchas dificultades, ya que los tipos primitivos no son y no pueden tratarse como objetos, es decir, no se pueden derivar y no tienen nada que ver unos con otros. 

Sin embargo, en C# (más propiamente en .NET Framework) se cuenta con un sistema de tipos unificado, el CTS (Common Type System), que proporciona todos los tipos de datos como clases derivadas de la clase de base System.Object (incluso los literales pueden tratarse como objetos).

Es importante aclarar que: “hacer que todos los datos que va a manejar un programa sean objetos, puede provocar que baje el rendimiento de la aplicación (performance y uso de recursos)”. Para solventar este problema, .NET Framework divide los tipos en dos grandes grupos: los tipos valor y los tipos referencia.

Cuando se declara una variable que es de un tipo valor se está reservando un espacio de memoria en la pila (stack) para que almacene los datos reales que contiene esta variable. Por ejemplo, en la declaración: int num = 10;
Se está reservando un espacio de 32 bits en la pila (una variable de tipo int es un objeto de la clase System.Int32), en los que se almacena el 10, que es el contenido de la variable.
Esto hace que la variable “num” se pueda tratar directamente como si fuera de un tipo primitivo en lugar de un objeto, mejorando notablemente el rendimiento. Como consecuencia, una variable de tipo valor nunca puede contener el valor null (referencia nula).

Durante la ejecución de un programa, la memoria se distribuye en tres bloques: la pila (stack), el montón (heap) y la memoria global.

La pila es una estructura en la que los elementos se van apilando de modo que el último elemento en entrar en la pila es el primero en salir (estructura LIFO, o sea, Last In First Out).

El montón es un bloque de memoria contiguo en el cual la memoria no se reserva en un orden determinado como en la pila, sino que se va reservando aleatoriamente según se va necesitando. Cuando el programa requiere un bloque del montón, este se sustrae y se retorna un puntero (variable que contiene una dirección de memoria), al principio del mismo.

La memoria global es el resto de memoria de la máquina que no está asignada ni a la pila ni al montón, y es donde se colocan el método main y las funciones que éste invocará. En el caso de una variable que sea de un tipo referencia, lo que se reserva es un espacio de memoria en el montón para almacenar el valor, pero lo que se devuelve internamente es una referencia al objeto, es decir, un puntero a la dirección de memoria que se ha reservado. En este caso, una variable de un tipo referencia si
puede contener una referencia nula (null).

¿Por qué esta “separación” de tipos y posiciones de memoria?
Porque una variable de un tipo valor funcionará como un tipo primitivo siempre que sea necesario, pero podrá funcionar también
como un tipo referencia, es decir como un objeto, cuando se necesite que sea un objeto. Hacer esto en otros lenguajes, como Java, es imposible, dado que los tipos primitivos en Java no son objetos. Más adelante ampliaremos estos conceptos.

Los tipos de dato básicos son ciertos tipos de dato tan comúnmente utilizados en la escritura de aplicaciones que en C# se ha incluido una sintaxis especial para tratarlos. Por ejemplo, para representar números enteros de 32 bits con signo se utiliza el tipo de dato System.Int32 definido en la BCL, aunque a lahora de crear un objeto a, de este tipo, que represente el valor 2, se usa la siguiente sintaxis: System.Int32 a = 2;

Para este tipo, que es de uso muy frecuente, también se ha predefinido en C# el alias int, por lo que la definición de variable anterior queda así de compacta: int a = 2;

System.Int32 no es el único tipo de dato básico incluido en C#. En el espacio de nombres System se han incluido otros tipos de dato como los siguientes:

             //Enteros                                          //Con los signos se reparten los rangos
Tipo         Descripción                            Bits        Rango de valores                 Alias     bytes q ocupa en RAM
SByte        Bytes con signo                        8           [-128, 127]                      Sbyte     1 byte
Byte         Bytes sin signo                        8           [0, 255]                         byte      1 byte
Int16        Enteros cortos con signo               16          [-32.768, 32.767]                short     2 bytes
UInt16       Enteros cortos sin signo               16          [0, 65.535]                      ushort    2 bytes
Int32        Enteros normales                       32          [-2.147.483.648, 2.147.483.647]  Int       4 bytes
UInt32       Enteros normales sin signo             32          [0, 4.294.967.295]               uint      4 bytes
Int64        Enteros largos                         64          [-9.223.372.036.854.775.808,     Long      8 bytes
                                                                9.223.372.036.854.775.807]       
UInt64       Enteros largos sin signo               64          [0-18.446.744.073.709.551.615]   Ulong     8 bytes

              //con decimales (SIEMPRE PUNTO ".")
              //por default, cualquier nro escrito con ".", es un Double, en C#.
              //Si quiero que el compilador entienda, que NO es un double, luego del nro tengo que agregarle el sufijo correspondiente. Ej. float numReal1 = 23.78369456456432132156784324538f;
Single       Reales con 7 dígitos de precisión      32          [1,5×10-45 - 3,4×1038]           Float     4 bytes //Sufijo n
Double       Reales de 15-16 dígitos de precisión   64          [5,0×10-324 - 1,7×10308]         double    8 bytes //Sin Sufijo
Decimal      Reales de 28-29 dígitos de precisión   128         [1,0×10-28 - 7,9×1028]           decimal  16 bytes //Sufijo m

Boolean      Valores lógicos                        32          true, false                      Bool      //

Char         Caracteres Unicode                     16          [‘\u0000’, ‘\uFFFF’]             Char      //'x';
String       Cadenas de caracteres                  Variable    El permitido por la memoria      String    //"hola";
Object       Cualquier objeto                       Variable    Cualquier objeto                 Object


Pese a su sintaxis especial, en C# los tipos básicos son tipos del mismo nivel que cualquier otro tipo del lenguaje. Es decir, todos heredan del tipo base que es System.Object, y pueden tratarse como objetos de dicha clase por cualquier método que espere un System.Object.

Esto es muy útil para el diseño de rutinas genéricas que admitan parámetros de cualquier tipo, y es una ventaja importante de C# frente a lenguajes similares, como Java, donde los tipos básicos no son considerados objetos.

El valor que por omisión se le da a los campos de tipos básicos, consiste en poner a cero todo el área de memoria que ocupen. Esto se traduce en que los campos de tipos básicos numéricos se inicializan por omisión con el valor 0, los de tipo bool lo hacen con false, los de tipo char con ‘\u0000’ (carácter nulo), y los de tipo string y object con null.

Para los casos de los tipos de variables numéricas se puede especificar (durante la asignación de un valor), el tipo de dato numérico de ese valor mediante el uso de sufijos.

Los sufijos para los valores literales de los distintos tipos de datos numéricos son los siguientes:
● L (mayúscula o minúscula): long ó ulong, por este orden;
● U (mayúscula o minúscula): int ó uint, por este orden;
● UL ó LU (independientemente de que esté en mayúsculas o minúsculas): ulong;
● F (mayúscula o minúscula): single;
● D (mayúscula o minúscula): double;
● M (mayúscula o minúscula): decimal;

**************


