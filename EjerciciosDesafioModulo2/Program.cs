/*******************************************
Ejercicio 1
Ingresar una nota de un alumno, e informar si está aprobado, si recupera o si promociona la materia.
Datos:
Se aprueba con nota 4, 5 o 6 y se promociona con nota igual o superior a 7.
*/
// byte nota = 0;
// string? readResult;

// Console.Clear();

// Console.WriteLine("Ingrese la nota del alumno (\"1 a 10\")");
// readResult = Console.ReadLine();

// if (readResult != null)
// {
//   nota = byte.Parse(readResult);
// }

// switch (nota)
// {
//   case <= 3:
//     Console.WriteLine("El alumno ha desaprobado la materia");
//     break;
//   case <= 6:
//     Console.WriteLine("El alumno ha aprobado la materia");
//     break;
//   case <= 10:
//     Console.WriteLine("El alumno ha promocionado la materia");
//     break;
//   default:
//     Console.WriteLine("La nota ingresada no es válida, por favor reinicie.");
//     break;
// };

// Console.WriteLine("Presione una tecla para finalizar");
// Console.ReadKey();




/*******************************************
Ejercicio 2
Realizar un programa que lea por teclado dos números, si el primero es mayor al segundo informar su suma y diferencia, en caso contrario informar el producto y la división del primero respecto al segundo.
*/

// string? readResult;
// int primerNumero = 0, segundoNumero = 0;

// Console.Clear();

// Console.WriteLine("Ingrese el primer número");
// readResult = Console.ReadLine();
// if (readResult != null)
//   primerNumero = int.Parse(readResult);

// Console.WriteLine("Ingrese el segundo número");
// readResult = Console.ReadLine();
// if (readResult != null)
//   segundoNumero = int.Parse(readResult);

// if (primerNumero > segundoNumero)
// {
//   Console.WriteLine("La suma de los valores ingresados es {0}", primerNumero + segundoNumero);
//   Console.WriteLine("La resta de los valores ingresados es {0}", primerNumero - segundoNumero);
// }
// else
// {
//   Console.WriteLine("El producto de los valores ingresados es {0}", primerNumero * segundoNumero);
//   Console.WriteLine("La división (1ero / 2do) de los valores ingresados es {0}", (Decimal)primerNumero / segundoNumero);
// }

// Console.WriteLine("Presione una tecla para finalizar");
// Console.ReadKey();




/*******************************************
Ejercicio 3
Ingresar 2 notas de parciales de un alumno, e informar si está aprobado, desaprobado o si debe recuperar el primer parcial o el segundo, sabiendo que la nota mínima de aprobación es 4 y se deben aprobar los 2 parciales.
*/

string? readResult;
decimal notaAprobar = 4, notaPromocionar = 7, notaPrimerParcial = 0, notaSegundoParcial = 0, promedio;


Console.Clear();

Console.WriteLine("Ingrese la nota obtenida en el primer parcial (\"1 a 10\")");
readResult = Console.ReadLine();
if (readResult != null)
  notaPrimerParcial = decimal.Parse(readResult);

Console.WriteLine("Ingrese la nota obtenida en el segundo parcial (\"1 a 10\")");
readResult = Console.ReadLine();
if (readResult != null)
  notaSegundoParcial = decimal.Parse(readResult);

if (notaPrimerParcial > 10 || notaSegundoParcial > 10 || notaPrimerParcial < 1 || notaSegundoParcial < 1)
{ Console.WriteLine("Los valores ingresados no son válidos, por favor reintente"); }
else if (notaPrimerParcial < notaAprobar && notaSegundoParcial >= notaAprobar)
{ Console.WriteLine("Tiene que recuperar el primer parcial"); }
else if (notaPrimerParcial >= notaAprobar && notaSegundoParcial < notaAprobar)
{ Console.WriteLine("Tiene que recuperar el segundo parcial"); }
else if (notaPrimerParcial < notaAprobar && notaSegundoParcial < notaAprobar)
{ Console.WriteLine("Tiene que recuperar ambos parciales"); }
else
{
  promedio = (notaPrimerParcial + notaSegundoParcial) / 2;
  if (promedio < notaPromocionar)
    Console.WriteLine($"Muy bien! Haz aprobado la materia - Promedio= {promedio}");
  else
    Console.WriteLine($"Felicitaciones! Haz promocionado la materia - Promedio= {promedio}");
}

Console.WriteLine("Presione una tecla para finalizar");
Console.ReadKey();