using System;
using System.Collections.Generic;

namespace Api.Model
{
    public class OneShot
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public RpgSystem System { get; set; }

        public List<Player> Players { get; set; }

        public Player GM { get; set; }

        public DateTime Date { get; set; }

        public TimeSpan Duration { get; set; }
    }
}