using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace CCore.Data
{
    public class SeriesRepository : IRepository<Series>
    {
        private ObservableCollection<Series> series;

        public bool Add(Series item)
        {
            this.series.Add(item);
            return true;
        }

        public ObservableCollection<Series> GetAll()
        {
            return this.series;
        }

        public void Save()
        {
            throw new NotImplementedException();
        }
    }
}
