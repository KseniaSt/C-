using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class TXTHandler : AbstractHandler
    {
        public TXTHandler(string filename) : base(filename) 
        { 
        }

        public override void Save()
        {
            Console.WriteLine("Документ сохранен в формате txt");
        }
    }
}
