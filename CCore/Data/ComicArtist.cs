using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCore.Data
{
    public class ComicArtist
    {
        public Guid Id { get; set; }
        public string ArtistName { get; set; }
        public ComicArtist()
        {
            this.Id = Guid.NewGuid();
        }
    }
}
