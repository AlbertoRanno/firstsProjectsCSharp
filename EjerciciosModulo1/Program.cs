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
n3 = n1 ^ n2; //El operador "XOR" ("^"),actua como un "OR exclusivo": devuelve true, si y solo si,uno de los valores es True y el otro false. De lo contrario, devuelve false. 
n4 = n1 ^ !n2;
Console.WriteLine($"\"E\"\t{n1}\t\t\t{n2}\t\t\t{n3}\t\t\t{n4}");
Console.WriteLine("Presione una tecla para continuar");
Console.ReadLine();