using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    class User
    {
        
        private List<string> usernames=new List<string>();
     
        public bool AddUser(string userName)
        {
            foreach (var user in usernames)
            {
               if(userName==user)
                {
                    return false;
                } 
            }
            usernames.Add(userName);
            return true;
        }
        public List<string> GetUsers()
        {
            return usernames;
        }
    }
}
