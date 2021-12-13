using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDeneme.Abstract
{
    public interface IPublisherService
    {
        Task Enqueue<T>(IEnumerable<T> queueDataModels, string queueName) where T : class;
    }
}
