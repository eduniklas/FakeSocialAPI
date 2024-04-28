using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FakeSocialAPI.Models
{
    public class Like
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Like_ID { get; set; } // PK
        [ForeignKey("Post")]
        public int Post_ID { get; set; } // FK
        public Post Post { get; set; }
        [ForeignKey("User")]
        public int User_ID { get; set; } // FK
        public Users User { get; set; }
        public DateTime Liked_On { get; set; }
    }
}