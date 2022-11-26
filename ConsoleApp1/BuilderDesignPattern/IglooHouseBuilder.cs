using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BuilderDesignPattern
{
    class IglooHouseBuilder : IHouseBuilder
    {
        private House _house;
        public void SetHouse(House house)
        {
            _house = house;
        }

        public void BuildBasement()
        {
            _house.SetBasement("Ice Basement");
        }

        public void BuildInterior()
        {
            _house.SetInterior("Ice Interior");
        }

        public void BuildRoof()
        {
            _house.SetRoof("Ice Roof");
        }

        public void BuildStructure()
        {
            _house.SetStructure("Ice Structure");
        }

       
    }
}
