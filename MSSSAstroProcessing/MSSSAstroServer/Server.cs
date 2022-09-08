using System;
using System.ServiceModel;

namespace MSSSAstroServer
{
    class Server
    {
        // Alternate code for connection
        
          //string address = "net.pipe://localhost/PipeMath";
          
          //ServiceHost serviceHost = new ServiceHost(typeof(AstroContract)); Creates new servicehost of the implementation of DLL
          //NetNamedPipeBinding binding = new NetNamedPipeBinding(NetNamedPipeSecurityMode.None);
          //serviceHost.AddServiceEndpoint(typeof(IAstroContract), binding, address); Adds endpoint to pipe, assigns address.
          //serviceHost.Open();
          
          //Console.WriteLine("ServiceHost is running. Press <<Return>> to Exist");
          //Console.ReadLine();
         
          //serviceHost.Close();
          
         
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(AstroServer),
                new Uri[] { new Uri("net.pipe://localhost") }
                ))
            {
                host.AddServiceEndpoint(typeof(IAstroContract), new NetNamedPipeBinding(), "PipeMath");
                host.Open();

                Console.WriteLine("Service available. \tPress <ENTER> to exit.");
                Console.ReadLine();
                host.Close();
            }
            //string address = "net.pipe://localhost/PipeMath";

            //ServiceHost serviceHost = new ServiceHost(typeof(AstroServer)); 
            //NetNamedPipeBinding binding = new NetNamedPipeBinding();
            //serviceHost.AddServiceEndpoint(typeof(IAstroContract), binding, address); 
            //serviceHost.Open();

            //Console.WriteLine("ServiceHost is running. Press <<Return>> to Exit");
            //Console.ReadLine();

            //serviceHost.Close();
        }
        

       
    }
}

