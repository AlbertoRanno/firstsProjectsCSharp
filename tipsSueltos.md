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

****
En que ámbito defino las variables?
Defina siempre el ámbito de las variables de la forma más estrecha posible. Esto permite una mejor administraciòn de los recursos y ayuda a minimizare el perfil de ataque de la aplicación.

 El ámbito más grande le permitiría acceder a ella desde cualquier lugar de la aplicación. Por lo tanto, ¿por qué no definir el ámbito de las variables en el nivel de aplicación cuando cree que se podrían usar más adelante en la aplicación? El ámbito de las variables en un nivel superior al necesario puede provocar problemas. El ámbito con privilegios elevados aumenta los requisitos de recursos de la aplicación y puede exponer la aplicación a riesgos de seguridad innecesarios. A medida que las aplicaciones aumentan de tamaño y son más complejas, requieren más recursos. Los teléfonos y equipos asignan memoria para estos recursos cuando están en el ámbito. A medida que las aplicaciones pasan a ser más "reales", se vuelven más accesibles. Las aplicaciones suelen ser accesibles desde la nube u otras aplicaciones. Al agravar estos problemas, las aplicaciones se suelen dejar en ejecución cuando no se usan. Es importante mantener los requisitos de recursos de una aplicación bajo control y la superficie de seguridad lo más reducida posible. Aunque los sistemas operativos actuales realizan un gran trabajo de administración de recursos y de protección de aplicaciones, sigue siendo recomendable mantener las variables en el ámbito del nivel en el que realmente se necesitan. 

****