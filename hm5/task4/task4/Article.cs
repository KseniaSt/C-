using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task4
{
    class Article
    {
        public string name{ set; get;}
        public string store { get; set; }
        public int price
        {
            set
            {
                if (value <= 0) 
                    Console.WriteLine("----");
                else price = value;
            }
            get
            {
                return price;
            }
        }

        public void Info()
        {
            Console.WriteLine("sda", name, store, price);
        }
    }
}
