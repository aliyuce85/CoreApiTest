using CoreDeneme.Entity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDeneme.Controllers
{
    [Route("[controller]")]
    public class ProfileController : Controller
    {
        private readonly IProfileRepository _repository;
        public ProfileController(IProfileRepository profileRepository)
        {
            _repository = profileRepository;
        }
        [HttpGet]
        public IActionResult Index()
        {
            var model = _repository.GetAll().ToList();
            return View(model);
        }
    }
}
