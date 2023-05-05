﻿/*Está trabajando en la aplicación Contoso Pets, una aplicación que ayuda a colocar mascotas en nuevos hogares. */

// the ourAnimals array will store the following: 
string animalSpecies = "";
string animalID = "";
string animalAge = "";
string animalPhysicalDescription = "";
string animalPersonalityDescription = "";
string animalNickname = "";

// variables that support data entry
int maxPets = 8;
string? readResult;
string menuSelection = "";

// array used to store runtime data, there is no persisted data
string[,] ourAnimals = new string[maxPets, 6];
/*Esto define una matriz bidimensional, tiene una longitud de 8 filas (maxPets) y 6 columnas. La matriz está formada por elementos de tipo "string", lo que significa que cada celda de la matriz contendrá una cadena de texto.

La línea de código utiliza la palabra clave "new" para crear una instancia de la matriz con el tamaño especificado de 8 filas y 6 columnas. Esto significa que la matriz es creada en tiempo de ejecución y se asigna un espacio en la memoria para almacenar los elementos de la matriz.

La sintaxis de la declaración de la matriz utiliza la sintaxis de los corchetes dobles "[,]" para indicar que es una matriz bidimensional y el número entre los corchetes indica la longitud de la matriz en cada dimensión ([maxPets, 6]).

La matriz puede ser accedida y modificada utilizando índices de fila y columna para acceder a elementos individuales.
*/

// create some initial ourAnimals array entries
for (int i = 0; i < maxPets; i++) //Armo la matriz:
{ // cada fila (i) de la matriz, será una mascota, y cada columna, será una característica de la misma:
  //animalSpecies | animalID | animalAge | animalPhysicalDescription | animalPersonalityDescription | animalNickname:
  switch (i) 
  {
    case 0:
      animalSpecies = "dog";
      animalID = "d1";
      animalAge = "2";
      animalPhysicalDescription = "medium sized cream colored female golden retriever weighing about 65 pounds. housebroken.";
      animalPersonalityDescription = "loves to have her belly rubbed and likes to chase her tail. gives lots of kisses.";
      animalNickname = "lola";
      break;
    case 1:
      animalSpecies = "dog";
      animalID = "d2";
      animalAge = "9";
      animalPhysicalDescription = "large reddish-brown male golden retriever weighing about 85 pounds. housebroken.";
      animalPersonalityDescription = "loves to have his ears rubbed when he greets you at the door, or at any time! loves to lean-in and give doggy hugs.";
      animalNickname = "loki";
      break;
    case 2:
      animalSpecies = "cat";
      animalID = "c3";
      animalAge = "1";
      animalPhysicalDescription = "small white female weighing about 8 pounds. litter box trained.";
      animalPersonalityDescription = "friendly";
      animalNickname = "Puss";
      break;
    case 3:
      animalSpecies = "cat";
      animalID = "c4";
      animalAge = "?";
      animalPhysicalDescription = "";
      animalPersonalityDescription = "";
      animalNickname = "";
      break;
    default:
      animalSpecies = "";
      animalID = "";
      animalAge = "";
      animalPhysicalDescription = "";
      animalPersonalityDescription = "";
      animalNickname = "";
      break;

  }

  //Por cada fila de la matriz, cada espacio, en las columnas del "0 al 5", se completará con lo siguiente:
  ourAnimals[i, 0] = "ID #: " + animalID;
  ourAnimals[i, 1] = "Species: " + animalSpecies;
  ourAnimals[i, 2] = "Age: " + animalAge;
  ourAnimals[i, 3] = "Nickname: " + animalNickname;
  ourAnimals[i, 4] = "Physical description: " + animalPhysicalDescription;
  ourAnimals[i, 5] = "Personality: " + animalPersonalityDescription;
}

do //el usuario ve al menos una vez el menú
{
  // display the top-level menu options

  Console.Clear();

  Console.WriteLine("Welcome to the Contoso PetFriends app. Your main menu options are:");
  Console.WriteLine(" 1. List all of our current pet information");
  Console.WriteLine(" 2. Add a new animal friend to the ourAnimals array");
  Console.WriteLine(" 3. Ensure animal ages and physical descriptions are complete");
  Console.WriteLine(" 4. Ensure animal nicknames and personality descriptions are complete");
  Console.WriteLine(" 5. Edit an animal’s age");
  Console.WriteLine(" 6. Edit an animal’s personality description");
  Console.WriteLine(" 7. Display all cats with a specified characteristic");
  Console.WriteLine(" 8. Display all dogs with a specified characteristic");
  Console.WriteLine();
  Console.WriteLine("Enter your selection number (or type Exit to exit the program)");

  readResult = Console.ReadLine(); // pause code execution
  if (readResult != null)
  {
    menuSelection = readResult.ToLower();
  }

   switch (menuSelection)
  {
    case "1":
      //List all of our current pet information
      for (int i = 0; i < maxPets; i++) //(*)
      {
        if (ourAnimals[i, 0] != "ID #: ")
        {
          Console.WriteLine();
          for (int j = 0; j < 6; j++)
          {
            Console.WriteLine(ourAnimals[i, j]);
          }
        }
      }
      Console.WriteLine("Press the Enter key to continue");
      readResult = Console.ReadLine();
      break;
    /*La razón por la que no se usa un bucle foreach en esta situación es porque ourAnimals es una matriz multidimensional. Dado que ourAnimals es una matriz de cadenas multidimensional, cada elemento que ourAnimals contiene es un elemento independiente de la cadena de tipo. Si usó un bucle foreach para recorrer en iteración ourAnimals, foreach reconocería cada cadena como un elemento independiente en una lista de 48 elementos de cadena (8 x 6 = 48). La instrucción foreach no procesaría las dos dimensiones de la matriz por separado. En otras palabras, un bucle foreach no reconocerá 8 filas de elementos de cadena, donde cada fila contiene una columna de 6 elementos. Como quiere trabajar con los animales de uno en uno y procesar las seis características de cada animal durante una sola iteración, la instrucción foreach no es la más adecuada.*/
    case "2":
      //Add a new animal friend to the ourAnimals array
      Console.WriteLine("this app feature is coming soon - please check back to see progress.");
      Console.WriteLine("Press the Enter key to continue");
      readResult = Console.ReadLine();
      break;
    case "3":
      //Ensure animal ages and physical descriptions are complete
      Console.WriteLine("Challenge Project - please check back soon to see progress.");
      Console.WriteLine("Press the Enter key to continue");
      readResult = Console.ReadLine();
      break;
    case "4":
      //Ensure animal nicknames and personality descriptions are complete
      Console.WriteLine("Challenge Project - please check back soon to see progress.");
      Console.WriteLine("Press the Enter key to continue");
      readResult = Console.ReadLine();
      break;
    case "5":
      //Edit an animal’s age
      Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
      Console.WriteLine("Press the Enter key to continue");
      readResult = Console.ReadLine();
      break;
    case "6":
      //Edit an animal’s personality description
      Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
      Console.WriteLine("Press the Enter key to continue");
      readResult = Console.ReadLine();
      break;
    case "7":
      //Display all cats with a specified characteristic
      Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
      Console.WriteLine("Press the Enter key to continue");
      readResult = Console.ReadLine();
      break;
    case "8":
      //Display all dogs with a specified characteristic
      Console.WriteLine("UNDER CONSTRUCTION - please check back next month to see progress.");
      Console.WriteLine("Press the Enter key to continue");
      readResult = Console.ReadLine();
      break;
    default:
      break;
  }

} while (menuSelection != "exit");

