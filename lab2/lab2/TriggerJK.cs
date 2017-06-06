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

        public void GiveToKinput()
        {
            if (!input2)
            {
                if (!input1)
                {
                    input2 = true;
                    output = false;
                }
                else
                {
                    input2 = true;
                    output = !output;
                }
            }
        }
        public void RemoveFromKinput()
        {
            if (input2)
            {
                input2 = false;
                if (input1)
                    output = true;
            }
        }
    }
}
