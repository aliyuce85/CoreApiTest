using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;


namespace CoreDeneme.Controllers
{
    public class TestAsyncController : Controller
    {
        [HttpGet]
        public async Task<System.Web.Mvc.ActionResult> Test()
        {

            Console.WriteLine("consumerService alındı.");
            Console.WriteLine($"consumerService.Start() başladı: {DateTime.Now.ToShortTimeString()}");
            //await _consumerService.Start();

            await TestMethod();


            await TestMethod();

            return await Task.FromResult<System.Web.Mvc.ViewResult> (new System.Web.Mvc.ViewResult());
        }

        private async Task TestMethod()
        {

            for (int i = 0; i < 10; ++i)
            {
                Thread.Sleep(1000);
            }
            Console.WriteLine("dasfdsafasdf");



        }
    }
}
