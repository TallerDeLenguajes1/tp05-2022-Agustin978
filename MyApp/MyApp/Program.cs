// See https://aka.ms/new-console-template for more information
//using System.Math;

Console.WriteLine("Hello, World!");
Console.WriteLine("Ingrese el numero que desea invertir");
//int num = Console.ReadLine();
char[] numero = Console.ReadLine().ToCharArray();
Array.Reverse(numero);
string num = new string(numero);

if (!string.IsNullOrEmpty(num))
{
    Console.WriteLine("El numero invertido es: " + num);
}else
{
    Console.WriteLine("No se ingreso ningun numero a invertir :v");
}



//int numero = 122;
//Console.WriteLine("Usted escribio "+texto+" y el numero es: "+numero);

