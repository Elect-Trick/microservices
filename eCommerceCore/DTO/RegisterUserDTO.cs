using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eCommerceCore.DTO
{
    public class RegisterUserDTO
    {
        public string? Email { get; set; }
        public string? Password { get; set; }
        public string? Name { get; set; }
        public char? Gender{ get; set; }


        public RegisterUserDTO()
        {
            
        }
    }
}
