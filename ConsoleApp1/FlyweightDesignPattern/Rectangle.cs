using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.FlyweightDesignPattern
{
    class Rectangle : IShape
    {
        public Rectangle()
        {
            Console.WriteLine("<<Rectangle Object created>>");
        }

        public void Draw(int x, int y, int height, int width, int font, string label)
        {
            Console.WriteLine($"Rectangle drawn with label : {label}");
        }
    }
}
