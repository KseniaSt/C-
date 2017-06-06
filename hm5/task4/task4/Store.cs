using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Store
    {
        private Article[] arc;
        public Store (int n)
        {
            arc = new Article[n];
        }


        public string this[int index]
    {
            get 
        {
            if (index <= 0 || index > arc.Length)
                return "error";
            else retrurn arc[index].ConsoleKeyInfo*
        }

    }

    }
}
