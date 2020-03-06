using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace CCore.Data
{
    public class SeriesRepository : IRepository<ComicSeries>
    {
        private List<ComicSeries> series;

        public bool Add(ComicSeries item)
        {
            this.series.Add(item);
            return true;
        }

        public List<ComicSeries> GetAll()
        {
            return this.series;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
