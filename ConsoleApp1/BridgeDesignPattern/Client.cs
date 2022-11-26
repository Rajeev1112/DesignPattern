using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.BridgeDesignPattern
{
    class Client
    {
        public void Execute()
        {
            IProgParadigm proceduralParadigm = new Procedural();
            IProgParadigm objectOrientedParadigm = new ObjectOriented();
            IProgParadigm heterogeneousParadigm = new Heterogeneous();
            ((Heterogeneous)heterogeneousParadigm).AddParadigm(proceduralParadigm);
            ((Heterogeneous)heterogeneousParadigm).AddParadigm(objectOrientedParadigm);

            IProgLangOops langC = new LangC();
            IProgLangOops langCPP = new LangCPP();
            IProgLangOops langCSharp = new LangCSharp();

            langC.ProgParadigm = proceduralParadigm;
            langCPP.ProgParadigm = heterogeneousParadigm;
            langCSharp.ProgParadigm = objectOrientedParadigm;

            Console.WriteLine($"Language C has {langC.GetName()} paradigm");
            Console.WriteLine($"Language CPP has {langCPP.GetName()} paradigm");
            Console.WriteLine($"Language C# has {langCSharp.GetName()} paradigm");

        }
        
    }
}
