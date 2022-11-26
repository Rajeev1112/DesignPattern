using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.AbstractFactoryDesignPattern
{
    class Client
    {
        public void Execute()
        {
            IDatabase db = new SqlDatabase();
            ICommand sqlCommand = db.CreateCommand();
            IConnection sqlConnection = db.CreateConnection();

            Console.WriteLine(sqlCommand.GetDbCommand());
            Console.WriteLine(sqlConnection.GetConnection());

        }
        
    }
}
