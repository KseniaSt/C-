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
            int el, minindex, min, temp;
            Console.WriteLine(size);
            
            int[,] a = new int[size,size];
            int[] d = new int[size];
            int[] v = new int[size];

            for (int i = 0; i < size; i++)
            {
                d[i] = 10000;
                v[i] = 1;
            }

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

            d[0] = 0;
            do {
		        minindex = 10000;
		        min = 10000;
		for (int i = 0; i<size; i++)
		{ // Если вершину ещё не обошли и вес меньше min
			if ((v[i] == 1) && (d[i]<min))
			{ 
				min = d[i];
				minindex = i;
			}
		}
        if (minindex != 10000)
        {
            for (int i = 0; i < size; i++)
            {
                if (a[minindex,i] > 0)
                {
                    temp = min + a[minindex,i];
                    if (temp < d[i])
                        d[i] = temp;
                }
            }
            v[minindex] = 0;
        }
            } while (minindex < 10000);
            for (int i = 0; i < size; i++)
                Console.Write(d[i]);
            Console.ReadKey();
        }
    }
    
}
