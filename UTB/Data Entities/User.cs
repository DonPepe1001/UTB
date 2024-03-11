using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UTB.Data_Entities
{
    public class User
    {
        public int userId { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public int GetuserId()
        {
            return userId;
        }

        public void SetUserId(int userId)
        {
            this.userId = userId;
        }

        public string GetUsername()
        {
            return username;
        }

        public void SetUsername(string nickname)
        {
            this.username = nickname;
        }

        public string GetPassword()
        {
            return password;
        }

        public void SetPassword(string password)
        {
            this.password = password;
        }
    }
}
