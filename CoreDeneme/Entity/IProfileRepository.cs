using CoreDeneme.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDeneme.Entity
{
    public interface IProfileRepository : IRepository<Profile>
    {
        Task<string> GetFirstProfileName();
    }
}
