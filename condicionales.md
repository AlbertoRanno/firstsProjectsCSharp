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

**** SWITCH

Use la instrucción switch cuando tenga un valor con muchas coincidencias posibles; cada una de las cuales requiere una bifurcación en la lógica del código.
Una sola sección switch que contiene lógica de código se puede emparejar con una o más etiquetas definidas por la palabra clave case.
Use la palabra clave opcional default para crear una etiqueta y una sección switch que se usen cuando no coincida ninguna otra etiqueta de caso.

int employeeLevel = 100;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");

