using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoubleNestedLoops2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2D Arrays
            //Double Nested Loops

            Console.WriteLine("Double Nested Loops");
            Console.WriteLine();

            //make a loops inside of another loop
            //1-10
            //1-10
            //inside of inner loop,
            //
            for (int i = 0; i <= 9; i++) // i = starts first, k would finish , then j loop and then i loop
            {
                for (int j = 0; j <= 9; j++)
                {
                    for (int k = 0; k <= 9; k++)
                    {
                        Console.WriteLine(i + "" + j + "" + k);
                    }
                }
            }

            //(i = i + 1) = i++ same for j & k

            Console.WriteLine();
            Console.ReadKey(true);
        }
    }
}
