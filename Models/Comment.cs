using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FakeSocialAPI.Models
{
    public class Comment
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Comment_ID { get; set; } // PK
        public int Post_ID { get; set; } // FK
        public int User_ID { get; set; } // FK
        public string Comment_Text { get; set; }
        public DateTime Commented_On { get; set; }
    }
}