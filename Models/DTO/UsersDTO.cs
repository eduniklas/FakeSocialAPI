namespace FakeSocialAPI.Models.DTO
{
    public class UsersDTO
    {
        // can modify
        public int User_ID { get; set; } // PK
        public string Username { get; set; }
        public string EmailAddress { get; set; }
        public string Password { get; set; } // Hash?
        public DateTime Creation_Date { get; set; }
        public DateTime Last_Login { get; set; }
        public virtual ICollection<FriendDTO> Friends { get; set; }
    }
}