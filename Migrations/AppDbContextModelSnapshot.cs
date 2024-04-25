﻿// <auto-generated />
using System;
using FakeSocialAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FakeSocialAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FakeSocialAPI.Models.Comment", b =>
                {
                    b.Property<int>("Comment_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Comment_ID"));

                    b.Property<string>("Comment_Text")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Commented_On")
                        .HasColumnType("datetime2");

                    b.Property<int>("Post_ID")
                        .HasColumnType("int");

                    b.Property<int>("User_ID")
                        .HasColumnType("int");

                    b.HasKey("Comment_ID");

                    b.ToTable("Comments");

                    b.HasData(
                        new
                        {
                            Comment_ID = 1,
                            Comment_Text = "Keep it secret, keep it safe!",
                            Commented_On = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Post_ID = 1,
                            User_ID = 2
                        },
                        new
                        {
                            Comment_ID = 2,
                            Comment_Text = "You have my sword should you need it.",
                            Commented_On = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Post_ID = 1,
                            User_ID = 3
                        },
                        new
                        {
                            Comment_ID = 3,
                            Comment_Text = "We await your arrival eagerly, Gandalf!",
                            Commented_On = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Post_ID = 2,
                            User_ID = 1
                        },
                        new
                        {
                            Comment_ID = 4,
                            Comment_Text = "Your efforts fortify us all.",
                            Commented_On = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Post_ID = 3,
                            User_ID = 10
                        },
                        new
                        {
                            Comment_ID = 5,
                            Comment_Text = "An elf may outdistance us in a sprint but not in endurance!",
                            Commented_On = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Post_ID = 4,
                            User_ID = 5
                        },
                        new
                        {
                            Comment_ID = 6,
                            Comment_Text = "Yet it is the mountains that rejuvenate your spirit, friend Gimli.",
                            Commented_On = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Post_ID = 5,
                            User_ID = 4
                        },
                        new
                        {
                            Comment_ID = 7,
                            Comment_Text = "I'll be right beside you, Mr. Frodo.",
                            Commented_On = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Post_ID = 6,
                            User_ID = 6
                        },
                        new
                        {
                            Comment_ID = 8,
                            Comment_Text = "What a show, Gandalf! You never cease to amaze.",
                            Commented_On = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Post_ID = 7,
                            User_ID = 7
                        },
                        new
                        {
                            Comment_ID = 9,
                            Comment_Text = "Be safe, Aragorn.",
                            Commented_On = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Post_ID = 8,
                            User_ID = 8
                        },
                        new
                        {
                            Comment_ID = 10,
                            Comment_Text = "I too have felt the ancient call of the woods.",
                            Commented_On = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Post_ID = 9,
                            User_ID = 9
                        },
                        new
                        {
                            Comment_ID = 11,
                            Comment_Text = "Never doubted the outcome!",
                            Commented_On = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Post_ID = 10,
                            User_ID = 5
                        },
                        new
                        {
                            Comment_ID = 12,
                            Comment_Text = "Sharp as ever, Legolas. Your skills are unmatched.",
                            Commented_On = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Post_ID = 4,
                            User_ID = 3
                        },
                        new
                        {
                            Comment_ID = 13,
                            Comment_Text = "The view must be breathtaking!",
                            Commented_On = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Post_ID = 5,
                            User_ID = 1
                        },
                        new
                        {
                            Comment_ID = 14,
                            Comment_Text = "May the winds be at your back.",
                            Commented_On = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Post_ID = 2,
                            User_ID = 4
                        },
                        new
                        {
                            Comment_ID = 15,
                            Comment_Text = "Well done, Aragorn. The city grows stronger under your care.",
                            Commented_On = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Post_ID = 3,
                            User_ID = 2
                        });
                });

            modelBuilder.Entity("FakeSocialAPI.Models.Friend", b =>
                {
                    b.Property<int>("Friend_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Friend_ID"));

                    b.Property<DateTime>("Since_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("User1_ID")
                        .HasColumnType("int");

                    b.Property<int>("User2_ID")
                        .HasColumnType("int");

                    b.HasKey("Friend_ID");

                    b.ToTable("Friends");

                    b.HasData(
                        new
                        {
                            Friend_ID = 1,
                            Since_Date = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Accepted",
                            User1_ID = 1,
                            User2_ID = 2
                        },
                        new
                        {
                            Friend_ID = 2,
                            Since_Date = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Accepted",
                            User1_ID = 1,
                            User2_ID = 3
                        },
                        new
                        {
                            Friend_ID = 3,
                            Since_Date = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Accepted",
                            User1_ID = 1,
                            User2_ID = 4
                        },
                        new
                        {
                            Friend_ID = 4,
                            Since_Date = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Accepted",
                            User1_ID = 1,
                            User2_ID = 5
                        },
                        new
                        {
                            Friend_ID = 5,
                            Since_Date = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Accepted",
                            User1_ID = 1,
                            User2_ID = 6
                        },
                        new
                        {
                            Friend_ID = 6,
                            Since_Date = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Accepted",
                            User1_ID = 1,
                            User2_ID = 7
                        },
                        new
                        {
                            Friend_ID = 7,
                            Since_Date = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Accepted",
                            User1_ID = 1,
                            User2_ID = 8
                        },
                        new
                        {
                            Friend_ID = 8,
                            Since_Date = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Accepted",
                            User1_ID = 2,
                            User2_ID = 3
                        },
                        new
                        {
                            Friend_ID = 9,
                            Since_Date = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Pending",
                            User1_ID = 2,
                            User2_ID = 9
                        },
                        new
                        {
                            Friend_ID = 10,
                            Since_Date = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Pending",
                            User1_ID = 2,
                            User2_ID = 10
                        },
                        new
                        {
                            Friend_ID = 11,
                            Since_Date = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Accepted",
                            User1_ID = 3,
                            User2_ID = 4
                        },
                        new
                        {
                            Friend_ID = 12,
                            Since_Date = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Accepted",
                            User1_ID = 3,
                            User2_ID = 5
                        },
                        new
                        {
                            Friend_ID = 13,
                            Since_Date = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Accepted",
                            User1_ID = 4,
                            User2_ID = 5
                        },
                        new
                        {
                            Friend_ID = 14,
                            Since_Date = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Pending",
                            User1_ID = 4,
                            User2_ID = 6
                        },
                        new
                        {
                            Friend_ID = 15,
                            Since_Date = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Pending",
                            User1_ID = 5,
                            User2_ID = 6
                        },
                        new
                        {
                            Friend_ID = 16,
                            Since_Date = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Accepted",
                            User1_ID = 6,
                            User2_ID = 7
                        },
                        new
                        {
                            Friend_ID = 17,
                            Since_Date = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Accepted",
                            User1_ID = 6,
                            User2_ID = 8
                        },
                        new
                        {
                            Friend_ID = 18,
                            Since_Date = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Accepted",
                            User1_ID = 7,
                            User2_ID = 8
                        },
                        new
                        {
                            Friend_ID = 19,
                            Since_Date = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Declined",
                            User1_ID = 7,
                            User2_ID = 9
                        },
                        new
                        {
                            Friend_ID = 20,
                            Since_Date = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Status = "Pending",
                            User1_ID = 8,
                            User2_ID = 10
                        });
                });

            modelBuilder.Entity("FakeSocialAPI.Models.Like", b =>
                {
                    b.Property<int>("Like_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Like_ID"));

                    b.Property<DateTime>("Liked_On")
                        .HasColumnType("datetime2");

                    b.Property<int>("Post_ID")
                        .HasColumnType("int");

                    b.Property<int>("User_ID")
                        .HasColumnType("int");

                    b.HasKey("Like_ID");

                    b.ToTable("Likes");

                    b.HasData(
                        new
                        {
                            Like_ID = 1,
                            Liked_On = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Post_ID = 1,
                            User_ID = 6
                        },
                        new
                        {
                            Like_ID = 2,
                            Liked_On = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Post_ID = 1,
                            User_ID = 7
                        },
                        new
                        {
                            Like_ID = 3,
                            Liked_On = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Post_ID = 1,
                            User_ID = 8
                        },
                        new
                        {
                            Like_ID = 4,
                            Liked_On = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Post_ID = 2,
                            User_ID = 1
                        },
                        new
                        {
                            Like_ID = 5,
                            Liked_On = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Post_ID = 2,
                            User_ID = 6
                        },
                        new
                        {
                            Like_ID = 6,
                            Liked_On = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Post_ID = 3,
                            User_ID = 1
                        },
                        new
                        {
                            Like_ID = 7,
                            Liked_On = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Post_ID = 3,
                            User_ID = 2
                        },
                        new
                        {
                            Like_ID = 8,
                            Liked_On = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Post_ID = 4,
                            User_ID = 3
                        },
                        new
                        {
                            Like_ID = 9,
                            Liked_On = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Post_ID = 4,
                            User_ID = 5
                        },
                        new
                        {
                            Like_ID = 10,
                            Liked_On = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Post_ID = 5,
                            User_ID = 4
                        },
                        new
                        {
                            Like_ID = 11,
                            Liked_On = new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Post_ID = 6,
                            User_ID = 2
                        },
                        new
                        {
                            Like_ID = 12,
                            Liked_On = new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Post_ID = 7,
                            User_ID = 1
                        },
                        new
                        {
                            Like_ID = 13,
                            Liked_On = new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Post_ID = 7,
                            User_ID = 8
                        },
                        new
                        {
                            Like_ID = 14,
                            Liked_On = new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Post_ID = 8,
                            User_ID = 7
                        },
                        new
                        {
                            Like_ID = 15,
                            Liked_On = new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Post_ID = 8,
                            User_ID = 6
                        },
                        new
                        {
                            Like_ID = 16,
                            Liked_On = new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Post_ID = 9,
                            User_ID = 3
                        },
                        new
                        {
                            Like_ID = 17,
                            Liked_On = new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Post_ID = 10,
                            User_ID = 4
                        },
                        new
                        {
                            Like_ID = 18,
                            Liked_On = new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Post_ID = 10,
                            User_ID = 9
                        },
                        new
                        {
                            Like_ID = 19,
                            Liked_On = new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Post_ID = 5,
                            User_ID = 9
                        },
                        new
                        {
                            Like_ID = 20,
                            Liked_On = new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Post_ID = 2,
                            User_ID = 10
                        });
                });

            modelBuilder.Entity("FakeSocialAPI.Models.Post", b =>
                {
                    b.Property<int>("Post_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Post_ID"));

                    b.Property<string>("Content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Image_URL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Posted_On")
                        .HasColumnType("datetime2");

                    b.Property<int>("User_ID")
                        .HasColumnType("int");

                    b.Property<string>("Visibility")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Post_ID");

                    b.ToTable("Posts");

                    b.HasData(
                        new
                        {
                            Post_ID = 1,
                            Content = "Just found the One Ring in my uncle's belongings. Wondering what adventures await!",
                            Image_URL = "images/frodo-ring.jpg",
                            Posted_On = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            User_ID = 1,
                            Visibility = "Public"
                        },
                        new
                        {
                            Post_ID = 2,
                            Content = "Heading to the Shire. I've heard a certain Mr. Baggins has something that needs safekeeping.",
                            Image_URL = "images/gandalf-on-road.jpg",
                            Posted_On = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            User_ID = 2,
                            Visibility = "Public"
                        },
                        new
                        {
                            Post_ID = 3,
                            Content = "Spent the day helping rebuild some of the older sections of Minas Tirith. The city must be ready.",
                            Image_URL = "images/aragorn-minas-tirith.jpg",
                            Posted_On = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            User_ID = 3,
                            Visibility = "Public"
                        },
                        new
                        {
                            Post_ID = 4,
                            Content = "Had a nice archery session with the elves today. It’s always refreshing to practice.",
                            Image_URL = "images/legolas-archery.jpg",
                            Posted_On = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            User_ID = 4,
                            Visibility = "Public"
                        },
                        new
                        {
                            Post_ID = 5,
                            Content = "I never tire of the mountains, though they're not quite as grand as the ones at home!",
                            Image_URL = "images/gimli-mountains.jpg",
                            Posted_On = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            User_ID = 5,
                            Visibility = "Public"
                        },
                        new
                        {
                            Post_ID = 6,
                            Content = "Making preparations to leave the Shire. A long journey ahead, but I have good company.",
                            Image_URL = "images/frodo-leaving-shire.jpg",
                            Posted_On = new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            User_ID = 1,
                            Visibility = "Public"
                        },
                        new
                        {
                            Post_ID = 7,
                            Content = "Just created a spectacular fireworks show for the Hobbits. Their joy makes the effort worthwhile.",
                            Image_URL = "images/gandalf-fireworks.jpg",
                            Posted_On = new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            User_ID = 2,
                            Visibility = "Public"
                        },
                        new
                        {
                            Post_ID = 8,
                            Content = "Tracking some orcs near the border of Rohan. Must ensure they do not threaten the nearby villages.",
                            Image_URL = "images/aragorn-tracking.jpg",
                            Posted_On = new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            User_ID = 3,
                            Visibility = "Public"
                        },
                        new
                        {
                            Post_ID = 9,
                            Content = "Exploring the forests of Fangorn. There's an ancient magic here that's palpable.",
                            Image_URL = "images/legolas-fangorn.jpg",
                            Posted_On = new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            User_ID = 4,
                            Visibility = "Public"
                        },
                        new
                        {
                            Post_ID = 10,
                            Content = "Joined a contest of axe-throwing today. Spoiler: I won.",
                            Image_URL = "images/gimli-axe-throwing.jpg",
                            Posted_On = new DateTime(2024, 4, 26, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            User_ID = 5,
                            Visibility = "Public"
                        });
                });

            modelBuilder.Entity("FakeSocialAPI.Models.Users", b =>
                {
                    b.Property<int>("User_ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("User_ID"));

                    b.Property<DateTime>("Creation_Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Last_Login")
                        .HasColumnType("datetime2");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("User_ID");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            User_ID = 1,
                            Creation_Date = new DateTime(2024, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "frodo@shire.net",
                            Last_Login = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Password = "RingBearer123",
                            Username = "Frodo"
                        },
                        new
                        {
                            User_ID = 2,
                            Creation_Date = new DateTime(2024, 1, 2, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "gandalf@middleearth.org",
                            Last_Login = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Password = "Mithrandir789",
                            Username = "Gandalf"
                        },
                        new
                        {
                            User_ID = 3,
                            Creation_Date = new DateTime(2024, 1, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "aragorn@gondor.gov",
                            Last_Login = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Password = "Strider456",
                            Username = "Aragorn"
                        },
                        new
                        {
                            User_ID = 4,
                            Creation_Date = new DateTime(2024, 1, 4, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "legolas@mirkwood.com",
                            Last_Login = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Password = "ElvenArcher321",
                            Username = "Legolas"
                        },
                        new
                        {
                            User_ID = 5,
                            Creation_Date = new DateTime(2024, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "gimli@lonelymountain.net",
                            Last_Login = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Password = "AxeMaster654",
                            Username = "Gimli"
                        },
                        new
                        {
                            User_ID = 6,
                            Creation_Date = new DateTime(2024, 1, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "sam@shire.com",
                            Last_Login = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Password = "SamwiseTheBrave",
                            Username = "Sam"
                        },
                        new
                        {
                            User_ID = 7,
                            Creation_Date = new DateTime(2024, 1, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "merry@buckland.net",
                            Last_Login = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Password = "Meriadoc123",
                            Username = "Merry"
                        },
                        new
                        {
                            User_ID = 8,
                            Creation_Date = new DateTime(2024, 1, 8, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "pippin@tookborough.org",
                            Last_Login = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Password = "PeregrinTook456",
                            Username = "Pippin"
                        },
                        new
                        {
                            User_ID = 9,
                            Creation_Date = new DateTime(2024, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "boromir@minastirith.gov",
                            Last_Login = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Password = "GondorDefender789",
                            Username = "Boromir"
                        },
                        new
                        {
                            User_ID = 10,
                            Creation_Date = new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmailAddress = "eowyn@rohan.com",
                            Last_Login = new DateTime(2024, 4, 25, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Password = "Shieldmaiden321",
                            Username = "Eowyn"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
