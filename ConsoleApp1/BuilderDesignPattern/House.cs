using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BuilderDesignPattern
{
    class House
    {
        private string basement;
        private string structure;
        private string roof;
        private string interior;

        public void SetBasement(string part)
        {
            basement = part;
        }

        public void SetStructure(string part)
        {
            structure = part;
        }

        public void SetRoof(string part)
        {
            roof = part;
        }

        public void SetInterior(string part)
        {
            interior = part;
        }

        public override string ToString()
        {
            return $"House is ready : {basement} -> {structure} -> {roof} -> {interior}";
        }
    }
}
