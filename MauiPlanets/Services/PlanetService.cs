using MauiPlanets.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiPlanets.Services
{
    internal static class PlanetsService
    {
        private static List<Planet> planets = new()
        {
            new()
            {
                Name = "Mercury",
                Subtitle = "  The smallest planet",
                HeroImage = "mercury.png",
                Description = "Mercury is the smallest planet in the Solar " +
                "System and the closest to the Sun. Its orbit around the Sun takes " +
                "87.97 Earth days, the shortest of all the Sun's planets. " +
                "It is named after the Roman god Mercurius (Mercury), god " +
                "of commerce, messenger of the gods, and mediator between gods " +
                "and mortals, corresponding to the Greek god Hermes (Ἑρμῆς). Like " +
                "Venus, Mercury orbits the Sun within Earth's orbit as an inferior " +
                "planet; its apparent distance from the Sun as viewed from Earth " +
                "never exceeds 28°.",
                AccentColorStart = Color.FromArgb("#353535"),
                AccentColorEnd = Color.FromArgb("#8d9098"),
                Images = new()
                {
                    "https://cdn.theatlantic.com/thumbor/D15rQggf6357X1-u6VpTD2N1yQE=/0x27:1041x613/976x549/media/img/mt/2017/04/MercuryImage/original.jpg",
                    "https://solarsystem.nasa.gov/system/feature_items/images/73_carousel_mercury_2.jpg",
                    "https://science.nasa.gov/_ipx/w_2048&f_webp/https://smd-cms.nasa.gov/wp-content/uploads/2023/05/pia19422-mercury.jpg"
                }
            },

            new()
            {
                Name = "Venus",
                Subtitle = " The Pressure Cooker",
                HeroImage = "venus.png",
                Description = "Venus is the second planet from the Sun. It is a rocky planet with the densest " +
                "atmosphere of all the rocky bodies in the Solar System, and the only one with a mass and size " +
                "that is close to that of its orbital neighbour Earth. Orbiting inferiorly (inside of Earth's " +
                "orbit), it appears in Earth's sky always close to the Sun, as either a \"morning star\" or an " +
                "\"evening star\". While this is also true for Mercury, Venus appears much more prominently, since " +
                "it is the third brightest object in Earth's sky after the Moon and the Sun,[20][21] appearing " +
                "brighter than any other star-like classical planet or any fixed star. With such prominence in Earth's " +
                "sky, Venus has historically been a common and important object for humans, in both their cultures and astronomy. ",
                AccentColorStart = Color.FromArgb("#a6393b"),
                AccentColorEnd = Color.FromArgb("#d17f21"),
                Images = new()
                {
                    "https://science.nasa.gov/_ipx/w_2048&f_webp/https://smd-cms.nasa.gov/wp-content/uploads/2023/05/venus-single.png",
                    "https://science.nasa.gov/_ipx/w_2048&f_webp/https://images-assets.nasa.gov/image/PIA13001/PIA13001~orig.jpg%3Fw=1920%26h=1080%26fit=clip%26crop=faces%252Cfocalpoint",
                    "https://cdn.mos.cms.futurecdn.net/kaPwBjHiUKax8syodHNPmF.jpg"
                }

            },

            new()
            {
                Name = "Earth",
                Subtitle = " The Cradle of Life",
                HeroImage = "earth.png",
                Description = "Earth is the third planet from the Sun and the only astronomical object known to harbor life. " +
                "This is enabled by Earth being a water world, the only one in the Solar System sustaining liquid surface water. " +
                "Almost all of Earth's water is contained in its global ocean, covering 70.8% of Earth's crust. The remaining " +
                "29.2% of Earth's crust is land, most of which is located in the form of continental landmasses within one hemisphere," +
                " Earth's land hemisphere. Most of Earth's land is somewhat humid and covered by vegetation, while large sheets of " +
                "ice at Earth's polar deserts retain more water than Earth's groundwater, lakes, rivers and atmospheric water combined." +
                " Earth's crust consists of slowly moving tectonic plates, which interact to produce mountain ranges, volcanoes, and " +
                "earthquakes. Earth has a liquid outer core that generates a magnetosphere capable of deflecting most of the destructive" +
                " solar winds and cosmic radiation.",
                AccentColorStart = Color.FromArgb("#0e3d68"),
                AccentColorEnd = Color.FromArgb("#2e97c7"),
                Images = new()
                {
                    "https://cdn.britannica.com/25/160325-050-EB1C8FB7/image-instruments-Earth-satellite-NASA-Suomi-National-2012.jpg",
                    "https://images.newscientist.com/wp-content/uploads/2019/09/09162708/iss048-e-2035_lrg.jpg",
                    "https://assets.weforum.org/editor/PTYtTC2H8A2aSCo1uw7GINVgSicFzjTiZETCg9Bqk1Q.png",
                    "https://images.immediate.co.uk/production/volatile/sites/7/2018/02/Earth-from-space-1-64e9a7c.jpg?quality=90&resize=980,654"
                }

            },

            new()
            {
                Name = "Mars",
                Subtitle = " The Iron Planet",
                HeroImage = "mars.png",
                Description = "Mars is the fourth planet and the furthest terrestrial planet from the Sun. The reddish color" +
                " of its surface is due to finely grained iron(III) oxide dust in the soil, giving it the nickname " +
                "the Red Planet. Mars's radius is second smallest among the planets in the Solar System at 3,389.5 km " +
                "(2,106 mi). The Martian dichotomy is visible on the surface: on average, the terrain on Mars's northern " +
                "hemisphere is flatter and lower than its southern hemisphere. Mars has a thin atmosphere made primarily " +
                "of carbon dioxide, and two irregularly shaped natural satellites, Phobos and Deimos. ",
                AccentColorStart = Color.FromArgb("#a23036"),
                AccentColorEnd = Color.FromArgb("#eb3333"),
                Images = new()
                {
                    "https://science.nasa.gov/_ipx/w_2048&f_webp/https://images-assets.nasa.gov/image/PIA02653/PIA02653~large.jpg%3Fw=1920%26h=1920%26fit=clip%26crop=faces%252Cfocalpoint",
                    "https://static01.nyt.com/images/2014/12/09/science/09life/09life-articleLarge-v2.jpg?quality=75&auto=webp&disable=upscale",
                    "https://www.science.org/do/10.1126/science.aau8871/abs/ca_0727NID_Mars_South_Polar_Ice_Cap_online.jpg"
                }
            },

            new()
            {
                Name = "Jupiter",
                Subtitle = " The Largest Planet",
                HeroImage = "jupiter.png",
                Description = "Jupiter is the fifth planet from the Sun and the largest in the Solar System. " +
                "It is a gas giant with a mass more than two and a half times that of all the other planets in" +
                " the Solar System combined, and slightly less than one one-thousandth the mass of the Sun. Jupiter" +
                " orbits the Sun at a distance of 5.20 AU (778.5 Gm) with an orbital period of 11.86 years. Jupiter " +
                "is the third brightest natural object in the Earth's night sky after the Moon and Venus, and it has" +
                " been observed since prehistoric times. It was named after Jupiter, the chief deity of ancient Roman religion. ",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#cd8026"),
                Images = new()
                {
                    "https://www.esa.int/var/esa/storage/images/esa_multimedia/images/2020/09/hubble_captures_crisp_new_image_of_jupiter_and_europa/22212206-1-eng-GB/Hubble_Captures_Crisp_New_Image_of_Jupiter_and_Europa_pillars.jpg",
                    "https://cdn.vox-cdn.com/thumbor/3hRXvyoAnTO45HJIl1_VloqMNSA=/1400x1050/filters:format(jpeg)/cdn.vox-cdn.com/uploads/chorus_asset/file/10842939/pia21974.jpg",
                    "https://science.nasa.gov/_ipx/w_2048&f_webp/https://images-assets.nasa.gov/image/hubble-captures-vivid-auroras-in-jupiters-atmosphere_28000029525_o/hubble-captures-vivid-auroras-in-jupiters-atmosphere_28000029525_o~large.jpg%3Fw=1920%26h=1913%26fit=clip%26crop=faces%252Cfocalpoint"
                }

            },

            new()
            {
                Name = "Saturn",
                Subtitle = " The Ring Planet",
                HeroImage = "saturn.png",
                Description = "Saturn is the sixth planet from the Sun and the second-largest in the Solar System," +
                " after Jupiter. It is a gas giant with an average radius of about nine-and-a-half times that of Earth. " +
                "It has only one-eighth the average density of Earth, but is over 95 times more massive.",
                AccentColorStart = Color.FromArgb("#996237"),
                AccentColorEnd = Color.FromArgb("#c6502f"),
                Images = new()
                {
                   "https://science.nasa.gov/_ipx/w_2048&f_webp/https://images-assets.nasa.gov/image/PIA02225/PIA02225~orig.jpg%3Fw=900%26h=1000%26fit=clip%26crop=faces%252Cfocalpoint",
                   "https://science.nasa.gov/_ipx/w_2048&f_webp/https://images-assets.nasa.gov/image/PIA02230/PIA02230~orig.jpg%3Fw=480%26h=410%26fit=clip%26crop=faces%252Cfocalpoint",
                   "https://science.nasa.gov/_ipx/w_2048&f_webp/https://images-assets.nasa.gov/image/PIA08392/PIA08392~orig.jpg%3Fw=1018%26h=1018%26fit=clip%26crop=faces%252Cfocalpoint"
                }

            },

            new()
            {
                Name = "Uranus",
                Subtitle = " The Herschel Planet",
                HeroImage = "uranus.png",
                Description = "Uranus is the seventh planet from the Sun. It is a gaseous cyan-coloured ice giant. " +
                "Most of the planet is made of water, ammonia, and methane in a supercritical phase of matter, which in " +
                "astronomy is called 'ice' or volatiles. The planet's atmosphere has a complex layered cloud structure and " +
                "has the lowest minimum temperature of 49 K (−224 °C; −371 °F) out of all the Solar System's planets. It " +
                "has a marked axial tilt of 97.8° with a retrograde rotation rate of 17 hours. This means that in an " +
                "84-Earth-year orbital period around the Sun, its poles get around 42 years of continuous sunlight, followed " +
                "by 42 years of continuous darkness. ",
                AccentColorStart = Color.FromArgb("#9d4a40"),
                AccentColorEnd = Color.FromArgb("#996237"),
                Images = new()
                {
                    "https://science.nasa.gov/_ipx/w_2048&f_webp/https://images-assets.nasa.gov/image/PIA18182/PIA18182~orig.jpg%3Fw=1720%26h=1720%26fit=clip%26crop=faces%252Cfocalpoint",
                    "https://science.nasa.gov/_ipx/w_2048&f_webp/https://images-assets.nasa.gov/image/GSFC_20171208_Archive_e000100/GSFC_20171208_Archive_e000100~orig.jpg%3Fw=1280%26h=1083%26fit=clip%26crop=faces%252Cfocalpoint",
                    "https://helios-i.mashable.com/imagery/articles/00brT8KigfbwzWQGzuYj8S4/hero-image.fill.size_1200x900.v1623382117.png"
                }

            },

            new()
            {
                Name = "Neptune",
                Subtitle = " The God of the Sea",
                HeroImage = "neptune.png",
                Description = "Neptune is the eighth and farthest planet from the Sun. It is the fourth-largest planet " +
                "in the Solar System by diameter, the third-most-massive planet, and the densest giant planet. It is 17" +
                " times the mass of Earth, and slightly more massive than its near-twin Uranus. Neptune is denser and " +
                "physically smaller than Uranus because its greater mass causes more gravitational compression of its " +
                "atmosphere. Being composed primarily of gases and liquids, it has no well-defined solid surface. The " +
                "planet orbits the Sun once every 164.8 years at an orbital distance of 30.1 astronomical units (4.5 " +
                "billion kilometres; 2.8 billion miles). It is named after the Roman god of the sea and has the astronomical " +
                "symbol ♆, representing Neptune's trident.",
                AccentColorStart = Color.FromArgb("#0c293d"),
                AccentColorEnd = Color.FromArgb("#26abe0"),
                Images = new()
                {
                 "https://science.nasa.gov/_ipx/w_2048&f_webp/https://images-assets.nasa.gov/image/PIA01492/PIA01492~large.jpg%3Fw=1920%26h=1917%26fit=clip%26crop=faces%252Cfocalpoint",
                 "https://science.nasa.gov/_ipx/w_2048&f_webp/https://images-assets.nasa.gov/image/PIA01142/PIA01142~orig.jpg%3Fw=945%26h=870%26fit=clip%26crop=faces%252Cfocalpoint"
                }

            },

            new()
            {
                Name = "Pluto",
                Subtitle = " The In-Between (Dwarf) Planet",
                HeroImage = "pluto.png",
                Description = "Pluto (minor-planet designation: 134340 Pluto) is a dwarf planet in the Kuiper belt, a ring of bodies " +
                "beyond the orbit of Neptune. It is the ninth-largest and tenth-most-massive known object to directly orbit the Sun. It" +
                " is the largest known trans-Neptunian object by volume, by a small margin, but is slightly less massive than Eris. Like " +
                "other Kuiper belt objects, Pluto is made primarily of ice and rock and is much smaller than the inner planets. Pluto has" +
                " only one sixth the mass of Earth's moon, and one third its volume. Pluto was recognized as a planet until 2006. ",
                AccentColorStart = Color.FromArgb("#9b6547"),
                AccentColorEnd = Color.FromArgb("#efb493"),
                Images = new()
                {
                    "https://science.nasa.gov/_ipx/animated_true&w_2048&f_webp/https://images-assets.nasa.gov/image/PIA19702/PIA19702~large.jpg%3Fw=1920%26h=1920%26fit=clip%26crop=faces%252Cfocalpoint",
                    "https://science.nasa.gov/_ipx/animated_true&w_2048&f_webp/https://images-assets.nasa.gov/image/PIA20544/PIA20544~orig.jpg%3Fw=855%26h=582%26fit=clip%26crop=faces%252Cfocalpoint",
                    "https://science.nasa.gov/_ipx/animated_true&w_2048&f_webp/https://images-assets.nasa.gov/image/PIA11707/PIA11707~large.jpg%3Fw=1920%26h=960%26fit=clip%26crop=faces%252Cfocalpoint"

                }

            },

            new()
            {
                Name = "Eris",
                Subtitle = " The Goddess of Chaos",
                HeroImage = "eris.png",
                Description = "Eris (minor-planet designation 136199 Eris) is the most massive and second-largest known " +
                "dwarf planet in the Solar System. It is a trans-Neptunian object (TNO) in the scattered disk and " +
                "has a high-eccentricity orbit. Eris was discovered in January 2005 by a Palomar Observatory–based team " +
                "led by Mike Brown and verified later that year. In September 2006, it was named after the Greco–Roman " +
                "goddess of strife and discord. Eris is the ninth-most massive known object orbiting the Sun and the " +
                "sixteenth-most massive overall in the Solar System (counting moons). It is also the largest known object " +
                "in the solar system that has not been visited by a spacecraft. Eris has been measured at 2,326 ± 12 kilometers (1,445 ± 7 mi) " +
                " in diameter;[12] its mass is 0.28% that of the Earth and 27% greater than that of Pluto, although Pluto is slightly larger by " +
                "volume. Both Eris and Pluto have a surface area that is comparable to the area of Russia or South America. ",
                AccentColorStart = Color.FromArgb("#4e8187"),
                AccentColorEnd = Color.FromArgb("#91cad1"),
                Images = new()
                {
                    "https://science.nasa.gov/_ipx/animated_true&w_2048&f_webp/https://images-assets.nasa.gov/image/PIA03034/PIA03034~orig.jpg%3Fw=603%26h=200%26fit=clip%26crop=faces%252Cfocalpoint",
                    "https://i.cbc.ca/1.1936894.1381378170!/httpImage/hi-852-eris-eso1142a.jpg"
                }

            },

            new()
            {
                Name = "Ceres",
                Subtitle = " The Insider Dwarf Planet",
                HeroImage = "ceres.png",
                Description = "Ceres (pronounced /ˈsɪəriːz/ SEER-eez), minor-planet designation 1 Ceres, is a dwarf " +
                "planet in the middle main asteroid belt between the orbits of Mars and Jupiter. It was the first asteroid" +
                " discovered on 1 January 1801, by Giuseppe Piazzi at Palermo Astronomical Observatory in Sicily and announced" +
                " as a new planet. Ceres was later classified as an asteroid and then a dwarf planet, the only one always " +
                "inside Neptune's orbit. ",
                AccentColorStart = Color.FromArgb("#497873"),
                AccentColorEnd = Color.FromArgb("#74b5ae"),
                Images = new()
                {
                     "https://i.natgeofe.com/n/b4a4f4c3-269e-4f37-a94d-45d86cf0cb52/ceres_occatorcrater_square.jpg",
                    "https://solarsystem.nasa.gov/rails/active_storage/blobs/redirect/eyJfcmFpbHMiOnsibWVzc2FnZSI6IkJBaHBBdUZsIiwiZXhwIjpudWxsLCJwdXIiOiJibG9iX2lkIn19--ca667488ed16597e35eaab71acd42034ca4f56c2/PIA20180-16-640x350.jpg",
                    "https://www.universetoday.com/wp-content/uploads/2016/05/Ceres_-_Oxo_and_Haulani_craters.png"

                }

            },

            new()
            {
                Name = "Makemake",
                Subtitle = " The Brightest Dwarf Planet",
                HeroImage = "makemake.png",
                Description = "Makemake[e] (minor-planet designation 136472 Makemake) is a dwarf planet and the second-largest " +
                "of what are known as the classical population of Kuiper belt objects, with a diameter approximately that of " +
                "Saturn's moon Iapetus, or 60% that of Pluto.[24][25] It has one known satellite.[26] Its extremely low average " +
                "temperature, about 40 K (−230 °C), means its surface is covered with methane, ethane, and possibly nitrogen ices.",
                AccentColorStart = Color.FromArgb("#835a44"),
                AccentColorEnd = Color.FromArgb("#b58b74"),
                Images = new()
                {
                    "https://astrophotographylens.com/cdn/shop/articles/Makemake.jpg?v=1693095521",
                    "https://upload.wikimedia.org/wikipedia/commons/2/29/Makemake_and_its_moon.jpg"
                }

            },

            new()
            {
                Name = "Haumea",
                Subtitle = " The Fastest Dwarf Planet",
                HeroImage = "haumea.png",
                Description = "Haumea (minor-planet designation 136108 Haumea) is a dwarf planet located beyond Neptune's orbit." +
                " It was discovered in 2004 by a team headed by Mike Brown of Caltech at the Palomar Observatory in the United " +
                "States and disputably also in 2005 by a team headed by José Luis Ortiz Moreno at the Sierra Nevada Observatory in " +
                "Spain. On September 17, 2008, it was named after Haumea, the Hawaiian goddess of childbirth, under the expectation " +
                "by the International Astronomical Union (IAU) that it would prove to be a dwarf planet. Nominal estimates make it " +
                "the third-largest known trans-Neptunian object, after Eris and Pluto, and approximately the size of Uranus's moon Titania. ",
                AccentColorStart = Color.FromArgb("#494746"),
                AccentColorEnd = Color.FromArgb("#6d6d6c"),
                Images = new()
                {
                     "https://scx2.b-cdn.net/gfx/news/hires/2017/59de5fc415107.jpg",
                    "https://static.wikia.nocookie.net/planet-archives/images/2/2d/Haumea.png/revision/latest?cb=20131012022005"

                }

            },
        };

        public static List<Planet> GetFeaturedPlanets()
        {
            var random = new Random();
            var randomizedPlanets = planets.OrderBy(item => random.Next());

            return randomizedPlanets.Take(2).ToList();
        }

        public static List<Planet> GetAllPlanets() => planets;
    }
}

