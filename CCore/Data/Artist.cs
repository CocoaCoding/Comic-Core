using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CCore.Data
{
    public class Artist
    {
        public Guid Id { get; set; }

        public string ArtistName { get; set; }

        public Artist()
        {
            this.Id = Guid.NewGuid();
        }
    }
}
