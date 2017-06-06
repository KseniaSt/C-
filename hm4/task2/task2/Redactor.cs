using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    class Redactor
    {
        AbstractHandler handler;

      //  public Redactor();
        public void ChooseFile(string fileName)
        {
            string format = fileName.Substring(fileName.Length - 4);
            switch(format)
            {
                case ".txt": handler = new TXTHandler(fileName);
                    break;
                case ".doc": handler = new DOCHandler(fileName);
                    break;
                case ".xml": handler = new DOCHandler(fileName);
                    break;
            }
        }

       public void Open()
        {
            handler.Open();
        }

        public void Save()
       {
           handler.Save();
       }
    }
}
