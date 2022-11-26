using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.AbstractFactoryDesignPattern
{
    class ODBCDatabase : IDatabase
    {
        public ICommand CreateCommand()
        {
            return new ODBCCommand();
        }

        public IConnection CreateConnection()
        {
            return new ODBCConnection();
        }
    }
}
