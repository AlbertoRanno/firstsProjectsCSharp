/* Un arreglo de dos dimensiones, es una matriz, y los elementos se acceden desde dos coordenadas, una que representa la fila y otra que representa la columna.
0 -1 -2 -3 -4 -5 -6 -7 -8 -9
0 1 2 3 4 5 6 7 8 9
● Esta matriz tiene 2 filas y 10 columnas.
● Contiene números enteros positivos y negativos.
● El índice de la fila va desde 0 a 1 (son 2 filas).
● El índice de la columna va desde 0 a 9 (son 10 columnas).
 ejemplo:
Creamos una matriz de 2 filas y 10 columnas, la llenamos con números aleatorios positivos menores a 100 (con el generador de números Random), y a la vez vamos mostrando el valor de cada elemento de la matriz:
 */

// static void Main(string[] args)
// {
// const int MaxFilas = 2;
// const int MaxColumnas = 10;
// Random objRandom = new Random();
// Console.WriteLine("Matriz");
// int[,] Matriz = new int[MaxFilas, MaxColumnas];
// for (int i = 0; i < MaxFilas; i++)
// {
//   for (int j = 0; j < MaxColumnas; j++)
//   {
//     Matriz[i, j] = objRandom.Next(100);
//     Console.WriteLine($"Matriz[{i},{j}] = {Matriz[i, j]}");
//   }
// }
// Console.ReadKey();
//}

/*
Si se imaginara una dimensión más, se tendría un cubo que es un arreglo de tres dimensiones.
Sus elementos se acceden con tres coordenadas, la primera que representa la fila, la segunda que representa la columna, y una tercera que representa la profundidad dentro del cubo.
En la imagen de la derecha se ilustra un cubo de 4 filas, 5 columnas y 3 niveles de profundidad.
Un array de tres dimensiones (4 x 5 x 3)
 ejemplo:
Creamos un cubo de 4 filas, 5 columnas y 3 niveles de profundidad, lo llenamos con números aleatorios positivos menores a 100 (con el generador de números Random), y a la vez vamos mostrando el valor de cada elemento del cubo:
*/
// static void Main(string[] args)
// {
//   const int MaxFilas = 4;
//   const int MaxColumnas = 5;
//   const int MaxNiveles = 3;
//   Random objRandom = new Random();
//   Console.WriteLine("Cubo" + Environment.NewLine);
//   int[,,] Cubo = new int[MaxFilas, MaxColumnas, MaxNiveles];
//   for (int i = 0; i < MaxFilas; i++)
//   {
//     for (int j = 0; j < MaxColumnas; j++)
//     {
//       for (int k = 0; k < MaxNiveles; k++)
// {
//         Cubo[i, j, k] = objRandom.Next(100);
//         Console.WriteLine($"Cubo [{i},{j},{k}] = {Cubo[i, j, k]}");
//       }
//     }
//   }
// Console.ReadKey();
// }

/*Nombre del arrego, si lo llamo con console.WriteLine, no voy a ver lo tengo, sus valores en cada coordenada... no.
Simplemente voy a ver el tipo de dato, esto es porque en el nombre se almacena la direccion de memoria. Una Referencia.
Por eso si quiero los valores del arreglo, tengo que trabajar con el valor del arreglo + sus subindices.

Para imprimir todos los datos de un arreglo, tendre que imprimir variable por variable. Sirve el FOR.

Para el largo NombreArreglo.Length

 */

// Console.WriteLine(Cubo.Length); // En varias dimensiones, dará el largo total, en este caso: 60 = (4 x 5 x 3)

/* Si quisiera acceder a un indice, que excede al maximo que tiene mi arreglo, estaria queriendo acceder a memoria que no tengo accedo por lo que da error en tiempo de ejecucion 

Copia de arreglos variable a variable mediante un for:
*/
// char[] origen = { '@', 'q', 'D', 'T', 'l' };
// char[] destino = new char[5];
// for (int i = 0; i < origen.Length; i++)
// {
//   destino[i] = origen[i]; //Ojo con el orden
// }
// for (int i = 0; i < destino.Length; i++)
// {
//   Console.WriteLine(destino[i]);
// }

/*Promedio*/
// short[] promedio = { -2344, 453, -2355, 666, 550, 3555 };
// int suma = 0;

// for (int i = 0; i < promedio.Length; i++)
// {
//   suma += promedio[i];
// }

// Console.WriteLine($"El promedio es {suma/(promedio.Length)}");

/*El Mayor y El Menor*/
// short elMayor = promedio[0], elMenor = promedio[0];
// for (int i = 1; i < promedio.Length; i++)
// {
//   if (elMayor < promedio[i])
//   {
//     elMayor = promedio[i];
//   }
//   if (elMenor > promedio[i])
//   {
//     elMenor = promedio[i];
//   }
// }
// Console.WriteLine($"El mayor {elMayor} El menor {elMenor}");

// Inicialización Array 2 dimensiones, y forma copada para visualizarlo:
// byte[,] array2D = {   {3,123,99},
//                       {23,54,99},
//                       {76,77,99},
//                       {40,36,99},
//                       {35,67,99},
//                       {76,21,99}
//                       };
// for (int i = 0; i < array2D.GetLength(0); i++) //GetLength da la longitud de las filas (indice 0)
// {
//   for (int j = 0; j < array2D.GetLength(1); j++) //GetLength da la longitud de las columnas (indice 1)
//   {
//     Console.Write($"{array2D[i, j]}\t"); //Write para uno al lado del otro, espaciado con tabulador
//   }
//   Console.WriteLine(); //El cambio de linea cada vez que termina de recorrer las columnas
// }

/* EJ 1
Uso de un arreglo para ingreso de datos por teclado.
Ingrese por teclado la facturación de los últimos 6 meses (se ingresa un importe por cada mes).
Solo se pueden ingresar números.
Informar
1. La facturación total (sumatoria).
2. El promedio de facturación de los últimos 6 meses.
3. El valor máximo facturado.
4. El valor mínimo facturado.
*/
// string? ReadResult;
// double[] facturacionXMes = new double[6];
// byte cantMeses = 6;
// double facturacionTotal = 0, elMenorMonto = facturacionXMes[0], elMayorMonto = facturacionXMes[0];

// Console.Clear();
// Console.WriteLine("Bienvenido a la app!\n");
// for (int i = 0; i < cantMeses; i++)
// {
//   Console.Write($"Ingresá la facturación del Mes {i + 1}: ");
//   ReadResult = Console.ReadLine();
//   if (ReadResult != null)
//   {
//     facturacionXMes[i] = double.Parse(ReadResult);
//     facturacionTotal += facturacionXMes[i];
//   }

//   if (elMayorMonto < facturacionXMes[i])
//   {
//     elMayorMonto = facturacionXMes[i];
//   }
//   if (elMenorMonto > facturacionXMes[i])
//   {
//     elMenorMonto = facturacionXMes[i];
//   }
// }
// for (int i = 0; i < cantMeses; i++)
// {
//   Console.WriteLine($"La facturación del mes {i + 1}, fue de ${facturacionXMes[i]}");
// }
// Console.WriteLine($"La facturación total del mes fue de {facturacionTotal}");
// Console.WriteLine($"El promedio de la facturación fue de {facturacionTotal / cantMeses}");
// Console.WriteLine($"El mes que menos se facturó {elMenorMonto}");
// Console.WriteLine($"El mes que más se facturó {elMayorMonto}");

/* EJ 2
Copiar el contenido del arreglo origen al arreglo destino utilizando una estructura de control de flujo repetitiva y, luego, informar el índice y los valores del arreglo destino.
*/
char[] origen = { '@', 'q', 'D', 'T', 'l' };
char[] destino = new char[5];
for (int i = 0; i < origen.Length; i++)
{
  destino[i] = origen[i];
}
for (int i = 0; i < destino.Length; i++)
{
  Console.WriteLine($"En la posición origen{i} {destino[i]}");
}