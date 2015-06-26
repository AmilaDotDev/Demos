﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MusicStore.Models.Repositories
{
    public class ArtistRepository : Repository<Artist>
    {
        public List<Artist> GetByName(string name)
        {
            return DbSet.Where(artist => artist.Name.ToLower().Contains(name.ToLower())).ToList();
        }

        public List<SoloArtist> GetSoloArtists()
        {
            return DbSet.OfType<SoloArtist>().ToList();
        }
    }
}