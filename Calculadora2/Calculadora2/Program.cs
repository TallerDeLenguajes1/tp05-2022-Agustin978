// See https://aka.ms/new-console-template for more information
using static System.Math;

Console.WriteLine("Hello, World!");

Console.WriteLine("Ingreasar el numero sobre el cual se realizaran las operaciones:");
float num = float.Parse(Console.ReadLine());

Console.WriteLine("Valor absoluto de "+num+": "+absoluto(num));
Console.WriteLine("Cuadrado del numero " + num + ": " + cuadrado(num));
Console.WriteLine("Raiz del numero "+num+": "+raiz(num));
Console.WriteLine("Seno de "+num+": "+seno(num));
Console.WriteLine("Coseno de "+num+": "+cos(num));
Console.WriteLine("Parte entera de "+num+": "+partEntera(num));

float absoluto(float num) => Math.Abs(num);
float cuadrado(float num) => (float)Math.Pow(num,2);

float raiz(float num)
{
    if(num < 0)
    {
        return (float)Math.Sqrt(absoluto(num));
    }
    return (float)Math.Sqrt(num);
    
}

float seno(float num) => (float)Math.Asin(num);
float cos(float num) => (float)Math.Acos(num);
int partEntera(float num) => (int)Math.Truncate(num);


