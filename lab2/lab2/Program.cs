using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class EnterException : Exception
    {
        public EnterException(string message)
            : base(message)
        { }
    }
    class Program
    {
        static public void InfoAdd()
        {
            Console.WriteLine("Trigger added");
        }
        static void Main(string[] args)
        {

            Register register = new Register("Test register");
            register.MyEvent += InfoAdd;
            register.AddTrig(new TriggerRS());
            register.AddTrig(new TriggerRS());
            register.AddTrig(new TriggerJK());

            register.ShowAllStates();


            TriggerJK temp2 = new TriggerJK();
            TriggerJK temp3 = new TriggerJK();
            temp3.GiveToJinput();

            /*
            bool p = temp2.Equals(temp3);
            Console.WriteLine("P = {0} ", p);
            int code1 = temp2.GetHashCode();
            int code2 = temp2.GetHashCode();
            Console.WriteLine("code 1 and 2" + code1 + " " + code2);
            */
            Console.WriteLine("+++++++++++++++++++++++++++++");
            TriggerJK temp4 = new TriggerJK();
            Console.WriteLine("ДОДАНОК 1 ");
            temp2.ShowState();

            Console.WriteLine("ДОДАНОК 2 ");

            temp4 = temp2 + temp3;
            temp4.ShowState();

            foreach (Trigger tr in register)
            {
                if (tr is TriggerRS) 
                {
                    TriggerRS temp = (TriggerRS)tr;
                    temp.GiveToSinput();
                }
                if (tr is TriggerJK)
                {
                    TriggerJK temp = (TriggerJK)tr;
                    temp.GiveToJinput();
                }
            }

            register.ShowAllStates();
            try
            {
                string TriggerName;
                Console.WriteLine("Enter name of trigger (JK or RS)");
                TriggerName = Console.ReadLine();
                if (TriggerName != "JK" && TriggerName !="RS")
            {
                throw new EnterException("There is no such trigger.");
            }
            }
            catch (EnterException ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);              
            

            
        }
            Console.ReadKey();
        }
    }
}
