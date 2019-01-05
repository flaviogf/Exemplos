﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace CatalogoFilmes.Api
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseUrls("http://0.0.0.0:8080")
                .UseStartup<Startup>()
                .Build();
    }
}
