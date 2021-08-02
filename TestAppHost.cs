using Funq;
using Microsoft.AspNetCore.Http;
using ServiceStack;
using ServiceStack.Api.OpenApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace TestSS
{
    public class TestAppHost : AppHostBase
    {
        public ILogger Logger { get; set; }

        public TestAppHost(string serviceName, params Assembly[] assembliesWithServices) : base(serviceName, assembliesWithServices)
        {
        }

        public override void Configure(Container container)
        {
            Plugins.Add(new OpenApiFeature());
            container.AddSingleton<ILogger, TestLogger>();
            container.AutoWire(this);
        }

        public override Task ProcessRequest(HttpContext context, Func<Task> next)
        {
            Logger?.Log("hmm");

            return base.ProcessRequest(context, next);
        }
    }
}
