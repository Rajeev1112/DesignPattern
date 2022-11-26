using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.FlyweightDesignPattern
{
    class Client
    {
        public void Execute()
        {
            for (int i = 1; i <= 10; i++)
            {
                IShape shape1 = ShapeFactory.GetShape("C");
                shape1.Draw(1, 2, 3, 4, 6, $"C{i}");
                IShape shape2 = ShapeFactory.GetShape("R");
                shape2.Draw(1, 2, 3, 4, 6, $"R{i}");
            }
           
        }
    }
}
