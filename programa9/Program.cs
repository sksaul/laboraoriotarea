using System;

class Program
{
    static void Main(string[] args)
    {
        double suma = 0; 

        Console.WriteLine("Ingrese los valores numericos (coloca 9999 para finalizar):");

        while (true) 
        {
            double valor = Convert.ToDouble(Console.ReadLine());

            if (valor == 9999)
            {
                break; 
            }

            suma += valor;
        }

       
        Console.WriteLine("Total acumulado: " + suma);

        
        if (suma == 0)
        {
            Console.WriteLine("El valor acumulado es cero.");
        }
        else if (suma > 0)
        {
            Console.WriteLine("El valor acumulado es mayor a cero.");
        }
        else
        {
            Console.WriteLine("El valor acumulado es menor a cero.");
        }
    }
}

