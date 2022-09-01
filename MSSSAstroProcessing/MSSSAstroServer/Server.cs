using System;
using System.ServiceModel;

namespace MSSSAstroServer
{
    class Server
    {
        
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(AstroServer),
                new Uri[] {
                    new Uri("net.pipe://localhost")}))
            {
                host.AddServiceEndpoint(typeof(IAstroContract), new NetNamedPipeBinding(), "PipeMath");
                host.Open();
                Console.WriteLine("Service available. \tPress <ENTER> to exit.");
                Console.ReadLine();
                host.Close();
            }
        }
        

       
    }
}

