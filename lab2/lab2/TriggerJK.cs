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

        public void ShowState()
        {
            Console.WriteLine(this.ToString());
        }
        public override string ToString()
        {
            string result = null;
            result += string.Format("Trigger type: {0}\n", this.GetName);
            result += string.Format("Trigger state:\nJ input:{0}\nK input:{1}\n Output:{2}",
                    Convert.ToByte(input1), Convert.ToByte(input2), Convert.ToByte(output));
            return result;
        }
        public override int GetHashCode()
        {
            return input1.GetHashCode() ^ input2.GetHashCode();
        }
        public override bool Equals(System.Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            TriggerJK p = obj as TriggerJK;
            if ((System.Object)p == null)
            {
                return false;
            }
            return (input1 == p.input1) && (input2 == p.input2);
        }


        public static TriggerJK operator +( TriggerJK obj1,  TriggerJK obj2)
        {
            TriggerJK tr = new TriggerJK();
            Console.WriteLine("8787654567890-9876543567890");
            tr.input1 = (obj1.input1 && obj2.input1);    // 0 0
            tr.input2 = (obj1.input2 && obj2.input2);    // 1 0 
            Console.WriteLine(tr.input1 + " " + tr.input2);
            return tr;
        }
    }
}
