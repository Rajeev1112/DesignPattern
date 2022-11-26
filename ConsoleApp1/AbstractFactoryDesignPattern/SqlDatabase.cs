using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.AbstractFactoryDesignPattern
{
    class SqlDatabase : IDatabase
    {
        public ICommand CreateCommand()
        {
            return new SqlDbCommand();
        }

        public IConnection CreateConnection()
        {
            return new SqlDbConnection();
        }
    }
}
