using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Register
    {
        private string name;
        private List<Trigger> reg;

        public Register(string name)
        {
            this.name = name;
            reg = new List<Trigger>();
        }

       
    }
}
