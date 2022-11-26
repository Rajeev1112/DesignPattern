using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.AbstractFactoryDesignPattern
{
    interface IDatabase
    {
        ICommand CreateCommand();
        IConnection CreateConnection();
    }
}
