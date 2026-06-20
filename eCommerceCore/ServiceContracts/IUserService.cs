using eCommerceCore.DTO;
using eCommerceCore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceCore.ServiceContracts
{
    public interface IUserService
    {

        /// <summary>
        /// Method to handle user login use case and returns an authentication respone object that contains the status of the login
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        Task<AuthenticationResponse?> Login(LoginDTO loginRequest);
        Task<AuthenticationResponse?> RegisterUser(RegisterUserDTO registerRequest);

    }
}
