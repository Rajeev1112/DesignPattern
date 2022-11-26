﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ConsoleApp1.ProxyDesignPattern
{
    class Browser
    {
        public void Browse()
        {
            var _internetGateway = new PICInternetGatewayProxy();
            _ = _internetGateway.Accept(new HttpRequest(null,null, null));
        }
    }
}
