/*DO-WHILE*/

Random random = new Random();

int current1 = 0;

do
{
  current1 = random.Next(1, 11);
  Console.WriteLine($"do-while: {current1}");
} while (current1 != 7);


/*WHILE*/

int current2 = random.Next(1, 11);

while (current2 >= 3)
{
  Console.WriteLine($"while: {current2}");
  current2 = random.Next(1, 11);
}
Console.WriteLine($"while - Last number: {current2}");


/*DO-WHILE + continue*/

do
{
  current2 = random.Next(1, 11);

  if (current2 >= 8) continue; // si true, saltea el Console.WriteLine, y va directo al while.
                               // por lo que no voy a ver valores mayores o iguales a 8 en consola.

  Console.WriteLine($"do-while + continue: {current2}");
} while (current2 != 7);


