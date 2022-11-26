using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BuilderDesignPattern
{
    class CivilEngineer
    {
        private House house = new House();
        public House ConstructHouse(IHouseBuilder houseBuilder)
        {
            houseBuilder.SetHouse(house);
            houseBuilder.BuildBasement();
            houseBuilder.BuildStructure();
            houseBuilder.BuildRoof();
            houseBuilder.BuildInterior();
            return house;
        }
    }
}
