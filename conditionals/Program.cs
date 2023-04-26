/*Se usará el método Random.Next() para simular el lanzamiento de tres dados de seis caras. Evaluaremos los valores para calcular la puntuación. Si la puntuación es mayor que un total arbitrario, el usuario verá un mensaje de que ha ganado. En caso contrario, el usuario verá un mensaje de que ha perdido.

Si dos dados cualesquiera muestran el mismo valor, se obtienen dos puntos extra por obtener un doble.
Si los tres dados muestran el mismo valor, se obtienen seis puntos extra por obtener un triple.
Si el jugador obtiene una puntuación igual o mayor que 16, gana un coche nuevo.
Si el jugador obtiene una puntuación igual o mayor que 10, gana un portátil nuevo.
Si el jugador obtiene una puntuación de 7, gana un viaje.
De lo contrario, el jugador gana un gatito.*/

Random dice = new Random(); // Creo una nueva instancia de la clase System.Random (un objeto) y almaceno ese objeto en la variable "dice"

int roll1 = dice.Next(1, 7); //llamo al método Random.Next() en el objeto "dice", 3 veces
int roll2 = dice.Next(1, 7); //restringiendo los limites en cada caso
int roll3 = dice.Next(1, 7); //y guardando cada valor en una variable

//Para probar los condicionales:
//  roll1 = 1; 
//  roll2 = 1;
//  roll3 = 1;

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total} ");



if ((roll1 == roll2) || (roll2 == roll3) || (roll3 == roll1))
{
  if ((roll1 == roll2) && (roll2 == roll3))
  {
    Console.WriteLine("You rolled triples! + 6 bonues to total!");
    total += 6;
  }
  else
  {
    Console.WriteLine("You rolled doubles! + 2 bonues to total!");
    total += 2;
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
else
{
  Console.WriteLine("You win a kitten!");
}

/**********************************************************************/

/*Le han pedido que agregue una característica al software de su empresa. La característica está pensada para mejorar la tasa de renovación de las suscripciones al software. Su tarea consiste en mostrar un mensaje de renovación cuando un usuario inicia sesión en el sistema de software y se notifica que su suscripción finaliza pronto. Para cumplir los requisitos, necesitará agregar un par de instrucciones de decisión para agregar lógica de rama a la aplicación.*/

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

if (daysUntilExpiration <= 10)
{
  if (daysUntilExpiration <= 5)
  {
    discountPercentage = 10;
    if (daysUntilExpiration == 1)
    {
      discountPercentage = 20;
      if (daysUntilExpiration < 1)
      {
        Console.WriteLine("You subscription has expired");
      }
      else
      { Console.WriteLine($"You subscription expires within a day!\nRenew now and save {discountPercentage}%!"); }
    }
    else
    {
      Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.\nRenew now and save {discountPercentage}%!");
    }
  }
  else
  { Console.WriteLine("Your subscription will expire soon. Renew now!"); }
}

/*
*Use una instrucción if para crear una rama en la lógica del código. La instrucción de decisión if ejecutará el código en su bloque de código si su expresión booleana es verdadera. De lo contrario, el runtime omitirá el bloque de código y continuará con la siguiente línea de código después de este.
*Una expresión booleana es cualquier expresión que devuelve un valor booleano.
*Los operadores booleanos compararán los dos valores a la izquierda y a la derecha para ver si son iguales, para compararlos, etc.
*Un bloque de código está delimitado por llaves { }. Recopila líneas de código que deben tratarse como una sola unidad.
*El operador Y lógico, &&, agrega dos expresiones y ambas subexpresiones deben ser verdaderas para que toda la expresión sea verdadera.
*El operador O lógico, ||, agrega dos expresiones y si alguna de las subexpresiones es verdadera, toda la expresión lo es también.
*La combinación de instrucciones if y else permite probar una condición y ejecutar código cuando una expresión booleana es verdadera, y ejecutar otro código si es falsa.
*Puede anidar instrucciones if para limitar una posible condición. Aun así, considere la posibilidad de usar instrucciones if else y else if en su lugar.
*Use else if para crear varias condiciones exclusivas.
*El bloque else es opcional, pero siempre debe aparecer en último lugar.
*/

/**********************************************************************/

// SKU = Stock Keeping Unit
string sku = "01-MN-L";

string[] product = sku.Split('-');

string type = "";
string color = "";
string size = "";

switch (product[0])
{
  case "01":
    type = "Sweat shirt";
    break;
  case "02":
    type = "T-Shirt";
    break;
  case "03":
    type = "Sweat pants";
    break;

  default:
    type = "Other";
    break;
}

switch (product[1])
{
  case "BL":
    color = "Black";
    break;
  case "MN":
    color = "Maroon";
    break;
  default:
    color = "White";
    break;

}

switch(product[2])
{
  case "S":
  size = "Small";
  break;
  case "M":
  size = "Medium";
  break;
  case "L":
  size = "Large";
  break;
  default :
  size = "One Size Fits All";
  break;
}

Console.WriteLine($"Product: {size} {color} {type}");