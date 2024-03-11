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
        public string nickname { get; set; }
        public string password { get; set; }
        public int registration { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public DateTime birthDate { get; set; }
        public string email { get; set; }
        public string phoneNumber { get; set; }
        public int GetuserId()
        {
            return userId;
        }

        public void SetUserId(int userId)
        {
            this.userId = userId;
        }

        public string GetNickname()
        {
            return nickname;
        }

        public void SetNickname(string nickname)
        {
            this.nickname = nickname;
        }

        public string GetPassword()
        {
            return password;
        }

        public void SetPassword(string password)
        {
            this.password = password;
        }

        public int GetRegistration()
        {
            return registration;
        }

        public void SetRegistration(int registration)
        {
            this.registration = registration;
        }

        public string GetName()
        {
            return name;
        }

        public void SetName(string name)
        {
            this.name = name;
        }

        public string GetLastName()
        {
            return lastName;
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }

    }
}
