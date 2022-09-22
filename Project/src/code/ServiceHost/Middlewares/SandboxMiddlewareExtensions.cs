using Microsoft.AspNetCore.Builder;

namespace ServiceHost.Middlewares
{
    public static class SandboxMiddlewareExtensions
    {
        public static IApplicationBuilder UseDatabaseSandbox(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<SandboxMiddleware>();
        }
    }
}