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

/*
¿qué ocurre si tengo que dividir dos variables de tipo int, pero no quiero que el resultado se trunque? En ese caso, debo realizar una conversión de tipo de datos de int a decimal. La conversión es un tipo de conversión de datos que indica al compilador que trate temporalmente un valor como si fuera otro tipo de datos.
Para convertir int a decimal, agrego el operador de conversión antes del valor. Usando el nombre del tipo de datos entre paréntesis delante del valor para convertirlo.
*/
decimal gradePointAverage = (decimal) totalGradePoints/totalCreditHours;
//Esto me va a mostrar un nro con muchos decimales, si quisiera solo dos decimales puedo usar este artilugio:

int leadingDigit = (int) gradePointAverage; //capturo el 1er entero
int trailingDigits = (int) (gradePointAverage * 100) - (leadingDigit * 100);//capturo los 1eros 2 decimales, como enteros (*)

Console.WriteLine($"\n\nStudent: {studentName}\n");
Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");

Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t\t{course2Grade}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t\t{course4Grade}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t\t{course5Grade}\t\t{course5Credit}");

Console.WriteLine($"\nFinal GPA:\t\t\t{leadingDigit}.{trailingDigits}");//los presento con el punto (*)

/*Tab stop locations are set at four-character intervals, and each tab will advance to the next tab stop location. If you have a string of five characters followed by a tab escape sequence, the escape sequence will advance to the tab stop at the eight-character location, filling the gap with space characters to create whitespace in the output. However, you can advance to the same location if you have a string of seven characters followed by a tab escape sequence. This makes tab escape sequences more noticeable when they occur further from the next tab stop location.
*/