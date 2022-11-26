using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp1.ProxyDesignPattern
{
    class PICInternetGateway : IInternetGateway
    {
        public HttpResponse Accept(HttpRequest request)
        {
            throw new NotImplementedException();
        }
    }
}
