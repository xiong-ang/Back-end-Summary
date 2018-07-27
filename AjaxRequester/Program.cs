using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace AjaxRequester
{
    class Program
    {
        
        static void Main(string[] args)
        {
            //Test();
            AjaxHelper helper = new AjaxHelper(@"https://www.baidu.com");

            //Test Get
            //var answer = string.Empty;
            //var ret = helper.GetCall("", out answer);
            //Console.WriteLine(answer);
            //Console.WriteLine(ret);

            //Test Post
            var answer = string.Empty;
            var ret = helper.PostCall("","", out answer);
            Console.WriteLine(answer);
            Console.WriteLine(ret);

        }

        static void Test()
        {
            var client = new HttpClient();
            var request = new HttpRequestMessage();
            try
            {
                request.RequestUri = new UriBuilder("https", "www.baidu.com", -1, "").Uri;
                request.Method = HttpMethod.Get;
                var response = client.SendAsync(request, HttpCompletionOption.ResponseContentRead).Result;
                var answer = response.Content.ReadAsStringAsync().Result;
                Console.WriteLine(answer);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                client.Dispose();
                request.Dispose();
            }
        }
    }
}
