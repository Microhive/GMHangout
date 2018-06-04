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
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new PC
            {
                Level = rng.Next(1, 20),
                Name = "Vexalia",
                Player = "Laura",
                Race = Race.Elf,
                Class = Class.Hunter,
                Status = Status.Retired
            });
        }

        [HttpGet("[action]")]
        public IEnumerable<NPC> NPCs()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new NPC
            {
                Level = rng.Next(1, 20),
                Name = "Vexalia",
                Race = Race.Elf,
                Class = Class.Hunter,
                Status = Status.Retired
            });
        }
    }
}
