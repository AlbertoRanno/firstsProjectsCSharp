// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello \"C#\"!");
Console.Write("Congratulations!");
Console.Write(" ");
Console.Write("You wrote your first lines of code!\n");

/*el énfasis en los tipos de datos es una de las características distintivas de C# en comparación con otros lenguajes como Python y JavaScript. Los diseñadores de C# creían poder ayudar a los desarrolladores a evitar errores comunes de software mediante la aplicación de tipos de datos.*/

/*
Un literal es literalmente un valor codificado de forma rígida.
Cuando se necesita trabajar con datos de fuera del código propio, se declara una variable.
Que son valores temporales que se almacenan en la memoria del equipo.
Para poder usar una variable, hay que declararla.
Primero se selecciona un tipo de datos correspondiente al tipo de datos que se quiere almacenar y, luego, se asigna a la variable un nombre (camelCase - No usar contracciones)
El compilador de C# debe comprender primero el valor del lado derecho del operador de asignación para poder realizar después la asignación a la variable en el lado izquierdo del operador de asignación. Si el orden se revierte, se confunde al compilador de C#
*/

string firstName = "Bob";
//string para palabras, frases o cualquier dato alfanumérico para presentación, no cálculo
Console.Write("Concatenacion: " + firstName + " es alto\t\\");
char lastChar = 'b';
//char para un solo carácter alfanumérico
Console.Write($"Interpolacion: {lastChar} es el ultimo caracter\n\\");
int age = 27;
//int para un número entero
Console.Write($@" El @ respeta lo que ponga dentro //\\\ ---       65{age}\t\n\\"+"\n\\");
bool legal = true;
//bool para un valor true o false
Console.Write(legal+"\n");
decimal weight = 2.35m;
//decimal para un número con un decimal
int quotient = 7/5; // Dará por resultado un nro entero
Console.Write(weight+"\t\t"+quotient);
/* 
Para que esto funcione, el cociente (a la izquierda del operador de asignación) debe ser de tipo decimaly el dividendo o el divisor deben ser de tipo decimal (o ambos):
decimal decimalQuotient = 7.0m / 5;
decimal decimalQuotient = 7 / 5.0m;
decimal decimalQuotient = 7.0m / 5.0m;
Console.WriteLine("Decimal quotient: " + decimalQuotient); //1.4
*/

/*
Una variable local con tipo implícito se crea mediante la palabra clave var, que indica al compilador de C# que deduzca el tipo. Una vez que se ha inferido el tipo, es igual que si hubiera usado el tipo de datos real para declarar la variable.
var message = "Hello world!";
De hecho, la variable message se escribe como una cadena y nunca se puede cambiar. 

var message = "Hello World!";
message = 10.0m;
Si se ejecuta este código, aparece un mensaje de error:  No se puede convertir implícitamente el tipo 'decimal' en 'string'

var tiene un uso importante en C#. Por motivos que pueden no quedarle claros hasta que escriba código avanzado, hay situaciones en las que el tipo de datos puede no ser obvio en el momento de inicializar la variable. De hecho, en algunos casos, C# puede inventar un nuevo tipo de datos solo para el código y puede no ser capaz de darle un nombre predecible por adelantado.
*/

/*
orden de las operaciones.
En matemáticas, PEMDAS es un acrónimo que ayuda a los alumnos a recordar el orden en el que se realizan varias operaciones. El orden es:
Paréntesis (lo que se encuentra dentro del paréntesis se realiza primero)
Exponents (exponentes)
Multiplication (multiplicación) y Division (división) (de izquierda a derecha)
Addition (suma) y Subtraction (resta) (de izquierda a derecha)
C# sigue el mismo orden que PEMDAS, excepto en el caso de los exponentes. Aunque no hay ningún operador exponencial en C#, puede utilizar el método System.Math.Pow()
*/

//+=, -=, *=, ++ y -- Son operadores de asignación compuesta porque realizan alguna operación además de asignar el resultado a la variable. 

int value = 1;
value = value + 1;
Console.WriteLine("\n\nFirst increment: " + value);//2
value += 1;
Console.WriteLine("Second increment: " + value);//3
value++;
Console.WriteLine("Third increment: " + value);//4
value = value - 1;
Console.WriteLine("First decrement: " + value);//3
value -= 1;
Console.WriteLine("Second decrement: " + value);//2
value--;
Console.WriteLine("Third decrement: " + value);//1

/*Los operadores de incremento y decremento tienen una cualidad interesante: según su posición, llevan a cabo la operación antes o después de recuperar el valor. En otras palabras, si usa el operador delante del valor (como en ++value), el incremento se producirá antes de recuperar el valor. Del mismo modo, value++ incrementará el valor una vez recuperado.*/
int value2 = 1;
value2++;
Console.WriteLine("First: " + value2); // 2 - muestra el valor acumulado de value
Console.WriteLine("Second: " + value2++); //2 -muestra el valor acum. y luego le suma 1
Console.WriteLine("Third: " + value2); //3 confirma, que luego de mostrar en la linea anterior, se acumuló uno más
Console.WriteLine("Fourth: " + (++value2)); //4 se acumula primero, y luego muestra. Los paréntesis se agregan para mejorar la legibilidad, pero no son necesarios.

//Pasar de Fahrenheit a Celsius:
int fahrenheit = 94;
decimal celsius = (fahrenheit-32) * (5.0m/9);
Console.WriteLine($"The temperatura is {celsius} Celsius");

/*Guided project - Calculate final GPA

You're developing a Student GPA Calculator that will help calculate students' overall Grade Point Average. The parameters for your application are:

You're given the student's name and class information.
Each class has a name, the student's grade, and the number of credit hours for that class.
Your application needs to perform basic math operations to calculate the GPA for the given student.
Your application needs to output/display the student’s name, class information, and GPA.
To calculate the GPA:

Multiply the grade value for a course by the number of credit hours for that course.
Do this for each course, then add these results together.
Divide the resulting sum by the total number of credit hours.
You're provided with the following sample of a student's course information and GPA:

Student: Sophia Johnson

Course          Grade   Credit Hours	
English 101         4       3
Algebra 101         3       3
Biology 101         3       4
Computer Science I  3       4
Psychology 101      4       3

Final GPA:          3.35
*/

string studentName = "Sophia Johnson";
string course1Name = "English 101";
string course2Name = "Algebra 101";
string course3Name = "Biology 101";
string course4Name = "Computer Science I";
string course5Name = "Psychology 101";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int gradeA = 4;
int gradeB = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

int totalCreditHours = 0;
totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

int totalGradePoints = 0;
totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;

decimal gradePointAverage = (decimal) totalGradePoints/totalCreditHours;

int leadingDigit = (int) gradePointAverage;
int trailingDigits = (int) (gradePointAverage * 100) - (leadingDigit * 100);

Console.WriteLine($"\n\nStudent: {studentName}\n");
Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");

Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t\t{course4Grade}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t\t{course5Grade}\t\t{course5Credit}");

Console.WriteLine($"\nFinal GPA:\t\t\t{leadingDigit}.{trailingDigits}");



