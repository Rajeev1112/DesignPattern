using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BridgeDesignPattern
{
    class Heterogeneous : IProgParadigm
    {
        private List<IProgParadigm> paradigms = new List<IProgParadigm>();
        public string GetParadigm()
        {
            return "Heterogeneous";
        }

        public void AddParadigm(IProgParadigm paradigm)
        {
            paradigms.Add(paradigm);
        }

        public void RemoveParadigm(IProgParadigm paradigm)
        {
            paradigms.Remove(paradigm);
        }
    }
}
