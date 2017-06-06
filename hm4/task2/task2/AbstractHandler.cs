using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    abstract class AbstractHandler
    {
        protected string filename;

        public AbstractHandler(string filename)
        {
            this.filename = filename;
        }

        public void Open()
        {
            Console.WriteLine("Документ открыт.");
        }
        public void Create()
        {
            Console.WriteLine("Документ созда.");
        }
        public void Change()
        {
            Console.WriteLine("Документ отредактирован.");
        }
        public abstract void Save();     
    }
}
