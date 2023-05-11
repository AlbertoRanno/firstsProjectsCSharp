/*************************************************************** Ejemplos de IF "CON ERRORES*/

// Caso correcto
// int numero = 20;

// if (numero < 50)
// {
//   numero++;
//   numero *= 2;
// }

// Console.WriteLine("El número final es : "+ numero); //42 OK

// Caso Incorrecto 1
// int numero = 60;

// if (numero < 50)

//   numero++;
// numero *= 2;


// Console.WriteLine("El número final es : " + numero);
//120 Wrong
//Al no poner las llaves, el sistema entiende que, en caso False, solo se omite la ejecuciòn del "numero++", y ejecuta la sentencia numero *=2... QUe se supone, en este ej. que no es lo deseado.

// Caso Incorrecto 2
// int numero = 100;

// if (numero < 50);
// {
//   numero++;
//   numero *= 2;
// }

// Console.WriteLine("El número final es : "+ numero);
//202 Wrong
//Al poner el ";" luego de la condición del if, el sistema interpreta que no hay ninguna condición para ejecutar (indistintamente de que sea T o F), y el código sigue ejecutándose, y ejecuta el bloque que sigue. Igualmente en este caso la compilación arroja una advertencia de "posible instrucción vacía errónea"



/*************************************************************** Ejercicio Laboratorio Adicional 1: Operador condicional

Dado el siguiente código, informe los distintos valores de n3.
      n1      n2      n3
A                     20
B                     0
C                     0
D                     20
*/

// int n1=20;
// int n2=10;
// int n3=(n1>n2)? n1:0;
// Console.WriteLine($"Siendo n1: {n1} y n2: {n2}, tenemos que n3 es: {n3}");
// n1=20;
// n2=10;
// n3=(n1<n2)? n1:0;
// Console.WriteLine($"Siendo n1: {n1} y n2: {n2}, tenemos que n3 es: {n3}");
// n1=20;
// n2=10;
// n3=(n1==n2)? n1:0;
// Console.WriteLine($"Siendo n1: {n1} y n2: {n2}, tenemos que n3 es: {n3}");
// n1=20;
// n2=10;
// n3=(n1!=n2)? n1:0;
// Console.WriteLine($"Siendo n1: {n1} y n2: {n2}, tenemos que n3 es: {n3}");



/***************************************************************Ejercicio Video Laboratorio 1 
Dadas las variables, informar cuál de las 3 es la mayor */

// int numero1 = 100, numero2 = 500, numero3 = 250;

// int elMasGrande = (numero1 > numero2 ) ? (numero1 > numero3 ? numero1 : numero3) : (numero2 > numero3 ? numero2 : numero3);

// Console.WriteLine($"El número más grande es el {elMasGrande}");



/***************************************************************Ejercicio Video Laboratorio 2 
Dado el siguiente código:
int a = 10, b= -2, c=5  // hay 2 números positivos y 1 negativo
Informar la multiplicaciòn de los dos números positivos */

// int a = -10, b = -2, c = 5;

// if (a > 0)
// {
//   if (b > 0)
//     Console.WriteLine($" \"a\" y \"b\" son los positivos, y la multiplicación entre ellos es igual a {a * b} ");
//   if (c > 0)
//     Console.WriteLine($" \"a\" y \"c\" son los positivos, y la multiplicación entre ellos es igual a {a * c} ");
// }
// else
// {
//   Console.WriteLine($" \"b\" y \"c\" son los positivos, y la multiplicación entre ellos es igual a {b * c} ");
// }



/***************************************************************Ejercicio Video Laboratorio 3 
Dado el siguiente código:
string usuario = "Pepito", clave = "1234";
informar los siguientes casos:
si usuario="pepito" y clave="1234" informar "Bienvenido pepito!" 
si usuario="pepito" y clave No es "1234" informar "Clave Incorrecta"
si usuario No es pepito informar "Usuario No Existe"*/

// string usuario = "Pepito", clave = "1234";

// if (usuario.ToLower() == "pepito")
//   if (int.Parse(clave) == 1234)
//     Console.WriteLine("Bienvenido {0}", usuario);
//   else
//     Console.WriteLine("Clave incorrecta");
// else
//   Console.WriteLine("Usuario No Existe");




/*************************************************************** Laboratorio Adicional 2 Ejercicio 1
Dado el siguiente código:
int nro1 = 100, nro2 = 500, nro3 = 250;
Informar cuál de los tres números es mayor.*/

// int nro1 = 100, nro2 = 500, nro3 = 250;

// if (nro1 > nro2 && nro1 > nro3)
//   Console.WriteLine("n1 es el mayor");
// else if (nro2 > nro1 && nro2 > nro3)
//   Console.WriteLine("n2 es el mayor");
// else if (nro3 > nro1 && nro3 > nro2)
//   Console.WriteLine("n3 es el mayor");



/*************************************************************** Laboratorio Adicional 2 Ejercicio 2
Dado el siguiente código:
int a = 10, b=-2, c=5; // hay 2 números positivos y 1 negativo.
Informar la multiplicación de los dos números positivos. */

// int a = 10, b = -2, c = 5;

// if (a > 0 && b > 0) { Console.WriteLine("a * b = {0}", a * b); }
// else if (a > 0 && c > 0) { Console.WriteLine("a * c = {0}", a * c); }
// else if (b > 0 && c > 0) { Console.WriteLine("b * c = {0}", b * c); }



/*************************************************************** Laboratorio Adicional 2 Ejercicio 3
Dado el siguiente código:
String usuario = “Pepito”, clave= “1234”;
Informar los siguientes casos:
Si usuario = “Pepito” y clave= “1234”
informar Bienvenido pepito!”.
Si usuario = “Pepito” y clave no es “1234”
informar “Usuario incorrecto”.
Si usuario no es “Pepito” y clave=
“1234”informar “Contraseña incorrecta”.*/

// String usuario = "Pepito", clave = "1234";

// if ( usuario.ToLower() == "pepito" && int.Parse(clave) == 1234)
// Console.WriteLine("Bienvenido pepito!");
// else if (usuario.ToLower() != "pepito" && int.Parse(clave) == 1234)
// { Console.WriteLine("Usuario incorrecto"); }
// else if ( usuario.ToLower() == "pepito" && int.Parse(clave) != 1234)
// {Console.WriteLine("Contraseña incorrecta");}



/*************************************************************** Laboratorio Adicional 2 Ejercicio 4
Ingresar dos números y ofrecer al usuario un menú con las siguientes opciones:
"1-suma 2-resta 3-producto 4-división"
Luego, mostrar el resultado de la operación aritmética elegida"*/

// double numero1 = 0, numero2 = 0; //********DUDA!!!! POR QUÉ SI NO LOS INICIALIZO, DA ERROR ASIGNARLES EL VALOR CUANDO SON INGRESADOS??

// string? readResult;
// string menuSelection = "";

// Console.Clear();
// Console.WriteLine("Bienvenidos a la calculadora básica en C#\n Ingrese un número:");
// readResult = Console.ReadLine();
// if (readResult != null)
// {
//   numero1 = double.Parse(readResult);
// }
// Console.WriteLine("Ingrese otro número:");
// readResult = Console.ReadLine();
// if (readResult != null)
// {
//   numero2 = double.Parse(readResult);
// }
// Console.WriteLine($"Usted ingresó {numero1} y {numero2}.\n Elija una de las siguientes opciones: ");
// Console.WriteLine("\t Presione \"1\" - Para sumar los números ingresados");
// Console.WriteLine("\t Presione \"2\" - Para restar los números ingresados");
// Console.WriteLine("\t Presione \"3\" - Para obtener el producto entre los números ingresados");
// Console.WriteLine("\t Presione \"4\" - Para realizar la división entre los números ingresados");

// readResult = Console.ReadLine();
// if (readResult != null)
// {
//   menuSelection = readResult.ToLower();
// }

// switch (int.Parse(menuSelection))
// {
//   case 1:
//     Console.WriteLine($"La suma de {numero1} y {numero2} es igual a {numero1 + numero2} ");
//     break;
//   case 2:
//     Console.WriteLine($"La resta de {numero1} y {numero2} es igual a {numero1 - numero2} ");
//     break;
//   case 3:
//     Console.WriteLine($"El producto entre {numero1} y {numero2} es igual a {numero1 * numero2} ");
//     break;
//   case 4:
//     Console.WriteLine($"La división entre {numero1} y {numero2} es igual a {numero1 / numero2} ");
//     break;
//   default:
//     Console.WriteLine("No es una operación válida");
//     break;
// }




/*************************************************************** Ejemplos ERRORES EN CICLOS WHILE*/
// byte numero = 1;

// while (numero <= 100)
// {
//   Console.WriteLine(numero);
//   numero++;
// }

/*Error 1 - Eliminar las llaves... tomaría como sentencia propia del while, son el Console.WriteLine, sin incrementarle la unidad. Por lo que "numero" siempre sería 1, y 1 siempre menor a 100, por lo que no saldría nunca del ciclo
Error 2 - reemplazar el 100, por un número superior al 255 (el límite de los tipo byte), dado que luego del 255, volvería al 1, nunca llegaría a superar el 256, por lo que se ejecutaría por siempre*/



/*************************************************************** Ejercicios WHILE Laboratorio Ej. 4
Imprimir los números del 1 a 10 sin imprimir los números 2,5 y 9 uno abajo del otro*/

// byte number = 1;

// while (number <= 10)
// {
//   if (number != 2 && number != 5 && number != 9)
//     Console.WriteLine(number);

//   number++;
// }



/*************************************************************** Ejercicios WHILE Laboratorio Ej. 5
Imprimir los números del 1 a 30 sin imprimir los números entre el 10 y el 20 uno abajo del otro*/

// byte number = 1;

// while (number <= 30)
// {
//   if (number < 10)
//     Console.WriteLine(number);
//   if (number > 20)
//     Console.WriteLine(number);

//   number++;
// }




/*************************************************************** Ejercicios WHILE Laboratorio Ej. 6
Imprimir la suma de los números del 1 a 10*/

// short number = 1, suma = 0; // OJO con los límites de los tipos de datos.. acá el short es por la variable suma que llega a 11325

// while (number <= 150)
// {

//   suma += number++;
// }

// Console.WriteLine(suma);




/*************************************************************** Ejercicios WHILE Laboratorio Ej. 7
Imprimir la suma de los números pares del 1 a 25*/

// byte numero = 1;  // Esta forma me parece mejor, así no se deja reservada más memoria para numero, de la que hace falta
// short sumaPares = 0;

// while (numero <= 25)
// {
//   if (numero % 2 == 0)
//     sumaPares += numero;

//   numero++;
// }
// Console.WriteLine(sumaPares);



/*************************************************************** Ejercicios Laboratorio Adicional 4 - Ej. 1
Imprimir los nros del 1 al 10 acorde al diagrama de flujo*/

// byte numero = 1;

// while (numero <= 10)
// {
//   Console.WriteLine(numero);
//   numero++;
// }


/*************************************************************** Ejercicios Laboratorio Adicional 4 - Ej. 2
Imprimir los nros del 1 al 10, salteando de a 2, acorde al diagrama de flujo*/

// int numero = 1;

// while (numero <= 10)
// {
//   numero = numero + 2;
//   Console.WriteLine(numero);
// }



/*************************************************************** Ejercicios Laboratorio Adicional 4 - Ej. 3
Imprimir los nros del 10 al 1, uno debajo del otro, acorde al diagrama de flujo*/

// byte numero = 10;

// while ( numero >= 1)
// {
//   Console.WriteLine(numero);
//   numero--;
// }



/*************************************************************** Ejercicios Laboratorio Adicional 4 - Ej. 4
Imprimir los nros del 1 al 10, sin imprimir 2,5,9, acorde al diagrama de flujo*/

// byte numero = 1;

// while (numero <= 10)
// {
//   if (numero != 2 && numero != 5 && numero != 9)
//   {
//     Console.WriteLine(numero);
//   }
//   numero++;
// }




/*************************************************************** Ejercicios Laboratorio Adicional 4 - Ej. 5
Imprimir los nros del 1 al 30, sin imprimir los nros entre 10 y 20, uno debajo del otro, acorde al diagrama de flujo*/

// byte numero = 1;

// while (numero <= 30)
// {
//   if (numero <= 10 || numero >= 20)
//   {
//     Console.WriteLine(numero);
//   }
//   numero++;
// }



/*************************************************************** Ejercicios Laboratorio Adicional 4 - Ej. 6
Imprimir la suma de los nros pares del 1 al 10, acorde al diagrama de flujo*/

// byte numero = 1;
// short suma = 0;

// while (numero <= 10)
// {
//   suma += numero; 
//   numero++;
// }

// Console.WriteLine(" Suma = {0}", suma);



/*************************************************************** Ejercicios Laboratorio Adicional 4 - Ej. 7
Imprimir la suma de los nros pares del 1 al 25, acorde al diagrama de flujo*/

// byte numero = 1;
// short suma = 0;

// while (numero <= 25)
// {
//   if (numero % 2 == 0)
//   { suma += numero; }

//   numero++;
// }

// Console.WriteLine(" Suma = {0}", suma);



/*************************************************************** Ejercicios Laboratorio Adicional 4 - Ej. 8
Imprimir la multiplicaciopn de los números impares que se encuentran entre -10 y 10, uno debajo del otro, acorde al diagrama de flujo*/

int producto = 1, numero = -10;

while (numero <= 10)
{
  //Console.WriteLine(numero);
  if (numero % 3 == 0 && numero != 0)
  {
    producto *= numero;
  }
  numero++;
}

Console.WriteLine(producto);


