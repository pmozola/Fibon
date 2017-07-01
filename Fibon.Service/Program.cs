﻿using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace Fibon.Service
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var host = new WebHostBuilder()
                .UseKestrel()
                .UseContentRoot(Directory.GetCurrentDirectory())
                .UseIISIntegration()
                .UseStartup<Startup>()
                .UseUrls("http://*:5050")
                .Build();

            host.Run();
        }
    }
}