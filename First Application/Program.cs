using System;

namespace FirstApplication
{
    class Program
        {
            static void Main(string[] args)
            {
            //Console.WriteLine("Hello World !");
            //Console.WriteLine("Press any key to continue...");
            //Console.ReadKey();
            Console.WriteLine("Podaj wysokość...");
            var a = Console.ReadLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            Console.WriteLine("Podaj podstawę...");
            var b = Console.ReadLine();
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
            var c =  Convert.ToInt32 (a) * Convert.ToInt32(b);

            Console.WriteLine($"Pole prostokąta to {c} ");
            Console.ReadKey();
        }


        }

}