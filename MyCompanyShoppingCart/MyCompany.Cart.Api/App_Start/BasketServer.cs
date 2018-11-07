using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompany.Cart.Api
{ 
    public class BasketServer
    {
        public event EventHandler Notified;

        private IDisposable _server;

        string _baseAddress = "http://localhost:7793";

        public void Start()
        {
            _server = WebApp.Start<Startup>(url: _baseAddress);

            Notify($"Server running at {_baseAddress}");
        }

        public void Stop()
        {
            Notify("Server shutting down");
        }

        private void Notify(string message)
        {
            Console.WriteLine(message); 
        }
    }
}
