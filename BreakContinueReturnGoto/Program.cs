/************************************************** break; // sale forzadamente de bucles o condicionales
 la instrucción break sólo se puede incluir dentro de bloques de instrucciones asociados a instrucciones iterativas o instrucciones switch, e indica que se desea abortar la ejecución de las mismas y seguir ejecutando a partir de la instrucción siguiente a ellas.*/

// for (int numero = 2; numero <= 30; numero += 2)
// {
//   Console.WriteLine(numero);
//   if (numero == 20)
//   {
//     Console.WriteLine("Llegó a 20 y salió con Break.");
//     break; // omite mostrar el 22 24 26 28 30
//   }
// }
// Console.WriteLine("Aquí salió con el break");

/*
Cuando esta sentencia se usa dentro de un bloque try con cláusula finally (que tiene como objetivo atrapar errores en tiempo de ejecución, tema a ver en el siguiente curso de C#), antes de abortarse la ejecución de la instrucción iterativa o del switch que la contiene y seguirse ejecutando por la instrucción que le siga, se ejecutarán las instrucciones de la cláusula finally del try. Esto se hace para asegurar que el bloque finally se ejecute aún en caso de salto. Además, si dentro de una cláusula finally incluida en un switch o de una instrucción iterativa se usa break, no se permite que como resultado del break se salga del finally.
Otro Ej.*/

//Obtener la sumotoria de los nros ingresados hasta cierto punto: que se ingrese "-1", o la suma supere los 1000 (nuevo con break)

// string? readResult;
// long numeroIngresado = 0, suma = 0;

// Console.Clear();

// do
// {
//   Console.WriteLine("Ingrese los numeroS que desee ir sumando, tipe \"-1\" para terminar");
//   readResult = Console.ReadLine();
//   if (readResult != null)
//   {
//     numeroIngresado = long.Parse(readResult);
//     suma += numeroIngresado;

//     if (suma >= 1000) break; //Pasa a informar cuánto sumó apenas superó los 1000. Es decir sale del bucle, y pasa al Console
//   }
// } while (numeroIngresado != -1);

// Console.WriteLine($"La suma acumulada es de {suma}");
// Console.WriteLine("Presione una tecla para finalizar la aplicación");
// Console.ReadKey();





/************************************************** continue; // En vez de seguir con lo que sigue a continuación, vuelve a evaluar la condición del comienzo.

La instrucción llamada continue sólo puede usarse dentro del bloque de instrucciones de una instrucción iterativa. Indica que se desea pasar a reevaluar directamente la condición de la iteración sin ejecutar el resto de instrucciones que contiene. La evaluación de la condición se haría de la forma habitual: si es cierta se repite el ciclo y si es falsa se continúa ejecutando por la instrucción que le sigue.*/
// for (int numero = 2; numero <= 30; numero += 2)
// {
//   Console.WriteLine(numero);
//   if (numero == 20)
//   {
//     Console.WriteLine("con Continue vuelve a ingresar al ciclo. No sale nunca");
//     numero = 8;
//     continue; // NO LO ENTIENDO, CONSULTAR... SI LO OMITO, IMPRIME LO MISMO
//   }
// }
/* Imprime:
2
4
6
8
10
12
14
16
18
20
con Continue vuelve a ingresar al ciclo. No sale nunca
10
12
14
16
18
20
con Continue vuelve a ingresar al ciclo. No sale nunca
10
...
*/
/*
En cuanto a sus usos dentro de sentencias try, tiene las mismas restricciones que break: antes de salir de un try se ejecutará siempre su bloque finally y no es posible salir de un finally incluido dentro de una instrucción iterativa como consecuencia de un continue.
 Otro Ejemplo:*/

//Obtener la sumotoria de los nros ingresados hasta cierto punto: que se ingrese "-1", o la suma supere los 1000 (nuevo con break). Agrego, "si el nro ingresado, es divisible por 3, no quiero que se sume

// string? readResult;
// long numeroIngresado = 0, suma = 0;

// Console.Clear();

// do
// {
//   Console.WriteLine("Ingrese los numeroS que desee ir sumando, tipe \"-1\" para terminar");
//   readResult = Console.ReadLine();
//   if (readResult != null) numeroIngresado = long.Parse(readResult);

//   if (numeroIngresado % 3 == 0) continue; // Se omite este valor para la suma, y se pasa a pedir el siguiente número

//   if (numeroIngresado >= 0) suma += numeroIngresado;

//   if (suma >= 1000) break; //Pasa a informar cuánto sumó apenas superó los 1000. Es decir sale del bucle, y pasa al Console

// } while (numeroIngresado != -1);

// Console.WriteLine($"La suma acumulada es de {suma}");
// Console.WriteLine("Presione una tecla para finalizar la aplicación");
// Console.ReadKey();



/************************************************** return <objetoRetorno>;
Esta instrucción se usa para indicar cuál es el objeto que ha de devolver una función. 
La ejecución de esta instrucción provoca que se aborte la ejecución de la función en la que aparece, y que se devuelva el <objetoRetorno> al código que llamó a la función. Como es lógico, este objeto ha de ser del tipo de retorno de la función en que aparece el return o de alguno compatible con él, por lo que esta instrucción solo podrá incluirse en funciones cuyo tipo de retorno no sea void, o en los bloques get de las propiedades o indizadores. De hecho, es obligatorio que toda función con tipo de retorno termine con un return. 
Las funciones que devuelvan void pueden tener un return con una sintaxis especial en la que no se indica ningún valor a devolver sino que simplemente se usa return para indicar que se desea terminar su ejecución: */
// static int Return_Ejemplo_Funcion()
// {
//   int numero1 = 10, numero2 = 20;
//   return numero1 + numero2;
// }
// static void Return_Ejercicio4()
// {
//   for (int numero = 2; numero <= 30; numero += 2)
//   {
//     Console.WriteLine(numero);
//     if (numero == 20)
//     {
//       Console.WriteLine("Sale con Return.....");
//       return;
//     }
//   }
// }
/*
Nuevamente, como con el resto de las instrucciones de salto hasta ahora vistas, si se incluyese un return dentro de un bloque try con cláusula finally, antes de devolverse el objeto especificado se ejecutarían las instrucciones de la cláusula finally. Si hubiesen varios bloques finally anidados, las instrucciones de cada uno se ejecutarían de manera ordenada (o sea, del más interno al más externo). Ahora bien, lo que no es posible es incluir un return dentro de una cláusula finally.*/


/************************************************** goto <etiqueta>;
La instrucción goto permite pasar a ejecutar el código a partir de una instrucción cuya etiqueta se indica en el goto. 
Como en la mayoría de los lenguajes, goto es una instrucción nada recomendable cuyo uso dificulta innecesariamente la legibilidad del código y suele ser fácil de simular usando instrucciones iterativas y selectivas con las condiciones apropiadas. Sin embargo, en C# se incluye porque puede ser eficiente usarla si se anidan muchas instrucciones y para reducir sus efectos negativos se le han impuesto unas restricciones. Vamos a ver estas restricciones en el próximo slide.
 
 ¡Esta instrucción mal utilizada puede provocar complejos errores de lógica en la programación! 
 
● Sólo se pueden etiquetar instrucciones, y no directivas de preprocesado, directivas using o definiciones de miembros, tipos o espacios de nombres.
● La etiqueta indicada no pueda pertenecer a un bloque de instrucciones anidado dentro del bloque desde el que se usa el goto ni que etiquete a instrucciones de otro método diferente a aquél en el cual se encuentra el goto que la referencia.
● Para etiquetar una instrucción de modo que pueda ser destino de un salto con goto basta precederla del nombre con el que se la quiera etiquetar seguido de dos puntos (:).
En el ejemplo de la siguiente slide veremos cómo usar goto y definir una etiqueta.  */

// for (int numero = 1; numero <= 5; numero++)
// {
//   if (numero <= 3)
//   {
//     Console.WriteLine(numero);
//   }
//   else
//   {
//     goto salida;
//   }
// }

// salida: Console.WriteLine("Llegó a 3 e interrumpió la ejecución del for");
// Console.ReadKey();
/*
El programa del ejemplo anterior muestra por pantalla los números del 1 al 5, pero una vez mostrado el 3 se aborta su ejecución. Véase además que el ejemplo pone de manifiesto una de las utilidades de la instrucción nula, ya que si no se hubiese escrito tras la etiqueta "salida", el programa no compilaría en tanto que toda etiqueta ha de preceder a alguna instrucción (aunque sea la instrucción nula). Nótese que al fin y al cabo los usos de goto dentro de instrucciones switch que se vieron al estudiar dicha instrucción no son más que variantes del uso general de goto, ya que default: no es más que una etiqueta y case <valor>: puede verse como una etiqueta un tanto especial cuyo nombre es case seguido de espacios en blanco y un valor. En ambos casos, la etiqueta indicada ha de pertenecer al mismo switch que el goto usado.
*/



/************************************************** Ejercicio Laboratorio 1
Imprimir la siguiente figura:
@@@@@
@@@
@
@@@
@@@@@
*/
// int LimiteJ = 5;

// for (int i = 1; i <= 5; i++)
// {
//   for (int j = 1; j <= LimiteJ; j++)
//   {
//     Console.Write("@");
//   }
//   if (i < 3) LimiteJ -= 2;
//   else LimiteJ += 2;

//   Console.WriteLine();
// }


/************************************************** Ejercicio Laboratorio 2
Mostrar la suma de los números pares mayores a 9 y menores a 20.*/

// int suma = 0;

// for (int i = 1; i <= 30; i++)
// {
//   if (i % 2 == 0 && i > 9 && i < 20)
//   {
//     suma += i;
//   }
// }

// Console.WriteLine(suma);


/************************************************** Ejercicio Laboratorio 3
Implementar un código que imprima el mayor y el menor de una serie de cinco números que vamos introduciendo por teclado. */

// int numeroIngresado = 0, elMayor = 0, elMenor = 0;
// string? readResult;

// Console.Clear();

// for (int i = 1; i <= 5; i++)
// {
//   Console.WriteLine("Ingrese un número");
//   readResult = Console.ReadLine();
//   if (readResult != null) numeroIngresado = int.Parse(readResult);

//   if (i == 1) // sin esta asignación, si luego no ingresaba un nro negativo, imprimía que el menor era el "0",xq no sobreescribía
//   {
//     elMenor = numeroIngresado;
//     elMayor = numeroIngresado;
//   }

//   if (numeroIngresado < elMenor) elMenor = numeroIngresado;
//   if (numeroIngresado > elMayor) elMayor = numeroIngresado;
//   Console.WriteLine($"De los números ingresados, el menor fue {elMenor}, y el mayor fue {elMayor}");
// }

// Console.WriteLine($"De los números ingresados, el menor fue {elMenor}, y el mayor fue {elMayor}");
// Console.WriteLine("Presione cualquier tecla para finalizar la app");
// Console.ReadKey();


/************************************************** Ejercicio Laboratorio 4
Mostrar la conversión de 1 hasta 10 euros en pesos, euro tras euro, suponiendo que el tipo de cambio es 5.80 pesos por euro.*/
decimal tipoDeCambio = 5.80M;

for (decimal i = 1; i <= 10; i++)
{ // Lenguaje Unicode:
  Console.OutputEncoding = System.Text.Encoding.UTF8; // codificación de la consola a UTF-8
  Console.WriteLine($"{i} \u20AC equivalen a ${i * tipoDeCambio} "); //€ = Alt + [0128] no lo reconoce la consola
}