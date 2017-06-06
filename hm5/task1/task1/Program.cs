using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class Program
    {
        static void Main(string[] args)
        {
            MyArray ar = new MyArray(8);
            ar.Sum();
            ar.MinMaxElement();
            ar.Nch();
            ar.SA();

            Console.ReadKey();
        }
    }
}
