using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;

namespace PortChecker
{
    class Program
    {
        static void Main(string[] args)
        {
            checkAvailablePort(0,8080).ToList().ForEach(e=>Console.WriteLine(e));
        }

        static IEnumerable<int> checkAvailablePort(int startPort, int endPort)
        {
            //Evaluate current system tcp connections. This is the same infomation
            //provided by the netstat command line application.
            var ipGlobalProperities = IPGlobalProperties.GetIPGlobalProperties();
            var tcpConnInfoArray = ipGlobalProperities.GetActiveTcpConnections();

            for (int i= startPort; i <= endPort ; ++i)
            {
                if(!tcpConnInfoArray.Any(tcpi => tcpi.LocalEndPoint.Port == i))
                    yield return i;
            }
        }
    }
}
