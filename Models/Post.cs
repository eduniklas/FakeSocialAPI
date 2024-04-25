using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FakeSocialAPI.Models
{
    public class Post
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Post_ID { get; set; } // PK
        public int User_ID { get; set; } // FK
        public string Content { get; set; }
        public string Image_URL { get; set; }
        public DateTime Posted_On { get; set; }
        public string Visibility { get; set; }
    }
}