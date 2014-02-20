using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
                   
            int x = 7;
            
            Console.WriteLine("x equals {0}", x);

            x += x;
            
            Console.WriteLine("x now equals {0}", x);

            x /= x;

            Console.WriteLine("x now equals {0}", x);

            Console.WriteLine("We are so good \n at this math stuff");

            Console.WriteLine(@"This    is 
some    wierd 
text
now!    !");

            
            Console.Write(x > 9 && x < 283);


            Console.Write("\n I'm too good");

            Console.ReadLine();
            
        }
    }
}
