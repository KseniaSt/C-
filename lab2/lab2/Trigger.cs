using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    abstract class Trigger
    {
        protected string name;
        protected bool input1;
        protected bool input2;
        protected bool output;

        public string GetName
        {
            get
            {
                return name;
            }
        }

    }
}
