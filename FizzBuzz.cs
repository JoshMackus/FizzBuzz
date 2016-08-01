using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class FizzBuzz
    {
        static void Main()
        {
            for (int i = 0; i < 101; i++)
            {
                string val = null;

                if (i % 3 == 0)
                    val = "Fizz";
                if (i % 5 == 0)
                    val += "Buzz";

                /* Ver. 1
                //if (s == null)
                //     s = i.ToString(); 


                 Console.WriteLine(s);*/

                // Bitwise null-coalescing operator, less lines
                Console.WriteLine(val ?? i.ToString());
            }
        }
    }
}
