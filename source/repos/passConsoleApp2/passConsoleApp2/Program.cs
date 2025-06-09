using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace passConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b,c;
                  Console.WriteLine("Enter a fist number");
              a = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("Enter a second Number");
              b = Convert.ToInt32(Console.ReadLine());
                  Console.WriteLine("Enter a third Number");
              c = Convert.ToInt32(Console.ReadLine());

               if (a > b && a > c)
            {


                Console.WriteLine(a + "is greatest");
            }
               else if (b > a && b > c)
            {
                Console.WriteLine(b + "is greatest");
            }
               else
            {
                Console.WriteLine(c + "is grastest");
            }
               Console.WriteLine("press any key to continue");
               Console.ReadLine();
        }
    }
}
