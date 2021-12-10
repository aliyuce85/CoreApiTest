using CoreDeneme.Abstract;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDeneme.RabbitMqService
{
    public class RabbitMqConfiguration : IRabbitMqConfiguration
    {
        public IConfiguration Configuration { get; }
        public RabbitMqConfiguration(IConfiguration configuration) => Configuration = configuration;
        public string HostName => Configuration.GetSection("HostName").Value;

        public string UserName => Configuration.GetSection("UserName").Value;

        public string Password => Configuration.GetSection("Password").Value;
    }
}
