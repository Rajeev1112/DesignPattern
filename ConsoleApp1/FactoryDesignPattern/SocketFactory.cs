using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.FactoryDesignPattern
{
    class SocketFactory
    {
        public static ISocket Create(string type)
        {
            ISocket socket;

            switch (type)
            {
                case "tcp":
                    socket = new TcpSocket();
                    break;
                case "http":
                    socket = new HttpSocket();
                    break;
                default:
                    socket = new WebSocket();
                    break;

            }

            return socket;
        }
    }
}
