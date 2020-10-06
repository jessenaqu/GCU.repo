using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double number = 1234.56;
                double bankBalance = 2345.0;
                Console.WriteLine("This is my weight: " + string.Format("{0:0.000}", number) + " on Earth");
                Console.WriteLine("This is my weight: " + string.Format("{0:#, 0.000}", number) + " on Earth");
                Console.WriteLine(number.ToString("{0:#, 0.000}"));
                //Console.WriteLine("Your account balance is {0:C2} or {1:0.000).", number, bankBalance);

            }


            //Console.WriteLine("Enter a number: ");
            //var num = int.Parse(Console.ReadLine());
            //Console.WriteLine($"Square of {num} is {num * num}");

            //int result = 100 / num;
            //Console.WriteLine("100 / {0} = {1}", num, result);
            //    //Console.ReadLine();
            //}


            //catch(DivideByZeroException exp)
            //{
            //    Console.WriteLine("Cannot divide by zero.");
            //}

            //catch(Exception exp)
            //{
            //    Console.WriteLine("Exception is: " + exp.Message);
            //    Console.WriteLine("An int must be entered");
            //    Console.WriteLine("Retry with a different number");
            //}

            finally
            {
                Console.ReadLine();
            }
        }


    }
}
