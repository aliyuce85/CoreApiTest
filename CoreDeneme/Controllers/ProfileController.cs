using CoreDeneme.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDeneme.Controllers
{
    [Route("[controller]")]
    public class ProfileController : Controller
    {
        private readonly IProfileRepository _repository;
        IConfiguration _configuration;
    
        public ProfileController(IProfileRepository profileRepository, IConfiguration configuration)
        {
            _repository = profileRepository;
            _configuration = configuration;
        
        
        }
        /// <summary>
        /// Short, descriptive title of the operation
        /// </summary>
        /// <remarks>
        /// More elaborate description
        /// </remarks>
        /// <param name="id">Here is the description for ID.</param>
        [HttpGet]
        public async Task<List<Model.Profile>> Index()
        {
            //var a = await _repository.GetFirstProfileName();
            //var model = _repository.GetAll().ToList();
            var c = _configuration.GetSection("ConnectionStrings:DevConnection");
            return null;
        }
    }
}
