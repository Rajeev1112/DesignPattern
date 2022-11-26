using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BuilderDesignPattern
{
    class WoodenHouseBuilder : IHouseBuilder
    {
        private House _house;

        public void SetHouse(House house)
        {
            _house = house;
        }

        public void BuildBasement()
        {
            _house.SetBasement("Wooden Basement");
        }

        public void BuildInterior()
        {
            _house.SetInterior("Wooden Interior");
        }

        public void BuildRoof()
        {
            _house.SetRoof("Wooden Roof");
        }

        public void BuildStructure()
        {
            _house.SetStructure("Wooden Structure");
        }

       
    }
}
