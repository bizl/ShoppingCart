﻿using MyCompany.Cart.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace MyCompany.Cart.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(x =>
            {
                //Use IoC to instantiate types and start server 

                x.Service<BasketServer>(s =>
                {
                    s.ConstructUsing(name => new BasketServer());
                    s.WhenStarted(tc => tc.Start());
                    s.WhenStopped(tc => tc.Stop());
                });

                x.RunAsLocalSystem();

                const string display = "Basket Service Started";
                x.SetDescription(display);
                x.SetDisplayName(display);
                x.SetServiceName(display);
            });
        }
    }
}
