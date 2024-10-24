using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Múltiplos de 8 hasta 500:");

        for (int i = 1; i * 8 <= 500; i++)
        {
            if (i == 62) 
            {
                Console.Write(i * 8);
            }
            else
            {
                Console.Write(i * 8 + " - ");
            }
        }

        Console.WriteLine();
    }
}
