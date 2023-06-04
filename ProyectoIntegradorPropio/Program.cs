/* PROYECTO INTEGRADOR - VERSION PROPIA

Correciones realizadas, a recordar:
-los nombres de las variables, comienzan con Mayúscula, dado que por convención se usa PascalCase (y NO camelCase como en JS)
-los nombres de variables constantes, por convención, se escriben con todas las letras MAYÚSCULAS
-la Edad, si bien, no se utiliza para cálculos, NO conviene almacenarla como string, por dos motivos:
1- en una BBDD siempre va a estar como valor numérico, y
2- dentro de los numéricos, va a ser byte, xq es el que menos memoria ocupa
-Con Confirmacion, pasa lo mismo, antes que string, conviene char. 
-OJO que char lleva comillas simples
*/

string? ReadResult;
string Nombre = "", Apellido = "", Email = "", ValueEntered = "";
byte Edad = 0, CodigoCarrera = 0;
char Confirmacion = 's';
const string CARRERA1 = "Programación .NET", CARRERA2 = "Programación Java", CARRERA3 = "Programación PHP";
bool ValidNumber = false;

Console.Clear();
Console.WriteLine("Bienvenido a la app!\n");
Console.Write("Ingresá tu nombre: ");
ReadResult = Console.ReadLine();
if (ReadResult != null)
{
  Nombre = ReadResult;
}

Console.Write("\nIngresá tu apellido: ");
ReadResult = Console.ReadLine();
if (ReadResult != null)
{
  Apellido = ReadResult;
}

do
{
  Console.Write("\nIngresá tu edad: ");
  ReadResult = Console.ReadLine();
  if (ReadResult != null)
  {
    ValueEntered = ReadResult;
  }
  ValidNumber = byte.TryParse(ValueEntered, out Edad);
  if (ValidNumber == false) Console.WriteLine("En formato numérico. Ejemplo: Edad = 37");
} while (ValidNumber == false);


Console.Write("\nIngresá tu correo electrónico: ");
ReadResult = Console.ReadLine();
if (ReadResult != null)
{
  Email = ReadResult;
}

Console.WriteLine($"\n<<<<< Datos del alumno >>>>>:\n Nombre: {Nombre}\n Apellido: {Apellido}\n Edad: {Edad} \n Email: {Email}");
Console.WriteLine("\n¿ Los datos son correctos ? - 'S' para confirmar, 'N' para cancelar\r");
ReadResult = Console.ReadLine();
if (ReadResult != null)
{
  Confirmacion = char.Parse(ReadResult);
}



if (Confirmacion == 's' || Confirmacion == 'S')
{
  Console.WriteLine("\n<<< Selecciona el código de la carrera elegida >>>");
  Console.WriteLine($"\n1. {CARRERA1}\n2. {CARRERA2}\n3. {CARRERA3}\n\r");
  ReadResult = Console.ReadLine();
  if (ReadResult != null)
  {
    CodigoCarrera = byte.Parse(ReadResult);
  }

  switch (CodigoCarrera)
  {
    case 1:
      Console.WriteLine($"\n<<<<< Constancia de inscripción >>>>>:");
      Console.WriteLine($"\nAlumno: {Nombre} {Apellido}\nCorreo electrónico: {Email}");
      Console.WriteLine($"{CARRERA1}");
      break;
    case 2:
      Console.WriteLine($"\n<<<<< Constancia de inscripción >>>>>:");
      Console.WriteLine($"\nAlumno: {Nombre} {Apellido}\nCorreo electrónico: {Email}");
      Console.WriteLine($"{CARRERA2}");
      break;
    case 3:
      Console.WriteLine($"\n<<<<< Constancia de inscripción >>>>>:");
      Console.WriteLine($"\nAlumno: {Nombre} {Apellido}\nCorreo electrónico: {Email}");
      Console.WriteLine($"{CARRERA3}");
      break;
    default:
      Console.WriteLine($"Carrera inexistente");
      Console.WriteLine("\nDatos incorrectos. Ejecutar nuevamente la aplicación.");
      break;
  }
}
else
{
  Console.WriteLine("\nDatos incorrectos. Ejecutar nuevamente la aplicación.");
}

