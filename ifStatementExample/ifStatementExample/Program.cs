using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifStatementExample
{
    class Program
    {
        static void Main(string[] args)
        {
            if (20 > 18)
            {
                Console.WriteLine("If 20 is > 18.");
            }


            int x = 20;
            int y = 18;
            if (x > y)
            {
                Console.WriteLine("If x is > y.");
            }


            int time = 20;
            if (time < 18) 
            {
                Console.WriteLine("Good day.");
            }
            else 
            {
                Console.WriteLine("Good evening.");
            }


            time = 22;
            if (time < 10)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time < 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening.");
            }


            time = 25;
            if (time == 30)
            {
                Console.WriteLine("Good morning.");
            }
            else if (time > 20)
            {
                Console.WriteLine("Good day.");
            }
            else
            {
                Console.WriteLine("Good evening");
            }


            //==========================================
            //  Prints all out instead of one by one
            //==========================================
            Console.ReadLine();
        }
    }
}
