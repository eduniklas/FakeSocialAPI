using System.ComponentModel.DataAnnotations.Schema;

namespace FakeSocialAPI.Models.DTO
{
    public class LikeDTO
    {
        // can modify
        public int Like_ID { get; set; }
        [ForeignKey("Post")]
        public int Post_ID { get; set; }
        public Post Post { get; set; }
        [ForeignKey("User")]
        public int User_ID { get; set; }
        public Users User { get; set; }
        public DateTime Liked_On { get; set; }
    }
}