using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationofTwoNo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insert Number1:");
            int number1=Convert.ToInt32(Console.ReadLine());
            Console.Write("Insert Number2:");
            int number2 = Convert.ToInt32(Console.ReadLine()); ;
            Console.WriteLine("Addition :{0}, subtraction: {1}, division: {2}, multiplication:{3} ",number1+number2,number1-number2,number1/number2,number1*number2);
            Console.ReadLine();

        }
    }
}
