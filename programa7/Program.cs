using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("¿Cuántos números enteros desea ingresar?");
        int n = Convert.ToInt32(Console.ReadLine());

        int pares = 0; 
        int impares = 0;

        
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Ingrese el número {i + 1}:");
            int numero = Convert.ToInt32(Console.ReadLine());

            if (numero % 2 == 0)
            {
                pares++; 
            }
            else
            {
                impares++; 
            }
        }

 
        Console.WriteLine($"Cantidad de números pares: {pares}");
        Console.WriteLine($"Cantidad de números impares: {impares}");
    }
}
