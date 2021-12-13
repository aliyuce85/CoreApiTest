using CoreDeneme.Abstract;
using CoreDeneme.ConsumerService;
using CoreDeneme.Data;
using CoreDeneme.Model;
using DotNetCore.CAP;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RabbitMqUi.Controllers
{
    public class ConsumerController : Controller
    {
     

        public ConsumerController()
        {
        

        }
        [CapSubscribe("producer.transaction2")]
        public void Consumer(string a)
        {

            var name = a;
        }
    }
}
