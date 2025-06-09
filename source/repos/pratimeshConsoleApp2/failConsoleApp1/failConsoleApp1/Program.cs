using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace failConsoleApp1
{
    internal class isprime
    {
        static void Main(string[] args)
        {
            int i,n,flag,r;
            Console.WriteLine("entar a number");
            n=Convert.ToInt32(Console.ReadLine());
            flag=1;
            for(i=2;i<=n;i++)
            {
                r=n%i;
                if(r==0)
                {
                    flag=0;
                    break;
                }
            }
            if(flag==1)
            {
                Console.WriteLine("given Number is prime");
            }
            else
            {
                Console.WriteLine("Given number is not a prime");
            }
            Console.ReadKey();
        }
    }
}
