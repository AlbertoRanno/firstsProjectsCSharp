********* Bloques de código
Los bloques de código definen los límites de las estructuras de nivel superior (como espacios de nombres, clases y métodos), así como de las instrucciones de decisión e iteración. Es importante tener en cuenta estos límites porque afectan a la visibilidad de las variables y de otras estructuras más grandes, como los métodos y las clases. En algunos casos, se deben usar palabras clave adicionales como public y using (le indica al compilador dónde debe buscar las referencias a las clases) para atravesar los límites de otro bloque de código. En otros casos, las estructuras definidas como elementos del mismo nivel dentro del mismo bloque de código pueden hacer referencia unas a otras libremente.

using System;

namespace MyNewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}

tres niveles de bloques de código, desde el bloque de código más interno al más externo:
Un método Main().
Una clase Program.
Un espacio de nombres MyNewApp.

El nombre del método, Main(), es especial. Cuando se ejecuta el programa, el entorno de ejecución de .NET busca de forma predeterminada un método denominado Main() que se usa como punto de partida o de entrada para el programa.

Una clase es un contenedor para miembros, como métodos, propiedades, eventos, campos, etc.

Un espacio de nombres elimina la ambigüedad de los nombres de clase. Hay tantas clases en la biblioteca de clases .NET que puede haber dos clases con el mismo nombre. El espacio de nombres garantiza que pueda indicar al compilador con qué clase y con qué método quiere trabajar al especificar también un espacio de nombres.

Al crear un nuevo proyecto, se creará automáticamente un espacio de nombres con el nombre del proyecto. Este es el motivo por el que el espacio de nombres predeterminado en el ejemplo de código anterior es MyNewApp. Puede crear espacios de nombres adicionales en el código según sea necesario, y también una serie jerárquica de espacios de nombres mediante el operador punto. Por lo tanto, supongamos que queremos crear un segundo nivel de espacios de nombres para las clases de nuestra aplicación. Podríamos agregar un espacio de nombres secundario como el siguiente:

namespace MyNewApp.Business
{
  // Classes here    
}

Y quizás otro espacio de nombres secundario como este:

namespace MyNewApp.Data
{
  // Classes here    
}

En el primer espacio de nombres MyNewApp.Business, agregaríamos clases que implementasen la lógica de negocios de la aplicación. En el segundo espacio de nombres MyNewApp.Data, agregaríamos clases que implementasen las características de acceso a los datos de la aplicación. Podemos agregar tantos espacios de nombres como deseemos, y podemos crear espacios de nombres tantos niveles de profundidad como sea necesario; simplemente seguiríamos agregando nombres de espacios de nombres secundarios mediante el operador de punto.

Lo más importante para los fines de este módulo es que los bloques de código definen los límites de cada una de estas construcciones. Los bloques de código sugieren una relación de propiedad (o contención), por lo que las reglas que acabamos de aprender sobre el ámbito de variable y el acceso también son verdaderos en este nivel.

****Llamada a un método en la misma clase

En el ejemplo de código siguiente se llama a un método denominado Reverse() que está definido en la misma clase.

using System;

namespace MyNewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "Microsoft Learn";
            string reversedValue = Reverse(value);
            
             //Dado que el método Reverse() está definido en la misma clase, el código que llama al método no necesita calificar al nombre del método con el nombre de la clase.
            
            Console.WriteLine($"Secret message: {reversedValue}");
        }

        static string Reverse(string message)
        {
            char[] letters = message.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
    }
}

****Llamada a un método desde una clase diferente
¿Qué ocurre si movemos el método Reverse() a su propia clase? Tenga en cuenta el siguiente código de ejemplo:

using System;

namespace MyNewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "Microsoft Learn";
            string reversedValue = Utility.Reverse(value);

              //Dado que el método ya no “vive” en la misma clase, para llamar la método Reverse(), tenemos que acceder a él a través de la clase a la que se ha trasladado.

            Console.WriteLine($"Secret message: {reversedValue}");
        }
    }

    class Utility
    {
        public static string Reverse(string message)

          //Aquí definimos la clase “Utility” y agregamos el método Reverse(). También agregamos la palabra clave public. De lo contrario, sería inaccesible para el método Main()de la clase Program. 

        {
            char[] letters = message.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
    }
}

****Cómo hacer referencia a una clase en un espacio de nombres diferente
¿Qué ocurre si se mueve la clase “Utility” a un espacio de nombres diferente? ¿Cómo afectará esto a la accesibilidad de la clase y de su método? Tenga en cuenta el siguiente código de ejemplo:

using System;

namespace MyNewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "Microsoft Learn";
            string reversedValue = MyNewApp.Utilities.Utility.Reverse(value);

              //Observe que hemos usado el “nombre completo” de la clase, incluido su espacio de nombres entero.

            Console.WriteLine($"Secret message: {reversedValue}");
        }
    }
}

namespace MyNewApp.Utilities
{
    class Utility
    {
        public static string Reverse(string message)

         //No solo hemos creado un espacio de nombres nuevo, MyNewApp.Utilities, sino que también hemos movido nuestra clase Utility y su contenido al nuevo espacio de nombres.

        {
            char[] letters = message.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
    }
}

****La instrucción “using” ayuda al compilador a resolver espacios de nombres, pero con menos pulsaciones de teclas
Una opción mejor sería agregar una instrucción using. La instrucción using se agrega a la parte superior de un archivo de código y resuelve los nombres de clase que se usan en el archivo, puesto que indica al compilador que examine la lista de espacios de nombres para buscar todos los nombres de clase.
Using, afecta a todos los espacios de nombres, a todas las clases, y a todos los métodos del archivo de código.

Esta es otra versión de la aplicación que agrega una instrucción “using” para simplificar la llamada al método Reverse():

using System;
using MyNewApp.Utilities;

//La instrucción using indica al compilador que busque aquí al intentar resolver los nombres de clase que necesita buscar.

namespace MyNewApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string value = "Microsoft Learn";
            string reversedValue = Utility.Reverse(value);

                //Ahora, podemos llamar al método Reverse() solo con el nombre de clase, de esta manera

            Console.WriteLine($"Secret message: {reversedValue}");
        }
    }
}

namespace MyNewApp.Utilities
{
    class Utility
    {
        public static string Reverse(string message)
        {
            char[] letters = message.ToCharArray();
            Array.Reverse(letters);
            return new string(letters);
        }
    }
}