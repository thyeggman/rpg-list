using System;
using System.Collections.Generic;

namespace Api.Model
{
    public class User
    {
        public Guid Id { get; set; }

        public string Login { get; set; }

        public List<RpgSystem> FavoriteSystems { get; set; }

        public List<Designer> FavoriteDesigners { get; set; }

        public List<Campaign> Campaigns { get; set; }

        public List<OneShot> OneShots { get; set; }

        public DateTime CreatedAt { get; set; }
    }
}