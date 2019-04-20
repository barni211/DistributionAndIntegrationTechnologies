using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class MyService : MarshalByRefObject
    {
        public MyService()
        {
            Console.WriteLine("Instance of MyService is created");
        }

        public string func1()
        {
            Console.WriteLine("func1() is invoked. Client is connected. " + RemotingConfiguration.ProcessId);
            return "Client is connected to server";
        }
    }
}
