using System;

class Program
{
    static void Main(string[] args)
    {
       
        Console.WriteLine("Ingrese la cantidad total de preguntas:");
        int totalPreguntas = Convert.ToInt32(Console.ReadLine());

       
        Console.WriteLine("Ingrese la cantidad de respuestas correctas:");
        int correctas = Convert.ToInt32(Console.ReadLine());

        
        double porcentaje = (correctas * 100.0) / totalPreguntas;

       
        if (porcentaje >= 90)
        {
            Console.WriteLine("Nivel: Máximo");
        }
        else if (porcentaje >= 75)
        {
            Console.WriteLine("Nivel: Medio");
        }
        else if (porcentaje >= 50)
        {
            Console.WriteLine("Nivel: Regular");
        }
        else
        {
            Console.WriteLine("Nivel: Fuera de nivel");
        }

        Console.WriteLine("Porcentaje de respuestas correctas: " + porcentaje + "%");
    }
}

