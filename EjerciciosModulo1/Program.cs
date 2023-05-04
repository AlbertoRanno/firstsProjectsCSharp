/*
string? Nombre; // Declaración de la variable Nombre, de tipo string
Console.WriteLine("¿ Cómo se llama el cliente ?");
//Captura del valor ingresado y asignación de ese valor a variable Nombre,
//a través de Console.ReadLine();
Nombre = Console.ReadLine();
//Mostrar en la posición 0 la variable Nombre
Console.WriteLine("El cliente se llama {0}", Nombre);
Console.ReadKey();


const double PI = 3.1415926; // Declaración de constante PI, de tipo double
double Radio = 4; //Declaración e inicialización de constante Radio, de tipo double
Console.WriteLine("El perímetro de una circunferencia de radio {0} es {1}", Radio, 2 * PI * Radio);
Console.WriteLine("El área de un círculo de radio {0} es {1}", Radio, PI * Math.Pow(Radio, 2));
Console.ReadKey();
*/


/*En cada ejercicio deberás analizar el código C# y completar la tabla correspondiente según el valor de la variable x y de la variable y.
Luego realiza la codificación para confirmar que has completado la tabla correctamente. */

/* Ejercicio 1
Asignación básica: en este primer ejercicio, completamos las partes A y B, para que comprendas cómo continuar las demás partes.
Ejercicio 1
      x       y
A    10      20
B    15      30
C    10      20
D    30      100
E    15      25
*/

/*
Console.WriteLine("Ejercicio 1 - Asignación básica\n");

Console.WriteLine("\tX\t\t\tY");
int x = 10;
int y = 20;
Console.WriteLine($"\"A\"\t{x}\t\t\t{y}");
x = x + 5;
y = y + 10;
Console.WriteLine($"\"B\"\t{x}\t\t\t{y}");
x = x - 5;
y = y - 10;
Console.WriteLine($"\"C\"\t{x}\t\t\t{y}");
x = x * 3;
y = y * 5;
Console.WriteLine($"\"D\"\t{x}\t\t\t{y}");
x = x / 2;
y = y / 4;
Console.WriteLine($"\"E\"\t{x}\t\t\t{y}");
Console.WriteLine("Presione una tecla para continuar");
Console.ReadLine();
*/


/* Ejercicio 2
Asignación compacta
      x       y
A    10       20
B    15       5
C    16       4   
D    64       -12
E    32       -3
*/

/*
Console.WriteLine("Ejercicio 2 - Asignación compacta\n");
Console.WriteLine("\tX\t\t\tY");
int x = 10;
int y = 20;
Console.WriteLine($"\"A\"\t{x}\t\t\t{y}");
x += 5;
y -= 15;
Console.WriteLine($"\"B\"\t{x}\t\t\t{y}");
x++;
y--;
Console.WriteLine($"\"C\"\t{x}\t\t\t{y}");
x *= 4;
y *= -3;
Console.WriteLine($"\"D\"\t{x}\t\t\t{y}");
x /= 2;
y /= 4;
Console.WriteLine($"\"E\"\t{x}\t\t\t{y}");
Console.WriteLine("Presione una tecla para continuar");
Console.ReadLine();
*/

/* Ejercicio Laboratorio Adicional 1
Operadores aritméticos: en este primer ejercicio, completamos las partes A y B, para que comprendas cómo continuar las demás partes.
      x       y
A    10       20
B    30       50
C    -20      70        
D    -1400    1960000 
E    -1400    0 
*/

/*
Console.WriteLine("Ejercicio 1 - Operadores aritméticos");
Console.WriteLine("\tX\t\t\tY");
int x = 10;
int y = 20;
Console.WriteLine($"\"A\"\t{x}\t\t\t{y}");
x = x + y;
y = y + x;
Console.WriteLine($"\"B\"\t{x}\t\t\t{y}");
x = x - y;
y = y - x;
Console.WriteLine($"\"C\"\t{x}\t\t\t{y}");
x = x * y;
y = x * x;
Console.WriteLine($"\"D\"\t{x}\t\t\t{y}");
x = y / x;
y = x / y;
Console.WriteLine($"\"E\"\t{x}\t\t\t{y}");
Console.WriteLine("Presione una tecla para continuar");
Console.ReadLine();
*/

/* Ejercicio Laboratorio Adicional 2
Operadores aritméticos con asignación compacta
      x       y
A     5       10    
B     15      25    
C     -10     35  
D     -350    -12250    
E     0       1    
*/
/*
Console.WriteLine("Ejercicio 2 - Operadores aritméticos con asignación compacta");
Console.WriteLine("\tX\t\t\tY");
int x = 5;
int y = 10;
Console.WriteLine($"\"A\"\t{x}\t\t\t{y}");
x += y;
y += x;
Console.WriteLine($"\"B\"\t{x}\t\t\t{y}");
x -= y;
y -= x;
Console.WriteLine($"\"C\"\t{x}\t\t\t{y}");
x *= y;
y *= x;
Console.WriteLine($"\"D\"\t{x}\t\t\t{y}");
x /= y;
y /= y;
Console.WriteLine($"\"E\"\t{x}\t\t\t{y}");
Console.WriteLine("Presione una tecla para continuar");
Console.ReadLine();
*/


/* Ejercicio Laboratorio Adicional 3
Operadores Aritméticos con asignación múltiple
(suma y resta)

      x           y           suma        resta
A     5           10          0           0         
B                             15          -5          
C                             10          0     
D                             20          -20
E                             20          -25
*/

/*
Console.WriteLine("Ejercicio 3-Operadores Aritméticos con asignación múltiple(suma y resta)");
Console.WriteLine("\tX\t\t\tY\t\t\tsuma\t\t\tresta");
int x = 5;
int y = 10;
int suma = 0;
int resta = 0;
Console.WriteLine($"\"A\"\t{x}\t\t\t{y}\t\t\t{suma}\t\t\t{resta}");
suma = x + y;
resta = x - y;
Console.WriteLine($"\"B\"\t{x}\t\t\t{y}\t\t\t{suma}\t\t\t{resta}");
suma = x + x;
resta = y - y;
Console.WriteLine($"\"C\"\t{x}\t\t\t{y}\t\t\t{suma}\t\t\t{resta}");
suma = x + y + x;
resta = x - x - 20;
Console.WriteLine($"\"D\"\t{x}\t\t\t{y}\t\t\t{suma}\t\t\t{resta}");
suma = y + x + x;
resta = -x - y - y;
Console.WriteLine($"\"E\"\t{x}\t\t\t{y}\t\t\t{suma}\t\t\t{resta}");
Console.WriteLine("Presione una tecla para continuar");
Console.ReadLine();
*/


/* Ejercicio Laboratorio Adicional 4
Operadores Aritméticos con asignación múltiple
(producto y división)


      x           y           multi        division
A     5           10          1           1                 
B                             50          0         
C                             25          1                 
D                             250         2
E                             -50         -2
*/

/*
Console.WriteLine("4-Operadores Aritméticos con asignación múltiple(producto y división)");
Console.WriteLine("\tX\t\t\tY\t\t\tmulti\t\t\tdivision");
int x = 5;
int y = 10;
int multi = 1;
int division = 1;
Console.WriteLine($"\"A\"\t{x}\t\t\t{y}\t\t\t{multi}\t\t\t{division}");
multi = x * y;
division = x / y;
Console.WriteLine($"\"B\"\t{x}\t\t\t{y}\t\t\t{multi}\t\t\t{division}");
multi = x * x;
division = y / y;
Console.WriteLine($"\"C\"\t{x}\t\t\t{y}\t\t\t{multi}\t\t\t{division}");
multi = x * y * x;
division = y / x;
Console.WriteLine($"\"D\"\t{x}\t\t\t{y}\t\t\t{multi}\t\t\t{division}");
multi = x * (-y);
division = y / (-x);
Console.WriteLine($"\"E\"\t{x}\t\t\t{y}\t\t\t{multi}\t\t\t{division}");
Console.WriteLine("Presione una tecla para continuar");
Console.ReadLine();
*/


/* Ejercicio Laboratorio Adicional 5
Operador Resto
      n1           n2         n3
A     20          2           2                                          
B     15          2           1                                     
C     3           20          2                                         
D     3           15          0                        
                             
*/
/*
Console.WriteLine("Ejercicio 5 - Operador Resto)");
Console.WriteLine("\tn1\t\t\tn2\t\t\tn3");
int n1 = 20;
int n2 = 2;
int n3 = n2 % n1;  
//2 dividido 20, da, entero 0, restan 2. Y luego, decimales, bajo el cero, y recién ahí serían los 20 / 20, para el 1, de "2 / 20 = 0.1"
Console.WriteLine($"\"A\"\t{n1}\t\t\t{n2}\t\t\t{n3}");
n1 = 15;
n2 = 2;
n3 = n1 % n2;
Console.WriteLine($"\"B\"\t{n1}\t\t\t{n2}\t\t\t{n3}");
n1 = 3;
n2 = 20;
n3 = n2 % n1;
Console.WriteLine($"\"C\"\t{n1}\t\t\t{n2}\t\t\t{n3}");
n1 = 3;
n2 = 15;
n3 = n2 % n1;
Console.WriteLine($"\"D\"\t{n1}\t\t\t{n2}\t\t\t{n3}");
Console.WriteLine("Presione una tecla para continuar");
Console.ReadLine();
*/


/* Ejercicio Laboratorio Adicional 6
Cadenas de Caracteres
      palabra1           palabra2         frase
A     "Hola"            "Mundo"           ""                                               
B                                         "HolaMundo" 
C                                         "Hola        Mundo"     
D                                         "Hola
                                           Mundo"      
E                                         "Hola
                                                Mundo"
*/

/*
Console.WriteLine("Ejercicio 6 - Cadenas de Caracteres");
Console.WriteLine("\tpalabra_1\t\tpalabra_2\t\tfrase");
String palabra_1 = "Hola";
String palabra_2 = "Mundo";
String frase = "";
Console.WriteLine($"\"A\"\t{palabra_1}\t\t\t{palabra_2}\t\t\t{frase}");
frase = palabra_1 + palabra_2;
Console.WriteLine($"\"B\"\t{palabra_1}\t\t\t{palabra_2}\t\t\t{frase}");
frase = palabra_1 + " \t " + palabra_2;
Console.WriteLine($"\"C\"\t{palabra_1}\t\t\t{palabra_2}\t\t\t{frase}");
frase = palabra_1 + " \n " + palabra_2;
Console.WriteLine($"\"D\"\t{palabra_1}\t\t\t{palabra_2}\t\t\t{frase}");
frase = palabra_1 + " \n \t " + palabra_2;
Console.WriteLine($"\"E\"\t{palabra_1}\t\t\t{palabra_2}\t\t\t{frase}");
Console.WriteLine("Presione una tecla para continuar");
Console.ReadLine();
*/


/* Ejercicio Laboratorio Adicional 7
Operadores Lógicos
      n1          n2          n3          n4
A     true        false       false       true                                            
B                             false       true
C                             true        false
D                             false       false
E                             true        false
       
*/

/*
Console.WriteLine("Ejercicio 7 - Operadores Lógicos");
Console.WriteLine("\tn1\t\t\tn2\t\t\tn3\t\t\tn4");
bool n1 = true;
bool n2 = false;
bool n3 = !n1;
bool n4 = !n2;
Console.WriteLine($"\"A\"\t{n1}\t\t\t{n2}\t\t\t{n3}\t\t\t{n4}");
n3 = n1 & n2;
n4 = n1 | n2;
Console.WriteLine($"\"B\"\t{n1}\t\t\t{n2}\t\t\t{n3}\t\t\t{n4}");
n3 = !(n1 & n2);
n4 = !(n1 | n2);
Console.WriteLine($"\"C\"\t{n1}\t\t\t{n2}\t\t\t{n3}\t\t\t{n4}");
n3 = !n1 & n2;
n4 = !n1 | n2;
Console.WriteLine($"\"D\"\t{n1}\t\t\t{n2}\t\t\t{n3}\t\t\t{n4}");
n3 = n1 ^ n2; // ALT + 94 = ^ "XOR"
n4 = n1 ^ !n2;
Console.WriteLine($"\"E\"\t{n1}\t\t\t{n2}\t\t\t{n3}\t\t\t{n4}");
Console.WriteLine("Presione una tecla para continuar");
Console.ReadLine();
*/

/*
Ejercicio Adicional Laboratorio - Operadores 1

Dados n1=5, n2=10 y n3=20. Informar:
a) n1+n2
b) n3-n1
c) n1*n3
d) n3/n2
*/

/*
byte n1 = 5, n2 = 10, n3 = 20;
Console.WriteLine($"n1+n2= {n1 + n2}\nn3-n1= {n3 - n1}\nn1*n3= {n1 * n3}\nn3/n2= {n3 / n2}");
*/

/*
Ejercicio Adicional Laboratorio - Operadores 2

Dados n1=10, n2=20 y n3=30. Informar:
a) El total.
b) El promedio.
c) El resto entre n2 y n1.
*/

/*
byte n1 = 10, n2 = 20, n3 = 30;
Console.WriteLine($"Total = {n1 + n2 + n3}\nPromedio = {(n1+n2+n3)/3}\nResto entre n2 y n1 = { n2 % n1}");
*/

/* EJERCICIOS DESAFÍO
Ejercicio 1
Dadas las variables n1=true, n2=false y n3=true.
Informar:
a. n1 ^ n2
b. (n1 & !n2) | n3
c. (n1 | n2) & !n3
*/

/*
bool n1 = true, n2 = false, n3 = true;
Console.WriteLine("Ejercicio 1");
Console.WriteLine($"n1 ^ n2 = {n1 ^ n2}\n(n1 & !n2) | n3 = {(n1 & !n2) | n3}\n(n1 | n2) & !n3 = {(n1 | n2) & !n3}");
Console.WriteLine("Presione una tecla para continuar");
Console.ReadLine();
*/

/*
Ejercicio 2
Declarar dos variables n1=5 y n2=10.
Utilizando concatenación entre las variables y los literales, mostrar en pantalla la siguiente expresión:
n1 es igual a 5, n2 es igual a 10 y n1 más n2 es igual a 15.
*/

/*
byte n1 = 5, n2 = 10;
Console.WriteLine("Ejercicio 2");
Console.WriteLine("n1 es igual a " + n1 + ", n2 es igual a " + n2 + " y n1 más n2 es igual a " + (n1 + n2) );
Console.WriteLine("Presione una tecla para continuar");
Console.ReadLine();
*/

/*
Ejercicio 3
Haciendo uso de la constante IVA=21, que representa el porcentaje de IVA a aplicar a los siguientes productos, cuyo precio sin IVA se indica en la siguiente lista:
● Remera: $59.90.
● Pantalón: $99.90.
● Campera: $149.90.
Informar los precios con IVA de cada uno
*/

const int IVA= 21;

decimal precioSinIVARemera = 59.90m, precioSinIVAPantalon = 99.90m, precioSinIVACampera = 149.90m;
decimal precioFinalRemera = precioSinIVARemera * (100 + IVA) / 100;
decimal precioFinalPantalon = precioSinIVAPantalon * (100 + IVA) / 100;
double precioFinalCampera = (double)precioSinIVACampera * (100 + IVA) / 100;

Console.WriteLine("Ejercicio 3 - Uso de constantes\n");
Console.WriteLine($"Precio final Remera: \t${precioFinalRemera}");
Console.WriteLine($"Precio final Pantalón: \t${precioFinalPantalon}");
Console.WriteLine($"Precio final Campera: \t${precioFinalCampera}\n");
Console.WriteLine("Presione una tecla para continuar");
Console.ReadLine();