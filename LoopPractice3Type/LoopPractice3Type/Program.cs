using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopPractice3Type
{
    public class Loop3Type
    {
        static void Main(string[] args)
        {
            /* Write a C# program to print the numbers from 1 to 10 using three different loop
             * constructs: for, while, and do-while*/

                /* print 1 to 10 using for loop*/
                Console.WriteLine("print 1 to 10 using for loop : ---->");
                for (int a = 1; a <= 10; a++)
                {
                    Console.Write(a + " ");
                }


                /* print 1 to 10 using while loop*/
                Console.WriteLine("\n\nprint 1 to 10 using while loop : ---->");
                int num = 1;
                while (num <= 10)
                {
                    Console.Write(num + " ");
                    num++;
                }


                /* print 1 to 10 using do while loop*/
                Console.WriteLine("\n\nprint 1 to 10 using do while loop : ----> ");
                num = 1;
                do
                {
                    Console.Write(num + " ");
                    num++;
                } while (num <= 10);
            Console.WriteLine("\n\n");



        }
    }
}
    

