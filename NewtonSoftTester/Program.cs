using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewtonSoftTester
{
    class Program
    {
        static void Main(string[] args)
        {
            var res = JsonHelper.ToJson(new MyClass("Barret", "******"));
            Console.WriteLine(res);

            var cls2 = JsonHelper.FormJson<MyClass>(res);
            Console.WriteLine(cls2.ToString());
        }
    }

    [JsonObject]
    class MyClass
    {
        public MyClass(string name, string password)
        {
            UserName = name;
            Password = password;
        }

        [JsonProperty]
        public string UserName { get; set; }

        [JsonIgnore]
        //[JsonProperty]
        public string Password { get; set; }

        public override string ToString()
        {
            return "UserName: "+ UserName + "\nPassword: " + Password;
        }
    }
}
