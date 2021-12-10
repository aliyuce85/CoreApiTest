using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreDeneme.Controllers
{
    public class RabbitMqController : Controller
    {
        public IActionResult Index()
        {
            var factory = new ConnectionFactory()
            {
                HostName = "localhost",
                UserName = "guest",
                Password = "guest",
            };

            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                //channel.QueueDeclare(queue: "EmailQuee",
                //                     durable: false,
                //                     exclusive: false,
                //                     autoDelete: false,
                //                     arguments: null);

                //var message = JsonConvert.SerializeObject(model);
                //var body = Encoding.UTF8.GetBytes(message);

                //channel.BasicPublish(exchange: "",
                //                     routingKey: "EmailQuee",
                //                     basicProperties: null,
                //                     body: body);
            }
            return View();
        }
    }
}
