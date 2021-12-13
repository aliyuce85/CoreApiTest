using CoreDeneme.Entity;
using Microsoft.AspNetCore.Mvc;
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
        public ProfileController(IProfileRepository profileRepository)
        {
            _repository = profileRepository;
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
            var a = await _repository.GetFirstProfileName();
            var model = _repository.GetAll().ToList();
            return model;
        }
    }
}
