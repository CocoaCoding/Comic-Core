using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace CCore.Data
{
    public class ArtistRepository : IRepository<Artist>
    {
        private ObservableCollection<Artist> artists;

        bool IRepository<Artist>.Add(Artist item)
        {
            this.artists.Add(item);
            return true;
        }

        ObservableCollection<Artist> IRepository<Artist>.GetAll()
        {
            return this.artists;
        }

        void IRepository<Artist>.Save()
        {
            throw new NotImplementedException();
        }
    }
}
