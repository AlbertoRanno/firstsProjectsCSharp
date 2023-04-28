/* Proyecto de código 2: escritura de código que valida la entrada de cadena

Estas son las condiciones que el segundo proyecto de codificación debe implementar:

La solución debe incluir una iteración do-while o while.

Antes del bloque de iteración, la solución debe usar una instrucción Console.WriteLine() para solicitar al usuario uno de los tres nombres de rol: Administrador, Director o Usuario.

Dentro del bloque de iteración:

La solución debe usar una instrucción Console.ReadLine() para obtener la entrada del usuario.
La solución debe garantizar que el valor especificado coincide con una de las tres opciones de rol.
La solución debe usar el método Trim() en el valor de entrada para omitir los caracteres de espacio iniciales y de entrenamiento.
La solución debe usar el método ToLower() en el valor de entrada para omitir el caso.
Si el valor especificado no coincide con una de las opciones de rol, el código debe usar una instrucción Console.WriteLine() para solicitar al usuario una entrada válida.
Debajo (después) del bloque de código de iteración, la solución debe usar una instrucción Console.WriteLine() para informar al usuario de que se ha aceptado su valor de entrada.

La salida de la consola de este ejemplo debe ser similar a la siguiente:

Enter your role name (Administrator, Manager, or User)
Admin
The role name that you entered, "Admin" is not valid. Enter your role name (Administrator, Manager, or User)
   Administrator
Your input value (Administrator) has been accepted.
*/

string? readResult;
string valueEntered = "";
bool validRole = false;

Console.WriteLine($"Enter your role name (Administrator, Manager, or User)");

do
{
  readResult = Console.ReadLine();
  if (readResult != null)
    valueEntered = readResult.ToLower().Trim();
  if ((valueEntered == "administrator") || (valueEntered == "manager") || (valueEntered == "user"))
  {
    validRole = true;
  }
  else
    Console.WriteLine($"The role name that you entered, \"{valueEntered}\" is not valid.\nEnter your role name (Administrator, Manager, or User)");
} while (validRole == false);

Console.WriteLine($"Your input value {valueEntered} has been accepted.");