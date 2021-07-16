using System;
using System.Collections.Generic;

namespace Api.Model
{
    public class Session
    {
        public Guid Id { get; set; }

        public int Number { get; set; }

        public List<Player> Players { get; set; }

        public Player GM { get; set; }

        public TimeSpan Duration { get; set; }
    }
}