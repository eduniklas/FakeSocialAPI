using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace FakeSocialAPI.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Comments",
                columns: table => new
                {
                    Comment_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Post_ID = table.Column<int>(type: "int", nullable: false),
                    User_ID = table.Column<int>(type: "int", nullable: false),
                    Comment_Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Commented_On = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.Comment_ID);
                });

            migrationBuilder.CreateTable(
                name: "Friends",
                columns: table => new
                {
                    Friend_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User1_ID = table.Column<int>(type: "int", nullable: false),
                    User2_ID = table.Column<int>(type: "int", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Since_Date = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Friends", x => x.Friend_ID);
                });

            migrationBuilder.CreateTable(
                name: "Likes",
                columns: table => new
                {
                    Like_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Post_ID = table.Column<int>(type: "int", nullable: false),
                    User_ID = table.Column<int>(type: "int", nullable: false),
                    Liked_On = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Likes", x => x.Like_ID);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    Post_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    User_ID = table.Column<int>(type: "int", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image_URL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Posted_On = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Visibility = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Post_ID);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    User_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Creation_Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Last_Login = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.User_ID);
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Comment_ID", "Comment_Text", "Commented_On", "Post_ID", "User_ID" },
                values: new object[,]
                {
                    { 1, "Keep it secret, keep it safe!", new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 2 },
                    { 2, "You have my sword should you need it.", new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 3 },
                    { 3, "We await your arrival eagerly, Gandalf!", new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 4, "Your efforts fortify us all.", new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 10 },
                    { 5, "An elf may outdistance us in a sprint but not in endurance!", new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 5 },
                    { 6, "Yet it is the mountains that rejuvenate your spirit, friend Gimli.", new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 4 },
                    { 7, "I'll be right beside you, Mr. Frodo.", new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 6 },
                    { 8, "What a show, Gandalf! You never cease to amaze.", new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 7 },
                    { 9, "Be safe, Aragorn.", new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 8 },
                    { 10, "I too have felt the ancient call of the woods.", new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 9 },
                    { 11, "Never doubted the outcome!", new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 5 },
                    { 12, "Sharp as ever, Legolas. Your skills are unmatched.", new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 3 },
                    { 13, "The view must be breathtaking!", new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 1 },
                    { 14, "May the winds be at your back.", new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 4 },
                    { 15, "Well done, Aragorn. The city grows stronger under your care.", new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "Friends",
                columns: new[] { "Friend_ID", "Since_Date", "Status", "User1_ID", "User2_ID" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accepted", 1, 2 },
                    { 2, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accepted", 1, 3 },
                    { 3, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accepted", 1, 4 },
                    { 4, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accepted", 1, 5 },
                    { 5, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accepted", 1, 6 },
                    { 6, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accepted", 1, 7 },
                    { 7, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accepted", 1, 8 },
                    { 8, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accepted", 2, 3 },
                    { 9, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending", 2, 9 },
                    { 10, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending", 2, 10 },
                    { 11, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accepted", 3, 4 },
                    { 12, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accepted", 3, 5 },
                    { 13, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accepted", 4, 5 },
                    { 14, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending", 4, 6 },
                    { 15, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending", 5, 6 },
                    { 16, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accepted", 6, 7 },
                    { 17, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accepted", 6, 8 },
                    { 18, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Accepted", 7, 8 },
                    { 19, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Declined", 7, 9 },
                    { 20, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pending", 8, 10 }
                });

            migrationBuilder.InsertData(
                table: "Likes",
                columns: new[] { "Like_ID", "Liked_On", "Post_ID", "User_ID" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 6 },
                    { 2, new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 7 },
                    { 3, new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, 8 },
                    { 4, new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 1 },
                    { 5, new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 6 },
                    { 6, new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 1 },
                    { 7, new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, 2 },
                    { 8, new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 3 },
                    { 9, new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, 5 },
                    { 10, new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 4 },
                    { 11, new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 6, 2 },
                    { 12, new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 1 },
                    { 13, new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 7, 8 },
                    { 14, new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 7 },
                    { 15, new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 8, 6 },
                    { 16, new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 9, 3 },
                    { 17, new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 4 },
                    { 18, new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 10, 9 },
                    { 19, new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, 9 },
                    { 20, new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, 10 }
                });

            migrationBuilder.InsertData(
                table: "Posts",
                columns: new[] { "Post_ID", "Content", "Image_URL", "Posted_On", "User_ID", "Visibility" },
                values: new object[,]
                {
                    { 1, "Just found the One Ring in my uncle's belongings. Wondering what adventures await!", "images/frodo-ring.jpg", new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Public" },
                    { 2, "Heading to the Shire. I've heard a certain Mr. Baggins has something that needs safekeeping.", "images/gandalf-on-road.jpg", new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Public" },
                    { 3, "Spent the day helping rebuild some of the older sections of Minas Tirith. The city must be ready.", "images/aragorn-minas-tirith.jpg", new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Public" },
                    { 4, "Had a nice archery session with the elves today. It’s always refreshing to practice.", "images/legolas-archery.jpg", new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Public" },
                    { 5, "I never tire of the mountains, though they're not quite as grand as the ones at home!", "images/gimli-mountains.jpg", new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Public" },
                    { 6, "Making preparations to leave the Shire. A long journey ahead, but I have good company.", "images/frodo-leaving-shire.jpg", new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, "Public" },
                    { 7, "Just created a spectacular fireworks show for the Hobbits. Their joy makes the effort worthwhile.", "images/gandalf-fireworks.jpg", new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, "Public" },
                    { 8, "Tracking some orcs near the border of Rohan. Must ensure they do not threaten the nearby villages.", "images/aragorn-tracking.jpg", new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 3, "Public" },
                    { 9, "Exploring the forests of Fangorn. There's an ancient magic here that's palpable.", "images/legolas-fangorn.jpg", new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 4, "Public" },
                    { 10, "Joined a contest of axe-throwing today. Spoiler: I won.", "images/gimli-axe-throwing.jpg", new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 5, "Public" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "User_ID", "Creation_Date", "EmailAddress", "Last_Login", "Password", "Username" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "frodo@shire.net", new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "RingBearer123", "Frodo" },
                    { 2, new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "gandalf@middleearth.org", new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mithrandir789", "Gandalf" },
                    { 3, new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "aragorn@gondor.gov", new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Strider456", "Aragorn" },
                    { 4, new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "legolas@mirkwood.com", new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "ElvenArcher321", "Legolas" },
                    { 5, new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "gimli@lonelymountain.net", new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "AxeMaster654", "Gimli" },
                    { 6, new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "sam@shire.com", new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "SamwiseTheBrave", "Sam" },
                    { 7, new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "merry@buckland.net", new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Meriadoc123", "Merry" },
                    { 8, new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "pippin@tookborough.org", new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "PeregrinTook456", "Pippin" },
                    { 9, new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "boromir@minastirith.gov", new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "GondorDefender789", "Boromir" },
                    { 10, new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "eowyn@rohan.com", new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shieldmaiden321", "Eowyn" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Comments");

            migrationBuilder.DropTable(
                name: "Friends");

            migrationBuilder.DropTable(
                name: "Likes");

            migrationBuilder.DropTable(
                name: "Posts");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
