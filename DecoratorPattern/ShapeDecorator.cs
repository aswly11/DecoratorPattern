using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public abstract class ShapeDecorator : IShape
    {
        public IShape Shape { get; set; }
        protected ShapeDecorator(IShape shape )
        {
            Shape = shape;
        }

        public virtual void Draw()
        {
            Shape.Draw();
        }
    }
}
