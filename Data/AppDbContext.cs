using Microsoft.EntityFrameworkCore;
using FakeSocialAPI.Models;

namespace FakeSocialAPI.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {}

        public DbSet<Users> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Friend> Friends { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Like> Likes { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Users>().HasData(
                new Users()
                {
                    User_ID = 1,
                    Username = "Frodo",
                    Password = "RingBearer123",
                    EmailAddress = "frodo@shire.net",
                    Creation_Date = new DateTime(2024, 1, 1),
                    Last_Login = new DateTime(2024, 4, 25)
                },
                new Users()
                {
                    User_ID = 2,
                    Username = "Gandalf",
                    Password = "Mithrandir789",
                    EmailAddress = "gandalf@middleearth.org",
                    Creation_Date = new DateTime(2024, 1, 2),
                    Last_Login = new DateTime(2024, 4, 25)
                },
                new Users()
                {
                    User_ID = 3,
                    Username = "Aragorn",
                    Password = "Strider456",
                    EmailAddress = "aragorn@gondor.gov",
                    Creation_Date = new DateTime(2024, 1, 3),
                    Last_Login = new DateTime(2024, 4, 25)
                },
                new Users()
                {
                    User_ID = 4,
                    Username = "Legolas",
                    Password = "ElvenArcher321",
                    EmailAddress = "legolas@mirkwood.com",
                    Creation_Date = new DateTime(2024, 1, 4),
                    Last_Login = new DateTime(2024, 4, 25)
                },
                new Users()
                {
                    User_ID = 5,
                    Username = "Gimli",
                    Password = "AxeMaster654",
                    EmailAddress = "gimli@lonelymountain.net",
                    Creation_Date = new DateTime(2024, 1, 5),
                    Last_Login = new DateTime(2024, 4, 25)
                },
                new Users()
                {
                    User_ID = 6,
                    Username = "Sam",
                    Password = "SamwiseTheBrave",
                    EmailAddress = "sam@shire.com",
                    Creation_Date = new DateTime(2024, 1, 6),
                    Last_Login = new DateTime(2024, 4, 25)
                },
                new Users()
                {
                    User_ID = 7,
                    Username = "Merry",
                    Password = "Meriadoc123",
                    EmailAddress = "merry@buckland.net",
                    Creation_Date = new DateTime(2024, 1, 7),
                    Last_Login = new DateTime(2024, 4, 25)
                },
                new Users()
                {
                    User_ID = 8,
                    Username = "Pippin",
                    Password = "PeregrinTook456",
                    EmailAddress = "pippin@tookborough.org",
                    Creation_Date = new DateTime(2024, 1, 8),
                    Last_Login = new DateTime(2024, 4, 25)
                },
                new Users()
                {
                    User_ID = 9,
                    Username = "Boromir",
                    Password = "GondorDefender789",
                    EmailAddress = "boromir@minastirith.gov",
                    Creation_Date = new DateTime(2024, 1, 9),
                    Last_Login = new DateTime(2024, 4, 25)
                },
                new Users()
                {
                    User_ID = 10,
                    Username = "Eowyn",
                    Password = "Shieldmaiden321",
                    EmailAddress = "eowyn@rohan.com",
                    Creation_Date = new DateTime(2024, 1, 10),
                    Last_Login = new DateTime(2024, 4, 25)
                }
            );

            builder.Entity<Post>().HasData(
                new Post()
                {
                    Post_ID = 1,
                    User_ID = 1,
                    Content = "Just found the One Ring in my uncle's belongings. Wondering what adventures await!",
                    Image_URL = "images/frodo-ring.jpg",
                    Posted_On = new DateTime(2024, 4, 25),
                    Visibility = "Public"
                },
                new Post()
                {
                    Post_ID = 2,
                    User_ID = 2,
                    Content = "Heading to the Shire. I've heard a certain Mr. Baggins has something that needs safekeeping.",
                    Image_URL = "images/gandalf-on-road.jpg",
                    Posted_On = new DateTime(2024, 4, 25),
                    Visibility = "Public"
                },
                new Post()
                {
                    Post_ID = 3,
                    User_ID = 3,
                    Content = "Spent the day helping rebuild some of the older sections of Minas Tirith. The city must be ready.",
                    Image_URL = "images/aragorn-minas-tirith.jpg",
                    Posted_On = new DateTime(2024, 4, 25),
                    Visibility = "Public"
                },
                new Post()
                {
                    Post_ID = 4,
                    User_ID = 4,
                    Content = "Had a nice archery session with the elves today. It’s always refreshing to practice.",
                    Image_URL = "images/legolas-archery.jpg",
                    Posted_On = new DateTime(2024, 4, 25),
                    Visibility = "Public"
                },
                new Post()
                {
                    Post_ID = 5,
                    User_ID = 5,
                    Content = "I never tire of the mountains, though they're not quite as grand as the ones at home!",
                    Image_URL = "images/gimli-mountains.jpg",
                    Posted_On = new DateTime(2024, 4, 25),
                    Visibility = "Public"
                },
                new Post()
                {
                    Post_ID = 6,
                    User_ID = 1,
                    Content = "Making preparations to leave the Shire. A long journey ahead, but I have good company.",
                    Image_URL = "images/frodo-leaving-shire.jpg",
                    Posted_On = new DateTime(2024, 4, 26),
                    Visibility = "Public"
                },
                new Post()
                {
                    Post_ID = 7,
                    User_ID = 2,
                    Content = "Just created a spectacular fireworks show for the Hobbits. Their joy makes the effort worthwhile.",
                    Image_URL = "images/gandalf-fireworks.jpg",
                    Posted_On = new DateTime(2024, 4, 26),
                    Visibility = "Public"
                },
                new Post()
                {
                    Post_ID = 8,
                    User_ID = 3,
                    Content = "Tracking some orcs near the border of Rohan. Must ensure they do not threaten the nearby villages.",
                    Image_URL = "images/aragorn-tracking.jpg",
                    Posted_On = new DateTime(2024, 4, 26),
                    Visibility = "Public"
                },
                new Post()
                {
                    Post_ID = 9,
                    User_ID = 4,
                    Content = "Exploring the forests of Fangorn. There's an ancient magic here that's palpable.",
                    Image_URL = "images/legolas-fangorn.jpg",
                    Posted_On = new DateTime(2024, 4, 26),
                    Visibility = "Public"
                },
                new Post()
                {
                    Post_ID = 10,
                    User_ID = 5,
                    Content = "Joined a contest of axe-throwing today. Spoiler: I won.",
                    Image_URL = "images/gimli-axe-throwing.jpg",
                    Posted_On = new DateTime(2024, 4, 26),
                    Visibility = "Public"
                }

            );

            builder.Entity<Friend>().HasData(
                new Friend()
                {
                    Friend_ID = 1,
                    User1_ID = 1, // Frodo
                    User2_ID = 2, // Gandalf
                    Status = "Accepted",
                    Since_Date = new DateTime(2024, 1, 1)
                },
                new Friend()
                {
                    Friend_ID = 2,
                    User1_ID = 1, // Frodo
                    User2_ID = 3, // Aragorn
                    Status = "Accepted",
                    Since_Date = new DateTime(2024, 1, 1)
                },
                new Friend()
                {
                    Friend_ID = 3,
                    User1_ID = 1, // Frodo
                    User2_ID = 4, // Legolas
                    Status = "Accepted",
                    Since_Date = new DateTime(2024, 1, 1)
                },
                new Friend()
                {
                    Friend_ID = 4,
                    User1_ID = 1, // Frodo
                    User2_ID = 5, // Gimli
                    Status = "Accepted",
                    Since_Date = new DateTime(2024, 1, 1)
                },
                new Friend()
                {
                    Friend_ID = 5,
                    User1_ID = 1, // Frodo
                    User2_ID = 6, // Sam
                    Status = "Accepted",
                    Since_Date = new DateTime(2024, 1, 1)
                },
                new Friend()
                {
                    Friend_ID = 6,
                    User1_ID = 1, // Frodo
                    User2_ID = 7, // Merry
                    Status = "Accepted",
                    Since_Date = new DateTime(2024, 1, 1)
                },
                new Friend()
                {
                    Friend_ID = 7,
                    User1_ID = 1, // Frodo
                    User2_ID = 8, // Pippin
                    Status = "Accepted",
                    Since_Date = new DateTime(2024, 1, 1)
                },
                new Friend()
                {
                    Friend_ID = 8,
                    User1_ID = 2, // Gandalf
                    User2_ID = 3, // Aragorn
                    Status = "Accepted",
                    Since_Date = new DateTime(2024, 1, 1)
                },
                new Friend()
                {
                    Friend_ID = 9,
                    User1_ID = 2, // Gandalf
                    User2_ID = 9, // Boromir
                    Status = "Pending",
                    Since_Date = new DateTime(2024, 1, 1)
                },
                new Friend()
                {
                    Friend_ID = 10,
                    User1_ID = 2, // Gandalf
                    User2_ID = 10, // Éowyn
                    Status = "Pending",
                    Since_Date = new DateTime(2024, 1, 1)
                },
                new Friend()
                {
                    Friend_ID = 11,
                    User1_ID = 3, // Aragorn
                    User2_ID = 4, // Legolas
                    Status = "Accepted",
                    Since_Date = new DateTime(2024, 1, 1)
                },
                new Friend()
                {
                    Friend_ID = 12,
                    User1_ID = 3, // Aragorn
                    User2_ID = 5, // Gimli
                    Status = "Accepted",
                    Since_Date = new DateTime(2024, 1, 1)
                },
                new Friend()
                {
                    Friend_ID = 13,
                    User1_ID = 4, // Legolas
                    User2_ID = 5, // Gimli
                    Status = "Accepted",
                    Since_Date = new DateTime(2024, 1, 1)
                },
                new Friend()
                {
                    Friend_ID = 14,
                    User1_ID = 4, // Legolas
                    User2_ID = 6, // Sam
                    Status = "Pending",
                    Since_Date = new DateTime(2024, 1, 1)
                },
                new Friend()
                {
                    Friend_ID = 15,
                    User1_ID = 5, // Gimli
                    User2_ID = 6, // Sam
                    Status = "Pending",
                    Since_Date = new DateTime(2024, 1, 1)
                },
                new Friend()
                {
                    Friend_ID = 16,
                    User1_ID = 6, // Sam
                    User2_ID = 7, // Merry
                    Status = "Accepted",
                    Since_Date = new DateTime(2024, 1, 1)
                },
                new Friend()
                {
                    Friend_ID = 17,
                    User1_ID = 6, // Sam
                    User2_ID = 8, // Pippin
                    Status = "Accepted",
                    Since_Date = new DateTime(2024, 1, 1)
                },
                new Friend()
                {
                    Friend_ID = 18,
                    User1_ID = 7, // Merry
                    User2_ID = 8, // Pippin
                    Status = "Accepted",
                    Since_Date = new DateTime(2024, 1, 1)
                },
                new Friend()
                {
                    Friend_ID = 19,
                    User1_ID = 7, // Merry
                    User2_ID = 9, // Boromir
                    Status = "Declined",
                    Since_Date = new DateTime(2024, 1, 1)
                },
                new Friend()
                {
                    Friend_ID = 20,
                    User1_ID = 8, // Pippin
                    User2_ID = 10, // Éowyn
                    Status = "Pending",
                    Since_Date = new DateTime(2024, 1, 1)
                }
            );

            builder.Entity<Comment>().HasData(
                new Comment()
                {
                    Comment_ID = 1,
                    Post_ID = 1,
                    User_ID = 2, // Gandalf commenting on Frodo's post
                    Comment_Text = "Keep it secret, keep it safe!",
                    Commented_On = new DateTime(2024, 4, 25)
                },
                new Comment()
                {
                    Comment_ID = 2,
                    Post_ID = 1,
                    User_ID = 3, // Aragorn commenting on Frodo's post
                    Comment_Text = "You have my sword should you need it.",
                    Commented_On = new DateTime(2024, 4, 25)
                },
                new Comment()
                {
                    Comment_ID = 3,
                    Post_ID = 2,
                    User_ID = 1, // Frodo commenting on Gandalf's post
                    Comment_Text = "We await your arrival eagerly, Gandalf!",
                    Commented_On = new DateTime(2024, 4, 25)
                },
                new Comment()
                {
                    Comment_ID = 4,
                    Post_ID = 3,
                    User_ID = 10, // Éowyn commenting on Aragorn's post
                    Comment_Text = "Your efforts fortify us all.",
                    Commented_On = new DateTime(2024, 4, 25)
                },
                new Comment()
                {
                    Comment_ID = 5,
                    Post_ID = 4,
                    User_ID = 5, // Gimli commenting on Legolas' post
                    Comment_Text = "An elf may outdistance us in a sprint but not in endurance!",
                    Commented_On = new DateTime(2024, 4, 25)
                },
                new Comment()
                {
                    Comment_ID = 6,
                    Post_ID = 5,
                    User_ID = 4, // Legolas commenting on Gimli's post
                    Comment_Text = "Yet it is the mountains that rejuvenate your spirit, friend Gimli.",
                    Commented_On = new DateTime(2024, 4, 25)
                },
                new Comment()
                {
                    Comment_ID = 7,
                    Post_ID = 6,
                    User_ID = 6, // Sam commenting on Frodo's post about leaving the Shire
                    Comment_Text = "I'll be right beside you, Mr. Frodo.",
                    Commented_On = new DateTime(2024, 4, 25)
                },
                new Comment()
                {
                    Comment_ID = 8,
                    Post_ID = 7,
                    User_ID = 7, // Merry commenting on Gandalf's fireworks post
                    Comment_Text = "What a show, Gandalf! You never cease to amaze.",
                    Commented_On = new DateTime(2024, 4, 25)
                },
                new Comment()
                {
                    Comment_ID = 9,
                    Post_ID = 8,
                    User_ID = 8, // Pippin commenting on Aragorn's tracking post
                    Comment_Text = "Be safe, Aragorn.",
                    Commented_On = new DateTime(2024, 4, 25)
                },
                new Comment()
                {
                    Comment_ID = 10,
                    Post_ID = 9,
                    User_ID = 9, // Boromir commenting on Legolas' exploration post
                    Comment_Text = "I too have felt the ancient call of the woods.",
                    Commented_On = new DateTime(2024, 4, 25)
                },
                new Comment()
                {
                    Comment_ID = 11,
                    Post_ID = 10,
                    User_ID = 5, // Gimli commenting on his own post
                    Comment_Text = "Never doubted the outcome!",
                    Commented_On = new DateTime(2024, 4, 25)
                },
                new Comment()
                {
                    Comment_ID = 12,
                    Post_ID = 4,
                    User_ID = 3, // Aragorn commenting on Legolas' post
                    Comment_Text = "Sharp as ever, Legolas. Your skills are unmatched.",
                    Commented_On = new DateTime(2024, 4, 25)
                },
                new Comment()
                {
                    Comment_ID = 13,
                    Post_ID = 5,
                    User_ID = 1, // Frodo commenting on Gimli's mountain post
                    Comment_Text = "The view must be breathtaking!",
                    Commented_On = new DateTime(2024, 4, 25)
                },
                new Comment()
                {
                    Comment_ID = 14,
                    Post_ID = 2,
                    User_ID = 4, // Legolas commenting on Gandalf's journey
                    Comment_Text = "May the winds be at your back.",
                    Commented_On = new DateTime(2024, 4, 25)
                },
                new Comment()
                {
                    Comment_ID = 15,
                    Post_ID = 3,
                    User_ID = 2, // Gandalf commenting on Aragorn's rebuilding efforts
                    Comment_Text = "Well done, Aragorn. The city grows stronger under your care.",
                    Commented_On = new DateTime(2024, 4, 25)
                }
            );

            builder.Entity<Like>().HasData(
                new Like()
                {
                    Like_ID = 1,
                    Post_ID = 1,
                    User_ID = 6, // Sam likes Frodo's post
                    Liked_On = new DateTime(2024, 4, 25)
                },
                new Like()
                {
                    Like_ID = 2,
                    Post_ID = 1,
                    User_ID = 7, // Merry likes Frodo's post
                    Liked_On = new DateTime(2024, 4, 25)
                },
                new Like()
                {
                    Like_ID = 3,
                    Post_ID = 1,
                    User_ID = 8, // Pippin likes Frodo's post
                    Liked_On = new DateTime(2024, 4, 25)
                },
                new Like()
                {
                    Like_ID = 4,
                    Post_ID = 2,
                    User_ID = 1, // Frodo likes Gandalf's post
                    Liked_On = new DateTime(2024, 4, 25)
                },
                new Like()
                {
                    Like_ID = 5,
                    Post_ID = 2,
                    User_ID = 6, // Sam likes Gandalf's post
                    Liked_On = new DateTime(2024, 4, 25)
                },
                new Like()
                {
                    Like_ID = 6,
                    Post_ID = 3,
                    User_ID = 1, // Frodo likes Aragorn's post
                    Liked_On = new DateTime(2024, 4, 25)
                },
                new Like()
                {
                    Like_ID = 7,
                    Post_ID = 3,
                    User_ID = 2, // Gandalf likes Aragorn's post
                    Liked_On = new DateTime(2024, 4, 25)
                },
                new Like()
                {
                    Like_ID = 8,
                    Post_ID = 4,
                    User_ID = 3, // Aragorn likes Legolas' post
                    Liked_On = new DateTime(2024, 4, 25)
                },
                new Like()
                {
                    Like_ID = 9,
                    Post_ID = 4,
                    User_ID = 5, // Gimli likes Legolas' post
                    Liked_On = new DateTime(2024, 4, 25)
                },
                new Like()
                {
                    Like_ID = 10,
                    Post_ID = 5,
                    User_ID = 4, // Legolas likes Gimli's post
                    Liked_On = new DateTime(2024, 4, 25)
                },
                new Like()
                {
                    Like_ID = 11,
                    Post_ID = 6,
                    User_ID = 2, // Gandalf likes Frodo's leaving post
                    Liked_On = new DateTime(2024, 4, 26)
                },
                new Like()
                {
                    Like_ID = 12,
                    Post_ID = 7,
                    User_ID = 1, // Frodo likes Gandalf's fireworks post
                    Liked_On = new DateTime(2024, 4, 26)
                },
                new Like()
                {
                    Like_ID = 13,
                    Post_ID = 7,
                    User_ID = 8, // Pippin likes Gandalf's fireworks post
                    Liked_On = new DateTime(2024, 4, 26)
                },
                new Like()
                {
                    Like_ID = 14,
                    Post_ID = 8,
                    User_ID = 7, // Merry likes Aragorn's tracking post
                    Liked_On = new DateTime(2024, 4, 26)
                },
                new Like()
                {
                    Like_ID = 15,
                    Post_ID = 8,
                    User_ID = 6, // Sam likes Aragorn's tracking post
                    Liked_On = new DateTime(2024, 4, 26)
                },
                new Like()
                {
                    Like_ID = 16,
                    Post_ID = 9,
                    User_ID = 3, // Aragorn likes Legolas' Fangorn post
                    Liked_On = new DateTime(2024, 4, 26)
                },
                new Like()
                {
                    Like_ID = 17,
                    Post_ID = 10,
                    User_ID = 4, // Legolas likes Gimli's axe-throwing post
                    Liked_On = new DateTime(2024, 4, 26)
                },
                new Like()
                {
                    Like_ID = 18,
                    Post_ID = 10,
                    User_ID = 9, // Boromir likes Gimli's axe-throwing post
                    Liked_On = new DateTime(2024, 4, 26)
                },
                new Like()
                {
                    Like_ID = 19,
                    Post_ID = 5,
                    User_ID = 9, // Boromir likes Gimli's mountain post
                    Liked_On = new DateTime(2024, 4, 26)
                },
                new Like()
                {
                    Like_ID = 20,
                    Post_ID = 2,
                    User_ID = 10, // Éowyn likes Gandalf's post
                    Liked_On = new DateTime(2024, 4, 26)
                }
            );
        }
    }
}