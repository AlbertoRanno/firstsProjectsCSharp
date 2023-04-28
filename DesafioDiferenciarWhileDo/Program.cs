/*
Proyecto de código 1: escritura de código que valida la entrada de enteros

Estas son las condiciones que el primer proyecto de codificación debe implementar:

La solución debe incluir una iteración do-while o while.

Antes del bloque de iteración: la solución debe usar una instrucción Console.WriteLine() para solicitar al usuario un valor de enteros entre 5 y 10.

Dentro del bloque de iteración:

La solución debe usar una instrucción Console.ReadLine() para obtener la entrada del usuario.
La solución debe asegurarse de que la entrada es una representación válida de un entero.
Si el valor de enteros no está comprendido entre 5 y 10, el código debe usar una instrucción Console.WriteLine() para solicitar al usuario un valor de enteros entre 5 y 10.
La solución debe garantizar que el valor de enteros está comprendido entre 5 y 10 antes de salir de la iteración.
Debajo (después) del bloque de código de iteración, la solución debe usar una instrucción Console.WriteLine() para informar al usuario de que se ha aceptado su valor de entrada.
*/

string? readResult;
/* El "?" evita el siguiente mensaje de advertencia:
(30,16): warning CS8600: Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL

el símbolo "?" indica que la variable es de un tipo "nullable". Un tipo nullable es aquel que puede contener un valor del tipo especificado o un valor nulo (null).

En el caso del ejemplo que mencionas, "string? nombreVariable", la variable "nombreVariable" es de tipo nullable string, lo que significa que puede contener un valor de tipo string o el valor nulo (null).

Al utilizar una variable de tipo nullable, es importante tener en cuenta que se debe comprobar si su valor es nulo antes de intentar acceder a su contenido, de lo contrario, podría producirse una excepción en tiempo de ejecución.
MÓDULO
*/
string valueEntered = "";
int numValue = 0;
bool validNumber = false;

Console.WriteLine("Enter an integer value between 5 and 10");

do
{
  readResult = Console.ReadLine();
  if (readResult != null)
  {
    valueEntered = readResult;
  }

  validNumber = int.TryParse(valueEntered, out numValue);

  if (validNumber == true)
  {
    if (numValue <= 5 || numValue >= 10)
    {
      validNumber = false;
      Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
    }
  }
  else
  {
    Console.WriteLine("Sorry, you entered an invalid number, please try again");
  }
} while (validNumber == false);

Console.WriteLine($"Your input value ({numValue}) has been accepted.");