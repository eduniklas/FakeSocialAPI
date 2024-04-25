using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FakeSocialAPI.Models
{
    public class Users
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int User_ID { get; set; } // PK
        public string Username { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; } // Hash?
        public DateTime Creation_Date { get; set; }
        public DateTime Last_Login { get; set; }
    }
}