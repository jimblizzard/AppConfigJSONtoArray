using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.AzureAppConfiguration;
using System.Collections.Generic;
using System.Text.Json;

namespace appconfigconsolecore
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = new ConfigurationBuilder();
            builder.AddAzureAppConfiguration(Environment.GetEnvironmentVariable("ConnectionString"));

            var config = builder.Build();

            Console.WriteLine("this is a test: " + config["foo"]);

            FooClass fclass = new FooClass(); 
            fclass = JsonSerializer.Deserialize<FooClass>(config["foo"]);        

            foreach (var f in fclass.value)
                {
                    Console.WriteLine("element is: {0}", f);
                }

        }

        class FooClass
        {
            public int[] value {get;set;}
        }
    }
}