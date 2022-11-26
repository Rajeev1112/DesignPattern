using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.FactoryDesignPattern
{
    interface ISocket
    {
        void Open();
        void SendReceive();
        void Close();
    }
}
