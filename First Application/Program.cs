using System;

namespace FirstApplication
{
    class Program
        {
            static void Main(string[] args)
            {
            //pole prostokąta
            Console.WriteLine("Pole prostokąta");
            Console.WriteLine("---------------");
            Console.WriteLine($" ");
            Console.WriteLine($" ");
            Console.WriteLine("Podaj wysokość...");
            var a = Console.ReadLine();
            Console.WriteLine("Podaj podstawę...");
            var b = Console.ReadLine();
            var c =  Convert.ToInt32 (a) * Convert.ToInt32(b);
            Console.WriteLine($"Pole prostokąta to {c} ");
            Console.ReadKey();
        }


        }

}