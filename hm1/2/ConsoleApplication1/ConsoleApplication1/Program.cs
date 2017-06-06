using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rec = new Rectangle(3.2, 5.6);
            Console.WriteLine("per is {0} area is {1}", rec.Perimetr, rec.Perimetr);
            Console.ReadKey();
        }
    }
    class Rectangle
    {
        double side1;
        double side2;

        public Rectangle() { }
        public Rectangle(double side1, double side2){
            this.side1=side1;
            this.side2=side2;
        }

        double AreaCalc()
        {
            return side1 * side2;
        }

        double PerCalc()
        {
            return 2 * (side1 + side2);
        }

        public double Area
        {
            get { return this.AreaCalc(); }
        }
        public double Perimetr
        {
            get { return this.PerCalc(); }
        }
    }
}
