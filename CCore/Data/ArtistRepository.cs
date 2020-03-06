using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace CCore.Data
{
    public class ArtistRepository : IRepository<ComicArtist>
    {
        private List<ComicArtist> artists;

        bool IRepository<ComicArtist>.Add(ComicArtist item)
        {
            this.artists.Add(item);
            return true;
        }

        List<ComicArtist> IRepository<ComicArtist>.GetAll()
        {
            return this.artists;
        }

        void IRepository<ComicArtist>.Save()
        {
            throw new NotImplementedException();
        }
    }
}
