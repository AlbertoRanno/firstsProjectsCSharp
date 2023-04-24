
/*
Puede usar comentarios de código para agregar un mensaje como TODO para recordarle que examine un fragmento de código determinado más adelante. Aunque debe usarlo con prudencia, es un motivo válido. Es posible que esté trabajando en otra característica y lea una línea de código en la que detecta un problema. En lugar de omitir el nuevo problema, puede marcarlo para investigarlo más adelante. El IDE de Visual Studio incluye incluso una ventana denominada Lista de tareas para ayudarle a identificar los mensajes TODO que deja en el código.

No se puede confiar en los comentarios de código. A menudo, los desarrolladores actualizan su código, pero se olvidan de actualizar los comentarios de código. Es mejor usar los comentarios para ideas de nivel superior y no agregar comentarios sobre cómo funciona una línea de código individual.

*Use los comentarios de código para dejar notas significativas sobre el problema que resuelve el código.
*No use comentarios de código que expliquen cómo funcionan C# o la biblioteca de clases .NET.
*Use los comentarios de código para probar temporalmente soluciones alternativas hasta que esté listo para confirmar la nueva solución de código, en cuyo momento, puede eliminar el código anterior.
*No confíe nunca en los comentarios. Es posible que no reflejen el estado actual del código después de muchos cambios y actualizaciones.

EJ COMENTARIOS INCORRECTOS:
Random random = new Random();
string[] orderIDs = new string[5];
// Loop through each blank orderID
for (int i = 0; i < orderIDs.Length; i++)
{
    // Get a random value that equates to ASCII letters A through E
    int prefixValue = random.Next(65, 70);
    // Convert the random value into a char, then a string
    string prefix = Convert.ToChar(prefixValue).ToString();
    // Create a random number, padd with zeroes
    string suffix = random.Next(1, 1000).ToString("000");
    // Combine the prefix and suffix together, then assign to current OrderID
    orderIDs[i] = prefix + suffix;
}
// Print out each orderID
foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}

EJ COMENTARIOS CORRECTOS:*/
/*
  The following code creates five random OrderIDs
  to test the fraud-detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/
Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}

/*
*Use los espacios en blanco prudentemente para mejorar la legibilidad del código.
*Use los avances de línea para crear líneas vacías que separen frases de código. Una frase se compone de líneas de código que son similares o que funcionan de forma conjunta.
*Use los avances de línea para separar los símbolos de los bloques de código para que estén en su propia línea de código.
*Use la tecla tab para alinear un bloque de código con la palabra clave con la que está asociado.
*Aplique sangría al código dentro de un bloque de código para mostrar a qué pertenece.
*/

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3)) 
{
    if ((roll1 == roll2) && (roll2 == roll3)) 
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6; 
    } 
    else 
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
}

/*
   This code reverses a message, counts the number of times 
   a particular character appears, then prints the results
   to the console window.
 */

string originalMessage = "The quick brown fox jumps over the lazy dog.";

char[] message = originalMessage.ToCharArray();
Array.Reverse(message);

int letterCount = 0;

foreach (char letter in message)
{
    if (letter == 'o')
    {
        letterCount++;
    }
}

string newMessage = new String(message);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {letterCount} times.");
