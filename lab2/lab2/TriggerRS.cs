using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class TriggerRS : Trigger
    {
        private bool prohibited;
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
                    prohibited = true;
                }
            }
        }
        public void RemoveFromRinput()
        {
            input2 = false;
            if (prohibited)
            {
                prohibited = false;
                output = true;
            }
        }


        public void GiveToSinput()
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
                    prohibited = true;
                }
            }
        }
        public void RemoveFromSinput()
        {
            input1 = false;
            if (prohibited)
            {
                prohibited = false;
                output = false;
            }
        }


        public void ShowState()
        {
            Console.WriteLine(this.ToString());
        }
        public override string ToString() 
        {
            string result = null;

            result += string.Format("Trigger type: {0}\n", this.GetName);
            if (prohibited)
                result += string.Format("Trigger state:\nR input:{0}\nS input:{1}\n Output:this is prohibited trigger state . .",
                    Convert.ToByte(input2), Convert.ToByte(input1));
            else
                result += string.Format("Trigger state:\nR input:{0}\nS input:{1}\n Output:{2}",
                    Convert.ToByte(input2), Convert.ToByte(input1), Convert.ToByte(output));
            return result;
        }


    }


}
