﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SeresProducoes.Models;

namespace SeresProducoes.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("SeresProducoes.Models.Article", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Content");

                    b.Property<DateTime>("Date");

                    b.Property<string>("Headline");

                    b.Property<string>("Image");

                    b.Property<string>("Link");

                    b.HasKey("Id");

                    b.ToTable("Articles");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Content = "Alexandros Djkevingr & Greg Ignatovich (Parquet Recordings, Diynamic) from Greek came up with the idea for a big collaboration that unites different countries and music styles from all over the world...",
                            Date = new DateTime(2020, 2, 29, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Headline = "Music can unite and spread more...",
                            Image = "/images/articles/n01.jpeg",
                            Link = "https://medium.com/@seresproducoes/alexandros-djkevingr-greg-ignatovich-vs-bruce-leroys-and-daniel-rateuke-that-music-can-9cac40c4d013"
                        },
                        new
                        {
                            Id = 2,
                            Content = "Drunky Daniels estão de Volta depois do Album ‘’Zabumba’’ lancado no ano passado com destaque na Mixmag, Bantumen e muito outros magazines. A Seres Producões apresenta o seu mais recente Single dos Drunky Daniels, com origens bem brasileiras viajando por drums africanos...",
                            Date = new DateTime(2020, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Headline = "Curitiba on Afro House map with the Brazilian duo Drunky Daniels.",
                            Image = "/images/articles/n02.jpeg",
                            Link = "https://medium.com/@seresproducoes/curitiba-on-afro-house-map-with-the-brazilian-duo-drunky-daniels-617e22f2cfeb"
                        },
                        new
                        {
                            Id = 3,
                            Content = "There’s something in the Two Strong duo, that’s making their music growing each day at the Angolan music scene and places around the world...",
                            Date = new DateTime(2020, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Headline = "Duo Two Strong starting the year in Force.",
                            Image = "/images/articles/n03.jpeg",
                            Link = "https://medium.com/@seresproducoes/duo-two-strong-starting-the-year-in-force-37cfa7480f39"
                        },
                        new
                        {
                            Id = 4,
                            Content = "Tswelelo ‘Tswex’ Malabola is a self taught underground house music producer.The diversity in his sound comes from the inspiration brought by listening to different genres. His love for house music started from an early age of 11 years and following that, he was able to start producing as well...",
                            Date = new DateTime(2020, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Headline = "“Can’t Stay Away EP” Tswex Malabola!",
                            Image = "/images/articles/n04.jpeg",
                            Link = "https://medium.com/@seresproducoes/cant-stay-away-ep-tswex-malabola-ff37e96bcec2"
                        },
                        new
                        {
                            Id = 5,
                            Content = "Sonar born of African-Shangani descent in Cottondale Acornhoek Bushbuckridge. Sonar loved to sing and make music and his teacher would constantly cite him for disturbing the peace of the classroom through his spontaneous need to tap rhythms on whatever he had on hand...",
                            Date = new DateTime(2020, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Headline = "Today Sonar has his fingerprints in our humble home.",
                            Image = "/images/articles/n05.jpeg",
                            Link = "https://medium.com/@seresproducoes/today-sonar-has-his-fingerprints-in-our-humble-home-3783cc9e20ba"
                        });
                });

            modelBuilder.Entity("SeresProducoes.Models.Artist", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Bio");

                    b.Property<string>("FacebookLink");

                    b.Property<string>("Image");

                    b.Property<string>("Name");

                    b.Property<string>("SoundCloudLink");

                    b.Property<string>("Tracks");

                    b.Property<string>("TwitterLink");

                    b.HasKey("Id");

                    b.ToTable("Artists");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bio = "Danykas Dj was born in Lisbon, Portugal. The love of music has always been a constant in her life, atmosphere felt early on in their home. A musical spirit cultivated by her father, a passion that exists in the whole family. Never leaving the corners of her room, in 2015 comes the first invitation to expose itself to the public in the Room System Project at Casa Independente, Lisbon ,held by Seres Producoes where she's working currently. Was the place where she could express her vibes through the simbiose of Afro Electronic Music and Deep House. The desire was increasing, the willingness to take the aspect of music more 'serious' as well, which allowed her to go through places like Lux Frágil, Festival Musa Cascais, Douro Rock Festival, Maus Hábitos, Musicbox Lisboa, two clubs in UK and host a Show at Quântica Rádio invited by Violet.",
                            FacebookLink = "https://www.facebook.com/danykasdj/",
                            Image = "/images/artists/DANYKAS.jpg",
                            Name = "DANYKAS DJ",
                            SoundCloudLink = "https://soundcloud.com/danykasdj",
                            Tracks = "https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/users/3447553&color=%23ff5500&auto_play=true&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true",
                            TwitterLink = "https://twitter.com/danykasdj"
                        },
                        new
                        {
                            Id = 2,
                            Bio = "DJ Satelite, a native of Luanda, started his career by raw, passionate curiosity and quickly became one of the main drivers of Afro House and Kuduro in many lusophone countries. After dedicating years on his own productions, in 2006 he achieved notoriety as one of the co-producers of the album Estado Maior do Kuduro dos Lambas. It is also known as the first album produced by a local artist and gained stellar reviews in Angola. In particular, the hit single, ‘Se desfio’ conquered the hearts of a huge fan base. Satelite’s productions have been featured on the critically acclaimed film ‘I Love Kuduro’. Internationally acclaimed as one of the most prominent Angolan beatmakers, He also launched his own record label, Seres Produções in order to expose extraordinary music, including his new release ‘If Only’ with the Moroccan producer Cee ElAssaad. 2016 was an exceptional year of top quality releases with additional productions such as ‘Malembe na Soukouss’, ‘Abantu’ & ‘Xe Mana Bella’. Including collaborations with Ancestral Soul master Boddhi Satva and the unique voice of Freddy Massamba, released by the globally recognized label Offering Recordings. Satelite’s journey has taken him to some of the biggest events and organizations, such as Red Bull Music Academy and the Ibiza International Music Summit. He also got to show his live skills on Boiler Room, alongside Batida. He has also graced some established and innovative festivals such as Sfinks Festival, AfricaNouveau and the Ten Cities project. He has played for the legendary British DJ Fatboy Slim. DJ Satelite is an ambassador of the new Angolan sound and a pioneer of the African Electronic Music scene that burns dance floors all across the globe.",
                            FacebookLink = "https://www.facebook.com/OfficialDJSatelite",
                            Image = "/images/artists/SATELITE.jpg",
                            Name = "DJ Satelite",
                            SoundCloudLink = "https://soundcloud.com/djsatelite",
                            Tracks = "https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/users/2259254&color=%23ff5500&auto_play=true&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true",
                            TwitterLink = "https://twitter.com/djsatelite_"
                        },
                        new
                        {
                            Id = 3,
                            Bio = "Inami is an Artist/Singer/Songwriter/performer/instrumentalist/producer/vocal trainer based in Africa (Nairobi – Kenya). INAMI simply means the Inner me and stands for IN me African Music Inspired. Internationally acclaimed as the first Lady of Equatorial House Music, Inami is a passionate and driven Kenyan musician who is slowly taking over and further strengthening its position, in the movement of house music in Nairobi to the world. Her first release was in February 2013 where she collaborated with Boneless (A Kenyan kamba House artist) on the song ‘Supasta’, produced by Saint Evo. The song was a Kamba tune based on the notion, that all people are born superstars and we can achieve that status, only if we believe in ourselves. Her smooth vocals and catchy hook in collaboration with Boneless’ rapping drove the track and made it a hit. A follow up video to ‘Supasta’ was released thereafter. With the great reception locally and airplay from radio to TV stations, the track ushered Inami into the Kenyan music scene. Mid 2013 saw the release of her first Equatorial House music Debut EP Album, under Celsius Degree Entertainment, titled Little Lost. The EP was inspired by the theme Love, peace and music and is made up of four songs which include: Little Lost, Constant Craving, Musiq Lingo and Peace. The Ep received great reviews and air play both locally and internationally, from Nairobi to Nigeria, DRC, Colombia, New Delhi, Australia and London. She later that year dropped a single titled “Don’t Look Back” – a soulful house track it’s a jazzy feel, that talked about not letting the past define who we are instead focus on the purpose that we resolved to effect in our futures. ‘Don’t Look Back’ is produced by Marcus Ezra, a drum & bass, house, electronic, progressive and retro music producer and artist of soul Bros Records. In 2014 she was officially signed on to Celsius Degree Entertainment, being the first signed artist of the label. She then released a follow up to the Little lost Ep: Part 2, titled “Little Lost Re-incarnation” which was made up of seven songs and a stunning video of the single titled “constant craving” to her debut EP, Little Lost. The songs included: Little Lost (Acoustic mix) which she co-produced with Saint Evo The Myth, Whispers of Love, Became Mucho(House Version), Constant Craving (Saint Evo’s Lounge Mix), Little Lost(Brackish Remix), Music Lingo (Reprise mix) and Jole. Mid 2014, the hit track ‘supasta’s official remix by Saint Evo was released. In 2015, Inami released an EP titled “Burn Hard” which comprised of the original mix by Saint Evo The Myth and a remix by Melo Mokoena, a producer and artist of Soul Candi Records. The EP was inspired by the theme ‘Love gone sour’ In 2016, the single “constant Craving” was remixed by The Exchange Project, an initiative made up of producers from Angola, Sierra Leone and Kenya aimed at bridging borders with sound. Inami also feature in a song titled, “Mapenzi” on Saint Evo The Myth’s ‘Early Years EP. In April 2016 she featured on Saint Evo’s EP “The Vika Vu EP” that consists of two tracks, namely, “Vika Vu” & “On My Way Home”, featuring the sultry vocals and creative writing of the First Lady Of Equatorial House, Inami. The EP was inspired by the theme, life’s Journey that talked about the firm resolve on a determined soul on a journey to greatness. The EP went global, courtesy of Seres Producoes, a record label in Angola making it available on traxsource, iTunes, Google Play, spotify, YouTube, beatport, junodownload and tidal. Following the Vika Vu Ep, Inami collaborated on a hit single titled ‘All OR Nothing’ produced by DJ Leah SA, a house producer from South Africa that was recently released under Seres Producoes and is now available on traxsource, iTunes, Google Play, Amazon, spotify, YouTube, beatport, junodownload, tidal and deezer. 2016 and 2017 were set to be exceptional years with forth coming releases, an Album as well as her own productions.",
                            FacebookLink = "https://www.facebook.com/inamikenya/",
                            Image = "/images/artists/INAMI.jpg",
                            Name = "INAMI",
                            SoundCloudLink = "https://soundcloud.com/inami-3",
                            Tracks = "https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/users/34477332&color=%23ff5500&auto_play=true&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true",
                            TwitterLink = "https://twitter.com/fi_inami "
                        },
                        new
                        {
                            Id = 4,
                            Bio = "K.O.D is a Producer| Artist| Songwriter| Entrepreneur| Philanthropist| Re-mixer and Poet currently residing in Bulawayo (Zimbabwe). Born in Simbarashe Kodzai on August 06 1990, he was introduced to House music in 2003 and was provided the opportunity to record in 2005. He went on to start making his own production in 2008 because he wanted to have full control of his career and creativity. Determined to make a break on the House scene he joined forces with Herbal 3 Records based in South Africa releasing smash hits In The Name Of love and Iculo Lothando which did well on the local scene. Determined to break into the international market he aligns himself with Seres Producoes a record label based in Luanda (Angola). He is heavily influenced by the likes of Kanye West, Grego Salto, Oskido, Black Coffee, Euphonic, Dj Fresh Sa, Ganyani, and Black Motion in the same level of work ethic. K.O.D (King Of Drums) is a self motivated individual, hard working and God fearing, set to change his life and of those around him with his musical gift.",
                            FacebookLink = "https://www.facebook.com/KODworldwide/",
                            Image = "/images/artists/KOD.jpg",
                            Name = "K.O.D",
                            SoundCloudLink = "https://soundcloud.com/kod_worldwide",
                            Tracks = "https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/users/190055831&color=%23ff5500&auto_play=true&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true",
                            TwitterLink = "https://twitter.com/KOD_worldwide"
                        },
                        new
                        {
                            Id = 5,
                            Bio = "Rosario, born in Luanda, Angola. Made his debut in the world of House Music in 2011 posting sets of Afro House on soundcloud by the Mbambu Records group ( with Dj Nax and Braga Havaiana). Later in 2012 he joined “Tainted House Records”, based in South Africa, where he released several projects such as “Kalunga Kianda” with Braga Havaina and “Destiny” with Jackie Queens.And several remixes on tracks like “Roots” and “Tyityimba” authored by Rune Sibiya, and “You Don’t Deserve Me” by Reel Skaps(Global Deep Recordings). Currently in Mbambu Records group known as the author of the hits songs “Me Mata” (with Dj Jesus) and “Tatau” (with Bebucho Q Kuia), and other projects that are having a high impact on today’s african house scene. Later he meets with Dj Satelite on the record label ”Seres Produções” from Angola, becoming a member on the label, releasing tracks in collaboration with South African artists like Jackie Queens and Lebo Snookums with whom he released the single ‘Silly Of Me” and other projects.",
                            FacebookLink = "https://www.facebook.com/Rosariokalenga",
                            Image = "/images/artists/ROSARIO.jpg",
                            Name = "ROSARIO",
                            SoundCloudLink = "https://soundcloud.com/rosariokalenga",
                            Tracks = "https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/users/2440049&color=%23ff5500&auto_play=true&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true",
                            TwitterLink = "https://twitter.com/rosariokalenga"
                        },
                        new
                        {
                            Id = 6,
                            Bio = "(Felisberto Arthur) a young Talented, born in Luanda (Angola), Dj and producer of Music house which his name does not ass unnoticed in the Angolan music, specifically in the style house Music. His passion for the art of music began at age 14 and had as their major influences artists like John Legend, Atjazz, Salif Keita, Michael Jackson, Dennis Ferrer, Bob Sinclar, Phil Collins, Kassav, Daft Punk and many others. In his career as a music producer, went through many styles including: Kuduro, Rap, Kizomba and finally his passion for art quickened in House music. Considered as one of the mentors of souful style and african - house in Angola. His remixes and His songs touch on several radio and television channels, having already launched several themes on various labels such as: Arrecha Records, Oluwki Music, “Seres Produções (where he is currently a member and partner), and many others. Throughout his career, Wilson has been present in Several bars and clubs COUNTRY and beyond. In 2012 he decided to join with other Angolan producer name Tiuze Money, with whom he formed the label VOZES QUENTES, where launched and have launched many musical themes rolling in Angola and in the world outside is expected to more than double in the coming months and years, and it is believed that could be heading for a great way to success!",
                            FacebookLink = "https://www.facebook.com/djwilsonkentura",
                            Image = "/images/artists/WILSON.jpg",
                            Name = "WILSON KENTURA",
                            SoundCloudLink = "https://soundcloud.com/wilson-kentura",
                            Tracks = "https://w.soundcloud.com/player/?url=https%3A//api.soundcloud.com/users/16837712&color=%23ff5500&auto_play=true&hide_related=false&show_comments=true&show_user=true&show_reposts=false&show_teaser=true&visual=true",
                            TwitterLink = "https://twitter.com/wilsonkentura"
                        });
                });

            modelBuilder.Entity("SeresProducoes.Models.Event", b =>
                {
                    b.Property<int>("Id");

                    b.Property<DateTime>("Date");

                    b.Property<string>("DescriptiveDate");

                    b.Property<string>("Host");

                    b.Property<string>("Image");

                    b.Property<string>("Link");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Events");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Date = new DateTime(2020, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DescriptiveDate = "Thursday, February 27, 2020 at 11:59 PM – 6 AM UTC",
                            Host = "Hosted by Seres Produções, MUSICBOX LISBOA, DJ Satelite, DANYKAS DJ",
                            Image = "/images/events/e1.jpg",
                            Name = "DJ Satelite + Danykas DJ"
                        },
                        new
                        {
                            Id = 2,
                            Date = new DateTime(2020, 1, 16, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DescriptiveDate = "Thursday, January 16, 2020 at 11:45 PM – 6 AM UTC",
                            Host = "Hosted by Lux Frágil and Batida",
                            Image = "/images/events/e2.jpg",
                            Name = "Batida b2b Satelite"
                        },
                        new
                        {
                            Id = 3,
                            Date = new DateTime(2020, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DescriptiveDate = "Thursday, January 9, 2020 at 11:45 PM – 6 AM UTC",
                            Host = "Hosted by Lux Frágil and Rádio Quântica",
                            Image = "/images/events/e3.jpg",
                            Name = "Rádio Quântica: Lsdxoxo x Danykas x Prec x Poly Garbo x Pachinko"
                        },
                        new
                        {
                            Id = 4,
                            Date = new DateTime(2019, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            DescriptiveDate = "Saturday, December 14, 2019 at 11:55 PM – 6 AM UTC",
                            Host = "Hosted by Room System, Village Underground Lisboa",
                            Image = "/images/events/e4.jpg",
                            Link = "https://www.residentadvisor.net/events/1348378?fbclid=IwAR2VzS6jFFBotx6I3p1KO2MnzrpkWcocCjgakDZpr1oHT7zR4sfpKGorONU.",
                            Name = "Room System #8"
                        });
                });

            modelBuilder.Entity("SeresProducoes.Models.Image", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ImagePath");

                    b.HasKey("Id");

                    b.ToTable("Images");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            ImagePath = "/images/gallery/1.jpg"
                        },
                        new
                        {
                            Id = 2,
                            ImagePath = "/images/gallery/2.jpg"
                        },
                        new
                        {
                            Id = 3,
                            ImagePath = "/images/gallery/3.jpg"
                        },
                        new
                        {
                            Id = 4,
                            ImagePath = "/images/gallery/4.jpg"
                        },
                        new
                        {
                            Id = 5,
                            ImagePath = "/images/gallery/5.jpg"
                        },
                        new
                        {
                            Id = 6,
                            ImagePath = "/images/gallery/6.jpg"
                        },
                        new
                        {
                            Id = 7,
                            ImagePath = "/images/gallery/7.jpg"
                        },
                        new
                        {
                            Id = 8,
                            ImagePath = "/images/gallery/8.jpg"
                        },
                        new
                        {
                            Id = 9,
                            ImagePath = "/images/gallery/9.jpg"
                        },
                        new
                        {
                            Id = 10,
                            ImagePath = "/images/gallery/10.jpg"
                        },
                        new
                        {
                            Id = 11,
                            ImagePath = "/images/gallery/11.png"
                        },
                        new
                        {
                            Id = 12,
                            ImagePath = "/images/gallery/12.jpg"
                        },
                        new
                        {
                            Id = 13,
                            ImagePath = "/images/gallery/13.jpg"
                        },
                        new
                        {
                            Id = 14,
                            ImagePath = "/images/gallery/14.jpg"
                        },
                        new
                        {
                            Id = 15,
                            ImagePath = "/images/gallery/15.jpg"
                        },
                        new
                        {
                            Id = 16,
                            ImagePath = "/images/gallery/16.jpg"
                        },
                        new
                        {
                            Id = 17,
                            ImagePath = "/images/gallery/17.jpg"
                        },
                        new
                        {
                            Id = 18,
                            ImagePath = "/images/gallery/18.jpg"
                        },
                        new
                        {
                            Id = 19,
                            ImagePath = "/images/gallery/19.png"
                        },
                        new
                        {
                            Id = 20,
                            ImagePath = "/images/gallery/20.png"
                        },
                        new
                        {
                            Id = 21,
                            ImagePath = "/images/gallery/21.jpg"
                        },
                        new
                        {
                            Id = 22,
                            ImagePath = "/images/gallery/22.jpg"
                        },
                        new
                        {
                            Id = 23,
                            ImagePath = "/images/gallery/23.png"
                        },
                        new
                        {
                            Id = 24,
                            ImagePath = "/images/gallery/24.jpg"
                        },
                        new
                        {
                            Id = 25,
                            ImagePath = "/images/gallery/25.jpg"
                        },
                        new
                        {
                            Id = 26,
                            ImagePath = "/images/gallery/26.jpg"
                        },
                        new
                        {
                            Id = 27,
                            ImagePath = "/images/gallery/27.jpg"
                        },
                        new
                        {
                            Id = 28,
                            ImagePath = "/images/gallery/28.png"
                        },
                        new
                        {
                            Id = 29,
                            ImagePath = "/images/gallery/29.jpg"
                        },
                        new
                        {
                            Id = 30,
                            ImagePath = "/images/gallery/30.jpg"
                        },
                        new
                        {
                            Id = 31,
                            ImagePath = "/images/gallery/31.jpg"
                        });
                });

            modelBuilder.Entity("SeresProducoes.Models.Release", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("Artist");

                    b.Property<string>("Image");

                    b.Property<string>("Link");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.ToTable("Releases");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Artist = "ERAN YAARI",
                            Image = "/images/releases/1_Komanta.jpg",
                            Link = "https://www.traxsource.com/title/1288428/komanta",
                            Title = "KOMANTA"
                        },
                        new
                        {
                            Id = 2,
                            Artist = "SATELITE & K.O.D",
                            Image = "/images/releases/2_Zona.jpg",
                            Link = "https://www.traxsource.com/title/1288476/zona-vermelha",
                            Title = "ZONA VERMELHA"
                        },
                        new
                        {
                            Id = 3,
                            Artist = "GREG, BRUCE, DANIEL...",
                            Image = "/images/releases/3_BlackCurse.jpg",
                            Link = "https://www.traxsource.com/title/1288475/black-curse-of-sarapast",
                            Title = "BLACK CURSE..."
                        },
                        new
                        {
                            Id = 4,
                            Artist = "DRUNKY DANIELS",
                            Image = "/images/releases/4_Janaina.jpg",
                            Link = "https://www.traxsource.com/title/1280077/janaina",
                            Title = "JANAINA"
                        },
                        new
                        {
                            Id = 5,
                            Artist = "TSWEX MALABOLA",
                            Image = "/images/releases/5_CantStayAway.jpg",
                            Link = "https://www.traxsource.com/title/1272414/cant-stay-away-ep",
                            Title = "CAN'T STAY AWAY EP"
                        },
                        new
                        {
                            Id = 6,
                            Artist = "2 STRONG",
                            Image = "/images/releases/6_obcecado.jpg",
                            Link = "https://www.traxsource.com/title/1281222/obcecado-ep",
                            Title = "OBCECADO EP"
                        },
                        new
                        {
                            Id = 7,
                            Artist = "ROSARIO",
                            Image = "/images/releases/7_mojo.jpg",
                            Link = "https://www.traxsource.com/title/1264053/mojo",
                            Title = "MOJO"
                        },
                        new
                        {
                            Id = 8,
                            Artist = "SONAR ft. TIKWE",
                            Image = "/images/releases/8_MoreLife.jpg",
                            Link = "https://www.traxsource.com/title/1272046/more-life",
                            Title = "MORE LIFE"
                        },
                        new
                        {
                            Id = 9,
                            Artist = "DJ SATELITE",
                            Image = "/images/releases/9_KedumaRemixes.jpg",
                            Link = "https://www.traxsource.com/title/1330792/kemuda-remixes",
                            Title = "KEMUDA REMIXES"
                        },
                        new
                        {
                            Id = 10,
                            Artist = "EuphoriQsoul",
                            Image = "/images/releases/10_MamboEP.jpg",
                            Link = "https://www.traxsource.com/title/1297704/mambo-ep",
                            Title = "MAMBO EP"
                        },
                        new
                        {
                            Id = 11,
                            Artist = "DJ SATELITE",
                            Image = "/images/releases/11_KANDONGUEIRO2000.jpg",
                            Link = "https://www.traxsource.com/title/1311959/kandongueiro-2000",
                            Title = "Kandongueiro 2000"
                        },
                        new
                        {
                            Id = 12,
                            Artist = "DEMENTED SOUL",
                            Image = "/images/releases/12_TranscendEP.jpg",
                            Link = "https://www.traxsource.com/title/1321228/transcend-ep",
                            Title = "Transcend EP"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
