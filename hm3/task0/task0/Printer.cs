using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task0
{
    class Printer
    {
        protected ConsoleColor color;

        public Printer(ConsoleColor color){
            this.color = color;
        }
       public virtual void Print(string text){ 
            Console.ForegroundColor = color;
          //  Console.WriteLine("red цвет текста");
            Console.WriteLine(text);}
    }

}
