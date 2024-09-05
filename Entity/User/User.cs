using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.User
{
    public class User:IdentityUser<int>
    {
        
     
        public string Surname { get; set; }
        public DateTime dateTime { get; set; }

    }
}
