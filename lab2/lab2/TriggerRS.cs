using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class TriggerRS : Trigger
    {
        public TriggerRS()
        {
            name = "RS-TRIGGER";
            input1 = false;
            input2 = false;
            output = false;
        }

        public void GiveToRinput()
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
                }
            }
        }

        public void RemoveFromRinput()
        {
            input2 = false;
        }
    }


}
