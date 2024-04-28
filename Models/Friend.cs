using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FakeSocialAPI.Models
{
    public class Friend
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Friend_ID { get; set; }
        [ForeignKey("User1")]               // need config relationship to work properly
        public int User1_ID { get; set; }
        public Users User1 { get; set; }
        public string Status { get; set; }
        // [ForeignKey("User2")]            // need config relationship to work properly
        public int User2_ID { get; set; }
        // public Users User2 { get; set; }
        public DateTime Since_Date { get; set; }
    }
}