using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    public class RedBorderDecorator : ShapeDecorator
    {
        public RedBorderDecorator(IShape shape) : base(shape)
        {
        }
       public override void Draw()
        {
            base.Draw();
            Console.WriteLine("Draw Red Border");
        }
    }
}
