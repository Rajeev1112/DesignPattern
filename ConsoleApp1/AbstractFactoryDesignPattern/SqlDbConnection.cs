using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.AbstractFactoryDesignPattern
{
    class SqlDbConnection : IConnection
    {
        public string GetConnection()
        {
            return "SQL connection";
        }
    }
}
