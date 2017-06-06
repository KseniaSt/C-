using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Content
    {
        string text;
        //public Content(){};
        public Content(string text)
        {
            this.text = text;
        }

        public void Show()
        {
            Console.WriteLine(text);
        }
    }
}
