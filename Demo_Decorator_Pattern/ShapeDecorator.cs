using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Decorator_Pattern
{
    public class ShapeDecorator : IShape
    {
        protected IShape decoratedShape;
        public ShapeDecorator(IShape decoratedShape)
        {
            this.decoratedShape = decoratedShape;
        }
        public virtual void draw()
        {
            decoratedShape.draw();
        }
    }
}
