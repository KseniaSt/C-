using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task0
{
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User("decv", "cafcd", "fcdsw", 15);
            user.Show();
            Console.ReadKey();
        }
        
    }
}
