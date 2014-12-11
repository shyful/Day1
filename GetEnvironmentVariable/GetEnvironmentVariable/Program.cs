using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace GetEnvironmentVariable
{
    class Program
    {
   
    public static void Main() 
    {
       Console.WriteLine();
       Console.WriteLine("GetEnvironmentVariables: ");
       foreach (DictionaryEntry de in Environment.GetEnvironmentVariables()) 
           Console.WriteLine("  {0} = {1}", de.Key, de.Value);
    }
}
    }

