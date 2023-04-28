/*Juego de Rol con las siguientes características

Desafío de la batalla del juego de rol

En algunos juegos de rol, el personaje del jugador se enfrenta a personajes que no son de jugador, normalmente monstruos o "los malos". A veces, en una batalla cada personaje genera un valor aleatorio mediante dados y ese valor se resta de la puntuación de salud del adversario. Cuando la salud de cualquiera de los personajes llega a cero, pierden.

En este desafío, esa interacción se reducirá a lo más básico. Un héroe y un monstruo comienzan con la misma puntuación de salud. Durante el turno de la héroe, se generará un valor aleatorio que se restará de la salud del monstruo. Si la salud del monstruo es mayor que cero, tomará su turno y atacará al héroe. Mientras que la salud del héroe y del monstruo sea mayor que cero, el combate se reanudará.

Estas son las reglas para el juego de batalla que necesita implementar en el proyecto de código:

Debes usar la instrucción do-while o la instrucción while como un bucle de juego externo.
El héroe y el monstruo comenzarán con 10 puntos de salud.
Todos los ataques serán un valor comprendido entre 1 y 10.
El héroe atacará primero.
Imprima la cantidad de salud que ha perdido el monstruo y su salud restante.
Si la salud del monstruo es mayor que 0, puede atacar al héroe.
Imprima la cantidad de salud que ha perdido el héroe y su salud restante.
Continúe con esta secuencia de ataque hasta que la salud del monstruo o del héroe sea cero o menos.
Imprima el ganador.

Con independencia de cómo lo haga, el código debe generar una salida similar a esta:

Monster was damaged and lost 1 health and now has 9 health.
Hero was damaged and lost 1 health and now has 9 health.
Monster was damaged and lost 7 health and now has 2 health.
Hero was damaged and lost 6 health and now has 3 health.
Monster was damaged and lost 9 health and now has -7 health.
Hero wins!

*/

Random randomAttack = new Random();

int heroHealth = 10;
int monsterHealth = 10;
int heroAttack = 0;
int monsterAttack = 0;

while (heroHealth > 0 && monsterHealth > 0)
{
  heroAttack = randomAttack.Next(1, 11);
  monsterHealth -= heroAttack;
  if (monsterHealth > 0)
  {
    Console.WriteLine($"Monster was damaged and lost {heroAttack} health !\nWith his {monsterHealth} life points remaining, he is furious, and attack!");
    monsterAttack = randomAttack.Next(1, 11);
    heroHealth -= monsterAttack;
    if (heroHealth > 0)
      Console.WriteLine($"Hero was damaged and lost {monsterAttack} health and now has {heroHealth} life points remaining.\nHe has a new opportunity!");
    else Console.Write($"His hit was too hard! ({monsterAttack} points!) and the hero die... a pitty xD");
  }
  else
    Console.WriteLine($"Hero hit was excellent ({heroAttack} points!) and killed the creature!\nHero wins!");
}

/* Forma sugerida:

int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");

*/