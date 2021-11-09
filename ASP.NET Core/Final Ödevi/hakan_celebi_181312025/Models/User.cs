using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace hakan_celebi_181312025.Models
{
    public class User
    {
        public enum AuthorityEnum
        {
            admin,
            system,
            user
        }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Authority { get; set; }
    }
}
