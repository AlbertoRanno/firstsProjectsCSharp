﻿/***************************************
Obtener la sumotoria de los nros ingresados hasta cierto punto */

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
//     Console.WriteLine($"La suma acumulada es de {suma}");
//   }
// } while (numeroIngresado != -1);

// Console.WriteLine("Presione una tecla para finalizar la aplicación");
// Console.ReadKey();




/***************************************
Ejemplos de FOR */

// //Forma Clásica:
// for (int i = 1; i <= 10; i++)
//   Console.WriteLine(i);

// //También se podría escribir así (dejando aún en mayor evidencia, su parecido al while)
// int i = 1;
// for (; i <= 10;)
// {
//   Console.WriteLine(i);
//   i++;
// }

// //Versión con más de una variable:
// for (int i = 0, j = 10; i <= 10 && j > 3; i++, j--)
// {
//   Console.WriteLine($"i: {i} - j: {j}");
// }




/***************************************
Mostrar la resta de la multiplicación de los números del 1 al 5, con la suma de los números del 1 al 5.
Por ejemplo sería (1*2*3*4*5) - (1+2+3+4+5) */
// short multiplicación = 1, suma = 0;

// for (byte i = 1; i <= 5; i++)
// {
//   multiplicación *= i;
//   suma += i;
// }

// Console.WriteLine($"(1*2*3*4*5) - (1+2+3+4+5) = {multiplicación} - {suma} = {multiplicación - suma}");




/***************************************
Imprimir la siguiente figura:
@
@@
@
@@
@
*/

// for (byte i = 1; i <= 5; i++)
// {
//   if (i % 2 != 0)
//     Console.WriteLine("@");
//   else
//     Console.WriteLine("@@");
// }




/***************************************
Imprimir la siguiente figura:
@
@@
@@@
@@@@
@@@@@
*/
// string arroba = "@", suma = "";

// for (byte i = 1; i <= 5; i++)
// {

//   Console.WriteLine(suma += arroba);

// }




/***************************************
Imprimir la siguiente figura:
@@@@@
@@@@
@@@
@@
@
*/

/*Para trabajar en 2 dimensiones, se suelen usar DOS FOR ANIDADOS, donde uno recorre las filas y otro las columnas.
En este caso particular, el limite de j (columnas, se achica en uno cada vez que se baja a la siguiente fila)
  12345   j
1 @@@@@
2 @@@@
3 @@@
4 @@
5 @
i
*/
byte limiteJ = 5;

for (byte i = 1; i <= 5; i++)
{
  for (int j = 1; j <= limiteJ; j++)
  {
    Console.Write("@");
  }
  Console.WriteLine();
  limiteJ--;
}

/*También se podría poner como:*/
for (byte i = 1; i <= 5; i++, limiteJ--)
{
  for (int j = 1; j <= limiteJ; j++)
  {
    Console.Write("@");
  }
  Console.WriteLine();
}