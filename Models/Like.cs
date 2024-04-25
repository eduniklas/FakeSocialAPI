using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FakeSocialAPI.Models
{
    public class Like
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Like_ID { get; set; } // PK
        public int Post_ID { get; set; } // FK
        public int User_ID { get; set; } // FK
        public DateTime Liked_On { get; set; }
    }
}