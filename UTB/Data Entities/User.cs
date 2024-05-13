using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace UTB.Data_Entities
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        [Required]
        [StringLength(50)]
        public string Username { get; set; }
        [Required]
        [StringLength(100)]
        public string Password { get; set; }
        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        public int GetuserId()
        {
            return UserId;
        }

        public void SetUserId(int userId)
        {
            this.UserId = userId;
        }

        public string GetUsername()
        {
            return Username;
        }

        public void SetUsername(string nickname)
        {
            this.Username = nickname;
        }

        public string GetPassword()
        {
            return Password;
        }

        public void SetPassword(string password)
        {
            this.Password = password;
        }
    }
}
