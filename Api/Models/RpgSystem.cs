using System;
using System.Collections.Generic;

namespace Api.Model
{
    public class RpgSystem
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public List<Designer> Designers { get; set; }

        public Publisher Publisher { get; set; }

        public DateTime ReleaseDate { get; set; }
    }
}