using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class TriggerJK : Trigger
    {
        public TriggerJK()
        {
            name = "JK-TRIGGER";
            input1 = false;
            input2 = false;
            output = false;
        }

        public void GiveToJinput()
        {
            if (!input1)
            {
                if (!input2)
                {
                    input1 = true;
                    output = true;
                }
                else
                {
                    input1 = true;
                    output = !output;
                }
            }
        }
        public void RemoveFromJinput()
        {
            if (input1)
            {
                input1 = false;
                if (input2)
                    output = false;
            }
        }
    }
}
