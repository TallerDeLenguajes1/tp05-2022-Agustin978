// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
Console.WriteLine("Ingrese una palabra o una frase: ");
string palabra = Console.ReadLine();
int letra = palabra.IndexOf('a');
Console.WriteLine("Posicion de la letra a: "+ letra);
Console.WriteLine("Tamanio de la palabra/frase: "+palabra.Length);
Console.WriteLine("\nIngrese una nueva palabra o frase: ");
string palabra2 = Console.ReadLine();
Console.WriteLine("Las dos frases ingresadas concatenades: " + palabra +" "+ palabra2);
Console.WriteLine("\nIngrese una nueva palabra o frase: ");
string palabra3 = Console.ReadLine();
Console.WriteLine("Ingrese a partir de que letra se debe obtener la subcadena: ");
string let = Console.ReadLine();

//int posicion = palabra3.IndexOf(let);
if(palabra3.IndexOf(let)!=0)
{
    Console.WriteLine("Obtengo la subcadena: "+palabra3.Substring(palabra3.IndexOf(let),palabra3.Length - palabra3.IndexOf(let)));
}else
{
    Console.WriteLine("La letra ingresada no se encontraba en la frase o palabra que se ingreso.");
}