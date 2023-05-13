using Librozone.Data.Enums;
using Librozone.Models;
using System.Net.NetworkInformation;

namespace Librozone.Data
{
    public class AppDbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            using (var serviceScope = applicationBuilder.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<AppDbContext>();

                context.Database.EnsureCreated();

                //Authors
                if (!context.Authors.Any())
                {
                    context.Authors.AddRange(new List<Author>()
                    {
                        new Author()
                        {
                            ProfilePictureURL = "https://i.ibb.co/CwmJ01L/brandon-sanderson.jpg",
                            FullName = "Brandon Sanderson",
                            Bio = "Brandon Sanderson is a renowned American author celebrated for his contributions to the fantasy genre." +
                            "Born in 1975, Sanderson developed a passion for storytelling from a young age and eventually emerged as a " +
                            "prominent figure in the realm of epic fantasy. Widely acclaimed for his intricate world-building, compelling characters, " +
                            "and meticulously crafted magic systems, he is best known for his works such as the \"Mistborn series\", \"The Stormlight Archive\", and completing Robert Jordan's epic \"Wheel of Time series\"."
                        },
                        new Author()
                        {
                            ProfilePictureURL = "https://i.ibb.co/9sJWfT8/donna-tartt.jpg",
                            FullName = "Donna Tartt",
                            Bio = "Donna Tartt is an esteemed American author recognized for her captivating literary works." +
                            "Born in 1963, Tartt rose to prominence with her debut novel, \"The Secret History,\" " +
                            "which garnered critical acclaim and a dedicated fan base. Known for her meticulous attention to detail, " +
                            "atmospheric prose, and immersive storytelling, Tartt has continued to enchant readers with her subsequent novels," +
                            "including \"The Little Friend\" and \"The Goldfinch,\" the latter of which earned her the Pulitzer Prize for Fiction in 2014."
                        },
                        new Author()
                        {
                            ProfilePictureURL = "https://i.ibb.co/mRKkVFH/stephen-king.jpg",
                            FullName = "Stephen King",
                            Bio = "Stephen King, born in 1947, is a highly prolific and influential American author known for his mastery of horror, suspense, and supernatural fiction. " +
                            "With a career spanning over five decades, King has authored numerous best-selling novels that have captivated readers worldwide. From classics like \"Carrie,\" " +
                            "\"The Shining,\" and \"It\" to his expansive Dark Tower series, King's ability to blend ordinary settings with chilling and psychological terror has solidified " +
                            "his position as one of the most prominent and successful writers in the genre."
                        },
                        new Author()
                        {
                            ProfilePictureURL = "https://i.ibb.co/jhbCNt6/alan-moore.jpg",
                            FullName = "Alan Moore",
                            Bio = "Alan Moore is an English writer most famous for his influential work in comics, " +
                            "including the acclaimed graphic novels \"Watchmen\", \"V for Vendetta\" and \"From Hell\"." +
                            " He has also written a novel, Voice of the Fire, and performs \"workings\" " +
                            "(one-off performance art/spoken word pieces) with The Moon and Serpent Grand Egyptian Theatre of Marvels, " +
                            "some of which have been released on CD."
                        },
                        new Author()
                        {
                            ProfilePictureURL = "https://i.ibb.co/3MKPGR8/fyodor-dostoevsky.jpg",
                            FullName = "Fyodor Dostoyevsky",
                            Bio = "Fyodor Mikhailovich Dostoyevsky was a Russian novelist, short story writer, essayist, and journalist. " +
                            "His literary works explore human psychology in the troubled political, social, and spiritual atmospheres of 19th-century Russia, and engage with a variety of philosophical and religious themes. " +
                            "His most acclaimed novels include \"Crime and Punishment\" (1866), \"The Idiot\" (1869), Demons (1872), and \"The Brothers Karamazov\" (1880)."
                        },
                        new Author()
                        {
                            ProfilePictureURL = "https://i.ibb.co/rtNynr3/jk-rowling.jpg",
                            FullName = "J. K. Rowling",
                            Bio = "\r\nJK Rowling, born in 1965, is a British author known for creating the enchanting world of Harry Potter. " +
                            "Starting as a struggling single mother, Rowling's life transformed when her first novel," +
                            " \"Harry Potter and the Philosopher's Stone,\" was published in 1997. " +
                            "The immensely popular series captivated readers of all ages, spawning a global phenomenon and inspiring a successful film franchise. " +
                            "Rowling's storytelling prowess, imaginative world-building, and themes of friendship, bravery, and magic have made her one of the most celebrated and influential authors of our time."
                        }
                    });
                    context.SaveChanges();

                }
                //Publishers
                if (!context.Publishers.Any())
                {
                    context.Publishers.AddRange(new List<Publisher>() 
                    { 
                        new Publisher()
                        {
                            LogoURL = "https://i.ibb.co/nwdk3P5/tor-logo.jpg",
                            Name = "Tor Books",
                            Description = "This is a description."
                        },
                        new Publisher()
                        {
                            LogoURL = "https://i.ibb.co/ns7G6y8/simon-and-schuster-logo.jpg",
                            Name = "Simon & Schuster",
                            Description = "This is a description."
                        },
                        new Publisher()
                        {
                            LogoURL = "https://i.ibb.co/t37SWZM/penguin-books-logo.jpg",
                            Name = "Penguin Books",
                            Description = "This is a description."
                        },
                        new Publisher()
                        {
                            LogoURL = "https://i.ibb.co/vLNxwRX/bloomsbury-publishing-logo.jpg",
                            Name = "Bloomsbury Publishing",
                            Description = "This is a description."
                        },
                        new Publisher()
                        {
                            LogoURL = "https://i.ibb.co/XLHJ2cs/dc-comics-logo.jpg",
                            Name = "DC Comics",
                            Description = "This is a description."
                        }
                    });
                    context.SaveChanges();
                }

                //Books
                if (!context.Books.Any())
                {
                    context.Books.AddRange(new List<Book>()
                    {
                        new Book()
                        {
                            Title = "The Way of Kings: Book One of the Stormlight Archive",
                            AuthorId = 1,
                            PublisherId = 1,
                            Description = "\"The Way of Kings\" is the first book in the epic fantasy series," +
                            " \"The Stormlight Archive,\" by Brandon Sanderson. Set in the magical world of Roshar," +
                            " the novel follows the stories of several characters, including a warrior, a scholar," +
                            " and a slave, as they navigate a war-torn landscape filled with political intrigue and supernatural dangers." +
                            " With its intricate world-building, well-developed characters, and thought-provoking themes of leadership, honor, and redemption," +
                            " \"The Way of Kings\" is a compelling and immersive read that has cemented Sanderson's place as a master of the fantasy genre.",
                            ISBN = "9780765376671",
                            PageCount = 1008,
                            Price = 19.90,
                            CoverURL = "https://i.ibb.co/0VJGcPs/the-way-of-kings-cover.jpg",
                            ReleaseDate = new DateTime(2010,08,31),
                            BookCategory = BookCategory.Fantasy
                        },
                        new Book()
                        {
                            Title = "Words of Radiance: Book Two of the Stormlight Archive",
                            AuthorId = 1,
                            PublisherId = 1,
                            Description = "\"Words of Radiance\" is the second book in the epic fantasy series," +
                            " \"The Stormlight Archive\" by Brandon Sanderson. Continuing the story of \"The Way of Kings\" " +
                            "the novel delves deeper into the world of Roshar, exploring new characters, magical powers, and political machinations." +
                            " With its intricate plot, well-rounded characters, and stunning action sequences, \"Words of Radiance\"" +
                            " is a masterful continuation of the series that solidifies Sanderson's place as one of the greatest modern fantasy authors.",
                            ISBN = "9781250166531",
                            PageCount = 1104,
                            Price = 20.90,
                            CoverURL = "https://i.ibb.co/VpX58xF/words-of-radiance-cover.jpg",
                            ReleaseDate = new DateTime(2014,03,04),
                            BookCategory = BookCategory.Fantasy
                        },
                        new Book()
                        {
                            Title = "Mistborn: The Final Empire",
                            AuthorId = 1,
                            PublisherId = 1,
                            Description = "\"The Final Empire\" is the first book in the \"Mistborn\" trilogy by Brandon Sanderson." +
                            " Set in a world ruled by an immortal tyrant, the novel follows a crew of thieves who plot a daring heist to overthrow the oppressive regime." +
                            " With its unique magic system, engaging characters, and intricate plot," +
                            " \"The Final Empire\" is a thrilling and imaginative read that combines elements of heist stories, epic fantasy, and dystopian fiction.",
                            ISBN = "9780765350381",
                            PageCount = 672,
                            Price = 9.99,
                            CoverURL = "https://i.ibb.co/HhrMTMg/mistborn-1-cover.jpg",
                            ReleaseDate = new DateTime(2006,07,17),
                            BookCategory = BookCategory.Fantasy
                        },
                        new Book()
                        {
                            Title = "The Secret History",
                            AuthorId = 2,
                            PublisherId = 3,
                            Description = "Under the influence of their charismatic classics professor, a group of clever," +
                            " eccentric misfits at an elite New England college discover a way of thinking and living that" +
                            " is a world away from the humdrum existence of their contemporaries." +
                            " But when they go beyond the boundaries of normal morality they slip gradually from obsession to corruption and betrayal, and at last—inexorably—into evil.",
                            ISBN = "9781400031702",
                            PageCount = 559,
                            Price =9.25,
                            CoverURL = "https://i.ibb.co/vc9JBnH/the-secret-history-cover.jpg",
                            ReleaseDate = new DateTime(1992,09,16),
                            BookCategory = BookCategory.Mystery
                        },
                        new Book()
                        {
                            Title = "The Little Friend",
                            AuthorId = 2,
                            PublisherId = 4,
                            Description = "The setting is Alexandria, Mississippi, where one Mother’s Day a little boy named Robin Cleve Dufresnes" +
                            " was found hanging from a tree in his parents’ yard. Twelve years later Robin’s murder is still unsolved and his family remains devastated." +
                            " So it is that Robin’s sister Harriet - unnervingly bright, insufferably determined," +
                            " and unduly influenced by the fiction of Kipling and Robert Louis Stevenson--sets out to unmask his killer. Aided only by her worshipful friend Hely," +
                            " Harriet crosses her town’s rigid lines of race and caste and burrows deep into her family’s history of loss.",
                            ISBN = "9781400031696",
                            PageCount = 624,
                            Price =8.99,
                            CoverURL = "https://i.ibb.co/gSrR554/the-little-friend-cover.jpg",
                            ReleaseDate = new DateTime(2002,10,22),
                            BookCategory = BookCategory.Mystery
                        },
                        new Book()
                        {
                            Title = "Batman: The Killing Joke",
                            AuthorId = 4,
                            PublisherId = 5,
                            Description = "For the first time the Joker's origin is revealed in this tale of insanity and human perseverance." +
                            " Looking to prove that any man can be pushed past his breaking point and go mad," +
                            " the Joker attempts to drive Commissioner Gordon insane.\r\n\r\n" +
                            "After shooting and permanently paralyzing his daughter Barbara (a.k.a. Batgirl)," +
                            " the Joker kidnaps the commissioner and attacks his mind in hopes of breaking the man.\r\n\r\n" +
                            "But refusing to give up, Gordon maintains his sanity with the help of Batman in an effort to beset the madman.",
                            ISBN = "9780930289454",
                            PageCount = 50,
                            Price =17.99,
                            CoverURL = "https://i.ibb.co/XY3BVFD/the-killing-joke-cover.jpg",
                            ReleaseDate = new DateTime(1988,11,16),
                            BookCategory = BookCategory.GraphicNovel
                        },
                        new Book()
                        {
                            Title = "The Idiot",
                            AuthorId = 5,
                            PublisherId = 3,
                            Description = "Returning to Russia from a sanitarium in Switzerland," +
                            " the Christ-like epileptic Prince Myshkin finds himself enmeshed in a tangle of love," +
                            " torn between two women—the notorious kept woman Nastasya and the pure Aglaia—both involved," +
                            " in turn, with the corrupt, money-hungry Ganya. In the end, Myshkin’s honesty, goodness," +
                            " and integrity are shown to be unequal to the moral emptiness of those around him." +
                            " In her revision of the Garnett translation, Anna Brailovsky has corrected inaccuracies wrought by" +
                            " Garnett’s drastic anglicization of the novel, restoring as much as possible the syntactical structure" +
                            " of the original story.",
                            ISBN = "9780140447927",
                            PageCount = 768,
                            Price =8.00,
                            CoverURL = "https://i.ibb.co/TtywP7b/the-idiot-cover.jpg",
                            ReleaseDate = new DateTime(2004,08,31),
                            BookCategory = BookCategory.Classic
                        },
                        new Book()
                        {
                            Title = "The Brothers Karamazov",
                            AuthorId = 5,
                            PublisherId = 3,
                            Description = "The Brothers Karamazov is a murder mystery, a courtroom drama," +
                            " and an exploration of erotic rivalry in a series of triangular love affairs involving" +
                            " the “wicked and sentimental” Fyodor Pavlovich Karamazov and his three sons―the impulsive and" +
                            " sensual Dmitri; the coldly rational Ivan; and the healthy, red-cheeked young novice Alyosha." +
                            " Through the gripping events of their story, Dostoevsky portrays the whole of Russian life," +
                            " is social and spiritual striving, in what was both the golden age and a tragic turning point in Russian culture.",
                            ISBN = "9780374528379",
                            PageCount = 824,
                            Price =10.50,
                            CoverURL = "https://i.ibb.co/6ZZ3Z0b/the-brothers-karamazov-cover.jpg",
                            ReleaseDate = new DateTime(2002,06,14),
                            BookCategory = BookCategory.Classic
                        },
                        new Book()
                        {
                            Title = "Crime and Punishment",
                            AuthorId = 5,
                            PublisherId = 3,
                            Description = "Raskolnikov, a destitute and desperate former student," +
                            " wanders through the slums of St Petersburg and commits a random murder without remorse or regret." +
                            " He imagines himself to be a great man, a Napoleon: acting for a higher purpose beyond conventional" +
                            " moral law. But as he embarks on a dangerous game of cat and mouse with a suspicious police investigator," +
                            " Raskolnikov is pursued by the growing voice of his conscience and finds the noose of his own guilt" +
                            " tightening around his neck. Only Sonya, a downtrodden sex worker, can offer the chance of redemption.",
                            ISBN = "9780143058144",
                            PageCount = 671,
                            Price =9.99,
                            CoverURL = "https://i.ibb.co/zVXj0c3/crime-and-punishment-cover.jpg",
                            ReleaseDate = new DateTime(2002,12,31),
                            BookCategory = BookCategory.Classic
                        },
                        new Book()
                        {
                            Title = "Harry Potter and the Half-Blood Prince",
                            AuthorId = 6,
                            PublisherId = 4,
                            Description = "It is the middle of the summer, but there is an unseasonal mist pressing against" +
                            " the windowpanes. Harry Potter is waiting nervously in his bedroom at the Dursleys' house in" +
                            " Privet Drive for a visit from Professor Dumbledore himself." +
                            " One of the last times he saw the Headmaster was in a fierce one-to-one duel with Lord Voldemort," +
                            " and Harry can't quite believe that Professor Dumbledore will actually appear at the Dursleys' of" +
                            " all places. Why is the Professor coming to visit him now? What is it that cannot wait until Harry" +
                            " returns to Hogwarts in a few weeks' time? Harry's sixth year at Hogwarts has already got off to" +
                            " an unusual start, as the worlds of Muggle and magic start to intertwine...",
                            ISBN = "9781338299199",
                            PageCount = 688,
                            Price =12.99,
                            CoverURL = "https://i.ibb.co/VSBXKYK/hp-6-cover.jpg",
                            ReleaseDate = new DateTime(2005,07,16),
                            BookCategory = BookCategory.Fantasy
                        },
                        new Book()
                        {
                            Title = "Harry Potter and the Prisoner of Azkaban",
                            AuthorId = 6,
                            PublisherId = 4,
                            Description = "Harry Potter, along with his best friends, Ron and Hermione, is about to start his third" +
                            " year at Hogwarts School of Witchcraft and Wizardry. Harry can't wait to get back to school after the" +
                            " summer holidays. (Who wouldn't if they lived with the horrible Dursleys?) But when Harry gets to Hogwarts," +
                            " the atmosphere is tense. There's an escaped mass murderer on the loose, and the sinister prison guards of" +
                            " Azkaban have been called in to guard the school...",
                            ISBN = "9780439655484",
                            PageCount = 384,
                            Price =9.99,
                            CoverURL = "https://i.ibb.co/GtJywG5/hp-3-cover.jpg",
                            ReleaseDate = new DateTime(1999,07,08),
                            BookCategory = BookCategory.Fantasy
                        },
                        new Book()
                        {
                            Title = "Harry Potter and the Chamber of Secrets",
                            AuthorId = 6,
                            PublisherId = 4,
                            Description = "Ever since Harry Potter had come home for the summer, the Dursleys had been so mean and hideous" +
                            " that all Harry wanted was to get back to the Hogwarts School for Witchcraft and Wizardry." +
                            " But just as he’s packing his bags, Harry receives a warning from a strange impish creature who" +
                            " says that if Harry returns to Hogwarts, disaster will strike.",
                            ISBN = "9780439676484",
                            PageCount = 303,
                            Price =9.99,
                            CoverURL = "https://i.ibb.co/DMnr2VD/hp-2-cover.jpg",
                            ReleaseDate = new DateTime(1998,07,02),
                            BookCategory = BookCategory.Fantasy
                        },
                        new Book()
                        {
                            Title = "Billy Summers",
                            AuthorId = 3,
                            PublisherId = 2,
                            Description = "Billy Summers is a man in a room with a gun. He’s a killer for hire and the best" +
                            " in the business. But he’ll do the job only if the target is a truly bad guy. And now Billy wants out." +
                            " But first there is one last hit. Billy is among the best snipers in the world, a decorated Iraq war vet," +
                            " a Houdini when it comes to vanishing after the job is done. So what could possibly go wrong?\n" +
                            "How about everything...",
                            ISBN = "9781982173616",
                            PageCount = 515,
                            Price =13.90,
                            CoverURL = "https://i.ibb.co/FV8TND2/billy-summers-cover.jpg",
                            ReleaseDate = new DateTime(2021,08,03),
                            BookCategory = BookCategory.Thriller
                        },
                        new Book()
                        {
                            Title = "'Salem's Lot",
                            AuthorId = 3,
                            PublisherId = 2,
                            Description = "Thousands of miles away from the small township of 'Salem's Lot, two terrified people," +
                            " a man and a boy, still share the secrets of those clapboard houses and tree-lined streets." +
                            " They must return to 'Salem's Lot for a final confrontation with the unspeakable evil that lives on in the town.",
                            ISBN = "9780450031069",
                            PageCount = 483,
                            Price =8.90,
                            CoverURL = "https://i.ibb.co/WyGjykR/salems-lot-cover.jpg",
                            ReleaseDate = new DateTime(1975,10,17),
                            BookCategory = BookCategory.Horror
                        },
                    });
                    context.SaveChanges();

                }
            }
        }
    }
}
