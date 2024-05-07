using System.ComponentModel.DataAnnotations;

namespace FakeSocialAPI.Models.DTO
{
    public class UsersDTO
    {
        // can modify
        [Key]
        public int User_ID { get; set; } // PK
        public string Username { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; } // Hash?
        public DateTime Last_Login { get; set; }
    }
}