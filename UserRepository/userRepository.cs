using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Annexus_API.Models;

namespace Annexus_API.UserRepository
{
    public static class userRepository
    {
        public static User Get(string UserName, string UserPass)
        {
            var users = new List<User>();
            users.Add(new User { Id = 1, UserName = "Admin", UserPass = "Admin", Role = "Admin" });
            users.Add(new User { Id = 2, UserName = "Master", UserPass = "Master", Role = "Master" });

            return users.Where(x => x.UserName == UserName & x.UserPass == UserPass).FirstOrDefault();
        }
    }
}
