using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Coursework.Models
{
    public class User
    {
        public int Id { get; set; }

        public int Name { get; set; }

        public string Image { get; set; }

        public string PasswordHash { get; set; }

        public string PasswordSalt { get; set; }

        public string Role { get; set; }
    }
}
