/*************************************** ARRAYS
Hasta ahora siempre había que saber con antelación el número de variables que el programa iba a necesitar.
Sin embargo, habrá situaciones en las que no sea posible determinar este número hasta que el programa no se esté ejecutando. Pues bien, para solucionar estas dificultades contamos con las estructuras de arreglos, arrays en inglés. 

/*************************************** Arreglos de una dimensión
Un array es una variable que es capaz de almacenar varios valores en forma simultánea.
Cada uno de estos valores se identifica mediante un número que se denomina “índice”.
Para acceder al primer elemento del array se usa el índice cero, para el segundo el índice uno, para el tercero el índice dos, y así sucesivamente. 

Al arreglo se lo declara de la siguiente forma: tipo[] variable;

Es muy parecido a cómo se declara una variable normal, sólo que hay que poner corchetes detrás del tipo de dato.

!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!IMPORTANTE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

En C# los arrays son objetos derivados de la clase System.Array. Por lo tanto, y esto es muy importante, cuando declaramos un array en C# este aún no se habrá creado en la memoria de la computadora, en consecuencia, antes de poder usarlos habrá que instanciarlos, como si fuera cualquier otro objeto.

Veamos un breve ejemplo:
string[] nombres; // Declaración del array
nombres = new string[3]; // Instanciación del array

En efecto, el array nombres será utilizable únicamente a partir de su instanciación, y podrá tener un máximo de tres elementos, accedidos desde los índices 0, 1 y 2.
Nótese que índice del array comienza de CERO (0) y NO de uno (1), por lo cual el índice del último elemento es siempre el TotalDeElementos menos uno (3-1=2)

/*************************************** Operaciones de recorrida de arreglos
Un array es un conjunto de objetos, ordenado y de tamaño fijo.
Para acceder a cualquier elemento de este conjunto se aplica el operador postfijo [] sobre la tabla para indicar entre corchetes 
la posición que ocupa el objeto al que se desea acceder dentro del conjunto. 

Es decir, este operador se usa así: [<posiciónElemento>]

Un ejemplo de su uso, en el que se asigna al elemento que ocupa la posición 3 en una tabla de nombre arrayPrueba, el valor del elemento que ocupa la posición 18 de dicha tabla es el siguiente: 

arrayPrueba[3] = arrayPrueba[18];
*/








/*
*Una matriz es una variable especial que contiene una secuencia de elementos de datos relacionados.
*Debe memorizar el formato básico de una declaración de variable de matriz.
*Acceda a cada elemento de una matriz para establecer u obtener sus valores mediante el uso de un índice de base cero entre corchetes.
*Si intenta obtener acceso a un índice fuera del límite de la matriz, obtendrá una excepción en tiempo de ejecución.
*La propiedad Length proporciona una manera de determinar mediante programación el número de elementos de una matriz.
*/

/* forma 1 de inicializar una matriz:
string[] fraudulentOrdersIDs = new string[3];

fraudulentOrdersIDs[0]= "A123";
fraudulentOrdersIDs[1]= "B456";
fraudulentOrdersIDs[2]= "C789";
//fraudulentOrdersIDs[3]= "D000";

forma 2 de inicializar una matriz:
*/
string[] fraudulentOrdersIDs = { "A123", "B456", "C789"};

Console.WriteLine($"First: {fraudulentOrdersIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrdersIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrdersIDs[2]}");

fraudulentOrdersIDs[0] = "FOOO";

Console.WriteLine($"Reassign First: {fraudulentOrdersIDs[0]}");

Console.WriteLine($"There are {fraudulentOrdersIDs.Length} fraudulent orders to process.");


/*FOREACH

*Use la instrucción foreach para recorrer en iteración cada elemento de una matriz y ejecutar el bloque de código asociado una vez por cada elemento de la matriz.
*La instrucción foreach establece el valor del elemento actual de la matriz en una variable temporal, la cual se puede usar en el cuerpo del bloque de código.
*Use el operador de incremento ++ para sumar 1 al valor actual de una variable.*/

string[] nombres = { "Bob", "Conrad", "Grant"};

foreach (string nombre in nombres)
{
    Console.WriteLine(nombre);
}

int[] inventory = { 200, 450, 700, 175, 250};

int sum = 0;
int bin = 0;

foreach (int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");

// ejemplo de cómo usar el método String.StartsWith():
string name = "Bob";
if (name.StartsWith("B"))
{
    Console.WriteLine("The name starts with 'B'!");
}
