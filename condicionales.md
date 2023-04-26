****Eliminar llaves

Si solo tiene una línea de código en un bloque de código, puede quitar las llaves y los espacios en blanco.
Elimine los bloques de código solo cuando esto ayude a que el código sea más legible.
Elimine los avances de línea solo si esto ayuda a que el código sea más legible.

string name = "steve";

if (name == "bob")
    Console.WriteLine("Found Bob");
else if (name == "steve") 
    Console.WriteLine("Found Steve");
else
    Console.WriteLine("Found Chuck");

**** "negación lógica" se refiere al operador !. Algunos lo llaman el "operador not".

 Al agregar ! antes de una expresión condicional como una llamada al método, se comprueba que la expresión sea false.

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(!pangram.Contains("fox")); // False
Console.WriteLine(!pangram.Contains("cow")); // True

**** El operador condicional "?:", conocido comúnmente como operador condicional ternario

Se usa cuando la situación es del tipo: devolver esto cuando sea True, y devolver esto otro cuando sea False

<evaluate this condition> ? <if condition is true, return this value> : <if condition is false, return this value>

int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;

Console.WriteLine($"Discount: {discount}"); // Discount: 100