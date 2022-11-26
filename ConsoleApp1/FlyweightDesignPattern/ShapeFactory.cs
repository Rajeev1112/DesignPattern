using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.FlyweightDesignPattern
{
    class ShapeFactory
    {
        private static Dictionary<string, IShape> shapes = new Dictionary<string, IShape>();

        public static IShape GetShape(string label)
        {
            if (shapes.ContainsKey(label))
                return shapes[label];

            IShape shape;

            switch (label)
            {
                case "R":
                    shape = new Rectangle();
                    shapes.Add("R", shape);
                    break;
                default:
                    shape = new Circle();
                    shapes.Add("C", shape);
                    break;
            }

            return shape;
        }
    }
}
