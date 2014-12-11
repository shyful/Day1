using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IncreaseNumberThroughUser
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert Lower Number :");
            int lower = Convert.ToInt16(Console.ReadLine());
            Console.Write("Insert Upper Number :");
            int upper = Convert.ToInt32(Console.ReadLine());
            
            for (int i = lower; i <= upper; i++)
            {
                Console.WriteLine("{0}",i);
            }
        }
    }
}
