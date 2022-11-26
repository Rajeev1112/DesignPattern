using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.FlyweightDesignPattern
{
    class Circle : IShape
    {

        public Circle()
        {
            Console.WriteLine("<<Circle Object created>>");
        }
        public void Draw(int x, int y, int height, int width, int font, string label)
        {
            Console.WriteLine($"Circle drawn with label : {label}");
        }
    }
}
