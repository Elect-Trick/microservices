using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eCommerceCore.Entities;
using eCommerceCore.RepositoryContracts;

namespace eCommerceInfrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        public async Task<ApplicationUser?> AddUser(ApplicationUser user)
        {
            return new ApplicationUser()
            { Id = 1, Email = "username", Password = "password", Name = "Njabulo" };
        }

        public async Task<ApplicationUser?> GetUserByEmailAndPassword(string? username, string? password)
        {
           
            return new ApplicationUser()
            { Id = 1, Email = username, Password = password ,Name = "Njabulo", Gender= 'M'};
            
        }
    }
}
