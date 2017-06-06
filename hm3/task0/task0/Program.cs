using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task0
{
    class Program
    {
        static void Main(string[] args)
        {
            ColorPrinter cp = new ColorPrinter (ConsoleColor.Green);
            cp.Print("caed");
            Console.ReadKey();
        }
    }

}
