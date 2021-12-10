using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDeneme.RabbitMqService
{
    public interface IRabbitMqService<T>
    {
        public void SendMail(T model);
    }
}
