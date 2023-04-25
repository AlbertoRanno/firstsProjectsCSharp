/*Cuando se hace el update de un proyecto, es mejor comentar los cambios en un solo bloque al comienzo del archivo, que ir detallando linea a linea.

En este caso, el update consistió en desglosar los resultados mostrados por consola. (Ver por un lado el promedio final, pero también, el promedio exclusivo de los exámenes, y la influencia de los créditos extras). Para tal fin, se crearon variables genéricas en el ciclo for each que permitieran calcular cada columna a mostrar.

The using statement enables you to write code that implements members of the System namespace without requiring you to specify System.For example, your code can use the Console.WriteLine() method without having to specify System.Console.WriteLine(). Among other things, the using statement makes your code easier to read.*/
using System;

/*Utilizando ahora Arrays, Condicionales y ciclos Foreach, automotizar la obtención de promedios, para distintos alumnos. Teniendo en cuenta la cantidad exámenes y sus notas, los créditos extras (los cuales suman solo un 10%), y la asignación de las califiaciones correspondientes ("B-", "F", ...). Además, con mínimos cambios, se debe de poder agregar alumnos a voluntad */

int examAssignments = 5; //Cantidad de exámenes

//Los 5 primeros son las notas de los examenes. A partir del 6, son los creditos extras, que pesan menos en el promedio.
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

string[] studentsNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

// Declaro variable genérica, la cual tomará el valor de los distintos arraysScores, a medida se recorre el arrayStudents.
int[] studentScores = new int[10];

// Declaro variable genérica para que tome el valor de la correspondiente calificacion en cada caso.
string currentStudentLetterGrade = "";

//Títulos de las columnas de salida
Console.WriteLine("Student\t\tExam Score\tOverall Grade\tExtra Credit\n");


foreach (string name in studentsNames)
{
  //podría haber utilizado directamente "name", pero así se entiende mejor:
  string currentStudent = name;

  //si el estudiante que está analizando es, Sophia, tener en cuenta que sus notas, son las de sophiaScores
  if (currentStudent == "Sophia")
    studentScores = sophiaScores;
  else if (currentStudent == "Andrew")
    studentScores = andrewScores;
  else if (currentStudent == "Emma")
    studentScores = emmaScores;
  else if (currentStudent == "Logan")
    studentScores = loganScores;
  else if (currentStudent == "Becky")
    studentScores = beckyScores;
  else if (currentStudent == "Chris")
    studentScores = chrisScores;
  else if (currentStudent == "Eric")
    studentScores = ericScores;
  else if (currentStudent == "Gregor")
    studentScores = gregorScores;

  //Declaro variable genérica para guardar la suma de las notas del estudiante en cuestión
  decimal sumAssigmentScores = 0;
  decimal sumExamScores = 0;
  decimal sumCreditsScores = 0;

  //Declaro variable genérica para guardar el promedio de las notas del estudiante en cuestión
  decimal currentStudentGrade = 0;
  decimal currentExamGrade = 0;
  decimal currentCreditsGrade = 0;

  int creditsAssignments = studentScores.Length - examAssignments;

  /*Lo siguiente es un mecanismo que lo que hace es que, las primeras 5 notas del array, las suma de forma directa. Pero de cada nota a partir de la sexta, inclusive, (el ELSE, de: gradedAssignments <= examAssignments), solo sume la décima parte, porque es lo que aportan los créditos extras*/
  int gradedAssignments = 0;

  foreach (int score in studentScores)
  {
    gradedAssignments += 1;

    if (gradedAssignments <= examAssignments)
    {
      sumAssigmentScores += score;
      sumExamScores += score;
    }
    else
    {
      sumAssigmentScores += (decimal)score / 10;
      sumCreditsScores += score;
    }
  }

  //Calculo el promedio final, como la suma(incluye el 10% de cada créd. extra), sobre la cantidad de exámenes
  currentStudentGrade = (decimal)sumAssigmentScores / examAssignments;
  currentExamGrade = (decimal)sumExamScores/ examAssignments;
  currentCreditsGrade = (decimal)sumCreditsScores/ creditsAssignments;
  decimal extraCreditPoint = currentStudentGrade - currentExamGrade;

  //Determino que calificación en string, se corresponde con cada promedio:
  if (currentStudentGrade >= 97)
    currentStudentLetterGrade = "A+";

  else if (currentStudentGrade >= 93)
    currentStudentLetterGrade = "A";

  else if (currentStudentGrade >= 90)
    currentStudentLetterGrade = "A-";

  else if (currentStudentGrade >= 87)
    currentStudentLetterGrade = "B+";

  else if (currentStudentGrade >= 83)
    currentStudentLetterGrade = "B";

  else if (currentStudentGrade >= 80)
    currentStudentLetterGrade = "B-";

  else if (currentStudentGrade >= 77)
    currentStudentLetterGrade = "C+";

  else if (currentStudentGrade >= 73)
    currentStudentLetterGrade = "C";

  else if (currentStudentGrade >= 70)
    currentStudentLetterGrade = "C-";

  else if (currentStudentGrade >= 67)
    currentStudentLetterGrade = "D+";

  else if (currentStudentGrade >= 63)
    currentStudentLetterGrade = "D";

  else if (currentStudentGrade >= 60)
    currentStudentLetterGrade = "D-";

  else currentStudentLetterGrade = "F";

  Console.WriteLine($"{currentStudent}:\t\t{currentExamGrade}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}\t{currentCreditsGrade} ({extraCreditPoint})");
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
/*
The Console.ReadLine() statement will pause the application so that the application user can review the output.

Your application was essentially paused after writing "Press the Enter key to continue" to the console. This behavior is caused by the Console.ReadLine() statement, which is used to collect user input in a console application. Your application will stop running once you press Enter.

The dotnet build command will compile your code and display error and warning messages related to your code syntax.

Visual Studio Code provides a Format Document command that can be used to keep your code formatting updated. Right-click inside the Visual Studio Code Editor, and then select Format Document from the popup menu. The keyboard shortcut for this command is: Shift + Alt + F.

The Visual Studio Code Editor panel support using the keyboard shortcut Control + F to find the text that you specify. The Visual Studio Code Editor panel also supports using the keyboard shortcut Control + H to find and replace the text that you specify.*/