using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp1.ProxyDesignPattern
{
    class PICInternetGatewayProxy : IInternetGateway
    {
        public PICInternetGateway picInternetGateway { get; set; }
        
        public HttpResponse Accept(HttpRequest request)
        {
            return picInternetGateway.Accept(request);
        }
    }
}
