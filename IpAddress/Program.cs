using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.NetworkInformation;
using System.Net;

namespace IpAddress
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(LocalIpAddress().ToString());
        }

        static IPAddress LocalIpAddress()
        {
            if (!NetworkInterface.GetIsNetworkAvailable())
                return null;
            var host = Dns.GetHostEntry(Dns.GetHostName());
            return host.AddressList.FirstOrDefault(ip => ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork);
        }
    }
}
