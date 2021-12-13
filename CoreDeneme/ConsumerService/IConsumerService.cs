using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDeneme.ConsumerService
{
    public interface IConsumerService : IDisposable
    {
        Task Start();
        void Stop();
    }
}
