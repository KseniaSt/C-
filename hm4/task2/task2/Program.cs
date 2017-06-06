using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    abstract class Program
    {
        static void Main(string[] args)
        {
            Redactor redactor = new Redactor();
            redactor.ChooseFile("cawdasx.txt");
            redactor.Open();
            redactor.Save();
            Console.ReadKey();
        }
    }
}
