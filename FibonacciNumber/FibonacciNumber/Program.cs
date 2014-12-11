using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciNumber
{
    class Program
    {
        static void Main(string[] args)
        {
           // int f1 = 0;
            //Console.WriteLine("{0}",f1);
            //f1=f1+1;
            int a = 0;
            Console.WriteLine("{0}",a);
            int b = 1;
            Console.WriteLine("{0}", b);
            for (int i = 0; i < 10; i++)
            {
               int c = a + b;
              
                a = b;
                b = c;
                if (c<100)
                {
                    Console.WriteLine("{0}", c);
                }
                else
                {
                    break;
                }
            }
        }
    }
}
