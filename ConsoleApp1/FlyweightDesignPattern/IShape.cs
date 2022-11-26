using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.FlyweightDesignPattern
{
    interface IShape
    {
        void Draw(int x, int y, int height, int width, int font, string label);
    }
}
