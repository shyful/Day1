using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindBiggerSmallerAndEqual
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert First Input:");
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insert Second Input:");
            int number2 = Convert.ToInt32(Console.ReadLine());
            if (number1>number2)
            {
                Console.WriteLine("Large Number:{0}", number1);
                Console.WriteLine("Small Number:{0}", number2); 

            }
            else if (number1<number2)
            {
                Console.WriteLine("Small Number:{0}", number1);
                Console.WriteLine("Large Number:{0}", number2); 

            }
            else
            {
                Console.WriteLine("Equal Number:{0}", number2); 
            }
        }
    }
}
