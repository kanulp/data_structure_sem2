using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Decorator_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IShape circle = new Circle();
            IShape redCircle = new RedShapeDecorator(new Circle());
            IShape redRectangle = new RedShapeDecorator(new Rectangle());
            Console.WriteLine("Circle with normal border");
            circle.draw();

            Console.WriteLine("\nCircle of red border");
            redCircle.draw();

            Console.WriteLine("\nRectangle of red border");
            redRectangle.draw();
        }
    }
}
