using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rgument_and_No_Return_Type
{
    internal class Program
    {
        static void Main(string[] args)
        {
            {
                // Call the Sum function with arguments
                Sum(10, 20);
                Console.ReadKey();
            }

            // Function with arguments and no return type
             void Sum(int a, int b)
            {
                int sum = a + b;
                Console.WriteLine($"Sum of {a} and {b} is {sum}");
            }
        }
    }
}
