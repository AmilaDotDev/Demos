using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicStore.Models
{
    public class Artist
    {
        public int ArtistId { get; set; }
        [Required]
        [StringLength(100, MinimumLength = 2)]
        public string Name { get; set; }

        public virtual List<Album> Albums { get; set; }

        public virtual ArtistDetails ArtistDetails { get; set; }
    }
}