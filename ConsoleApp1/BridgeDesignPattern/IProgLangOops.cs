using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BridgeDesignPattern
{
    interface IProgLangOops
    {
        IProgParadigm ProgParadigm { get; set; }

        string GetName();
    }
}
