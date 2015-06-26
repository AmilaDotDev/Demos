using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class MusicStoreDataContextInitializer : DropCreateDatabaseAlways<MusicStoreDataContext>
    {
        protected override void Seed(MusicStoreDataContext context)
        {
            var artist = new Artist() {Name = "First Artist"};
            context.Artists.Add(artist);
            context.Artists.Add(new SoloArtist
            {
                Name = "Solo Artist",
                Instrument = "Guitar"
            });

            context.Albums.Add(new Album()
            {
                Artist = artist,
                Title = "First Album"
            });

            context.Albums.Add(new Album()
            {
                Artist = artist,
                Title = "Second Album"
            });

            context.Albums.Add(new Album()
            {
                Artist = new Artist() { Name = "Second Artist" },
                Title = "Third Album"
            });

            context.SaveChanges();
        }
    }
}