using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp1.ProxyDesignPattern
{
    interface IInternetGateway
    {
        HttpResponse Accept(HttpRequest request);
    }
}
