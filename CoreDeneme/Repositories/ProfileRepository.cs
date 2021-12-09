using CoreDeneme.Entity;
using CoreDeneme.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreDeneme.Repositories
{
    public class ProfileRepository : GenericRepository<Profile>, IProfileRepository
    {
        public ProfileRepository(ApplicationDbContext dbContext) : base(dbContext)
        {

        }
        public async Task<string> GetFirstProfileName()
        {
            return await GetAll().Select(x => x.Customer_Name).FirstOrDefaultAsync();
        }
    }
}
