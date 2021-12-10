using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDeneme.Abstract
{
    public interface IRabbitMqService
    {
        //public void SendMail(T model);
        //public void SetConfiguration();
        public IConnection GetConnection();
        public IModel GetModel(IConnection connection);
    }
}
