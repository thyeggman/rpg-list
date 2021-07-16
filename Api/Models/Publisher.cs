using System;
using System.Collections.Generic;

namespace Api.Model
{
    public class Publisher
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTime Founded { get; set; }

        public DateTime Dissolved { get; set; }
    }
}