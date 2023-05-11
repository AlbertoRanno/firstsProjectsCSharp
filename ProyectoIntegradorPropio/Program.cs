// PROYECTO INTEGRADOR - VERSION PROPIA

string? readResult;
string nombre = "", apellido = "", edad = "", email = "", confirmacion = "", codigoCarrera = "",
carrera1 = "Programación .NET", carrera2 = "Programación Java", carrera3 = "Programación PHP";

Console.Clear();
Console.WriteLine("Bienvenido a la app!\nIngresá tu nombre:\r");
readResult = Console.ReadLine();
if (readResult != null)
{
  nombre = readResult;
}

Console.WriteLine("\nIngresá tu apellido:\r");
readResult = Console.ReadLine();
if (readResult != null)
{
  apellido = readResult;
}

Console.WriteLine("\nIngresá tu edad: \r");
readResult = Console.ReadLine();
if (readResult != null)
{
  edad = readResult;
}

Console.WriteLine("\nIngresá tu correo electrónico: \r");
readResult = Console.ReadLine();
if (readResult != null)
{
  email = readResult;
}

Console.WriteLine($"\n<<<<< Datos del alumno >>>>>:\n Nombre: {nombre}\n Apellido: {apellido}\n Edad: {edad}\n Email: {email}");
Console.WriteLine("\n¿ Los datos son correctos ? - 'S' para confirmar, 'N' para cancelar\r");
readResult = Console.ReadLine();
if (readResult != null)
{
  confirmacion = readResult;
}

if (confirmacion.ToLower() == "s")
{
  Console.WriteLine("\n<<< Selecciona el código de la carrera elegida >>>");
  Console.WriteLine($"\n1. {carrera1}\n2. {carrera2}\n3. {carrera3}\n\r");
  readResult = Console.ReadLine();
  if (readResult != null)
  {
    codigoCarrera = readResult;
  }

  switch (codigoCarrera)
  {
    case "1":
      Console.WriteLine($"\n<<<<< Constancia de inscripción >>>>>:");
      Console.WriteLine($"\nAlumno: {nombre} {apellido}\nCorreo electrónico: {email}");
      Console.WriteLine($"{carrera1}");
      break;
    case "2":
      Console.WriteLine($"\n<<<<< Constancia de inscripción >>>>>:");
      Console.WriteLine($"\nAlumno: {nombre} {apellido}\nCorreo electrónico: {email}");
      Console.WriteLine($"{carrera2}");
      break;
    case "3":
      Console.WriteLine($"\n<<<<< Constancia de inscripción >>>>>:");
      Console.WriteLine($"\nAlumno: {nombre} {apellido}\nCorreo electrónico: {email}");
      Console.WriteLine($"{carrera3}");
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

