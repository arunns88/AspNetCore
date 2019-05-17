using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.AspNetCore.Connections
{
    public interface IConnectionListener
    {
        EndPoint Endpoint { get; }

        ValueTask<ConnectionContext> AcceptAsync();

        ValueTask DisposeAsync();
    }
}