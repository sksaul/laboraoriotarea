using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Ingrese un número entero positivo:");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero < 0)
        {
            Console.WriteLine("Error: El número debe ser un entero positivo.");
            return;
        }

      
        if (numero >= 100 && numero <= 999)
        {
            Console.WriteLine("El número tiene 3 dígitos.");
        }
        else if (numero >= 10 && numero < 100)
        {
            Console.WriteLine("El número tiene 2 dígitos.");
        }
        else if (numero >= 1 && numero < 10)
        {
            Console.WriteLine("El número tiene 1 dígito.");
        }
        else if (numero == 0)
        {
            Console.WriteLine("Error: El número no puede ser cero.");
        }
        else
        {
            Console.WriteLine("Error: El número debe ser de hasta tres dígitos.");
        }
    }
}
