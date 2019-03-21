using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_1_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.White;
            int start = 1;
            int finish = 50;
            while (start <= finish)
            {
                Console.WriteLine(start);
                start++;
            }
            Console.ReadLine();




        }

    }

}