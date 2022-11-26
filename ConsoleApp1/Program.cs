using ConsoleApp1.Visitor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp1.StateDesignPattern;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {


            BuilderDesignPattern.Client client = new BuilderDesignPattern.Client();
            client.Execute();

            Console.ReadLine();

        }

    }


}
