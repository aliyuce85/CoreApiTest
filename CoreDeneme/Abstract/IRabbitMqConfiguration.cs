using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDeneme.Abstract
{
    public interface IRabbitMqConfiguration
    {
        string HostName { get; }
        string UserName { get; }
        string Password { get; }
    }
}
