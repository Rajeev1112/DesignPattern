using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BuilderDesignPattern
{
    class Client
    {
        

        public void Execute()
        {
            CivilEngineer _civilEngineer = new CivilEngineer();
            IHouseBuilder houseBuilder = new WoodenHouseBuilder();
            var house = _civilEngineer.ConstructHouse(houseBuilder);

            Console.WriteLine(house.ToString());
        }
    }
}
