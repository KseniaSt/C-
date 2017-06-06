using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class XMLHandler : AbstractHandler
    {
        public XMLHandler (string filename): base(filename)
        { }
        public override void Save()
        {
            Console.WriteLine("xml save");
        }
    }
}
