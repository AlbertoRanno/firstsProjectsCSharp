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

