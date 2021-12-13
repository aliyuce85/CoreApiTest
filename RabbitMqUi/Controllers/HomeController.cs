using CoreDeneme.Abstract;
using CoreDeneme.ConsumerService;
using CoreDeneme.Data;
using CoreDeneme.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using RabbitMqUi.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace RabbitMqUi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISmtpConfiguration _smtpConfig;
        private readonly IPublisherService _publisherService;
        private readonly IDataModel<User> _userListData;
      
        public HomeController(IDataModel<User> userListData, ISmtpConfiguration smtpConfig, IPublisherService publisherService, IConsumerService consumerService)
        {
            _userListData = userListData;
            _smtpConfig = smtpConfig;
            _publisherService = publisherService;
           
        }


        public IActionResult Index()
        {
            Console.WriteLine("Açıldı");

            return View();
        }
        [HttpPost]
        public IActionResult MailSend(PostMailViewModel postMailViewModel)
        {
            _publisherService.Enqueue(
                                       PrepareMessages(postMailViewModel),
                                       "producer.transaction2"
                                     );
            return View();
        }
        private IEnumerable<MailMessageData> PrepareMessages(PostMailViewModel postMailViewModel)
        {
            var users = _userListData.GetData().ToList();
            var messages = new List<MailMessageData>();
            for (int i = 0; i < users.Count; i++)
            {
                messages.Add(new MailMessageData()
                {
                    To = users[i].Email.ToString(),
                    From = _smtpConfig.User,
                    Subject = postMailViewModel.Post.Title,
                    Body = postMailViewModel.Post.Content
                });
            }
            return messages;
        }
        [HttpGet]
        public async Task<IActionResult> PrivacyAsync2()
        {

            Console.WriteLine("consumerService alındı.");
            Console.WriteLine($"consumerService.Start() başladı: {DateTime.Now.ToShortTimeString()}");
            //await _consumerService.Start();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet]
        public async Task<IActionResult> Test()
        {

            Console.WriteLine("consumerService alındı.");
            Console.WriteLine($"consumerService.Start() başladı: {DateTime.Now.ToShortTimeString()}");
            //await _consumerService.Start();
            
            await TestMethod();


            await TestMethod();

            return await Task.FromResult<ViewResult>(new ViewResult());
        }

        private async Task TestMethod()
        {

            for(int i = 0; i < 10; ++i)
            {
                Thread.Sleep(1000);
            }
            Console.WriteLine("dasfdsafasdf");
         


        }
    }
}
