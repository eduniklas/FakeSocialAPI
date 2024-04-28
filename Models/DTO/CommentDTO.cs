using System.ComponentModel.DataAnnotations.Schema;

namespace FakeSocialAPI.Models.DTO
{
    public class CommentDTO
    {
        // can modify
        public int Comment_ID { get; set; } // PK
        [ForeignKey("Post")]
        public int Post_ID { get; set; } // FK
        public Post Post { get; set; }
        [ForeignKey("User")]
        public int User_ID { get; set; } // FK
        public Users User { get; set; }
        public string Comment_Text { get; set; }
        public DateTime Commented_On { get; set; }
    }
}