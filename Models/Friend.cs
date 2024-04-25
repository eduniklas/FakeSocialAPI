using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FakeSocialAPI.Models
{
    public class Friend
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Friend_ID { get; set; } // PK
        public int User1_ID { get; set; } // FK
        public int User2_ID { get; set; } // FK
        public string Status { get; set; }
        public DateTime Since_Date { get; set; }
    }
}