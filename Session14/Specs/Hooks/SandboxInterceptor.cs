using System;
using System.Collections.Generic;
using System.Net.Http;
using Suzianna.Rest.Interception;

namespace Specs.Hooks
{
    public class SandboxInterceptor : IHttpInterceptor
    {
        private readonly Guid _sandboxId;
        public SandboxInterceptor(Guid sandboxId)
        {
            _sandboxId = sandboxId;
        }
        public HttpRequestMessage Intercept(HttpRequestMessage message)
        {
            message.Headers.TryAddWithoutValidation("SANDBOX-ID", new List<string>() {_sandboxId.ToString("N")});
            return message;
        }
    }
}