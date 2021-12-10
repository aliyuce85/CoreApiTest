using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDeneme.Abstract
{
    public interface IPublisherService
    {
        void Enqueue<T>(IEnumerable<T> queueDataModels, string queueName) where T : class;
    }
}
