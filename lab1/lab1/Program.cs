using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("N=");
            string s = Console.ReadLine();
            int size = int.Parse(s);
            long el;
            Console.WriteLine(size);

            long[,] a = new long[size,size];
            for (int i = 0; i < size; i++)
                for (int j = 0; j < size; j++)
                {
                    Console.Write("el" + i + j + "= ");
                    el = Convert.ToInt32(Console.ReadLine());
                    a[i,j] = el;
                }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("\n");
                for (int j = 0; j < size; j++)
                    Console.Write(a[i, j] + "   ");
            }
            

            Console.ReadKey();
        }
    }
}
