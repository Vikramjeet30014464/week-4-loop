using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please enter a symbol to use: ");
            string symbol = Console.ReadLine();
            Console.Write("Please enter the height of the rectangle: ");
            int h = int.Parse(Console.ReadLine());
            Console.Write("Please enter the width the rectangle: ");
            int w = int.Parse(Console.ReadLine());

            for (int i = 0; i < h; i++)//deals with the height of the rectagle
            {
                for (int j = 0; j < w; j++)
                {
                    Console.Write(symbol);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n Task 3 end...");
            Console.ReadLine();


        }
    }
}
