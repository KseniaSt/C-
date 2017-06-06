using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    class MyArray
    {
        int[] array;

        public MyArray(int n)
        {
            array = new int[Math.Abs(n)];
            Random random = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(0, 40);
                Console.WriteLine(array[i]);
            }

        }

        public void MinMaxElement()
        {
            int min = array[0];
            int max = array[0];
            for(int i = 0 ; i < array.Length; i++)
            {
                min = Math.Min(min, array[i]);
                max = Math.Max(max, array[i]);
            }

            Console.WriteLine("min el = {0} max el = {1}", min, max);
        }

        public int Sum()
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
            {
                sum += array[i];
            }

            Console.WriteLine(sum);
            return sum;
        }

        public void SA()
        {
            Console.WriteLine("среднее = {0}", Sum() / array.Length);
        }

        public void Nch()
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 != 0) Console.WriteLine(array[i]);

            }
        }
    }
}
