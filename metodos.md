**** ToUpper() - ToLower() - Trim()

Para manipular dos cadenas antes de comprobar la igualdad, debe:

Asegurarse de que ambas cadenas estén en su totalidad en mayúsculas o en minúsculas con el método auxiliar ToUpper() o ToLower() en cualquier valor de cadena.
Quite los espacios en blanco iniciales o finales con el método auxiliar Trim() en cualquier valor de cadena.

string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());
Al ejecutar el código, la salida es true.

**** Contains() - StartsWith() - EndsWith()

Algunos tipos de datos tienen métodos que realizan tareas de utilidad. El tipo de datos String tiene muchos. Varios devuelven un valor booleano, incluidos Contains(), StartsWith() y EndsWith().

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));

**** Random()

Tiros de una moneda, a ver si cae Cara o Seca:

Random coin = new Random();
int flip = coin.Next(0,2); //el primer valor exclusive, el 2do inclusivo
Console.WriteLine((flip == 0) ? "heads" : "tails" ); // a veces uno u otro con 50% de chance