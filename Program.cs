using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LOOP_NUMBER
{
    class Program
    {
        static void Main(string[] args)
        {
            /*task2*/
            /*for loop*/
            Console.Clear();
            double total = 0;
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($"Please enter number {i}: ");
                total = double.Parse(Console.ReadLine());
            }
            Console.WriteLine($"Total: {total}");
            Console.WriteLine("... Task to complete, press enter to continue...");
            Console.ReadLine();



            total = 0;
            bool check = true;
            do
            {
                Console.Clear();
                Console.WriteLine("...Task 2 extension ...");
                Console.Write("Please enter a number: ");
                total = double.Parse(Console.ReadLine());
                Console.WriteLine("Would you like add another number (y/n):");
                string input = Console.ReadLine().ToLower();
                if (input == "n")
                    check = false;
            } while (check == true);
            Console.WriteLine($"Total: {total}");
            Console.WriteLine("... Task 2 extensioncomplete, press ENTER to continue...");
            Console.ReadLine();
            


        }
    }
}
