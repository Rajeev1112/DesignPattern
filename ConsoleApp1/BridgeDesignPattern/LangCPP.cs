using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BridgeDesignPattern
{
    class LangCPP : IProgLangOops
    {
        public IProgParadigm ProgParadigm { get; set; }

        public string GetName()
        {
            return ProgParadigm.GetParadigm();
        }
    }
}
