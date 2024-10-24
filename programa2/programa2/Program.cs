using System;

class Program
{
    static void Main(string[] args)
    {

        Console.WriteLine("Ingrese el precio del artículo:");
        double precio = Convert.ToDouble(Console.ReadLine());

     
        Console.WriteLine("Ingrese la cantidad que lleva el cliente:");
        int cantidad = Convert.ToInt32(Console.ReadLine());


        double total = precio * cantidad;


        Console.WriteLine($"El total a abonar es: Q{total:F2}"); 
    }
}
