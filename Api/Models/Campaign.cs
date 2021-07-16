using System;
using System.Collections.Generic;

namespace Api.Model
{
    public class Campaign
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public List<Session> Sessions { get; set; }

        public RpgSystem System { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }
    }
}