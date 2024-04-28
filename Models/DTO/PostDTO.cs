using System.ComponentModel.DataAnnotations.Schema;

namespace FakeSocialAPI.Models.DTO
{
    public class PostDTO
    {
        // can modify
        public int Post_ID { get; set; } // PK
        [ForeignKey("User")]
        public int User_ID { get; set; } // FK
        public Users User { get; set; }
        public string Content { get; set; }
        public string Image_URL { get; set; }
        public DateTime Posted_On { get; set; }
        public string Visibility { get; set; }
        public virtual ICollection<Like> Likes { get; set; }
    }
}