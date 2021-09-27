using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_3
{
    class Program
    {

        static int count = 0;
        static void Loop()
        {
            count = count + 1;
            Console.WriteLine("This is Loop: " + count);
            Loop();
        }
        
        static void Main(string[] args)
        {
            Loop();

            Console.ReadKey(true);
        }
    }
}
