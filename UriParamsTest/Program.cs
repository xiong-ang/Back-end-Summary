using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace UriParamsTest
{
    class Program
    {
        static void Main(string[] args)
        {
            TestCompose();
            TestDisCompose();           
        }

        static void TestCompose()
        {
            var uri = new UriBuilder("http", "localhost", 8080, "home/login");
            uri.Query = new UriParamsComposer
            {
                {"action","login"},
                {"username","barret"},
                {"password","******"}
            }
            .ToString();

            //Run page in default browser
            Process.Start(uri.ToString());
        }
        static void TestDisCompose()
        {
            var uri = new UriBuilder(@"https://www.google.co.in/search?q=tes&oq=tes&aqs=chrome..69i57j69i60l3j69i65l2.1326j0j4&sourceid=chrome&ie=UTF-8");
            var uriParams = new UriParamsComposer(uri.Uri);

            uriParams.ToList().ForEach(e => {
                Console.WriteLine(e);
            });
        }
    }
}
