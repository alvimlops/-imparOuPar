using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parOUimpra
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("entre com um numero : ");
            int n = int.Parse(Console.ReadLine());
           if ( n % 2 == 0)
            {
                Console.WriteLine("e par");
            }
          
            else
            {
                Console.WriteLine("e impar");
            }
               
                  
            
        }
    }
}
