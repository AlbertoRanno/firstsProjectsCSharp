La instrucción de iteración "for" permite recorrer en iteración un bloque de código un número específico de veces.
La instrucción de iteración "for" permite controlar todos los aspectos de la mecánica de la iteración mediante la modificación de las tres condiciones que se encuentran dentro de los paréntesis: el inicializador, la condición y el iterador.
Es habitual utilizar la instrucción for cuando se necesita controlar la manera de recorrer en iteración cada elemento de una matriz.
Si el bloque de código tiene solo una línea de código, se pueden eliminar las llaves de apertura y cierre y el espacio en blanco. (*)


**** El break, detiene también al ciclo for!

for (int i = 0; i < 10; i+=2)
{
    Console.WriteLine(i);
    if (i == 8) break;
}

****

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