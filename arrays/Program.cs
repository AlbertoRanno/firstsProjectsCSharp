/*************************************** ARRAYS
Hasta ahora siempre había que saber con antelación el número de variables que el programa iba a necesitar.
Sin embargo, habrá situaciones en las que no sea posible determinar este número hasta que el programa no se esté ejecutando. Pues bien, para solucionar estas dificultades contamos con las estructuras de arreglos, arrays en inglés. 

/*************************************** Arreglos de una dimensión
Un array es una variable que es capaz de almacenar varios valores en forma simultánea.
Cada uno de estos valores se identifica mediante un número que se denomina “índice”.
Para acceder al primer elemento del array se usa el índice cero, para el segundo el índice uno, para el tercero el índice dos, y así sucesivamente. 

Al arreglo se lo declara de la siguiente forma: tipo[] variable;

Es muy parecido a cómo se declara una variable normal, sólo que hay que poner corchetes detrás del tipo de dato.

!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!IMPORTANTE!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!

En C# los arrays son objetos derivados de la clase System.Array. Por lo tanto, y esto es muy importante, cuando declaramos un array en C# este aún no se habrá creado en la memoria de la computadora, en consecuencia, antes de poder usarlos habrá que instanciarlos, como si fuera cualquier otro objeto.

Veamos un breve ejemplo:
string[] nombres; // Declaración del array
nombres = new string[3]; // Instanciación del array

En efecto, el array nombres será utilizable únicamente a partir de su instanciación, y podrá tener un máximo de tres elementos, accedidos desde los índices 0, 1 y 2.
Nótese que índice del array comienza de CERO (0) y NO de uno (1), por lo cual el índice del último elemento es siempre el TotalDeElementos menos uno (3-1=2)

/*************************************** Operaciones de recorrida de arreglos
************IMPORTANTE************ Un array es un conjunto de objetos, ordenado y de tamaño fijo. En los lenguajes fuertemente tipados, una vez almacenado en memoria, su tamaño, no puede cambiar! (a diferencia de JS). Y los datos tienen que ser del mismo tipo!
Para acceder a cualquier elemento de este conjunto se aplica el operador postfijo [] sobre la tabla para indicar entre corchetes 
la posición que ocupa el objeto al que se desea acceder dentro del conjunto. 

Es decir, este operador se usa así: [<posiciónElemento>]

Un ejemplo de su uso, en el que se asigna al elemento que ocupa la posición 3 en una tabla de nombre arrayPrueba, el valor del elemento que ocupa la posición 18 de dicha tabla es el siguiente: 

arrayPrueba[3] = arrayPrueba[18];

Ejemplo de recorrer un array dado, en sentido inverso:*/
// int[] losValores = { 25, 10, 15, 5 };

// for (int indice = (losValores.Length-1); indice >= 0 ; indice--)
// {
//   Console.WriteLine(losValores[indice]);
// }

//Búsqueda de Máximo y Mínimo:
// int maximo = losValores[0], minimo = losValores[0];
// // Recorremos desde la posición 1, ya que el valor de la posición 0 se asignó a maximo y a minimo
// for (int a = 1; a < losValores.Length; a++)
// {
//   if (losValores[a] > maximo)
//   {
//     maximo = losValores[a];
//   }
//   if (losValores[a] < minimo)
//   {
//     minimo = losValores[a];
//   }
// }
// Console.WriteLine("El valor máximo es : " + maximo);
// Console.WriteLine("El valor mínimo es : " + minimo);

//Contar cuántas veces aparece el número 10
// int contador = 0;
// for (int a = 0; a < losValores.Length; a++)
// {
//   if (losValores[a] == 10)
//   {
//     contador++;
//   }
// }
// Console.WriteLine("El numero 10 aparece: " + contador + " veces.");

//Totalizar el contenido de un arreglo numérico y calcular el promedio
// int suma = 0;
// for (int a = 0; a < losValores.Length; a++)
// {
//   suma += losValores[a];
// }
// Console.WriteLine("La suma total es: " + suma);
// Console.WriteLine("El promedio es: " + suma / losValores.Length);

/* Ejercicio 1
Dado el arreglo {10,20,5,15,30,20}
1. Informar el arreglo de la forma: "Indice: X, Valor: Y"
2. Sumar el los valores de los elementos del arreglo
e informar el total.
3. Informar el contenido de las posiciones impares (por
ejemplo, las posiciones 1, 3, 5, etc).
4. Informar el número mayor número.
5. Informar cuántas veces aparece el número 20.*/

// byte[] Valores = { 10, 20, 5, 15, 30, 20 };
// byte Suma = 0, ElMayor = Valores[0], CuantasVeces = 0;

// for (int indice = 0; indice < Valores.Length; indice++)
// {
//   Console.WriteLine($"1- Indice: {indice}, Valor: {Valores[indice]}");
//   Suma += Valores[indice];
// }
// Console.WriteLine($"2- Suma de los elementos: {Suma}");

// for (int indice = 0; indice < Valores.Length; indice++)
// {
//   if (indice % 2 != 0)
//   {
//     Console.WriteLine($"3- Indice: {indice}, Valor: {Valores[indice]}");
//   }
//   if (Valores[indice] == 20)
//   {
//     CuantasVeces++;
//   }
// }

// for (int indice = 1; indice < Valores.Length; indice++)
// {
//   if (Valores[indice] > ElMayor)
//   {
//     ElMayor = Valores[indice];
//   }
// }
// Console.WriteLine($"4- El mayor es {ElMayor}");
// Console.WriteLine($"5- El 20 aparece {CuantasVeces} veces");

/* Ejercicio 2
Dado el arreglo inflación {0.8, 0.1, 0.3, 0.4,0.3, 0.6, 0.5, 0.3, 0.7, 0.3, 0.2, 0.9}
Donde cada ítem del arreglo representa la inflación de un mes, de tal manera que el primer ítem del arreglo que es 0.8 representa la inflación de Enero, y el último ítem del arreglo que es 0.9 representa la inflación de diciembre.

Se pide:
1. Informar la inflación anual (sumatoria).
2. Informar la inflación más baja, junto con el número de mes. Por ejemplo: Mes 2 = 0.1
3. Informar la inflación más alta, junto con el número de mes. Por ejemplo: Mes 12 = 0.9
4. Informar el promedio de inflación (inflación total / 12).
*/

/* Ejercicio 3
Agregar los cambios que resulten necesarios al ejercicio anterior para que en los puntos 2 y 3 se informe la inflación junto con el nombre del mes. */

// string[] Meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
// string NombreMesBaja = "", NombreMesAlta = "";


// float[] inflacion = { 0.8f, 0.1f, 0.3f, 0.4f, 0.3f, 0.6f, 0.5f, 0.3f, 0.7f, 0.3f, 0.2f, 0.9f };
// float Suma = 0.0f, LaMasBaja = inflacion[0], LaMasAlta = inflacion[0];
// int MesBaja = 0, MesAlta = 0;

// for (byte i = 0; i < inflacion.Length; i++)
// {
//   Suma += inflacion[i];
// }
// Console.WriteLine($"inflación anual de {Suma} ");


// for (int i = 0; i < inflacion.Length; i++)
// {
//   if (LaMasBaja > inflacion[i])
//   {
//     LaMasBaja = inflacion[i];
//     MesBaja = i + 1; //DUDA!!!!!!!!!! si i es byte, no suma?
//     NombreMesBaja = Meses[i];
//   }
//   if (LaMasAlta < inflacion[i])
//   {
//     LaMasAlta = inflacion[i];
//     MesAlta = i + 1;
//     NombreMesAlta = Meses[i];
//   }

// }
// Console.WriteLine($"la inflación más baja se dió en el mes de {NombreMesBaja} ({MesBaja}), y fue de {LaMasBaja}");
// Console.WriteLine($"la inflación más alta se dió en el mes de {NombreMesAlta} ({MesAlta}), y fue de {LaMasAlta}");
// Console.WriteLine($"el promedio de la inflación es de {Suma / 12}");

/* Ejercicio Desafío 1
Una persona desea invertir $1000 en un banco, el cual le otorga un 2% de interés mensual.
¿Cuál será la cantidad de dinero que esta persona tendrá al cabo de un año?.
En el primer mes tendrá acumulado $1000 más $20 de interés ( 2% de 1000 ). En el segundo mes se le sumará un 2% a la base de $1020 del mes anterior y así sucesivamente. */

// float Dinero = 1000;
// string[] Meses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio", "Julio", "Agosto", "Septiembre", "Octubre", "Noviembre", "Diciembre" };
//  string Mes = "";


// for (int mes = 1; mes <= 12; mes++)
// {
//   Dinero *= 1.02f;
// }
// Console.WriteLine($"Dinero después de un año: {Dinero}");

/*
Una persona desea invertir $1000 en un banco, el cual le otorga un 3% de interés mensual.
¿En cuantos meses conseguirá $1200, si reinvierte cada mes todo su dinero?. */

// for (int mes = 1; mes <= 12; mes++)
// {
//   Dinero *= 1.03f;
//   if (Dinero >= 1200)
//   {
//     Mes = Meses[mes-1];
//   }
// }
// Console.WriteLine($"El mes que alcanza los $1200 es {Mes}");

/* Ejercicio Desafío 3
Desarrollar el código que permita a una persona ingresar como máximo tres veces su contraseña.
● En caso de ingreso correcto deberá exhibirse la leyenda “Bienvenido!!”, caso contrario se mostrará “tres veces fallidas”.
● Indicar cuantas posibilidades de ingresar el código le queda. Por ejemplo, si tiene 2 posibilidades, informar "Tiene dos chances !" y si le queda una última oportunidad "Atención!! Ultima oportunidad!" */

string? ReadResult = "";
string Password = "1234";
int intentos = 0;

Console.Clear();

do
{
  Console.WriteLine("Por favor ingrese su password para continuar: \r");
  ReadResult = Console.ReadLine();
  if (ReadResult != null)
    Password = ReadResult;

  if (Password == "1234")
  {
    Console.WriteLine("¡Bienvenido!!");
    break;
  }
  
  intentos++;

  switch (intentos)
  {
    case 1:
      Console.WriteLine($"Password inválido. Tiene {3 - intentos} chances!");
      break;
    case 2:
      Console.WriteLine($"Password inválido. Atención!! Última oportunidad!!");
      break;
    default:
      Console.WriteLine($"Password inválido. Tres veces fallidas. \nSu usuario ha sido bloqueado");
      break;
  }

} while (Password != "1234" && intentos != 3);







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
// string[] fraudulentOrdersIDs = { "A123", "B456", "C789"};

// Console.WriteLine($"First: {fraudulentOrdersIDs[0]}");
// Console.WriteLine($"Second: {fraudulentOrdersIDs[1]}");
// Console.WriteLine($"Third: {fraudulentOrdersIDs[2]}");

// fraudulentOrdersIDs[0] = "FOOO";

// Console.WriteLine($"Reassign First: {fraudulentOrdersIDs[0]}");

// Console.WriteLine($"There are {fraudulentOrdersIDs.Length} fraudulent orders to process.");


/*FOREACH

*Use la instrucción foreach para recorrer en iteración cada elemento de una matriz y ejecutar el bloque de código asociado una vez por cada elemento de la matriz.
*La instrucción foreach establece el valor del elemento actual de la matriz en una variable temporal, la cual se puede usar en el cuerpo del bloque de código.
*Use el operador de incremento ++ para sumar 1 al valor actual de una variable.*/

// string[] nombres = { "Bob", "Conrad", "Grant"};

// foreach (string nombre in nombres)
// {
//     Console.WriteLine(nombre);
// }

// int[] inventory = { 200, 450, 700, 175, 250};

// int sum = 0;
// int bin = 0;

// foreach (int items in inventory)
// {
//     sum += items;
//     bin++;
//     Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
// }

// Console.WriteLine($"We have {sum} items in inventory.");

// // ejemplo de cómo usar el método String.StartsWith():
// string name = "Bob";
// if (name.StartsWith("B"))
// {
//     Console.WriteLine("The name starts with 'B'!");
// }
