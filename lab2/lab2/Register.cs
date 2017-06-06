using System;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
     public delegate void MyDelegate();

    class Register
    {
        private string name;
        private List<Trigger> reg;

        public event MyDelegate MyEvent = null;
        public Register(string name)
        {
            this.name = name;
            reg = new List<Trigger>();
        }

       

        public void AddTrig(Trigger tr)
        {
            reg.Add(tr);
            MyEvent.Invoke();
        }
        public Trigger GetTrig(int ind)
        {
            if (ind < reg.Count && ind >= 0)
                return reg[ind];
            else
                throw new Exception("Out of range in Register class collection");
        }
        public void DelTrig(int ind)
        {
            if (ind < reg.Count && ind >= 0)
                reg.Remove(reg[ind]);
            else
                throw new Exception("Out of range in Register class collection");
        }
        public void ShowAllStates()
        {
            Console.WriteLine("Register {0}:", name);
            foreach(Trigger tr in reg)
            {
                Console.WriteLine(tr.ToString());
            }
        }

        public IEnumerator GetEnumerator()
        {
            foreach (Trigger tr in reg)
            {
                yield return tr;
            }
        }

        
    }
    
}
