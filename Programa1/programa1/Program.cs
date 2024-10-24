using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Ingrese el valor del lado del cuadrado:");
        double lado = Convert.ToDouble(Console.ReadLine());

        double perimetro = 4 * lado;
        
        Console.WriteLine($"El perímetro del cuadrado es: {perimetro}");
    }
}
