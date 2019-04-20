using Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace WaitressTerminal
{
    public class ConnectionHandler
    {
        private MyService _service;
        public void CreateConnection()
        {
            //RemotingConfiguration.Configure("Client.exe.config");
            RemotingConfiguration.RegisterWellKnownClientType(
                typeof(MyService),
                "tcp://localhost:33000/MyServiceUri");

            _service = new Server.MyService();
        }

        public string InvokeFunc1()
        {
            return _service.func1();
        }

    }
}
