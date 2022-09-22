using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Primitives;
using UOM.Config.ConnectionManagement;

namespace ServiceHost.Middlewares
{
    public class SandboxMiddleware
    {
        private readonly RequestDelegate _next;
        public SandboxMiddleware(RequestDelegate next)
        {
            _next = next;
        }
        public Task Invoke(HttpContext httpContext, IConnectionManager connectionManager)
        {
            StringValues value;
            if (httpContext.Request.Headers.TryGetValue("SANDBOX_CONSTR", out value))
            {
                var connectionString = value.FirstOrDefault();
                connectionManager.OverrideConnectionString(connectionString);
            }

            return _next(httpContext);
        }
    }
}
