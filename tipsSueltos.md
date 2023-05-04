**** Otra forma de impresión en pantalla de un valor dentro de un string:

byte x = 10, y = 5;

Console.WriteLine( "Valor de x: {0} valor de y: {1}, x, y );
{0} indica que se reemplace por el valor de la primer variable luego de la coma
{1} indica que se reemplace por el valor de la variable siguiente

****  
la expresión c = a = b asigna a las variables c y a el valor de b (el operador = es asociativo por la derecha).

****
 Aparte del operador de asignación compuesto +=, también se ofrecen operadores de asignación compuestos para la mayoría de los operadores binarios ya vistos. Estos son: +=, -=, *=, /=, %=, &=, |=, ^=, <<= y >>=. 
Nótese que no hay versiones compuestas para los operadores binarios && y ||.

**** 
c = b++; // Se asigna a c el valor de b y luego se incrementa b
c = ++b; // Se incrementa el valor de b y luego se asigna a c