using System.ComponentModel.DataAnnotations.Schema;

namespace FakeSocialAPI.Models.DTO
{
    public class FriendDTO
    {
        // can modify
        public int Friend_ID { get; set; }
        [ForeignKey("User1")]
        public int User1_ID { get; set; }
        public Users User1 { get; set; }
        [ForeignKey("User2")]
        public int User2_ID { get; set; }
        public Users User2 { get; set; }
        public string Status { get; set; }
        public DateTime Since_Date { get; set; }
    }
}