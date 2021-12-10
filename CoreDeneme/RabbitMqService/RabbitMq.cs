using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreDeneme.RabbitMqEntity;
using CoreDeneme.Abstract;

namespace CoreDeneme.RabbitMqService
{
    public class RabbitMq : IRabbitMqService
    {
        private readonly string _hostName;
        private readonly string _userName;
        private readonly string _password;

        public RabbitMq(IRabbitMqConfiguration rabbitMqConfiguration)
        {
            _hostName = rabbitMqConfiguration.HostName;
            _userName = rabbitMqConfiguration.UserName;
            _password = rabbitMqConfiguration.Password;
        }

        public IConnection GetConnection()
        {
            var factory = new ConnectionFactory()
            {
                HostName = "localhost",
                UserName = "guest",
                Password = "guest",
            };

            var connection = factory.CreateConnection();
            return connection;
         }

        public IModel GetModel(IConnection connection)
        {
            return connection.CreateModel();
        }

     

  
    }
}
