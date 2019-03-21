using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            /*task 3 ...*/
            Console.Write("Please enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for(int i = 0; i<= num; i++)
            {
                if (i != 0 & i % 2 == 0)
                    Console.WriteLine(i);
            }
            Console.WriteLine("...Task 3 complete,press ENTER to continue...");
            Console.ReadLine();
        }
    }
}
