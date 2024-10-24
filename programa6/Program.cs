using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Ingrese el sueldo del empleado:");
        double sueldo = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Ingrese los años de antigüedad:");
        int antiguedad = Convert.ToInt32(Console.ReadLine());

        if (sueldo < 500)
        {
            if (antiguedad >= 10)
            {
                sueldo *= 1.20; 
            }
            else
            {
                sueldo *= 1.05; 
            }
        }

        
        Console.WriteLine("El sueldo a pagar es: " + sueldo);
    }
}

