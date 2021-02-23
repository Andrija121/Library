using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class User
    {
        private string userName;
        private List<User> usernames;
        public string UserName { get; set; }

     
        public User AddUser(string userName)
        {
            foreach (var user in usernames)
            {
                if(user.UserName==userName)
                {
                    return user;
                }
                
            }
            return null;
        }
        public List<User> GetUsers()
        {
            return usernames;
        }
    }
}
