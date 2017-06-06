using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3
{
    class Author
    {
        readonly string name;
        //public Author();
        public Author(string name){
        this.name = name;
        }

        public void Show(){
            Console.WriteLine(name);
        }
    }
    

   
}
