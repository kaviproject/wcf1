using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;

namespace HelloServiceHost
{
    class Program
    {
         static void Main()
        {
            using (ServiceHost host = new ServiceHost(typeof(HelloService.HelloService)))
            {
                host.Open();
                Console.WriteLine("Host Strted at  @" + DateTime.Now.ToString());
                Console.ReadLine();
            }
        }
    }
}
