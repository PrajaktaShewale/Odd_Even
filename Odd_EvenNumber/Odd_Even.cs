using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_EvenNumber
{
    internal class Odd_Even
    {
        public void OddEve()
        {
            int n=Convert.ToInt32(Console.ReadLine());
            if ( n % 2 == 0)
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }
        }
    }
}
