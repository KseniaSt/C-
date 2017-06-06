using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();
            player.Play();
            player.Record();
            (player as IPlayeble).Stop();
            (player as IRecordable).Stop();

            Console.ReadKey();
        }
    }
}
