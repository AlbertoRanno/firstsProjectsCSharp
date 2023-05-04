**** Operador condicional ternario
<condición>?<expresión1>:<expresión2>
b = (a>0)? a : 0;     // Suponemos a y b de tipos enteros

En el ejemplo, si el valor de la variable a es mayor a 0 se asignará a b el valor de a, en caso contrario el valor que se le asignará será 0. 

Hay que tener en cuenta que este operador es asociativo por la derecha, por lo que una expresión como
 a?b:c?d:e es equivalente a a?b:(c?d:e)

No hay que confundir este operador con la instrucción condicional if, pues aunque su utilidad es similar al de ésta ,? devuelve un valor e if no.


**** Los operadores && y || se diferencian de & y | en que los primeros realizan la evaluación perezosa y los segundos no. 

La evaluación perezosa consiste en que si el resultado de evaluar el primer operando permite deducir el resultado de la operación, entonces no se evalúa el segundo y se devuelve dicho resultado directamente.

La evaluación no perezosa consiste en evaluar siempre ambos operandos. Es decir, si el primer operando de una operación
&& es falso, se devuelve false directamente, sin evaluar el segundo; y si el primer operando de una || es verdadero, se devuelve true directamente, sin evaluar el otro.

****Operador XOR "^" (ALT + 94)
El operador "XOR" ("^"),actua como un "OR exclusivo": devuelve true, si y solo si, uno de los valores es True y el otro false. De lo contrario, devuelve false. 
La única diferencia con "||" es que,  en OR: "V || V dá V", mientras que en XOR: "V ^ V dá F"

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

