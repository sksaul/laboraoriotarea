using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Ingrese la coordenada x:");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese la coordenada y:");
        int y = Convert.ToInt32(Console.ReadLine());


        if (x > 0 && y > 0)
        {
            Console.WriteLine("El punto está en el 1º cuadrante.");
        }
        else if (x < 0 && y > 0)
        {
            Console.WriteLine("El punto está en el 2º cuadrante.");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("El punto está en el 3º cuadrante.");
        }
        else
        {
            Console.WriteLine("El punto está en el 4º cuadrante.");
        }
    }
}

