/*Proyecto de código 3: 
Estas son las condiciones que el tercer proyecto de codificación debe implementar:

-La solución debe usar la siguiente matriz de cadenas para representar la entrada en la lógica de codificación:

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

-La solución debe declarar una variable de enteros denominada "periodLocation" que se pueda usar para contener la ubicación del carácter de punto dentro de una cadena.

-La solución debe incluir un bucle externo foreach o for que se pueda usar para procesar cada elemento de cadena de la matriz. La variable de cadena que procesará dentro de los bucles debe denominarse "myString".

En el bucle externo, la solución debe usar el método IndexOf() de la clase String para obtener la ubicación del primer carácter de punto de la variable myString. La llamada al método debe ser similar a myString.IndexOf("."). Si no hay ningún carácter de punto en la cadena, se devolverá un valor de -1.

La solución debe incluir un bucle interno do-while o while que se pueda usar para procesar la variable myString.

En el bucle interno, la solución debe extraer y mostrar (escribir en la consola) cada frase contenida en cada una de las cadenas que se procesan.

En el bucle interno, la solución no debe mostrar el carácter de punto.

En el bucle interno, la solución debe usar los métodos Remove(), Substring() y TrimStart() para procesar la información de cadena.

Si la lógica de código funciona correctamente, la salida debe ser similar a la siguiente:

I like pizza
I like roast chicken
I like salad
I like all three of the menu choices
*/

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

string myString = "";
int periodLocation = 0;

for (int i = 0; i < myStrings.Length; i++)
{
  myString = myStrings[i];
  periodLocation = myString.IndexOf("."); // ubicación del primer punto

  string mySentence;

  // extract sentences from each string and display them one at a time
  while (periodLocation != -1) // se ejecuta mientras se encuentren puntos en la cadena
  {

    // first sentence is the string value to the left of the period location
    mySentence = myString.Remove(periodLocation); //extrae una oración de la cadena actual, hasta el primer punto

    // the remainder of myString is the string value to the right of the location
    myString = myString.Substring(periodLocation + 1); //extrae una subcadena desde el indice de inicio (periodLocation +1 )

    // remove any leading white-space from myString
    myString = myString.TrimStart(); //elimina cualquier espacio en blanco inicial

    // update the comma location and increment the counter
    periodLocation = myString.IndexOf(".");//se encuentra la ubicación del siguiente punto

    Console.WriteLine(mySentence);
  }

  // the remaining portion of speciesToListSelection is the final species name 
  mySentence = myString.Trim(); // se extrae la última oración de cada cadena (las que no tienen punto final)
  Console.WriteLine(mySentence);
}