using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    class Player : IPlayeble, IRecordable
    {
        public void Play()
        {
            Console.WriteLine("Играет");
        }

        public void Record()
        {
            Console.WriteLine("Играет");
        }
         void IPlayeble.Pause()
        {
            Console.WriteLine("Пауза проигрывания");
        }

         void IRecordable.Pause()
        {
            Console.WriteLine("Пауза записи");
        }

         void IPlayeble.Stop()
        {
            Console.WriteLine("Остновка проигрывания");
        }
         void IRecordable.Stop()
        {
            Console.WriteLine("Остановка записи");
        }
    }
}
