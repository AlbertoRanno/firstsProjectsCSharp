/*Está trabajando en la aplicación Contoso Pets, una aplicación que ayuda a colocar mascotas en nuevos hogares. */

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
    /*
    Cuando se procesa el contenido de una matriz multidimensional, un desarrollador quiere a menudo recorrer en iteraciòn las dimensiones de una matriz por separado. Y la instrucciòn FOR lo permite de una manera mucho más simple
    
    La razón por la que no se usa un bucle foreach en esta situación es porque ourAnimals es una matriz multidimensional. Dado que ourAnimals es una matriz de cadenas multidimensional, cada elemento que ourAnimals contiene es un elemento independiente de la cadena de tipo. Si usó un bucle foreach para recorrer en iteración ourAnimals, foreach reconocería cada cadena como un elemento independiente en una lista de 48 elementos de cadena (8 x 6 = 48). La instrucción foreach no procesaría las dos dimensiones de la matriz por separado. En otras palabras, un bucle foreach no reconocerá 8 filas de elementos de cadena, donde cada fila contiene una columna de 6 elementos. Como quiere trabajar con los animales de uno en uno y procesar las seis características de cada animal durante una sola iteración, la instrucción foreach no es la más adecuada.*/
    case "2":
      //Add a new animal friend to the ourAnimals array
      string anotherPet = "y";
      int petCount = 0;

      //cuento los animales que ya tenemos
      for (int i = 0; i < maxPets; i++)
      {
        if (ourAnimals[i, 0] != "ID #: ")
        {
          petCount++;
        }
      }

      if (petCount < maxPets)
      {
        Console.WriteLine($"We currently have {petCount} pets that need homes. We can manage {(maxPets - petCount)} more.");
      }

      bool validEntry = false;

      // defino la especie:
      do
      {
        Console.WriteLine("\n\rEnter 'dog' or 'cat' to begin a new entry");
        //El "\r"  significa "retorno de carro" (carriage return) se usa para mover el cursor al principio de la siguiente línea.
        readResult = Console.ReadLine();
        if (readResult != null)
        {
          animalSpecies = readResult.ToLower();
          if (animalSpecies != "dog" && animalSpecies != "cat")
          {
            Console.WriteLine($"You enteder: {animalSpecies}");
            validEntry = false;
          }
          else
          {
            validEntry = true;
          }
        }
      } while (validEntry == false);

      //desde la posicion 0, avanzo 1 caracter, y corto el resto. Luego le sumo el nro siguiente a petCount, pasado a string  
      animalID = animalSpecies.Substring(0, 1) + (petCount + 1).ToString();

      // defino la edad:
      do
      {
        int petAge;
        Console.WriteLine("Enter the pet's age or enter ? if unknown");
        readResult = Console.ReadLine();

        if (readResult != null)
        {
          animalAge = readResult.ToLower();
          if (animalAge != "?")
          {
            validEntry = int.TryParse(animalAge, out petAge);
            /*
            La función "int.TryParse()" se utiliza para intentar analizar una cadena (string) y convertirla en un valor entero (int).
 "animalAge" es una cadena que contiene la edad de una mascota. La variable "petAge" es una variable de tipo entero (int) que se utiliza para almacenar la edad de la mascota después de que se convierte de una cadena a un valor entero.

La función "int.TryParse()" tiene dos parámetros:

El primer parámetro es la cadena (string) que se va a analizar y convertir a un valor entero.
El segundo parámetro es una variable de salida (out) que almacenará el valor entero resultante después del análisis de la cadena.

La función "int.TryParse()" devuelve un valor booleano que indica si el análisis y la conversión de la cadena fueron exitosos o no. Si la función devuelve "true", significa que la cadena se analizó y se convirtió correctamente a un valor entero, y el valor entero se almacenó en la variable "petAge". Si la función devuelve "false", significa que el análisis y la conversión de la cadena no fueron exitosos, y la variable "petAge" tendrá un valor predeterminado (en este caso, el valor predeterminado de una variable int es 0).
            */
          }
        }
      } while (validEntry == false);

      do
      {
        Console.WriteLine("Enter a physical description of the pet (size, color, gender, weight, housebroken)");
        readResult = Console.ReadLine();
        if (readResult != null)
        {
          animalPhysicalDescription = readResult.ToLower();
          if (animalPhysicalDescription == "")
          {
            animalPhysicalDescription = "tbd"; //significa "por determinar" ( to be determined )
          }
        }
      } while (animalPhysicalDescription == "");

      do
      {
        Console.WriteLine("Enter a description of the pet's personality (likes or dislikes, tricks, energy level)");
        readResult = Console.ReadLine();
        if (readResult != null)
        {
          animalPersonalityDescription = readResult.ToLower();
          if (animalPersonalityDescription == "")
          {
            animalPersonalityDescription = "tbd";
          }
        }
      } while (animalPersonalityDescription == "");

      do
      {
        Console.WriteLine("Enter a nickname for the pet");
        readResult = Console.ReadLine();
        if (readResult != null)
        {
          animalNickname = readResult.ToLower();
          if (animalNickname == "")
          {
            animalNickname = "tbd";
          }
        }
      } while (animalNickname == "");

      /* store the pet information in the ourAnimals array (zero based)
      Al comienzo, guardé en las primeras filas de la matriz, los datos precargados en cada columna, de cada fila.
      Ahora, cargaré en las filas restantes, dado a que petCount iniciará en "4", y se irá incrementando al cargar más mascotas.
      Recordar que las primeras filas que se cargaron fueron de la fila 0, a la fila 3 inclusive (4 mascotas)
      */
      ourAnimals[petCount, 0] = "ID #: " + animalID;
      ourAnimals[petCount, 1] = "Species: " + animalSpecies;
      ourAnimals[petCount, 2] = "Age: " + animalAge;
      ourAnimals[petCount, 3] = "Nickname: " + animalNickname;
      ourAnimals[petCount, 4] = "Physical description: " + animalPhysicalDescription;
      ourAnimals[petCount, 5] = "Personality: " + animalPersonalityDescription;

      while (anotherPet == "y" && petCount < maxPets)
      {
        petCount++;
        if (petCount < maxPets)
        {
          Console.WriteLine("Do you want to enter info for another pet (y/n)");
          do
          {
            readResult = Console.ReadLine();
            if (readResult != null)
            {
              anotherPet = readResult.ToLower();
            }
          } while (anotherPet != "y" && anotherPet != "n");
        }
      }


      if (petCount >= maxPets)
      {
        Console.WriteLine("We have reached our limit on the number of pets that we can manage.");
        Console.WriteLine("Press the Enter key to continue");
        readResult = Console.ReadLine();
      }
      break;

    /* Comentarios son el análisis del código
    en este caso, la lógica de código se basa en la relación entre petCount y maxPets. Sabe que a maxPets se le asigna un valor de 8, pero ¿qué hay de petCount? Los siguientes elementos ayudan a evaluar la lógica que ha implementado:

Sabe que petCount es 4 cuando escribe la primera iteración del bucle while.

Sabe que se incrementa petCount cada vez que el bucle while recorre en iteración.

Sabe que el valor asignado a petCount y la forma en que se incrementa petCount afecta a cómo se almacenan los datos en la matriz ourAnimals. Los siguientes elementos explican la relación entre petCount y los datos almacenados en ourAnimals:

La aplicación agrega cuatro mascotas a la matriz ourAnimals cuando crea los datos de ejemplo.
La aplicación almacena nuevos datos en la matriz ourAnimals cuando el valor de petCount es 4. Esto no es un error. El código tiene sentido cuando se recuerda que los elementos de la matriz están basados en cero. Por ejemplo, ourAnimals[0,0] contiene el identificador de mascota para el animal 1, y ourAnimals[3,0] contiene el identificador de mascota para el animal 4. Por lo tanto, cuando petCount es 4, está almacenando datos para la quinta mascota.
La aplicación almacenará los datos de mascotas en la matriz antes de incrementar petCount.
La aplicación incrementa petCount antes de solicitar al usuario que agregue otra mascota.
Cuando la aplicación muestra la solicitud ¿Desea especificar información sobre otra mascota? (s/n) por primera vez, petCount ya está establecido en 5.
Si el usuario escribe y en el primer mensaje ¿Desea especificar información sobre otra mascota? (y/n), sabe que:

El bucle while (anotherPet == "y" && petCount < maxPets) recorrerá en iteración. Sabe que el bucle recorrerá en iteración debido a anotherPet == "y" y petCount < maxPets.
El valor asignado a petCount se incrementará (cuando el bucle while recorra en iteración).
El valor asignado a petCount será 6 (después de que el usuario escriba y por primera vez).
Tenga en cuenta este análisis de la lógica de código mientras continúa probando la aplicación.

Observe que el panel del terminal se actualiza con el mismo mensaje "¿otra mascota?", pero el código no muestra un petCount actualizado.

El panel del terminal debería mostrar ahora la siguiente salida:

We currently have 4 pets that need homes. We can manage 4 more.
Do you want to enter info for another pet (y/n)
y
Do you want to enter info for another pet (y/n)

En el símbolo del sistema del terminal, escriba y

Al escribir y por segunda vez, petCount se incrementa en 7. Por lo tanto, petCount sigue siendo menor que maxPets.

En el símbolo del sistema del terminal, escriba y

Al escribir y por tercera vez, petCount se incrementa en 8. Por lo tanto, ahora petCount es igual a maxPets.

Compruebe que el código sale del bucle while al escribir y por tercera vez.

El panel del terminal debería mostrar ahora la siguiente salida:

We currently have 4 pets that need homes. We can manage 4 more.
Do you want to enter info for another pet (y/n)
y
Do you want to enter info for another pet (y/n)
y
Do you want to enter info for another pet (y/n)
y
We have reached our limit on the number of pets that we can manage.
Press the Enter key to continue.

    */

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

