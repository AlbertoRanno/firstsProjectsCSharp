/*Se usará el método Random.Next() para simular el lanzamiento de tres dados de seis caras. Evaluaremos los valores para calcular la puntuación. Si la puntuación es mayor que un total arbitrario, el usuario verá un mensaje de que ha ganado. En caso contrario, el usuario verá un mensaje de que ha perdido.

Si dos dados cualesquiera muestran el mismo valor, se obtienen dos puntos extra por obtener un doble.
Si los tres dados muestran el mismo valor, se obtienen seis puntos extra por obtener un triple.
Si el jugador obtiene una puntuación igual o mayor que 16, gana un coche nuevo.
Si el jugador obtiene una puntuación igual o mayor que 10, gana un portátil nuevo.
Si el jugador obtiene una puntuación de 7, gana un viaje.
De lo contrario, el jugador gana un gatito.*/

Random dice = new Random(); // Creo una nueva instancia de la clase System.Random (un objeto) y almaceno ese objeto en la variable "dice"

int roll1 = dice.Next(1,7); //llamo al método Random.Next() en el objeto dice, 3 veces
int roll2 = dice.Next(1,7); //restringiendo los limites en cada caso
int roll3 = dice.Next(1,7); //y guardando cada valor en una variable

//Para probar los condicionales:
//  roll1 = 1; 
//  roll2 = 1;
//  roll3 = 1;

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total} ");



if((roll1 == roll2) || (roll2 == roll3) || (roll3 == roll1))
{
  if((roll1 == roll2) && (roll2 == roll3))
  {
  Console.WriteLine("You rolled triples! + 6 bonues to total!");
  total +=6;
  }
  else
  {
  Console.WriteLine("You rolled doubles! + 2 bonues to total!");
  total +=2;
  } 
}

if (total >= 16) //En tiempo de ejecución, se evalúa la expresión booleana "total > 14", si es true, se ejecuta el código entre {}, o, mejor dicho, el bloque de código
{
  Console.WriteLine("You win a new car!"); //Un bloque de código es una colección de una o varias líneas de código delimitadas por un símbolo de llave de apertura y otro de cierre { }. Los bloques de código son fundamentales para comprender la organización y la estructura del código, y definen los límites del ámbito de la variable. 
} 
else if (total >= 10)
{
  Console.WriteLine("You win a new laptop!");
}
else if (total >= 7)
{
  Console.WriteLine("You win a trip for two!");
}
else {
  Console.WriteLine("You win a kitten!");
}


