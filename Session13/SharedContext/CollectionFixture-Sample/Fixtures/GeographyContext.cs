using System;
using System.Collections.Generic;

namespace SharedContext.Fixtures
{
    public class GeographyContext : IDisposable
    {
        public Guid RandomId { get; private set; }
        public GeographyContext()
        {
            this.RandomId = Guid.NewGuid();
        }
        public void Dispose()
        {
        }
    }
}