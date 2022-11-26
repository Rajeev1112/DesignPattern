using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BuilderDesignPattern
{
    interface IHouseBuilder
    {
        void SetHouse(House house);
        void BuildBasement();
        void BuildStructure();
        void BuildRoof();
        void BuildInterior();
    }
}
