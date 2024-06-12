namespace NovelNest.Infrastructure.Data.DataSeeding
{
    using Microsoft.AspNetCore.Identity;
    using NovelNest.Infrastructure.Data.Models.Articles;
    using NovelNest.Infrastructure.Data.Models.Books;
    using NovelNest.Infrastructure.Data.Models.BookStores;
    using NovelNest.Infrastructure.Data.Models.Events;
    using NovelNest.Infrastructure.Data.Models.Roles;
    using System.Globalization;
    using static NovelNest.Infrastructure.Data.Constants.DataConstants.ArticleConstants;
    using static NovelNest.Infrastructure.Data.Constants.DataConstants.BookStoreConstants;
    using static NovelNest.Infrastructure.Data.Constants.DataConstants.EventConstants;
    using static NovelNest.Infrastructure.Data.Constants.CustomClaims;
    using NovelNest.Infrastructure.Data.Models.Mappings;

    internal class DataSeed
    {
        //Constructor
        public DataSeed()
        {
            SeedUsers();
            SeedPublisher();
            SeedGenres();
            SeedCoverTypes();
            SeedBooks();
            SeedBookReviews();
            SeedBookStores();
            SeedArticles();
            SeedArticleComments();
            SeedEvents();
        }

        //Users
        public ApplicationUser AdminUser { get; set; }
        public ApplicationUser PublisherUser { get; set; }
        public ApplicationUser GuestUser { get; set; }
        public ApplicationUser RandomUserOne { get; set; }
        public ApplicationUser RandomUserTwo { get; set; }

        //Roles
        public Publisher Publisher { get; set; }
        public Publisher PublisherAdmin { get; set; }

        //Claims
        public IdentityUserClaim<string> AdminUserClaim { get; set; }
        public IdentityUserClaim<string> PublisherUserClaim { get; set; }
        public IdentityUserClaim<string> GuestUserClaim { get; set; }
        public IdentityUserClaim<string> RandomUserOneClaim { get; set; }
        public IdentityUserClaim<string> RandomUserTwoClaim { get; set; }

        //Genres
        public Genre Poetry { get; set; }
        public Genre Mystery { get; set; }
        public Genre Fantasy { get; set; }
        public Genre Thriller { get; set; }
        public Genre Romance { get; set; }
        public Genre ClassicLiterature { get; set; }
        public Genre Horror { get; set; }
        public Genre Adventure { get; set; }
        public Genre Biography { get; set; }
        public Genre Autobiography { get; set; }
        public Genre Crime { get; set; }
        public Genre Humor { get; set; }
        public Genre Fiction { get; set; }
        public Genre Drama { get; set; }
        public Genre Military { get; set; }
        public Genre History { get; set; }
        public Genre Philosophy { get; set; }
        public Genre Business { get; set; }
        public Genre Science { get; set; }
        public Genre Health { get; set; }
        public Genre Cooking { get; set; }
        public Genre Travel { get; set; }

        //CoverTypes
        public CoverType HardCover { get; set; }
        public CoverType SoftCover { get; set; }

        //Books
        public Book BookOne { get; set; }
        public Book BookTwo { get; set; }
        public Book BookThree { get; set; }
        public Book BookFour { get; set; }
        public Book BookFive { get; set; }
        public Book BookSix { get; set; }
        public Book BookSeven { get; set; }
        public Book BookEight { get; set; }
        public Book BookNine { get; set; }
        public Book BookTen { get; set; }
        public Book BookEleven { get; set; }
        public Book BookTwelve { get; set; }
        public Book BookThirteen { get; set; }
        public Book BookFourteen { get; set; }
        public Book BookFiveteen { get; set; }
        public Book BookSixteen { get; set; }
        public Book BookSeventeen { get; set; }

        //BookReviews
        public BookReview ReviewOne { get; set; }
        public BookReview ReviewTwo { get; set; }
        public BookReview ReviewThree { get; set; }
        public BookReview ReviewFour { get; set; }

        //Book Stores
        public BookStore BookStoreOne { get; set; }
        public BookStore BookStoreTwo { get; set; }
        public BookStore BookStoreThree { get; set; }
        public BookStore BookStoreFour { get; set; }
        public BookStore BookStoreFive { get; set; }
        public BookStore BookStoreSix { get; set; }
        public BookStore BookStoreSeven { get; set; }
        public BookStore BookStoreEight { get; set; }
        public BookStore BookStoreNine { get; set; }

        //Articles
        public Article ArticleOne { get; set; }
        public Article ArticleTwo { get; set; }
        public Article ArticleThree { get; set; }
        public Article ArticleFour { get; set; }
        public Article ArticleFive { get; set; }
        public Article ArticleSix { get; set; }
        public Article ArticleSeven { get; set; }
        public Article ArticleEight { get; set; }
        public Article ArticleNine { get; set; }

        //Article Comments
        public ArticleComment CommentOne;
        public ArticleComment CommentTwo;
        public ArticleComment CommentThree;
        public ArticleComment CommentFour;

        //Events
        public Event EventOne { get; set; }
        public Event EventTwo { get; set; }
        public Event EventThree { get; set; }
        public Event EventFour { get; set; }
        public Event EventFive { get; set; }
        public Event EventSix { get; set; }
        public Event EventSeven { get; set; }
        public Event EventEight { get; set; }
        public Event EventNine { get; set; }


        private void SeedUsers()
        {
            var hasher = new PasswordHasher<ApplicationUser>();

            AdminUser = new ApplicationUser()
            {
                Id = "c2f14bf7-ffdd-47a4-90b3-f2309486fae9",
                UserName = "admin@gmail.com",
                NormalizedUserName = "ADMIN@GMAIL.COM",
                Email = "admin@gmail.com",
                NormalizedEmail = "ADMIN@GMAIL.COM",
                FirstName = "Admin",
                LastName = "Adminov"
            };
            AdminUserClaim = new IdentityUserClaim<string>()
            {
                Id = 1,
                ClaimType = UserFullNameClaim,
                ClaimValue = "Admin Adminov",
                UserId = "c2f14bf7-ffdd-47a4-90b3-f2309486fae9"
            };
            AdminUser.PasswordHash = hasher.HashPassword(AdminUser, "admin420");


            PublisherUser = new ApplicationUser()
            {
                Id = "dea12856-c198-4129-b3f3-b893d8395082",
                UserName = "publisher@gmail.com",
                NormalizedUserName = "PUBLISHER@GMAIL.COM",
                Email = "publisher@gmail.com",
                NormalizedEmail = "PUBLISHER@GMAIL.COM",
                FirstName = "Publisher",
                LastName = "Publishov"
            };
            PublisherUserClaim = new IdentityUserClaim<string>()
            {
                Id = 2,
                ClaimType = UserFullNameClaim,
                ClaimValue = "Publisher Publishov",
                UserId = "dea12856-c198-4129-b3f3-b893d8395082"
            };
            PublisherUser.PasswordHash = hasher.HashPassword(PublisherUser, "publisher420");


            GuestUser = new ApplicationUser()
            {
                Id = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                UserName = "guest@gmail.com",
                NormalizedUserName = "GUEST@GMAIL.COM",
                Email = "guest@gmail.com",
                NormalizedEmail = "GUEST@GMAIL.COM",
                FirstName = "Guest",
                LastName = "Guestov"
            };
            GuestUserClaim = new IdentityUserClaim<string>()
            {
                Id = 3,
                ClaimType = UserFullNameClaim,
                ClaimValue = "Guest Guestov",
                UserId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e"
            };
            GuestUser.PasswordHash = hasher.HashPassword(GuestUser, "guest420");

            RandomUserOne = new ApplicationUser()
            {
                Id = "64ce3106-ec7d-44cb-b167-bf946b88bb1b",
                UserName = "nevena@gmail.com",
                NormalizedUserName = "NEVENA@GMAIL.COM",
                Email = "nevena@gmail.com",
                NormalizedEmail = "NEVENA@GMAIL.COM",
                FirstName = "Nevena",
                LastName = "Ilieva"
            };
            RandomUserOneClaim = new IdentityUserClaim<string>()
            {
                Id = 4,
                ClaimType = UserFullNameClaim,
                ClaimValue = "Nevena Ilieva",
                UserId = "64ce3106-ec7d-44cb-b167-bf946b88bb1b"
            };
            RandomUserOne.PasswordHash = hasher.HashPassword(GuestUser, "nevena420");

            RandomUserTwo = new ApplicationUser()
            {
                Id = "cabfd9b8-4411-47f6-9639-df70d753c275",
                UserName = "boris@gmail.com",
                NormalizedUserName = "BORIS@GMAIL.COM",
                Email = "boris@gmail.com",
                NormalizedEmail = "BORIS@GMAIL.COM",
                FirstName = "Boris",
                LastName = "Vladov"
            };
            RandomUserTwoClaim = new IdentityUserClaim<string>()
            {
                Id = 5,
                ClaimType = UserFullNameClaim,
                ClaimValue = "Boris Vladov",
                UserId = "cabfd9b8-4411-47f6-9639-df70d753c275"
            };
            RandomUserTwo.PasswordHash = hasher.HashPassword(GuestUser, "boris420");
        }

        private void SeedPublisher()
        {
            Publisher = new Publisher()
            {
                Id = 1,
                UserId = PublisherUser.Id
            };
            PublisherAdmin = new Publisher()
            {
                Id = 2,
                UserId = AdminUser.Id
            };
        }

        private void SeedGenres()
        {
            Poetry = new Genre()
            {
                Id = 1,
                Name = "Poetry"
            };
            Mystery = new Genre()
            {
                Id = 2,
                Name = "Mystery"
            };
            Fantasy = new Genre()
            {
                Id = 3,
                Name = "Fantasy"
            };
            Thriller = new Genre()
            {
                Id = 4,
                Name = "Thriller"
            };
            Romance = new Genre()
            {
                Id = 5,
                Name = "Romance"
            };
            ClassicLiterature = new Genre()
            {
                Id = 6,
                Name = "Classics"
            };
            Horror = new Genre()
            {
                Id = 7,
                Name = "Horror"
            };
            Adventure = new Genre()
            {
                Id = 8,
                Name = "Adventure"
            };
            Biography = new Genre()
            {
                Id = 9,
                Name = "Biography"
            };
            Autobiography = new Genre()
            {
                Id = 10,
                Name = "Autobiography"
            };
            Crime = new Genre()
            {
                Id = 11,
                Name = "Crime"
            };
            Humor = new Genre()
            {
                Id = 12,
                Name = "Humor"
            };
            Fiction = new Genre()
            {
                Id = 13,
                Name = "Fiction"
            };
            Drama = new Genre()
            {
                Id = 14,
                Name = "Drama"
            };
            Military = new Genre()
            {
                Id = 15,
                Name = "Military"
            };
            History = new Genre()
            {
                Id = 16,
                Name = "History"
            };
            Philosophy = new Genre()
            {
                Id = 17,
                Name = "Philosophy"
            };
            Business = new Genre()
            {
                Id = 18,
                Name = "Business"
            };
            Science = new Genre()
            {
                Id = 19,
                Name = "Science"
            };
            Health = new Genre()
            {
                Id = 20,
                Name = "Health"
            };
            Cooking = new Genre()
            {
                Id = 21,
                Name = "Cooking"
            };
            Travel = new Genre()
            {
                Id = 22,
                Name = "Travel"
            };
        }

        private void SeedCoverTypes()
        {
            SoftCover = new CoverType()
            {
                Id = 1,
                Name = "Soft"
            };
            HardCover = new CoverType()
            {
                Id = 2,
                Name = "Hard"
            };
        }

        private void SeedBooks()
        {
            BookOne = new Book()
            {
                Id = 1,
                Title = "Anna Karenina",
                Author = "Leo Tolstoy",
                GenreId = 6,
                Description = "Anna Karenina seems to have everything: she is beautiful, rich, married to an influential politician, and adores her son. But she feels her life is empty – until the moment she meets the elegant officer Count Vronsky. In a desperate attempt to find meaning in her life, she defies the traditions of society. She leaves her husband and son to live with her beloved. Condemned and isolated, Anna increasingly gives in to fits of jealousy toward Vronsky, which alienates him. Soon the young woman finds herself unable to escape an increasingly hopeless situation.",
                Pages = 832,
                YearPublished = 1877,
                CoverTypeId = 2,
                Price = 24.95m,
                ImageUrl = "https://www.ciela.com/media/catalog/product/cache/32bb0748c82325b02c55df3c2a9a9856/a/n/ana-karenina-lev-tolstoi-hermes-9789542619529.jpg",
                PublishingHouse = "Hermes"
            };

            BookTwo = new Book()
            {
                Id = 2,
                Title = "Hannibal",
                Author = "Thomas Harris",
                GenreId = 11,
                Description = "You already know Dr. Hannibal Lecter well – a refined gentleman, a perceptive psychologist and... yes, a sophisticated cannibal. For seven years he has been free since his escape from prison, seven years under a false identity lavishly enjoying life in the cradle of the Renaissance – Florence, and killing almost no one. The beast in him seems asleep. But there are people who have not forgotten him, and they are far from being only the FBI, who long to capture him again. A depraved rich man, brutally maimed by Dr. Lecter, would give anything to catch him alive, to feed him to a special breed of monstrous pigs bred for the purpose. The final hunt has begun, and this time the hunter himself is the prey. To his aid will come no one other than the beautiful agent Clarice Starling, who has gone from law enforcer to scapegoat of the system. The lambs in her have fallen silent, but Lecter's words still move her. And she is ready to answer the call of the brilliant psychopath. After in \"Red Dragon\" and \"The Silence of the Lambs\" the most famous serial killer in world literature showed what he is capable of, in \"Hannibal\" his story reaches its epic finale, in which all scores will be settled. And only one more story will remain to be told – the one in \"Hannibal Rising\", which describes the making of a charming monster.",
                Pages = 488,
                YearPublished = 1999,
                CoverTypeId = 1,
                Price = 19.90m,
                ImageUrl = "https://www.ciela.com/media/catalog/product/cache/32bb0748c82325b02c55df3c2a9a9856/_/-/_-_-_-_9789542838296_-_ciela.jpg",
                PublishingHouse = "Ciela"
            };

            BookThree = new Book()
            {
                Id = 3,
                Title = "The Girl with the Dragon Tattoo",
                Author = "Stieg Larsson",
                GenreId = 11,
                Description = "The wealthy industrialist Henrik Vanger offers Mikael Blomkvist a one-year contract for a huge fee if he can solve the mystery of the disappearance of his beloved niece Harriet. Mikael Blomkvist is an investigative journalist who has exposed a number of scandalous cases and was unjustly convicted of libel for an exposé he wrote against a powerful Swedish financial magnate. Together with super-hacker Lisbeth Salander – young, skinny, tattooed and registered as a psychopath, now working at a detective agency – they are caught in a whirlwind of dynamic events and dramatic trials, in a world of family hatred and financial scandals roamed by psychopathic killers. The trilogy with over 80 million readers worldwide tells of a real world of amoral financial spheres, extremist conspiracies and twisted justice.",
                Pages = 464,
                YearPublished = 2005,
                CoverTypeId = 1,
                Price = 16.00m,
                ImageUrl = "https://www.ciela.com/media/catalog/product/cache/32bb0748c82325b02c55df3c2a9a9856/m/i/millenium_1.jpg",
                PublishingHouse = "Colibri"
            };

            BookFour = new Book()
            {
                Id = 4,
                Title = "Me Before You",
                Author = "Jojo Moyes",
                GenreId = 5,
                Description = "Twenty-six-year-old Louisa Clark is an ordinary girl who likes her ordinary life. Lou lives with her family in a small house in a provincial English town. The young woman loves her job at the local cafe and her eccentric clothes. She is content with her quiet life, intends to marry her long-time boyfriend Patrick and have a bunch of kids with him. Her world turns upside down when she unexpectedly loses her job. Along with the lack of money, unemployment makes her feel useless. Lou makes tremendous efforts to find a new job, but a few weeks at a chicken processing factory and a fast food chain bring her to the brink of despair. So when she is offered a well-paid job as a personal assistant to a disabled man, she decides to try. Thirty-three-year-old Will Traynor grabs life with both hands. He loves his job, the challenges and the travels that constantly remind him how vast the world is. A motorcycle accident confines him to a wheelchair and turns his days into a joyless existence. Two years later, Will has no idea that Lou will become part of his life and shake it to its foundations. Neither of them suspects that meeting each other will change them forever...",
                Pages = 408,
                YearPublished = 2012,
                CoverTypeId = 1,
                Price = 17.95m,
                ImageUrl = "https://cdn.ozone.bg/media/catalog/product/cache/1/image/a4e40ebdc3e371adff845072e1c73f37/a/z/6d3e59789317f6a5d3c5e6dffb38e9db/az-predi-teb-30.jpg",
                PublishingHouse = "Hermes"
            };

            BookFive = new Book()
            {
                Id = 5,
                Title = "The Diary of Anne Frank",
                Author = "Anne Frank",
                GenreId = 10,
                Description = "The extraordinary diary written in the attic of a \"secret annex\" in Amsterdam, where the 13-year-old girl and her family spent two years hiding from the Nazis, takes its deserved place among the classics of the 20th century. With \"The Diary of Anne Frank\" the memory of one of the darkest eras in human history comes alive again in a luxury hardcover edition, complete and uncensored. In the darkest times of the last century, a seemingly ordinary girl creates day after day her love letter to life, youth and hope, her testimony to the strength of the human spirit. Anne Frank kept her diary from 12 June 1942 to 1 August 1944.",
                Pages = 312,
                YearPublished = 1947,
                CoverTypeId = 2,
                Price = 19.90m,
                ImageUrl = "https://www.ciela.com/media/catalog/product/cache/32bb0748c82325b02c55df3c2a9a9856/a/n/ane-frank-zadnata-kyshta-ciela-9789542827214.jpg",
                PublishingHouse = "Ciela"
            };
            
            BookSix = new Book()
            {
                Id = 6,
                Title = "Finders Keepers",
                Author = "Stephen King",
                GenreId = 4,
                Description = "Finders keepers! \"Wake up, genius!\" – from the very first sentence of his new novel Stephen King has us in his grip and does not let go until the very end. The genius is John Rothstein (the author who created the trilogy with the cult hero Jimmy Gold), who has not published a new book in decades and lives as a recluse. And the rude remark is aimed by Morris Bellamy, a young man obsessed with Jimmy Gold. Morris seethes with anger – not only has his beloved writer stopped creating, but before that he turned the rebel Jimmy Gold into a conformist who abandons his ideals for a career in advertising and bourgeois comfort. Rothstein must pay. With his life! Morris shoots him and takes the money from the safe hidden in the closet. Only the real treasure is not the thousands of dollars, but notebooks handwritten by Rothstein, containing at least one more novel about Jimmy Gold. Morris buries his loot, looking forward to soon reading the sequel to the trilogy, but – what an irony of fate! – he is arrested and sent to prison for another crime. After long years a boy named Peter Saubers accidentally stumbles upon the buried chest with the treasure, and now Bill Hodges, Holly Gibney and Jerome Robinson – the unforgettable trio from \"Mr. Mercedes\" – must protect Pete and his family from the cunning, revenge-hungry Morris, released after thirty-five years behind bars. For the first time since \"Misery\" Stephen King returns to the theme of the thin line between devotion to a fictional hero and fanaticism. \"Finders Keepers\" is a gripping thriller, but also a reflection on the way literature shapes our lives – for good or ill, but always irreversibly.",
                Pages = 480,
                YearPublished = 2015,
                CoverTypeId = 1,
                Price = 24.00m,
                ImageUrl = "https://cdn.ozone.bg/media/catalog/product/cache/1/image/a4e40ebdc3e371adff845072e1c73f37/t/a/93afd46bc6f480cdee09e8c4ced2d74a/tarsi-se-31.jpg",
                PublishingHouse = "Pleiad"
            };

            BookSeven = new Book()
            {
                Id = 7,
                Title = "Quo Vadis",
                Author = "Henryk Sienkiewicz",
                GenreId = 6,
                Description = "A complete luxury edition of one of the most-read novels of the 20th century\r\n\r\nRome during the reign of Nero is a seemingly glamorous place. Lavish feasts and poetry contests are organized, and the entertainments in Circus Maximus seem endless. On the other side of the coin, however, are debauchery and lack of morals, the poverty of the people and the madness of the emperor, who sets fire to his own city.\r\n\r\nIn these dark days of the decline of the Roman Empire, the young soldier Marcus Vinicius falls in love with Lygia – the captive daughter of a barbarian king. But he does not suspect that his beloved professes the Christian faith, for which many have already lost their lives.\r\n\r\nThe fates of Vinicius and Lygia intertwine, and the two watch the world they know change before their eyes. And while the apostles Peter and Paul try to save the immoral city from ruin, the Christians are subjected to cruel persecution.",
                Pages = 560,
                YearPublished = 2020,
                CoverTypeId = 2,
                Price = 24.95m,
                ImageUrl = "https://cdn.ozone.bg/media/catalog/product/cache/1/image/a4e40ebdc3e371adff845072e1c73f37/q/u/fb2e33e9edf08ab8b8e46d9237e5ab06/quo-vadis-hermes-30.jpg",
                PublishingHouse = "Hermes"
            };
            
            BookEight = new Book()
            {
                Id = 8,
                Title = "Tobacco (Set - Volumes 1 and 2)",
                Author = "Dimitar Dimov",
                GenreId = 6,
                Description = "Probably Dimov's entire new approach to the novel, the new structure and unexpected accents in \"Tobacco\" were one of the reasons it was not understood when it first appeared. Many ranked the author among the exotic flowers, grown and cultivated not on our fruitful cultural soil. But today it is clear that with his attempt Dimitar Dimov bequeathed, and with his example supported, a new trend in the national novel, expanded its horizons, enriched its traditions. In \"Tobacco\" the mature thought, taste and intellect of the moralist bridge the frightening distance between his wanderings through foreign worlds and our own national historical experience; they have found their own language for our new national experience. Bridging this huge distance, the unusual parabola of this journey also overcame the death of the novel in intellectual dryness and speculation, opening new, not purely plastic paths for the development of the future Bulgarian novel and for our new narrative art.",
                Pages = 864,
                YearPublished = 2019,
                CoverTypeId = 2,
                Price = 45.00m,
                ImageUrl = "https://cdn.ozone.bg/media/catalog/product/cache/1/image/a4e40ebdc3e371adff845072e1c73f37/t/j/1940371da707cb6bf1a3b777c9b3f9f1/tyutyun-komplekt---1-i-2-tom-30.jpg",
                PublishingHouse = "Ciela"
            };
            
            BookNine = new Book()
            {
                Id = 9,
                Title = "Britney Spears: The Woman in Me - Autobiography",
                Author = "Britney Spears",
                GenreId = 10,
                Description = "\"The Woman in Me\" is a brave and astonishingly moving story about freedom and fame, motherhood and survival, faith and hope! In June 2021 the whole world listened with bated breath as Britney Spears spoke at an open court hearing. The chance to be heard – and to share her truth – had an undeniable impact that changed the direction of her life, as well as the lives of many others. \"The Woman in Me\" reveals for the first time her incredible life journey – and the inner strength of one of the greatest performers in pop music history. Written with remarkable candor and humor, Britney Spears's shattering memoirs illuminate the enduring power of music and love and show how important it is for a woman to tell her story in her own words, as she sees it. This is happening now. Multi-platinum Grammy Award winner, pop icon Britney Spears is one of the most successful and famous performers in music history with over 100 million records sold. In 2021 she was named by Time magazine as one of the 100 most influential people.",
                Pages = 240,
                YearPublished = 2023,
                CoverTypeId = 2,
                Price = 19.99m,
                ImageUrl = "https://cdn.ozone.bg/media/catalog/product/cache/1/image/a4e40ebdc3e371adff845072e1c73f37/b/r/219d4cce0a619d1122bab9cd24e91c5e/britni-spiars--zhenata-v-men---avtobiografiya-30.jpg",
                PublishingHouse = "Ciela"
            };

            BookTen = new Book()
            {
                Id = 10,
                Title = "At Mom's",
                Author = "Ivo Siromahov",
                GenreId = 12,
                Description = "A hilarious collection of stories about mothers, family gatherings, and the everyday comedy of Bulgarian life. Ivo Siromahov serves up his signature wit in short tales that will make you laugh out loud and nod in recognition.",
                Pages = 352,
                YearPublished = 2020,
                CoverTypeId = 2,
                Price = 15.90m,
                ImageUrl = "https://cdn.ozone.bg/media/catalog/product/cache/1/image/a4e40ebdc3e371adff845072e1c73f37/y/-/d93901634b9ba810eb05ed61dc67608a/u-maykini-30.jpg",
                PublishingHouse = "Ciela"
            };

            BookEleven = new Book()
            {
                Id = 11,
                Title = "The Witcher 1: The Last Wish",
                Author = "Andrzej Sapkowski",
                GenreId = 3,
                Description = "Geralt of Rivia, the White Wolf, returns to bookstores! The book that forever changed people's ideas of modern fantasy, skillfully intertwining motifs from classic fairy tales, Eastern European mythology and Raymond Chandler's crime stories. The book that launched a series which inspired the cult role-playing game series The Witcher and gave us one of the most iconic characters of the entertainment industry – Geralt of Rivia. He is no hero. Not the knight in shining armor who saves the damsel at the last moment. He is a professional who kills monsters for pay. A witcher – one of the last representatives of a legendary caste of mutants, created to stand with sword in hand against everything that lurks in the dark, beyond the fires of human settlements. He is a legend. And this is the beginning of his story!",
                Pages = 316,
                YearPublished = 2016,
                CoverTypeId = 1,
                Price = 25.00m,
                ImageUrl = "https://ciela.bg/wp-content/uploads/2020/07/61078ba28b743deaed799f19905cf6c4.jpg",
                PublishingHouse = "Ciela"
            };

            BookTwelve = new Book()
            {
                Id = 12,
                Title = "I Still Count the Days",
                Author = "Georgi Bardarov",
                GenreId = 15,
                Description = "The story takes us to one of the bloodiest periods in Balkan history – the siege of Sarajevo. Bardarov's book is a story of war and love, above all of a love that transcends time. A warm May night in 1993. The siege of Sarajevo began a year ago and no end is in sight, just like the fratricidal war between the formerly allied Yugoslav peoples. A young Serbian couple stand in their kitchen, sunk in silence. Davor, a Christian, and Aida, a Muslim, have preserved their love amid the ruins and madness reigning in the besieged city. They know that the next brief, barely half-hour lull is approaching, when the snipers rest. Staring at the hands of the clock, they have made the decision to escape – to reach freedom... or to meet death. Twenty years later a Bulgarian travels to Sarajevo to meet the Serbian translator of his book. They soon find themselves in a tavern and imperceptibly start talking about the war. As the hours advance, the empty bottles on the table multiply, and long-buried secrets surface. Two nights. Four fates. All leading to the most important questions. Who started this war? And who profited from it?",
                Pages = 182,
                YearPublished = 2016,
                CoverTypeId = 1,
                Price = 14.00m,
                ImageUrl = "https://ciela.bg/wp-content/uploads/2020/07/330956df410727967d0c2b77316a204b.jpg",
                PublishingHouse = "Ciela"
            };

            BookThirteen = new Book()
            {
                Id = 13,
                Title = "The War of the Letters",
                Author = "Lyudmila Filipova",
                GenreId = 3,
                Description = "In the novel \"The War of the Letters\" the inimitable Lyudmila Filipova focuses her creative talent on one of the most important moments in Bulgarian history and reveals the life battles and challenges of Tsar Simeon, his sons and their greatest adversaries. The creation, establishment and preservation of the Bulgarian alphabet is a deed we are not just proud of – it defines us as a strong and unshakable people. Yet there is a mystique involved that remains unsolved to this day – who is Chernorizets Hrabar and what is the hidden power of the letters? This is a secret that overturns the fate of thousands, decides battles and bestows unearthly powers. Power, love, manipulation and epic battles intertwine in the historical novel, revealing the mysterious events behind one of the most emblematic periods in Bulgarian history. And one of the greatest deeds of the Bulgarian people and their apostles of letters.",
                Pages = 552,
                YearPublished = 2019,
                CoverTypeId = 1,
                Price = 22.00m,
                ImageUrl = "https://www.ciela.com/media/catalog/product/e/n/enthusiast_voynata-na-bukvite_otkas-01.jpg",
                PublishingHouse = "Enthusiast"
            };

            BookFourteen = new Book()
            {
                Id = 14,
                Title = "The Hunger Games",
                Author = "Suzanne Collins",
                GenreId = 13,
                Description = "In the ruins of what was once North America lies the state of Panem with its glittering capital, the Capitol, and its twelve districts. The Capitol is ruthless and keeps the districts in submission by forcing them to send one boy and one girl between the ages of twelve and eighteen to the annual Hunger Games - a reality show broadcast live on television. Katniss Everdeen knows she is signing her death sentence when she voluntarily takes the place of her younger sister in the Games. Katniss has been close to death more than once - and survival has become her second nature. But if she wants to win, she will have to choose between survival and humanity, between life and love. Suzanne Collins serves up equal parts suspense and philosophy, adventure and love in this scorching novel, set in a future disturbingly reminiscent of our present. Victory means wealth and fame. Defeat means certain death. The Hunger Games begin...",
                Pages = 376,
                YearPublished = 2015,
                CoverTypeId = 1,
                Price = 14.90m,
                ImageUrl = "https://cdn.ozone.bg/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/i/g/21c0fb1dee462cdb569e1abe136df330/igrite-na-glada-30.jpg",
                PublishingHouse = "Exlibris"
            };

            BookFiveteen = new Book()
            {
                Id = 15,
                Title = "Catching Fire (The Hunger Games 2)",
                Author = "Suzanne Collins",
                GenreId = 13,
                Description = "In the ruins of what was once North America lies the state of Panem with its glittering capital, the Capitol, and its twelve districts. The Capitol is ruthless and keeps the districts in submission by forcing them to send one boy and one girl between the ages of twelve and eighteen to the annual Hunger Games - a reality show broadcast live on television. Only one can win the Games. And watching is mandatory! Improbably enough, Katniss Everdeen is the winner of the Hunger Games. And victory means wealth and fame. Now Katniss should be happy - after all, she is back with her family and her old friend Gale. But nothing is quite as she wants it. And there are rumors of a rebellion against the Capitol - a rebellion Katniss may have helped spark. In the second part of the "Hunger Games" trilogy Suzanne Collins continues Katniss's story, putting her through even more trials and serving up surprises on every page.",
                Pages = 384,
                YearPublished = 2015,
                CoverTypeId = 1,
                Price = 14.90m,
                ImageUrl = "https://cdn.ozone.bg/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/i/g/a25f88a9f0259f66c7f210909fbba17f/vazplamenyavane-igrite-na-glada-2-31.jpg",
                PublishingHouse = "Exlibris"
            };

            BookSixteen = new Book()
            {
                Id = 16,
                Title = "Mockingjay (The Hunger Games 3)",
                Author = "Suzanne Collins",
                GenreId = 13,
                Description = "District 12, the home of Katniss Everdeen, the girl on fire, has been destroyed, but she is alive. Gale has escaped. Katniss's family is safe. Peeta is in the hands of the Capitol. District 13 really exists, there are rebels, there are new leaders. The revolution is flaring up. Now the success of the uprising depends on Katniss's willingness to submit, to take responsibility for the lives of countless people and to change the future of Panem. To do so, she must overcome her anger and distrust and become the Mockingjay - the symbol of the rebellion - whatever the personal cost to her. The stunning finale of \"The Hunger Games\" trilogy.",
                Pages = 384,
                YearPublished = 2015,
                CoverTypeId = 1,
                Price = 14.90m,
                ImageUrl = "https://www.ciela.com/media/catalog/product/1/1/112444.jpeg",
                PublishingHouse = "Exlibris"
            };

            BookSeventeen = new Book()
            {
                Id = 17,
                Title = "The Ballad of Songbirds and Snakes (The Hunger Games) - movie cover",
                Author = "Suzanne Collins",
                GenreId = 13,
                Description = "The morning of the Reaping that begins the tenth "Hunger Games". In the Capitol, eighteen-year-old Coriolanus Snow prepares for this single chance to win fame as a mentor in the Games. Hard times have come for the once-mighty Snow family, and its fate depends on the slim chance that Coriolanus manages to be more charming, smarter and more resourceful than his classmates, so he can become mentor to the winning tribute. The odds of winning are small. He gets the humiliating task of mentoring the girl tribute from District 12, the most insignificant of all. The fates of the two are now completely intertwined - every decision Coriolanus makes can lead to victory or failure, triumph or defeat. In the arena the battle will be to the death. Outside the arena Coriolanus begins to sympathize with his doomed tribute... and must balance between the need to follow the rules and the desire to survive at any cost.",
                Pages = 492,
                YearPublished = 2019,
                CoverTypeId = 1,
                Price = 20.00m,
                ImageUrl = "https://img.cms.bweb.bg/media/images/640x/Nov2023/2113171734.webp",
                PublishingHouse = "Exlibris"
            };
        }

        private void SeedBookReviews()
        {
            ReviewOne = new BookReview()
            {
                Id = 1,
                Title = "Loved it!",
                Description = "The book left me speechless! Extremely well written. Of course my favorite character is Lisbeth Salander. Recommended!",
                Rate = 9,
                BookId = 3,
                UserId = "dea12856-c198-4129-b3f3-b893d8395082"
            };
            ReviewTwo = new BookReview()
            {
                Id = 2,
                Title = "Can't say it's anything special.",
                Description = "I'm a fan of crime novels, but this book didn't grab me. It felt too superficial and not very descriptive. Still, not bad.",
                Rate = 6,
                BookId = 3,
                UserId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e"
            };
            ReviewThree = new BookReview()
            {
                Id = 3,
                Title = "It became my favorite!",
                Description = "I just finished \"The Girl with the Dragon Tattoo\" by Stieg Larsson. I listened to the book on Storytel, as the title sounded extremely trivial and unnecessarily dramatic to me. Books that don't sound that interesting to me, but are highly rated by readers, I leave to listen to on Storytel. The same happened with \"The Girl with the Dragon Tattoo\" - at first I viewed it with skepticism, but I was wrong in my judgment and this book turned out to be deservedly highly rated. I am a thriller fan, especially of crime novels. The characters were carefully built, and most of all I liked Lisbeth Salander. She surprisingly became my favorite. A strange girl, part of the emo culture, with tattoos and piercings. Extremely atypical and intelligent. The story around the Vanger family is horrifying, but I won't say more so as not to reveal the plot to those who haven't picked up this deserved undisputed bestseller yet. I learned there is a movie from 2011. Of course - I will watch it, although I'm sure it won't be the same.",
                Rate = 10,
                BookId = 3,
                UserId = "64ce3106-ec7d-44cb-b167-bf946b88bb1b"
            };
            ReviewFour = new BookReview()
            {
                Id = 4,
                Title = "Didn't like it one bit",
                Description = "Not well written at all. The plot is flat and uninteresting.",
                Rate = 3,
                BookId = 3,
                UserId = "cabfd9b8-4411-47f6-9639-df70d753c275"
            };
        }

        private void SeedBookStores()
        {
            BookStoreOne = new BookStore()
            {
                Id = 1,
                Name = "Ciela - Vitosha",
                Location = "Sofia Center, 60 Vitosha Blvd, 1463 Sofia",
                ImageUrl = "https://adandcity.files.wordpress.com/2015/05/926.jpg",
                OpeningTime = DateTime.ParseExact("09:00", DateTimeBookStoreFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                ClosingTime = DateTime.ParseExact("21:00", DateTimeBookStoreFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                Contact = "0876536843",
            };
            BookStoreTwo = new BookStore()
            {
                Id = 2,
                Name = "Helikon - Pazardzhik",
                Location = "Pazardzhik Center, 23 Professor Asen Zlatarov St, 4400 Pazardzhik",
                ImageUrl = "https://i.helikon.bg/content/601/202304270903201726.jpg",
                OpeningTime = DateTime.ParseExact("09:00", DateTimeBookStoreFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                ClosingTime = DateTime.ParseExact("19:30", DateTimeBookStoreFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                Contact = "0896236457",
            };
            BookStoreThree = new BookStore()
            {
                Id = 3,
                Name = "Orange - The Mall",
                Location = "Karo area, 115 Tsarigradsko Shose Blvd, 1000 Sofia",
                ImageUrl = "https://www.orangecenter.bg/media/extensa_shop/image/grand-mall-varna_1.jpg",
                OpeningTime = DateTime.ParseExact("10:00", DateTimeBookStoreFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                ClosingTime = DateTime.ParseExact("22:00", DateTimeBookStoreFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                Contact = "0892414935",
            };
            BookStoreFour = new BookStore()
            {
                Id = 4,
                Name = "Helikon - Plovdiv Center",
                Location = "29 Knyaz Aleksandar I St, Plovdiv",
                ImageUrl = "https://cdn.oink.bg/gallery/23010/05adf581-0397-4f92-a9fa-65a087cd918f_large.webp",
                OpeningTime = DateTime.ParseExact("09:00", DateTimeBookStoreFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                ClosingTime = DateTime.ParseExact("20:00", DateTimeBookStoreFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                Contact = "032 207 621",
            };
            BookStoreFive = new BookStore()
            {
                Id = 5,
                Name = "From A to Z - Sofia Center",
                Location = "Lozenets district, 1 Dragalevska St, 1407 Sofia",
                ImageUrl = "https://lh3.googleusercontent.com/p/AF1QipM6sAeCcik9kS-GHs0pAigNGtXReSFIrBZmMVdy=s680-w680-h510-rw",
                OpeningTime = DateTime.ParseExact("09:30", DateTimeBookStoreFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                ClosingTime = DateTime.ParseExact("19:00", DateTimeBookStoreFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                Contact = "0899997719",
            };
            BookStoreFive = new BookStore()
            {
                Id = 5,
                Name = "From A to Z - Sofia Center",
                Location = "Lozenets district, 1 Dragalevska St, 1407 Sofia",
                ImageUrl = "https://lh3.googleusercontent.com/p/AF1QipPgXofDl2u9d6h6aNNQ6Phs0i7mzeVYEwU5ssQX=s680-w680-h510-rw",
                OpeningTime = DateTime.ParseExact("09:00", DateTimeBookStoreFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                ClosingTime = DateTime.ParseExact("20:00", DateTimeBookStoreFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                Contact = "0878929358",
            };
            BookStoreSix = new BookStore()
            {
                Id = 6,
                Name = "Ciela Books & Music - Plovdiv",
                Location = "Kazarmi Iztochen, 3 Dr. Georgi Stranski St, floor 2, 4019 Plovdiv",
                ImageUrl = "https://lh3.googleusercontent.com/p/AF1QipNKR7OEDjOL8kyn96Fz8P-EFTLP5VQvpi0i1CSi=s680-w680-h510-rw",
                OpeningTime = DateTime.ParseExact("10:00", DateTimeBookStoreFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                ClosingTime = DateTime.ParseExact("21:00", DateTimeBookStoreFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                Contact = "0876211144",
            };
            BookStoreSeven = new BookStore()
            {
                Id = 7,
                Name = "Bookpoint - Varna",
                Location = "Varna Center Odessos, 1 Tsar Simeon I St, 9000 Varna",
                ImageUrl = "https://lh3.googleusercontent.com/p/AF1QipOoQHzIG3B8LxmxLjyoCSlDD93L6ftaFLVYFWzX=s680-w680-h510-rw",
                OpeningTime = DateTime.ParseExact("10:00", DateTimeBookStoreFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                ClosingTime = DateTime.ParseExact("19:00", DateTimeBookStoreFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                Contact = "0879228009",
            };
            BookStoreEight = new BookStore()
            {
                Id = 8,
                Name = "Ciela - Ruse",
                Location = "121 D Lipnik Blvd, 7000 Ruse",
                ImageUrl = "https://lh3.googleusercontent.com/p/AF1QipPbLF_2y5KAuPxHse21tPodoOooVGlsa1R5gJ4p=s680-w680-h510-rw",
                OpeningTime = DateTime.ParseExact("10:00", DateTimeBookStoreFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                ClosingTime = DateTime.ParseExact("20:30", DateTimeBookStoreFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                Contact = "0882560013",
            };
            BookStoreNine = new BookStore()
            {
                Id = 9,
                Name = "Ciela - Burgas",
                Location = "North Industrial Zone, Yanko Komitov Blvd, 8001 Burgas",
                ImageUrl = "https://lh3.googleusercontent.com/p/AF1QipONKzh539ObWS-NI_g3XohjjChkUr2khxVk7bP6=s680-w680-h510-rw",
                OpeningTime = DateTime.ParseExact("10:00", DateTimeBookStoreFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                ClosingTime = DateTime.ParseExact("21:00", DateTimeBookStoreFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                Contact = "0877257199",
            };
        }

        private void SeedArticles()
        {
            ArticleOne = new Article()
            {
                Id = 1,
                Title = "\"The Girl with the Dragon Tattoo\" by Stieg Larsson in a new edition",
                Content = "A new edition of \"The Girl with the Dragon Tattoo\" (translated by Neda Dimova-Brenstrom, 464 pages, price: 18 BGN, Colibri Publishing) has been released - the most stunning thriller of the early 21st century. The spectacular cover is by Zhivko Petrov. MILLENNIUM is the name of the newspaper co-owned and edited by Mikael Blomkvist, the main character of the thriller trilogy. Upon its release in 2005, the trilogy achieved phenomenal worldwide success. \"The Girl with the Dragon Tattoo,\" the first book of the series, won the Glass Key Award for Best Scandinavian Novel of 2005, and the second, \"The Girl Who Played with Fire,\" won the award for Best Swedish Crime Novel of 2006. Over 86 million copies of the three books have been sold to date. Wealthy industrialist Henrik Vanger offers Mikael Blomkvist a one-year contract for a huge fee if he can solve the mystery of the disappearance of his beloved niece Harriet. Together with super-hacker Lisbeth Salander, they fall into a whirlwind of dramatic trials, family hatred, and financial scandals. The MILLENNIUM trilogy tells of a world of amoral financial deals, extremist conspiracies, and twisted justice. Stieg Larsson (1954-2004) was a renowned Swedish journalist and writer. The Millennium trilogy brought him extraordinary popularity.",
                ImageUrl = "https://i0.wp.com/vevesti.bg/wp-content/uploads/2021/11/9089304680924850968250498290457.jpg?resize=678%2C509&ssl=1",
                DatePublished = DateTime.ParseExact("24/04/2023 10:00", DateTimeArticleFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                ViewsCount = 0
            };

            ArticleTwo = new Article()
            {
                Id = 2,
                Title = "Harry Potter book gathering dust for 26 years sold for 55,000 pounds",
                Content = "In the United Kingdom, a copy of the first edition of \"Harry Potter and the Philosopher's Stone\" by J.K. Rowling, kept for 26 years in a cupboard under the stairs, was sold at auction, reports Derbyshire Times. The book was sold on December 11 at Hansons Auctioneers in Derbyshire for 55,100 pounds. For many years it was kept by a 58-year-old resident who bought it in 1997 during a family trip. In the shop, the children's book was in the bargain basket and sold for only 10 pounds. \"I bought a Harry Potter book when nobody knew about him or his author. We were driving through the Scottish Highlands. There was a coffee-bookshop on a distant peninsula at the end of the road,\" the woman recalls. She also noted that she managed to bargain the book down to eight pounds since it had no dust jacket. During the trip, every evening the Briton read the tale to her children. Later the book was put away in a closet, where it was stored until recently. The book was preserved in excellent condition. A specialist from Hansons Auctioneers revealed that this is a very rare first hardcover edition of Joan Rowling's first Harry Potter novel. A total of 500 books were printed, 300 of them distributed to libraries, and only 200 released for sale. Currently only 19 books from this print run are known to collectors. They have sold at auctions for sums of 17,500 to 69,000 British pounds. It was also previously reported that librarian Janet Taqwell decided to sell first editions of Harry Potter books with the author's autographs.",
                ImageUrl = "https://www.tialoto.bg/media/files/resized/article/615x348/7e2/ad7a2b33b135c4662c374a7a37a8d7e2-5580840.jpg",
                DatePublished = DateTime.ParseExact("02/02/2024 14:00", DateTimeArticleFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                ViewsCount = 0
            };

            ArticleThree = new Article()
            {
                Id = 3,
                Title = "Ivo Siromahov presents his novel \"Bai Tosho\" today in Burgas",
                Content = "From 5:30 PM in the Ahelo hall of the Grand Hotel and SPA Primorets - organizer of the cultural forum - writer, screenwriter, playwright, and TV host Ivo Siromahov will present his new book \"Bai Tosho.\" The read, with the Ciela logo, is a funny, merciless satire of the absurd times we live in. \"Bulgaria today. After the failure of all puppet parties created by invisible political engineers, a severe deadlock has been reached. It is time to play the last trump card. With the help of modern technology, an oligarch resurrects the image of Bai Tosho and puts him at the head of the state. To 'fix' everything...\" - reads the book's annotation. Come learn more in person from its author Ivo Siromahov. There will be talks, books, autographs.",
                ImageUrl = "https://www.burgasnews.com/wp-content/uploads/2023/10/ivo-siromahov.jpg",
                DatePublished = DateTime.ParseExact("18/02/2024 19:30", DateTimeArticleFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                ViewsCount = 0
            };
            
            ArticleFour = new Article()
            {
                Id = 4,
                Title = "Salman Rushdie answers violence with art",
                Content = "British writer of Indian origin Salman Rushdie, a man of incorruptible conscience, uncompromising toward any form of dictatorship and restriction of freedom of speech, was honored with the Peace Prize of the German Publishers and Booksellers Association during the Frankfurt Book Fair. This is one of the most significant German distinctions, first awarded in 1950. With it, Rushdie joins writers such as Margaret Atwood, Orhan Pamuk, Susan Sontag, Amos Oz, and Vaclav Havel. The jury announced that the writer was chosen for his unbreakable spirit and consistent affirmation of life. Praising Rushdie in his speech, his friend and colleague, writer Daniel Kehlmann, described him as \"probably the most important defender of the freedom of art and speech of our time.\" Rushdie, who is undoubtedly one of the most skillful and enchanting storytellers today, thanked for the award but noted that \"peace at the moment seems like a fantasy born of drug use.\" In his speech at St. Paul's Church, the 76-year-old author of \"The Satanic Verses\" and \"Quichotte\" condemned Russia's war against Ukraine and expressed hope that the terror in the Middle East would end as soon as possible. \"I never imagined I would live to see such a time. A time in which freedom - especially freedom of speech, without which the world of literature could not exist - is attacked everywhere by reactionary, authoritarian, populist voices.\" Rushdie did not spare criticism of American political reality either.",
                ImageUrl = "https://www.colibri.bg/news_img/20231027_1.jpg",
                DatePublished = DateTime.ParseExact("10/04/2024 19:34", DateTimeArticleFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                ViewsCount = 0
            };

            ArticleFive = new Article()
            {
                Id = 5,
                Title = "Silvia Wagenstein with a special award from the Union of Translators",
                Content = "On International Translators Day, September 30, at a special ceremony in Hall 65 of the Rectorate of Sofia University \"St. Kliment Ohridski,\" the Union of Translators in Bulgaria presented the Annual Translation Awards in various categories. We are pleased to announce that a jury composed of Galina Melamed, Lyudmil Dimitrov, and Darin Tenev awarded this year's Special Prize for exceptionally high achievements in the translation of fiction (poetry) to Silvia Wagenstein - for her translation from French of the conceptually selected poems of Paul Eluard in \"Poetry,\" rendered with the full authorial range of imagery, melody, and poetic messages in an equally rich and vivid Bulgarian language. Besides being the author of the congenial translation, Silvia Wagenstein is behind the compilation, foreword, and notes to this exquisite edition, which offers an extract from 14 poetry books by the great French artist. Here are the jury's motives: \"Translator Silvia Wagenstein presents us with a conceptual volume of selected poetry by Paul Eluard, unburdened by ideological layers. Sustained and magnificently interpreted, the present Eluard is Wagenstein's choice and personal anthology, which she wants to share with her readers. Far more important are the linguistic energies, tremors, and quakes that survived in the translation, the melody, and especially the personal, intimate message, paralleled with the competent foreword by the devoted translator.\"",
                ImageUrl = "https://www.colibri.bg/news_img/202301002_1.jpg",
                DatePublished = DateTime.ParseExact("11/04/2024 13:14", DateTimeArticleFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                ViewsCount = 0
            };

            ArticleSix = new Article()
            {
                Id = 6,
                Title = "Angel Wagenstein has passed into eternity",
                Content = "At the age of one hundred, Angel Wagenstein has left us, one of the brightest intellectuals of our time. A man of an era. A personality of proverbial integrity, spirit, and wisdom, who gave life to dozens of film scripts, enlightening speeches, insightful \"scribbles,\" and the world-renowned fiction triptych \"Isaac's Torah,\" \"Far from Toledo,\" and \"Farewell, Shanghai,\" dedicated to the fate of European Jews during World War II. Tending words, arranging them with warmth and responsibility like pearls in the necklace of memory, Wagenstein bequeathed us a captivating tale of the murky whirlpool of a pivotal era, of the diversity of human characters and the collapse of illusions, of life's complex knot, which is heartlessly short, while human hope is unquenchable. The trials that failed to crush his faith in a more just world order remind us today of the famous Jewish proverb \"Ash is more dignified than sand - because it has burned.\" And if we borrow a particle of his brilliant eloquence, we will say that his work is \"a finely written love letter - an encoded confession of affection and even love - to you, reader, to all people of goodwill, and to that unbearable but dear rascal, life, which annoys us constantly until merciful chance one day kicks it away...\" All that is expected of us is to learn to read. The memorial service will be held at the Sofia Synagogue on the thirtieth day after death, as Jewish tradition commands. Homage to the memory of the man and artist Angel Wagenstein, who left a lasting mark on Bulgarian culture!",
                ImageUrl = "https://www.colibri.bg/news_img/20230629_1.jpg",
                DatePublished = DateTime.ParseExact("12/04/2024 09:46", DateTimeArticleFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                ViewsCount = 0
            };

            ArticleSeven = new Article()
            {
                Id = 7,
                Title = "New book from the Robert Galbraith series expected in September",
                Content = "The seventh novel from the hit Cormoran Strike series will have its world premiere on September 26, 2023, in the year marking exactly one decade since the release of the first bestseller - \"The Cuckoo's Calling.\" This fall, Sphere, an imprint of Little, Brown Book Group, will publish The Running Grave by Robert Galbraith, pseudonym of J.K. Rowling. By tradition, print, electronic, and audio editions are planned. \"The Running Grave\" will be the seventh title in a planned series of ten books, and all six previous titles became international bestsellers. The Cormoran Strike and Robin Ellacott series is described as \"extremely engaging\" (Daily Express), \"the work of a master storyteller\" (Daily Telegraph), and \"amazing crime writing\" (Sunday Times), while protagonists Strike and Robin are \"one of the most engaging duos in crime literature\" (Guardian). \"The Cuckoo's Calling\" won the Nielsen Platinum award for surpassing 1,000,000 copies sold. \"It has been a wonderful experience witnessing the immense success of Robert Galbraith's books over the past ten years. It is an honor for us to publish them. With over 11 million copies sold in English to date, the story of Strike and Robin continues to command readers' imaginations,\" admits David Shelley, CEO of Hachette UK.",
                ImageUrl = "https://www.colibri.bg/news_img/20230505_1.jpg",
                DatePublished = DateTime.ParseExact("13/04/2024 11:20", DateTimeArticleFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                ViewsCount = 0
            };

            ArticleEight = new Article()
            {
                Id = 8,
                Title = "The first bookstore with 360-degree virtual reality",
                Content = "It is now a fact: the only Bulgarian bookstore with implemented 360-degree virtual reality - Libraria, https://www.colibri.bg/libraria/. It is an integral part of the Colibri Publishing House website. The virtual bookstore can be reached via the link or from the colibri.bg menu. Besides offering an exceptional opportunity to select and purchase books in a virtual environment for the first time in Bulgaria, and perhaps in the world, this integrated functionality of the publisher's website will provide a bonus of an additional 10% discount on absolutely all current reductions on the main site! The 360-degree tour is a unique, almost surreal adventure in the company of titles from various genres by acclaimed artists and thinkers. Recreating the interior of a physical bookstore, the 3D visualization provides an experience as close to sensory as possible. Thanks to VR technology, the interactive experience allows a 360-degree walk in an excellently built virtual space, factual access to every product, real book selection, and an optimized purchase process. Libraria is the first virtual bookstore of its kind - a true literary universe in which each object is a microcosm. An invitation to meaningful entertainment, addressed to every awake mind, but also to all those growing readers instinctively drawn to great literature. All available titles of Colibri Publishing House will be on offer - masterpieces of world fiction, classical poetry, select contemporary European and Bulgarian prose, inventive thrillers, irresistible offers for children, scientific works, essays and documentaries, language systems and study aids.",
                ImageUrl = "https://www.colibri.bg/news_img/20220715_1.jpg",
                DatePublished = DateTime.ParseExact("14/04/2024 17:03", DateTimeArticleFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                ViewsCount = 0
            };

            ArticleNine = new Article()
            {
                Id = 9,
                Title = "Two \"Hristo G. Danov\" awards for Colibri editions",
                Content = "At a solemn ceremony in the Old Town of Plovdiv, this year's laureates of the national \"Hristo G. Danov\" award, given for contribution to Bulgarian literary culture, were announced. The statuette for translator of fiction went to Vasil Samokovliev, honored for the brilliant translation of the novella \"Weddings in the House\" by Bohumil Hrabal. \"Weddings in the House\" is an ironic portrait of artistic life in post-war Eastern Europe and an eloquent testimony of how an artist's personal history can be reworked into brilliant form through literature. In the category \"Artist or design and layout of a book,\" the award went to Yasen Gyuzelev for the admirable edition \"Orpheus and Eurydice.\" The story of Orpheus and Eurydice is one of the saddest myths in all of Greek mythology. In the Colibri edition, it is movingly illustrated with Yasen Gyuzelev's original illustrations. The artistic layout is by Kiril Zlatkov. The jury this year was represented by Yuri Valkovski - Deputy Minister of Culture, Plamen Panov, Deputy Mayor of Plovdiv Municipality, Anton Baev, Dr. Silva Hacheryan, Dimitar Minev, Director of the Ivan Vazov National Library - Plovdiv, Boyko Lambovski, Prof. Magdalena Kostova-Panayotova, Ivan Esenski, Tonya Goranova. The \"Hristo G. Danov\" awards are organized by the Ministry of Culture and Plovdiv Municipality. The laureates receive a diploma, a small sculpture, and a cash prize. The awards are presented annually on the occasion of May 24.",
                ImageUrl = "https://www.colibri.bg/news_img/20220616_1.jpg",
                DatePublished = DateTime.ParseExact("12/03/2024 16:20", DateTimeArticleFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                ViewsCount = 0
            };
        }

        private void SeedArticleComments()
        {
            CommentOne = new ArticleComment()
            {
                Id = 1,
                Title = "We were there!",
                Description = "My whole family are fans of Siromahov. He finally came to Burgas!",
                ArticleId = 3,
                UserId = "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e"
            };
            CommentTwo = new ArticleComment()
            {
                Id = 2,
                Title = "Long awaited!",
                Description = "I waited quite a while for him to publish his new book. Now I will go get an autograph too!",
                ArticleId = 3,
                UserId = "dea12856-c198-4129-b3f3-b893d8395082"
            };
            CommentThree = new ArticleComment()
            {
                Id = 3,
                Title = "I do not get it",
                Description = "I really do not understand how so many people can like this man so much that they even go to events related to him.",
                ArticleId = 3,
                UserId = "64ce3106-ec7d-44cb-b167-bf946b88bb1b"
            };
            CommentFour = new ArticleComment()
            {
                Id = 4,
                Title = "Going",
                Description = "Siromahov's work has always been among my favorites. This book will be no exception.",
                ArticleId = 3,
                UserId = "cabfd9b8-4411-47f6-9639-df70d753c275"
            };
        }

        private void SeedEvents()
        {
            EventOne = new Event()
            {
                Id = 1,
                Topic = "EXHIBITION | Etudes of Sofia: 24 Hours in the City",
                Description = "Alongside the release of the book \"Etudes of Sofia: 24 Hours in the City,\" Ivan Shishiev will also present an exhibition at Slaveykov Square. It can be seen between September 5 and 30, and on Sofia Day, September 17, lovers of photography and literature will be able to meet the author on site at 11 AM. ABOUT THE BOOK: Within 200 pages, the reader is both observer and main participant in a Sofia day. What are 24 hours in the big city? How do time and space refract under the sounds of trams and the silence of stopped clocks? This time the photographer of \"Etudes of Sofia\" turns to these questions and to showing how a day in the city is lived. Time in Sofia flows by its own rules. And to truly capture it in photography, you must know them. Tick-tock...",
                Location = "Slaveykov Square, Sofia",
                StartDate = DateTime.ParseExact("05/09/2023 12:00", DateTimeEventFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                EndDate = DateTime.ParseExact("30/09/2023 23:59", DateTimeEventFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                ImageUrl = "https://www.colibri.bg/uploads/2023/09/shishiev_event3.jpg",
                Seats = 5,
                TicketPrice = 20
            };
            EventTwo = new Event()
            { 
                Id = 2,
                Topic = "Book presentation of Albert Benbasat's \"When the Big Ones Become Small\"",
                Description = "We look forward to seeing you at the presentation of Albert Benbasat's book \"When the Big Ones Become Small\" on December 12, Tuesday, at 6:30 PM at Casa Libri, 64 Tsar Asen St. With the special participation of Toni Nikolov and Georgi Tsankov! Albert Benbasat (b. 1950) is a literary historian, critic, publicist, and publisher; professor at the Faculty of Journalism and Mass Communication at Sofia University \"St. Kliment Ohridski.\" He is the author of 13 books. Editor and publisher of \"Critique\" magazine and the \"Critique\" Library, compiler and editor of numerous books.",
                Location = "Casa Libri, 64 Tsar Asen St",
                StartDate = DateTime.ParseExact("12/12/2023 18:30", DateTimeEventFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                EndDate = DateTime.ParseExact("12/12/2023 21:30", DateTimeEventFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                ImageUrl = "https://www.colibri.bg/uploads/2023/12/benbasat_event.jpg",
                Seats = 200,
                TicketPrice = 5
            };
            EventThree = new Event()
            {
                Id = 3,
                Topic = "Hannah Arendt - The Origins of Totalitarianism | Premiere",
                Description = "On June 6 at 7:00 PM we invite you to the premiere of \"The Origins of Totalitarianism\" by Hannah Arendt. We look forward to seeing you at Toplocentrala, Stage Bar. The book \"The Origins of Totalitarianism\" is published for the first time in Bulgarian in its entirety and includes its three main parts: Antisemitism, Imperialism, Totalitarianism. This is Hannah Arendt's earliest large-scale work, which brought her international fame. Upon its publication in 1951, it sparked wide discussion in academic circles with interpretations beyond the dominant paradigms.",
                Location = "Toplocentrala, Stage Bar, Sofia",
                StartDate = DateTime.ParseExact("06/06/2024 19:00", DateTimeEventFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                EndDate = DateTime.ParseExact("06/06/2024 22:00", DateTimeEventFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                ImageUrl = "https://www.colibri.bg/uploads/2023/05/arendt_event.jpg",
                Seats = 10,
                TicketPrice = 15
            };
            EventFour = new Event()
            {
                Id = 4,
                Topic = "PREMIERE | Death of the White Fox",
                Description = "On April 17 at 7:00 PM at \"The Red House\" (15 Lyuben Karavelov St) we will present \"Death of the White Fox.\" Anna Zarkova herself will tell more. Event moderator: Svetlozar Zhelev. What to expect from the book? On October 2, 1996, Andrey Lukanov - a landmark politician of the Bulgarian transition, prime minister in two governments, MP - was shot dead in front of his home. By whom and why? To this day, not a single version has been refuted or confirmed. The \"Lukanov\" case has been closed.",
                Location = "\"The Red House\" (15 Lyuben Karavelov St)",
                StartDate = DateTime.ParseExact("17/04/2025 19:00", DateTimeEventFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                EndDate = DateTime.ParseExact("17/04/2025 22:00", DateTimeEventFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                ImageUrl = "https://www.colibri.bg/uploads/2024/04/zarkova_event.jpg",
                Seats = 100,
                TicketPrice = 10
            };
            EventFive = new Event()
            {
                Id = 5,
                Topic = "Premiere: \"Unfinished Past\"",
                Description = "On March 21 at 7:00 PM we will mark the appearance of \"Unfinished Past\" - a criminal psychological novel based on the cult NOVA series \"Search Department.\" A masterfully conceived, dynamic, and captivating story that expands the world of the on-screen heroes and lets the reader peek into their most intimate thoughts! Alexander Chobanov, Vladimir Poleganov, Yulian Vergov, and Ana Papadopulu will be with us. Criminal psychologist Rosen Yordanov will make a special appearance.",
                Location = "Derida Stage",
                StartDate = DateTime.ParseExact("21/03/2024 19:00", DateTimeEventFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                EndDate = DateTime.ParseExact("21/03/2024 22:00", DateTimeEventFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                ImageUrl = "https://www.colibri.bg/uploads/2024/03/minalonesvarsheno_event.jpg",
                Seats = 7,
                TicketPrice = 10
            };
            EventSix = new Event()
            {
                Id = 6,
                Topic = "Meet and greet with Colibri authors",
                Description = "On December 8 at 6:00 PM we look forward to seeing you at stand 315 in the NDK for a meeting with the authors who delighted us with their works in 2023. Svetlozar Zhelev, Bozhidar Manov, Selja Ahava, Milena Kirova, Iskren Krasimirov, Maria Kasimova-Moase, Ivan Shishiev, and Albert Benbasat will be waiting for you! Get their books at a discount and receive an autograph! The project was realized with the financial support of the National Culture Fund under the Recovery and Development Program for Private Cultural Organizations.",
                Location = "Stand 315, NDK",
                StartDate = DateTime.ParseExact("08/12/2024 18:00", DateTimeEventFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                EndDate = DateTime.ParseExact("08/12/2024 21:00", DateTimeEventFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                ImageUrl = "https://www.colibri.bg/uploads/2023/12/sreshta-s-avtograf.jpg",
                Seats = 200,
                TicketPrice = 0
            };
            EventSeven = new Event()
            {
                Id = 7,
                Topic = "Meet and greet with Colibri authors",
                Description = "The Sofia International Literary Festival and Colibri Publishing House invite you to a meeting with Selja Ahava in conversation with Egil Bjartnason on December 8, Friday, at 2:00 PM at the NDK, floor 2, marble foyer. The event moderator will be Silvia Nedkova. Finnish writer Selja Ahava (b. 1974) gained fame with the novel \"Things That Fall from the Sky,\" which won the EU Literature Prize. Published with the Colibri logo in Bulgaria is the shocking autofiction \"Before My Husband Disappears.\" \"The Woman Who Loved Insects\" (translated by Rositsa Tsvetanova) is Ahava's fourth novel, in which she explores the relationship between man and nature. Her books can also be found at stand 315 during the Christmas Book Fair at a discount! We look forward to seeing you!",
                Location = "NDK, floor 2, marble foyer",
                StartDate = DateTime.ParseExact("08/12/2023 14:00", DateTimeEventFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                EndDate = DateTime.ParseExact("08/12/2023 19:00", DateTimeEventFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                ImageUrl = "https://www.colibri.bg/uploads/2023/12/ahava_event.jpg",
                Seats = 44,
                TicketPrice = 5
            };
            EventEight = new Event()
            {
                Id = 8,
                Topic = "Premiere: From Authors and Readers ON BOOKS AND READING",
                Description = "We are pleased to invite you to the premiere of \"From Authors and Readers ON BOOKS AND READING\" compiled by Anna Lazarova and Svetlozar Zhelev. The event will take place on November 29 (Wednesday) at 7:00 PM at the Literary Club of the Sofia Library (floor -1). Bring your good mood and love of books! Free entry! ABOUT THE BOOK: Back in 1978, in \"The Hitchhiker's Guide to the Galaxy,\" Douglas Adams gave the answer to \"The Great Question of Life, the Universe and Everything.\" Forty-two. This number has traveled the world, been dissected and researched, analyzed and over-interpreted. It has become a recognizable mark of the book, and through it literature alone among arts and sciences dares to stand behind an answer to the unanswerable.",
                Location = "Literary Club of the Sofia Library (floor -1)",
                StartDate = DateTime.ParseExact("29/11/2023 19:00", DateTimeEventFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                EndDate = DateTime.ParseExact("29/11/2023 22:00", DateTimeEventFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                ImageUrl = "https://www.colibri.bg/uploads/2023/11/za-knigite-i-cheteneto-sofia.jpg",
                Seats = 27,
                TicketPrice = 2
            };
            EventNine = new Event()
            {
                Id = 9,
                Topic = "Premiere in Sofia | \"Tales from the Upper and Lower Earth\"",
                Description = "After the sticky heat of Buenos Aires, everything here is clean, fresh, and crisp like freshly laundered sheets, cozy like a mountain village, spring-like like a buttercup, colorful like a handful of candies, smiling like a sunbeam, blue-skied like a child's dream. Kind and amazingly lonely. Far, far from the noise and hustle, from crowds and civilization, from rushing and stress, at the very bottom, southernmost, at the very end of the earth. Fin del Mundo. The end of the world. This is how Isabella Shopova describes Ushuaia, the town in the southernmost part of the Earth, the end of the world that will surely not put an end to her travels. After \"To the East - to Paradise,\" \"To the West of Paradise,\" \"To the South of Reason,\" \"After the Shadow of the Condor,\" and \"A Manual for the Deliberate Murder of Boredom,\" Isabella offers us her next captivating saga - \"Tales from the Upper and Lower Earth.\"",
                Location = "Casa Libri",
                StartDate = DateTime.ParseExact("05/07/2024 09:00", DateTimeEventFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                EndDate = DateTime.ParseExact("05/07/2024 22:00", DateTimeEventFormat, CultureInfo.InvariantCulture, DateTimeStyles.None),
                ImageUrl = "https://www.colibri.bg/uploads/2023/06/shopova_event_sofia.jpg",
                Seats = 200,
                TicketPrice = 3
            };
        }
    }
}