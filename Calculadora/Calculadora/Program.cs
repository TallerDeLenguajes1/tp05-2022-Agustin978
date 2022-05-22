// See https://aka.ms/new-console-template for more information


Console.WriteLine("Ingrese los numeros para realizar las operaciones:\n");
Console.WriteLine("Numero 1: ");
float a = int.Parse(Console.ReadLine());
Console.WriteLine("Numero 2: ");
float b = int.Parse(Console.ReadLine());

Console.WriteLine(a + " + " + b + " = " + suma(a, b));
Console.WriteLine(a + " - " + b + " = " + resta(a, b));
Console.WriteLine(a + " * " + b + " = " + producto(a, b));
Console.WriteLine(a + " / " + b + " = " + cociente(a, b));


float suma(float a, float b) => a + b;

float resta(float a, float b) => a - b;

float cociente(float a, float b)
{
    if (b != 0)
    {
        return a / b;
    }
    else
    {
        Console.WriteLine("Error.. no se puede dividir en 0. Intente nuevamente");
        return 0;
    }
}

float producto(float a, float b) => a * b;
