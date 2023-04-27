**** FOR
La instrucción de iteración "for" permite recorrer en iteración un bloque de código un número específico de veces.
La instrucción de iteración "for" permite controlar todos los aspectos de la mecánica de la iteración mediante la modificación de las tres condiciones que se encuentran dentro de los paréntesis: el inicializador, la condición y el iterador.
Es habitual utilizar la instrucción for cuando se necesita controlar la manera de recorrer en iteración cada elemento de una matriz.
Si el bloque de código tiene solo una línea de código, se pueden eliminar las llaves de apertura y cierre y el espacio en blanco. (*)


-- El break, detiene también al ciclo for!!!!

for (int i = 0; i < 10; i+=2)
{
    Console.WriteLine(i);
    if (i == 8) break;
}

--

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = names.Length - 1; i >= 0; i--)
{
    Console.WriteLine(names[i]);
}

**** Foreach, NO sirve para reasignar valores. En cambio FOR si:

string[] names = { "Alex", "Eddie", "David", "Michael" };
foreach (var name in names)
{
    // Can't do this:
    if (name == "David") name = "Sammy";
}

string[] names = { "Alex", "Eddie", "David", "Michael" };
for (int i = 0; i < names.Length; i++)
    if (names[i] == "David") names[i] = "Sammy";

foreach (var name in names) Console.WriteLine(name); (*)

**** DO-WHILE   //  WHILE

Las instrucciones do-while y while permiten controlar el flujo de ejecución del código recorriendo en bucle un bloque de código hasta que se cumpla una condición. Cuando se trabaja con la instrucción foreach, se itera una vez por cada elemento de forma secuencial, como una matriz. La instrucción for permite iterar un número predeterminado de veces y controlar el proceso de iteración. Las instrucciones do-while y while permiten recorrer en iteración un bloque de código con la intención de que la lógica que contiene afectará al momento de poder detener la iteración.

La instrucción do-while ejecuta una instrucción o un bloque de instrucciones mientras que una expresión booleana especificada se evalúa como true. Como esa expresión se evalúa después de cada ejecución del bucle, un bucle do-while se ejecuta una o varias veces.

do
{
    // This code executes at least one time
} while (true)

El flujo de ejecución comienza dentro de la llave. El código se ejecuta al menos una vez y después se evalúa la expresión booleana que se encuentra junto a la palabra clave while. Si la expresión booleana devuelve true, el bloque de código se vuelve a ejecutar.

Al codificar de forma rígida la expresión booleana en true, se ha creado un bucle infinito, un bucle que no finalizará nunca, al menos tal y como está escrito actualmente. En este caso, se necesita una forma de salir del bucle dentro del bloque de código.

La instrucción do-while recorre en iteración un bloque de código al menos una vez y puede continuar la iteración en función de una expresión booleana. La evaluación de la expresión booleana normalmente depende de un valor generado o recuperado dentro del bloque de código.

Random random = new Random();
int current = 0;

do
{
    current = random.Next(1, 11);
    Console.WriteLine(current);
} while (current != 7);

Es importante tener en cuenta que el código dentro del bloque influye en si la iteración por el bloque de código continúa o no. Un bloque de código que influye en los criterios de salida es una razón principal para seleccionar una instrucción do-while o while en lugar de una de las otras instrucciones de iteración. Tanto foreach como for dependen de factores externos al bloque de código para determinar el número de iteraciones de bloques de código.

-- while

La instrucción while evalúa primero una expresión booleana y continúa recorriendo en iteración el bloque de código siempre y cuando la expresión booleana se evalúe como true.

Random random = new Random();
int current = random.Next(1, 11);

while (current >= 3)
{
  Console.WriteLine(current);
  current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");

En este caso, se coloca la palabra clave while y la expresión booleana delante del bloque de código. Esto cambia el significado del código y actúa como una "puerta" para permitir el flujo de ejecución solamente si la expresión booleana se evalúa como true.

Si current se ha inicializado en un valor mayor o igual que 3, la expresión booleana devolverá true, y el flujo de ejecución entrará en el bloque de código. Dentro del bloque de código, lo primero que hacemos es escribir el valor de current en la consola. A continuación, todavía dentro del bloque de código, actualizamos el valor de current con un nuevo valor aleatorio. En este momento, el control vuelve a la parte superior de la instrucción while donde se evalúa la expresión booleana. Este proceso continúa hasta que la expresión booleana devuelve false y el flujo de ejecución se interrumpe del bloque de código.
Si current se inicializa (en la parte superior del código) en un valor menor que 3, la expresión booleana devolverá false, y el bloque de código nunca se ejecutará.
La línea de código final escribe el valor de current en la consola. Este código ejecuta si el bloque de código de iteración se ejecutó o no, y es nuestra oportunidad de escribir el valor final de current en la consola.

-- do-while + continue

Continue transfiere la ejecución al final de la iteración actual.
A diferencia de break, que finaliza la iteración por completo.

Random random = new Random();
int current = random.Next(1, 11);

do
{
  current = random.Next(1, 11);

  if (current >= 8) continue; // si true, saltea el Console.WriteLine, y va directo al while.
                              // por lo que no voy a ver valores mayores o iguales a 8 en consola.

  Console.WriteLine(current);
} while (current != 7);



La palabra clave continue, para pasar inmediatamente a la expresión booleana.