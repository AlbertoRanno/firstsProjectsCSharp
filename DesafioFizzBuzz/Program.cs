/*FizzBuzz es un conocido desafío de codificación y un tema que se suele plantear en las entrevistas. Sirve para conocer su dominio de la lógica básica, así como su comprensión de las instrucciones for e if, y del operador de resto %.

Implemente cada una de las reglas de FizzBuzz:

Valores de salida entre 1 y 100; un número por línea.
Si el valor actual es divisible por 3, se imprime el término Fizz junto al número.
Si el valor actual es divisible por 5, se imprime el término Buzz junto al número.
Si el valor actual es divisible por 3 y por 5, se imprime el término FizzBuzz junto al número.
 
 Importante
Deberá saber cómo se usa el operador de resto % para determinar si un número es divisible de manera exacta por otro número.

Independientemente de cómo lo haga, el código debe generar el siguiente resultado. Solo mostraremos los primeros 22 valores, pero la salida debe continuar hasta 100.

Resultado

1
2
3 - Fizz
4
5 - Buzz
6 - Fizz
7
8
9 - Fizz
10 - Buzz
11
12 - Fizz
13
14
15 - FizzBuzz
16
17
18 - Fizz
19
20 - Buzz
21 - Fizz
22
.
.
.
Como puede ver, el número 15 es divisible por 3 y 5, por lo que se imprime FizzBuzz junto al número.

*/

for (int i = 1; i <= 100; i++)
{
  if (i % 3 == 0 && i % 5 == 0)
    Console.WriteLine($"{i} - FizzBuzz");
  else if (i % 3 == 0)
    Console.WriteLine($"{i} - Fizz");
  else if (i % 5 == 0)
    Console.WriteLine($"{i} - Buzz");
  else
    Console.WriteLine($"{i}");
}