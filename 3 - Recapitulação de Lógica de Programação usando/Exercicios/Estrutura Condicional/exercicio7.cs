﻿namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite a coordenada (x, y): ");
            double x = double.Parse(Console.ReadLine()!);
            double y = double.Parse(Console.ReadLine()!);

            if (x == 0 && y == 0)
                Console.WriteLine("Origem");
            else if (x == 0 && y != 0)
                Console.WriteLine("Eixo y");
            else if (x != 0 && y == 0)
                Console.WriteLine("Eixo x");
            else if (x > 0 && y > 0)
                Console.WriteLine("Q1");
            else if (x < 0 && y > 0)
                Console.WriteLine("Q2");
            else if (x < 0 && y < 0)
                Console.WriteLine("Q3");
            else if (x > 0 && y < 0)
                Console.WriteLine("Q4");
        }
    }
}