using System;
using System.Collections.Generic;
using System.Text;

namespace WebApplication7.Shared
{
    public class Session
    {
        public int PlayedAt { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public Player GM { get; set; }
        public IEnumerable<Player> Players { get; set; }
    }
}
