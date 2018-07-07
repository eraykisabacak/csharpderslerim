using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            islem isl = new islem();
            Console.WriteLine(isl.topla(5, 6));

            Console.WriteLine("\n\n\n");
            isl.kare(6);
            Console.ReadKey();
        }
    }
}
