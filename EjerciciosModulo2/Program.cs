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