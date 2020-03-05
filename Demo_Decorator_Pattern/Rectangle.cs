using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Decorator_Pattern
{
    public class Rectangle : IShape
    {
        public void draw()
        {
            Console.WriteLine("Shape: Rectangle");
        }
    }
}
