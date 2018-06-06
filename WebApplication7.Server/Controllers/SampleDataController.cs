using WebApplication7.Shared;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication7.Server.Controllers
{
    [Route("api/[controller]")]
    public class SampleDataController : Controller
    {
        private static string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        [HttpGet("[action]")]
        public IEnumerable<WeatherForecast> WeatherForecasts()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            });
        }

        private static string[] Races = new[]
        {
            "Human", "Dwarf", "Halfling", "Gnome", "Half-Orc", "Elf", "Dragonborn", "Drow"
        };

        private static string[] Classes = new[]
        {
            "None", "Fighter", "Paladin", "Cleric", "Warlock", "Wizard", "Sorcerer", "Hunter", "Rogue"
        };

        [HttpGet("[action]")]
        public IEnumerable<PC> PCs()
        {
            return new PC[] {
                new PC
                    {
                        Level = 20,
                        Name = "Vax'ildan",
                        Player = "Liam O'Brien",
                        Race = Race.Elf_Wood,
                        Class = Class.Rogue,
                        Status = Status.Dead,
                        Description = "Vax'ildan, also known as \"Vax\", was a half-elf rogue/paladin, a member of Vox Machina, and the current Champion of the Raven Queen. He was played by Liam O'Brien.",
                        ImageUrl = "Vaxildan2.png"
                    },
                new PC
                    {
                        Level = 18,
                        Name = "Vex'ahlia de Rolo",
                        Player = "Laura Bailey",
                        Race = Race.Elf_Wood,
                        Class = Class.Hunter,
                        Status = Status.Retired,
                        Description = "Vex'ahlia, also known as \"Vex\", is a half-elf ranger/rogue member of Vox Machina and the wife of Lord Percival de Rolo of Whitestone. She was played by Laura Bailey.",
                        ImageUrl = "Vexahlia2.jpg"
                    },
                new PC
                    {
                        Level = 20,
                        Name = "Grog Strongjaw",
                        Player = "Travis Willingham",
                        Race = Race.Goliath,
                        Class = Class.Barbarian,
                        Status = Status.Retired,
                        Description = "Grog Strongjaw is a goliath barbarian/fighter and a member of Vox Machina. He was played by Travis Willingham.",
                        ImageUrl = "Grog2.png"
                    },
                new PC
                    {
                        Level = 20,
                        Name = "Keyleth",
                        Player = "Marisha Ray",
                        Race = Race.Elf_Wood,
                        Class = Class.Druid,
                        Status = Status.Retired,
                        Description = "Keyleth is a half-elf druid in the group Vox Machina and headmaster of the Air Ashari. She was played by Marisha Ray.",
                        ImageUrl = "Keyleth2.png"
                    },
                new PC
                    {
                        Level = 18,
                        Name = "Percival Fredrickstein Von Musel Klossowski De Rolo III",
                        Player = "Taliesin Jaffe",
                        Race = Race.Human,
                        Class = Class.Gunslinger,
                        Status = Status.Retired,
                        Description = "Lord Percival Fredrickstein Von Musel Klossowski de Rolo III of Whitestone, better known as \"Percy\", is a human gunslinger, a member of Vox Machina, and the husband of Vex'ahlia. He was played by Taliesin Jaffe.",
                        ImageUrl = "Percy2.png"
                    },
                new PC
                    {
                        Level = 18,
                        Name = "Scanlan Shorthalt",
                        Player = "Sam Riegel",
                        Race = Race.Halfling,
                        Class = Class.Bard,
                        Status = Status.Retired,
                        Description = "Scanlan Shorthalt is a gnome bard, a member of the group Vox Machina and the husband of Pike Trickfoot. He was played by Sam Riegel.",
                        ImageUrl = "Scanlan2.png"
                    },
                new PC
                    {
                        Level = 18,
                        Name = "Pike Trickfoot",
                        Player = "Ashley Johnson",
                        Race = Race.Gnome,
                        Class = Class.Cleric,
                        Status = Status.Retired,
                        Description = "Pike Trickfoot is a gnome cleric of Sarenrae, a member of Vox Machina and the wife of Scanlan Shorthalt. She was played by Ashley Johnson.",
                        ImageUrl = "Pike2.png"
                    },
            };
        }

        [HttpGet("[action]")]
        public IEnumerable<NPC> NPCs()
        {
            var rng = new Random();
            return Enumerable.Range(1, 10).Select(index => new NPC
            {
                Level = rng.Next(1, 20),
                Name = RandomString(rng.Next(5, 10)),
                Race = RandomEnumValue<Race>(),
                Class = RandomEnumValue<Class>(),
                Status = RandomEnumValue<Status>()
            });
        }

        private static Random random = new Random();

        private static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ'-";
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        static T RandomEnumValue<T>()
        {
            var v = Enum.GetValues(typeof(T));
            return (T)v.GetValue(random.Next(v.Length));
        }
    }
}
